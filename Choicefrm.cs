using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace table
{
    public partial class Choicefrm : Form
    {
        public Choicefrm()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            Frmreg _frmreg = new Frmreg();
            _frmreg.ShowDialog();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Loginfrm _frmlogin = new Loginfrm();
            _frmlogin.ShowDialog();
        }
    }
}
