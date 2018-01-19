using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = dateDogumTarihi.Value;

            

            Hasta1 hasta = new Hasta1
            {
                Adi = txtAdi.Text,
                Ucret = Convert.ToInt32(txtUcret.Text),
                DogumYili = dogumTarihi.Year,
                Cinsiyet = cmbCinsiyet.Text,
            };

            hasta.YasHesapla();
            hasta.IndirimliUcretHesapla();

            dataGridView1.Rows.Add(hasta.Adi, hasta.DogumYili, hasta.Cinsiyet, hasta.Ucret, hasta.IndirimUcrt, hasta.Yas);
        }
    }
}
