using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191122
{
    public partial class FrmMasikAblak : Form
    {
        FrmMain frmMainRef;
        public FrmMasikAblak(string szoveg, FrmMain foablak)
        {
            InitializeComponent();
            frmMainRef = foablak;
            lblMasikSzoveg.Text = szoveg;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cdSzinvalaszto.ShowDialog();
            frmMainRef.BackColor = cdSzinvalaszto.Color;
        }

        private void FrmMasikAblak_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainRef.vanMarAblak = false;
        }
    }
}
