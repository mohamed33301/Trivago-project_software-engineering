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

namespace Trivago_swe
{
    public partial class Form4 : Form
    {
        string ordb = "Data source = orcl;User Id = scott;Password=tiger;"; 
        OracleConnection conn;
        MessageBox_Form messageBox_F;

        public Form4()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            string username = TB_UserName.Text;
            string password = TB_Password.Text;

            // Check if username and password are provided
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                messageBox_F = new MessageBox_Form("Please Enter both Username and Password 😜😜😜.");
                messageBox_F.ShowDialog();
                return;
            }

            // Connect to the database
            using (conn = new OracleConnection(ordb))
            {
                try
                {
                    conn.Open();

                    // Prepare SQL query to retrieve user_id for the given username and password
                    string sql = "SELECT user_id FROM MyUsers WHERE username = :username AND password = :password";

                    // Create command and parameters
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;

                        // Execute the query and retrieve user_id
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);

                            TB_UserName.Text = "";
                            TB_Password.Text = "";

                            Form1 Form1 = new Form1(userId);
                            Form1.Show();
                        }
                        else
                        {
                            messageBox_F = new MessageBox_Form("Invalid Username or Password 😡😡😡.");
                            messageBox_F.Show();
                        }
                    }
                }
                catch (OracleException ex)
                {
                    //MessageBox.Show("Database error: " + ex.Message);
                    messageBox_F = new MessageBox_Form("Database error: " + ex.Message);
                    messageBox_F.ShowDialog();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("An error occurred: " + ex.Message);
                    messageBox_F = new MessageBox_Form("An error occurred: " + ex.Message);
                    messageBox_F.ShowDialog();
                }
            }
        }


        private void BTN_Register_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            this.Close();
            Form5.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void TB_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
