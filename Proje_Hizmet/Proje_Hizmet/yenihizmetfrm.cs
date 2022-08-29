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
    public partial class yenihizmetfrm : Form
    {
        public yenihizmetfrm()
        {
            InitializeComponent();
        }
        //SqlConnection SetSqlConectionConfiguration.SetConnectionString() = new SqlConnection(ConfigurationManager.AppSettings["baglanti"]); 
        SqlConnection connectionString = SetSqlConectionConfiguration.SetConnectionString();

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("insert into tblhizmet (hizmet_turu) values (@hizmet_turu)", connectionString);
            cmd.Parameters.AddWithValue("@hizmet_turu", txthiztürü.Text);
            cmd.ExecuteNonQuery();
            connectionString.Close();
            MessageBox.Show("Hizmet Türü Kaydı Başarıyla Gerçekleştirilmiştir.");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void yenihizmetfrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnekle.PerformClick();
            }
        }
    }
}
