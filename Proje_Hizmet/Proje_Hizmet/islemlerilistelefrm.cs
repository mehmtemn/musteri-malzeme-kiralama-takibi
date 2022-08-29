using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Proje_Hizmet;
using Proje_Hizmet.SetSqlConnection;

namespace Proje_Hizmet  
{
    public partial class islemlerilistelefrm : Form
    {
        public islemlerilistelefrm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        //SqlConnection SetSqlConectionConfiguration.SetConnectionString() = SetSqlConectionConfiguration.SetConnectionString();     
        SqlConnection connection = SetSqlConectionConfiguration.SetConnectionString();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtislemıd.Text = dataGridView1.CurrentRow.Cells["islemıd"].Value.ToString();
        }

        private void txtislemıd_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from tblislemler where islemıd like '" + txtislemıd.Text + "'", connection);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtislemıd.Text = read["islemıd"].ToString();
                dateTimePicker1.CustomFormat = read["kayit_tarih"].ToString();
                dateTimePicker2.CustomFormat = read["bitis_tarih"].ToString();
                txtmusteriıd.Text = read["musteriıd"].ToString();
                txthizmetıd.Text = read["hizmetıd"].ToString();
                txtacik1.Text = read["aciklama1"].ToString();
                txtacik2.Text = read["aciklama2"].ToString();
            }
            connection.Close(); 
        }

        DataSet daset = new DataSet();

        private void islemlerilistelefrm_Load(object sender, EventArgs e)
        {
            islemlerilistele();
        }

        private void txtislemıdara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["tblislemler"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select islemıd, kayit_tarih, bitis_tarih, aciklama1, aciklama2, unvan, telno, hizmet_turu from tblislemler join tblmusteri on tblislemler.musteriıd = tblmusteri.musteriıd join tblhizmet on tblislemler.hizmetıd = tblhizmet.hizmetıd  where islemıd like '%" + txtislemıdara.Text + "%'", connection);
            adtr.Fill(daset, "tblislemler");
            dataGridView1.DataSource = daset.Tables["tblislemler"];
            connection.Close();
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
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from tblislemler where islemıd = @islemıd", connection);
                cmd.Parameters.AddWithValue("@islemıd", dataGridView1.CurrentRow.Cells["islemıd"].Value.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleşti.");
                daset.Tables["tblislemler"].Clear();
                islemlerilistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }
        
        private void islemlerilistele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select islemıd, kayit_tarih, bitis_tarih, aciklama1, aciklama2, unvan, telno, hizmet_turu from tblislemler join tblmusteri on tblislemler.musteriıd = tblmusteri.musteriıd join tblhizmet on tblislemler.hizmetıd = tblhizmet.hizmetıd ", connection);                                                                                                                                  
            adtr.Fill(daset, "tblislemler");
            dataGridView1.DataSource = daset.Tables["tblislemler"];
            connection.Close();
        }
        
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update tblislemler set kayit_tarih=@kayit_tarih, bitis_tarih=@bitis_tarih, musteriıd=@musteriıd, hizmetıd=@hizmetıd, aciklama1=@aciklama1, aciklama2=@aciklama2 where islemıd=@islemıd", connection);                             
            cmd.Parameters.AddWithValue("@kayit_tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@bitis_tarih", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@musteriıd", txtmusteriıd.Text);
            cmd.Parameters.AddWithValue("@hizmetıd", txthizmetıd.Text);
            cmd.Parameters.AddWithValue("@aciklama1", txtacik1.Text);
            cmd.Parameters.AddWithValue("@aciklama2", txtacik2.Text);
            cmd.Parameters.AddWithValue("@islemıd", txtislemıd.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleşti.");

            daset.Tables["tblislemler"].Clear();
            islemlerilistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        
        private void txtbittarihara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["tblislemler"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select islemıd, kayit_tarih, bitis_tarih, aciklama1, aciklama2, unvan, telno, hizmet_turu from tblislemler join tblmusteri on tblislemler.musteriıd = tblmusteri.musteriıd join tblhizmet on tblislemler.hizmetıd = tblhizmet.hizmetıd  where bitis_tarih like '%" + txtbittarihara.Text + "%'", connection);
            adtr.Fill(daset, "tblislemler");
            dataGridView1.DataSource = daset.Tables["tblislemler"];
            connection.Close();
        }

        private void islemlerilistelefrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btngüncelle.PerformClick();
            }
        }
    }
}
