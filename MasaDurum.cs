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

namespace Cafe_Restaurant
{
    public partial class FormMasa : Form
    {
        public FormMasa()
        {
            InitializeComponent();
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis(); 
            int uzunluk = btnMasa1.Text.Length; 

            ClassGenel._ButtonValue = btnMasa1.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();

        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa2.Text.Length;

            ClassGenel._ButtonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa3.Text.Length;

            ClassGenel._ButtonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa4.Text.Length;

            ClassGenel._ButtonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa5.Text.Length;

            ClassGenel._ButtonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa6.Text.Length;

            ClassGenel._ButtonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa7.Text.Length;

            ClassGenel._ButtonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa8.Text.Length;

            ClassGenel._ButtonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa8.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa9.Text.Length;

            ClassGenel._ButtonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa9.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa10.Text.Length;

            ClassGenel._ButtonValue = btnMasa10.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa10.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa11_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa11.Text.Length;

            ClassGenel._ButtonValue = btnMasa11.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa11.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnMasa12_Click(object sender, EventArgs e)
        {
            FormSiparis frm = new FormSiparis();
            int uzunluk = btnMasa12.Text.Length;

            ClassGenel._ButtonValue = btnMasa12.Text.Substring(uzunluk - 6, 6);
            ClassGenel._ButtonName = btnMasa12.Name;
            this.Close();
            frm.ShowDialog();
        }

       
            }
        }
    }
}
