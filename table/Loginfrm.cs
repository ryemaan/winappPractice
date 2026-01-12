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
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (logintxt.Text.Trim() == " " || passtxt.Text.Trim() == " ")
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            if (logintxt.Text.Trim() == "@Login" && passtxt.Text.Trim() == "@Password")
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
