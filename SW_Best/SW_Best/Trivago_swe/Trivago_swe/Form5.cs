using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trivago_swe
{
    public partial class Form5 : Form
    {
        string ordb = "Data source=orcl;User Id=scott;    Password=tiger;";
        OracleConnection conn;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Register_Click(object sender, EventArgs e)
        {
            string username = TB_UserName.Text;
            string role = TB_Role.Text;
            string email = TB_Email.Text;
            string password = TB_Password.Text;

            // Validate email
            if (!email.Contains("@"))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Email should contain '@' 😎😎😎.");
                messageBox_F.ShowDialog();
                return;
            }

            // Validate password length
            if (password.Length < 3)
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Password should be at least 3 characters 😂😂😂.");
                messageBox_F.ShowDialog();
                return;
            }

            // Connect to the Oracle database
            using (conn = new OracleConnection(ordb))
            {
                try
                {
                    conn.Open();

                    // Check if the username already exists
                    string checkUsernameQuery = "SELECT COUNT(*) FROM MyUsers WHERE username = :username";
                    using (OracleCommand checkUsernameCmd = new OracleCommand(checkUsernameQuery, conn))
                    {
                        checkUsernameCmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        int userCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox_Form messageBox_F = new MessageBox_Form("Username Already Exists. Please Choose a Different Username 😅😅😅.");
                            messageBox_F.ShowDialog();
                            return;
                        }
                    }

                    // Prepare the SQL query
                    string sql = "INSERT INTO MyUsers (user_id, username, email, password, role) VALUES (MyUsers_SEQ.nextval, :username, :email, :password, :role)";

                    // Create and execute the command
                    using (OracleCommand command = new OracleCommand(sql, conn))
                    {
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;
                        command.Parameters.Add(":role", OracleDbType.Varchar2).Value = role;

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox_Form messageBox_F = new MessageBox_Form("User Registered Successfully! 👍");
                            messageBox_F.ShowDialog();

                            TB_UserName.Text = "";
                            TB_Role.Text = "";
                            TB_Email.Text = "";
                            TB_Password.Text = "";

                            Form4 form4 = new Form4();
                            this.Hide();
                            form4.ShowDialog();
                        }
                        else
                        {
                            MessageBox_Form messageBox_F = new MessageBox_Form("Failed to Register User. 😡😡😡");
                            messageBox_F.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox_Form messageBox_F = new MessageBox_Form("An error occurred: " + ex.Message);
                    messageBox_F.ShowDialog();
                }
            }
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            this.Hide();
            Form4.ShowDialog();
        }
    }
}
