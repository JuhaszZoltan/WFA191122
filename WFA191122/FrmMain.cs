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
    public partial class FrmMain : Form
    {
        public bool vanMarAblak = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGomb_Click(object sender, EventArgs e)
        {
            
            if(!vanMarAblak)
            {
                var frm = new FrmMasikAblak(tbSzoveg.Text, this);
                vanMarAblak = true;
                frm.Show();
            }
            
            
        }
    }
}
