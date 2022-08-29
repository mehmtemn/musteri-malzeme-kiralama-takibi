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
using Proje_Hizmet.SetSqlConnection;

namespace Proje_Hizmet
{
    public partial class müsterieklefrm : Form
    {
        public müsterieklefrm()
        {
            InitializeComponent();
        }
        //SqlConnection SetSqlConectionConfiguration.SetConnectionString() = new SqlConnection(ConfigurationManager.AppSettings["baglanti"]);
        SqlConnection connection = SetSqlConectionConfiguration.SetConnectionString();
        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into tblmusteri (unvan, telno) values (@unvan, @telno)", connection);
            cmd.Parameters.AddWithValue("@telno", txtelno.Text);
            cmd.Parameters.AddWithValue("@unvan", txtunvan.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Ekleme İşlemi Başarıyla Gerçekleşmiştir.");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void müsterieklefrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnekle.PerformClick();
            }
        }
    }
}
