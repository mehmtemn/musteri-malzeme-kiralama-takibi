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
    public partial class hizmetlerilistelefrm : Form
    {
        public hizmetlerilistelefrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.CurrentRow.Cells["hizmetıd"].Value.ToString();
        }
        //SqlConnection SetSqlConectionConfiguration.SetConnectionString() = new SqlConnection(ConfigurationManager.AppSettings["baglanti"]);
        SqlConnection connectionString = SetSqlConectionConfiguration.SetConnectionString();
        private void txtıd_TextChanged(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("select * from tblhizmet where hizmetıd like '" + txtıd.Text + "'", connectionString);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtıd.Text = read["hizmetıd"].ToString();
                txtur.Text = read["hizmet_turu"].ToString();
            }
            connectionString.Close();
        }

        DataSet daset = new DataSet();

        private void hizmetlerilistelefrm_Load(object sender, EventArgs e)
        {
            hizmetlerilistele();
        }

        private void txtıdara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["tblhizmet"].Clear();
            connectionString.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from tblhizmet where hizmetıd like '%" + txtıdara.Text + "%'", connectionString);
            adtr.Fill(daset, "tblhizmet");
            dataGridView1.DataSource = daset.Tables["tblhizmet"];
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
                SqlCommand cmd = new SqlCommand("delete from tblhizmet where hizmetıd = @hizmetıd", connectionString);
                cmd.Parameters.AddWithValue("@hizmetıd", dataGridView1.CurrentRow.Cells["hizmetıd"].Value.ToString());
                cmd.ExecuteNonQuery();
                connectionString.Close();
                MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşti.");
                daset.Tables["tblhizmet"].Clear();
                hizmetlerilistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void hizmetlerilistele()
        {
            connectionString.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from tblhizmet", connectionString);
            adtr.Fill(daset, "tblhizmet");
            dataGridView1.DataSource = daset.Tables["tblhizmet"];
            connectionString.Close();
        }
        //
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("update tblhizmet set hizmet_turu=@hizmet_turu where hizmetıd=@hizmetıd", connectionString);
            cmd.Parameters.AddWithValue("@hizmet_turu", txtur.Text);
            cmd.Parameters.AddWithValue("@hizmetıd", txtıd.Text);
            cmd.ExecuteNonQuery();
            connectionString.Close();
            MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşti.");

            daset.Tables["TBLHİZMET"].Clear();
            hizmetlerilistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void hizmetlerilistelefrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnguncelle.PerformClick();
            }
        }
    }
}
