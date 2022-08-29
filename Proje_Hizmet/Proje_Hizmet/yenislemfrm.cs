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
    public partial class yenislemfrm : Form
    {
        public yenislemfrm()
        {
            InitializeComponent();
        }
        //SqlConnection SetSqlConectionConfiguration.SetConnectionString() = new SqlConnection(ConfigurationManager.AppSettings["baglanti"]);
        SqlConnection connectionString = SetSqlConectionConfiguration.SetConnectionString();


        private void yenislemfrm_Load(object sender, EventArgs e)   // Veri tabanından verileri Comboboxa çekmek için yaptık.
        {
            SqlCommand cmd = new SqlCommand();
            connectionString.Open();


            cmd.CommandText = "SELECT * FROM tblmusteri";

            cmd.Connection = connectionString;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr;
            //var connection = connect1;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["musteriıd"].ToString() + "-- " + dr["unvan"].ToString());
            }

            connectionString.Close();

            SqlCommand kmt = new SqlCommand();
            kmt.CommandText = "SELECT * FROM tblhizmet";
            kmt.Connection = connectionString;
            kmt.CommandType = CommandType.Text;

            SqlDataReader dat;
            connectionString.Open();
            dat = kmt.ExecuteReader();
            while (dat.Read())
            {
                comboBox2.Items.Add(dat["hizmetıd"] + "-- " + dat["hizmet_turu"]);
            }
            connectionString.Close();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand komut = new SqlCommand("insert into tblislemler (kayit_tarih, bitis_tarih, musteriıd, hizmetıd, aciklama1, aciklama2) values (@kayit_tarih, @bitis_tarih, @musteriıd, @hizmetıd, @aciklama1, @aciklama2)", connectionString);
            komut.Parameters.AddWithValue("@kayit_tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@bitis_tarih", dateTimePicker1.Value.AddYears(Convert.ToInt32(comboBox3.SelectedItem)));
            string resultMusteri = comboBox1.SelectedItem.ToString();
            string[] valuesMusteri = resultMusteri.Split('-');
            komut.Parameters.AddWithValue("@musteriıd", Convert.ToInt32(valuesMusteri[0].ToString()));
            string result = comboBox2.SelectedItem.ToString();
            string[] values = result.Split('-');
            komut.Parameters.AddWithValue("@hizmetıd", Convert.ToInt32(values[0].ToString()));
            komut.Parameters.AddWithValue("@aciklama1", textBox1.Text);
            komut.Parameters.AddWithValue("@aciklama2", textBox2.Text);
            komut.ExecuteNonQuery();
            connectionString.Close();
            MessageBox.Show("Yeni İşlem Kaydı Başarıyla Gerçekleşmiştir.");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void yenislemfrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnekle.PerformClick();
            }
        }
    }
}
