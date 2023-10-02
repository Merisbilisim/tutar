using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesepla_Click(object sender, EventArgs e)
        {
            int birimfiyat, adet, toplamfiyat, hesap;
            
            birimfiyat=Convert.ToInt32(txtBirimFiyat.Text);
            adet=Convert.ToInt32(txtAdet.Text);
            toplamfiyat = birimfiyat * adet;

            lblToplamFiyat.Text="Toplam Fiyat: "+ toplamfiyat;

             

        }
    }
}
