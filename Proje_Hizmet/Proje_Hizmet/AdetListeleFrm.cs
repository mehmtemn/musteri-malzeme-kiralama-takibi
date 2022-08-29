using Proje_Hizmet.SetSqlConnection;
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

namespace Proje_Hizmet
{
    public partial class AdetListeleFrm : Form
    {
        public AdetListeleFrm()
        {
            InitializeComponent();
        }

        SqlConnection connectionString = SetSqlConectionConfiguration.SetConnectionString();

        DataTable List()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("select islemıd, kayit_tarih, bitis_tarih, aciklama1, aciklama2, unvan, telno, hizmet_turu from tblislemler join tblmusteri on tblislemler.musteriıd = tblmusteri.musteriıd join tblhizmet on tblislemler.hizmetıd = tblhizmet.hizmetıd ", connectionString);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            //dataGridView1.Columns[1].Visible = false;
            Count();
            return tbl;
        }

        DataTable Filtrele()
        {
            string sql = "select islemıd, kayit_tarih, bitis_tarih, aciklama1, aciklama2, unvan, telno from tblislemler join tblmusteri on tblislemler.musteriıd = tblmusteri.musteriıd  Where kayit_tarih between @p1 and @p2 and hizmetıd=@hizmetıd";
            
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, connectionString);
            adtr.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            adtr.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            string resultMusteri = comboBox1.SelectedItem.ToString();
            string[] valuesMusteri = resultMusteri.Split('-');
            adtr.SelectCommand.Parameters.AddWithValue("@hizmetıd", Convert.ToInt32(valuesMusteri[0].ToString()));
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            //dataGridView1.Columns[1].Visible = false; 
            Count();
            return tbl;
        }

        void Count()
        {
            label4.Text = $"TOPLAM KAYIT SAYISI : {dataGridView1.RowCount - 1}";
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List();
        }

        private void AdetListeleFrm_Load(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand();
            kmt.CommandText = "SELECT * FROM tblhizmet";
            kmt.Connection = connectionString;
            kmt.CommandType = CommandType.Text;

            SqlDataReader dat;
            connectionString.Open();
            dat = kmt.ExecuteReader();
            while (dat.Read())
            {
                comboBox1.Items.Add(dat["hizmetıd"] + "-- " + dat["hizmet_turu"]);
            }
            connectionString.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}
