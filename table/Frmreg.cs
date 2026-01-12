using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace table
{
    public partial class Frmreg : Form
    {
        #region feilds

        DataTable _dt = new DataTable();
        SqlConnection _con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Library;Data Source=(local)\r\n");
        System.Data.SqlClient.SqlCommandBuilder _cmdBuilder;
        SqlDataAdapter _da;

        #endregion
        public Frmreg()
        {
            InitializeComponent();
        }
        void GenerateCommands(string SqlSelectCommand)
        {
            _da = new SqlDataAdapter(SqlSelectCommand, _con);
            _cmdBuilder = new System.Data.SqlClient.SqlCommandBuilder(_da);
            _da.DeleteCommand = _cmdBuilder.GetDeleteCommand();
            _da.UpdateCommand = _cmdBuilder.GetUpdateCommand();
            _da.InsertCommand = _cmdBuilder.GetInsertCommand();
        }

        private void tablebtn_Click(object sender, EventArgs e)
        {
            GenerateCommands("Select * from Users");
            _dt.Clear();
            _da.Fill(_dt);
            dgvData.DataSource = _dt;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Users(UserName, Email, PhoneNumber,Login, Password)" +
                "VALUES(@Username, @Email, @PhoneNumber, @Login, @Password)";
            using (SqlCommand command = new SqlCommand(query, _con))
            {
                _con.Open();
                command.Parameters.AddWithValue("@Username", UserNametxt.Text);
                command.Parameters.AddWithValue("@Login", Logintxt.Text);
                if (PhoneNumbertxt.TextLength == 11)
                {
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumbertxt.Text);
                }
                else
                {
                    command.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                    MessageBox.Show("Некорректно введен Phone number");
                    return;
                }
                string emailText = Emailtxt.Text;
                if (emailText.Contains("@") && emailText.IndexOf('@') > 0)
                {
                    command.Parameters.AddWithValue("@Email", emailText);
                }
                else
                {
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                    MessageBox.Show("Некорректно введен Email");
                    return;
                }
                if (Regex.IsMatch(Passwordtxt.Text, "^[A-Za-z0-9]+$") && Passwordtxt.TextLength >= 5)
                {
                    command.Parameters.AddWithValue("@Password", Passwordtxt.Text);
                }
                else
                {
                    command.Parameters.AddWithValue("@Password", DBNull.Value);
                    MessageBox.Show("Некорректно введен Password");
                    return;
                }
                if(UserNametxt.Text.Trim() == "" || Logintxt.Text.Trim() == "" || Passwordtxt.Text.Trim() == "" || PhoneNumbertxt.Text.Trim() == "" || Emailtxt.Text.Trim() == "")
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Данные сохранились");
                }
            }
        } 
    }
}
