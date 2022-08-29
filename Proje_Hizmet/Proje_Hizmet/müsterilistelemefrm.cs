using Proje_Hizmet.SetSqlConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hizmet
{
    public partial class müsterilistelemefrm : Form
    {
        public müsterilistelemefrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmüsteriıd.Text = dataGridView1.CurrentRow.Cells["musteriıd"].Value.ToString();
        }
        //SqlConnection SetSqlConectionConfiguration.SetConnectionString() = new SqlConnection(ConfigurationManager.AppSettings["baglanti"]); 
        
        SqlConnection connectionString = SetSqlConectionConfiguration.SetConnectionString();

        private void txtmüsteriıd_TextChanged(object sender, EventArgs e)
        {
            connectionString.Open();      
            SqlCommand cmd = new SqlCommand("select * from tblmusteri where musteriıd like '" + txtmüsteriıd.Text + "'", connectionString);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtmüsteriıd.Text = read["musteriıd"].ToString();
                txtelno.Text = read["telno"].ToString();
                txtunvan.Text = read["unvan"].ToString();
            }
            connectionString.Close();
        }
        DataSet daset = new DataSet();

        private void müsterilistelemefrm_Load(object sender, EventArgs e)
        {
            müsterilisteleme();
        }

        private void txtmusıdara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["tblmusteri"].Clear();
            connectionString.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from tblmusteri where musteriıd like '%" + txtmusıdara.Text + "%'", connectionString);
            adtr.Fill(daset, "tblmusteri");
            dataGridView1.DataSource = daset.Tables["tblmusteri"];
            connectionString.Close();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstediğinize Emin Misiniz ?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connectionString.Open();
                SqlCommand cmd = new SqlCommand("delete from tblmusteri where musteriıd = @musteriıd", connectionString);
                cmd.Parameters.AddWithValue("@musteriıd", dataGridView1.CurrentRow.Cells["musteriıd"].Value.ToString());
                cmd.ExecuteNonQuery();
                connectionString.Close();
                MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşti.");
                daset.Tables["tblmusteri"].Clear();
                müsterilisteleme();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void müsterilisteleme()
        {
            connectionString.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from tblmusteri", connectionString);
            adtr.Fill(daset, "tblmusteri");
            dataGridView1.DataSource = daset.Tables["tblmusteri"];
            connectionString.Close();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("update tblmusteri set telno=@telno, unvan=@unvan where musteriıd=@musteriıd", connectionString);
            cmd.Parameters.AddWithValue("@telno", txtelno.Text);
            cmd.Parameters.AddWithValue("@unvan", txtunvan.Text);
            cmd.Parameters.AddWithValue("@musteriıd", txtmüsteriıd.Text);
            cmd.ExecuteNonQuery();
            connectionString.Close();
            MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşti.");

            daset.Tables["tblmusteri"].Clear();
            müsterilisteleme();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void müsterilistelemefrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btngüncelle.PerformClick();
            }
        }
    }
}
