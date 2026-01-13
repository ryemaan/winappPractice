using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace table
{
    public partial class Loginfrm : Form
    {
        SqlConnection _con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Library;Data Source=(local)\r\n");
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            string login = logintxt.Text;
            string password = passtxt.Text;
            string username = LoginUser(login, password);
            if (username != null)
            {
                MessageBox.Show($"Авторизация успешна {username}");
                return;
            }
            if (login.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
          
        private string LoginUser(string login, string password)
        {
            _con.Open();
            string query = "SELECT Username FROM Users WHERE Login = @Login AND Password = @Password";

            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Password", password);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }

            }
        } 
    }
}
