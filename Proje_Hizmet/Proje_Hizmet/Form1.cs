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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        //SqlConnection SetSqlConectionConfiguration.SetConnectionString() = new SqlConnection(ConfigurationManager.AppSettings["baglanti"]);

        private void btnmüsteriekle_Click(object sender, EventArgs e)
        {
            müsterieklefrm müsekle = new müsterieklefrm();
            müsekle.ShowDialog();
        }

        private void btnmüslistele_Click(object sender, EventArgs e)
        {
            müsterilistelemefrm müslistele = new müsterilistelemefrm();
            müslistele.ShowDialog();
        }

        private void btnhizekle_Click(object sender, EventArgs e)
        {
            yenihizmetfrm yenihzmt = new yenihizmetfrm();
            yenihzmt.ShowDialog();
        }

        private void hizlistele_Click(object sender, EventArgs e)
        {
            hizmetlerilistelefrm hizliste = new hizmetlerilistelefrm();
            hizliste.ShowDialog();
        }

        private void btnislemekle_Click(object sender, EventArgs e)
        {
            yenislemfrm yenislem = new yenislemfrm();
            yenislem.ShowDialog();
        }

        private void btnislemlistele_Click(object sender, EventArgs e)
        {
            islemlerilistelefrm islemlis = new islemlerilistelefrm();
            islemlis.ShowDialog();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            müsterieklefrm müekle = new müsterieklefrm();
            müekle.ShowDialog();
        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            müsterilistelemefrm müliste = new müsterilistelemefrm();
            müliste.ShowDialog();
        }

        private void yeniHizmetEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenihizmetfrm yenhiz = new yenihizmetfrm();
            yenhiz.ShowDialog();
        }

        private void hizmetleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hizmetlerilistelefrm hizlis = new hizmetlerilistelefrm();
            hizlis.ShowDialog();
        }

        private void yeniİşlemEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenislemfrm yenislm = new yenislemfrm();
            yenislm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?", "DİKKAT !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
                Application.Exit();
        }

        private void işlemleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islemlerilistelefrm islemlis = new islemlerilistelefrm();
            islemlis.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdetListeleFrm adliste = new AdetListeleFrm();
            adliste.ShowDialog();
        }
    }
}
