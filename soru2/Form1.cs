using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sifrele sifre;
        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen değer giriniz");
                txtSifre.Clear();
                txtSifre.Focus();
            }
            else
            {
                sifre = new sifrele(txtSifre.Text);
                if (cmbSifre.SelectedIndex==0)
                {
                    lblSifre.Text = sifre.SifreCevir();
                }
                else if (cmbSifre.SelectedIndex==1)
                {
                    lblSifre.Text = sifre.SifreCevir1();
                }
                else
                {
                    MessageBox.Show("Şifreleme Yöntemi Seçiniz");
                }
            }
            
        }
    }
}
