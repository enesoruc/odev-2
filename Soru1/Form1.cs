using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lstPersons.Items.Add(new Personel(txtAd.Text,txtSoyad.Text,txtUnvan.Text,dateTimePicker1.Value,cmbDepartman.SelectedItem.ToString()));
            }
            catch
            {
                MessageBox.Show("Değerleri Giriniz");
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {

        }
    }
}
