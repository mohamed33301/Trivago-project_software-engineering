using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trivago_swe
{
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=scott;    Password=tiger;"; 
        OracleConnection conn;
        int userId;

        public Form1(int userId) 
        {
            InitializeComponent();
            this.userId = userId; 
            textBox1.Text = userId.ToString();
            this.Opacity = 0; 
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            TB_Profile.ReadOnly = true;
            
            // Connect to the database
            using (conn = new OracleConnection(ordb))
            {
                try
                {
                    conn.Open();

                    // Create OracleCommand to execute the stored procedure
                    OracleCommand cmd = new OracleCommand("GetUserProfile", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add input parameter for user_id
                    int userId = int.Parse(textBox1.Text); // Assuming textBox1 contains the user ID
                    cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = userId;

                    // Add output parameters for user details
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_email", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_role", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    // Display user profile in ListView
                    string id = cmd.Parameters["p_user_id"].Value.ToString();
                    string name = cmd.Parameters["p_username"].Value.ToString();
                    string Email = cmd.Parameters["p_email"].Value.ToString();
                    string role = cmd.Parameters["p_role"].Value.ToString();

                    string Profile = "";
                    Profile = "Welcome Sir,  " + name + " In Trivago This is Your Email is " + Email + " and This is Your Role " + role;

                    TB_Profile.Text = Profile;

                }
                catch (Exception ex)
                {
                    MessageBox_Form messageBox_F = new MessageBox_Form("An error occurred: " + ex.Message);
                    messageBox_F.ShowDialog();
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Search hotels by location
            string hotelLocation = textBox2.Text;
            if (string.IsNullOrEmpty(hotelLocation))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Please Enter a Hotel Location To Search.");
                messageBox_F.ShowDialog();
                return;
            }

            // Connect to the database
            using (OracleConnection conn = new OracleConnection(ordb))
            {
                try
                {
                    conn.Open();

                    // Create OracleCommand to execute the stored procedure
                    OracleCommand cmd = new OracleCommand("GetHotelsLocation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add input parameter for hotelLocation
                    cmd.Parameters.Add("p_hotelLocation", OracleDbType.Varchar2).Value = hotelLocation;

                    // Add output parameter for result set
                    cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    // Execute the stored procedure
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Set DataGridView DataSource
                    dataGridView1.DataSource = dt;

                    // Customize DataGridView columns
                    dataGridView1.Columns["HOTEL_ID"].HeaderText = "Hotel ID";
                    dataGridView1.Columns["NAME"].HeaderText = "Name";
                    dataGridView1.Columns["LOCATION"].HeaderText = "Location";
                    dataGridView1.Columns["STAR_RATING"].HeaderText = "Star Rating";
                    dataGridView1.Columns["DESCRIPTION"].HeaderText = "Description";
                    dataGridView1.Columns["AMENITIES"].HeaderText = "Amenities";
                    dataGridView1.Columns["IMAGE_URL"].HeaderText = "Image URL";

                    // Set column widths and other properties as needed
                    dataGridView1.Columns["HOTEL_ID"].Width = 80;
                    dataGridView1.Columns["NAME"].Width = 150;
                    dataGridView1.Columns["LOCATION"].Width = 100;
                    dataGridView1.Columns["STAR_RATING"].Width = 90;
                    dataGridView1.Columns["DESCRIPTION"].Width = 210;
                    dataGridView1.Columns["AMENITIES"].Width = 150;
                    dataGridView1.Columns["IMAGE_URL"].Width = 160;

                    // Optionally, set some columns to be read-only
                    dataGridView1.Columns["HOTEL_ID"].ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox_Form messageBox_F = new MessageBox_Form("An error occurred: " + ex.Message);
                    messageBox_F.ShowDialog();
                }
            }
        }


        private string selectedHotelName = ""; // Variable to store the selected hotel name

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming you want to pass the hotel ID to the next form
                int hotelId = Convert.ToInt32(row.Cells["hotel_id"].Value);

                // Assuming the column name for hotel name is "name"
                if (dataGridView1.Columns.Contains("name"))
                {
                    selectedHotelName = row.Cells["name"].Value.ToString(); // Store the hotel name

                    // Pass the hotel ID and hotel name to the next form
                    button3.Tag = hotelId;
                }
                else
                {
                    MessageBox_Form messageBox_F = new MessageBox_Form("Hotel Name Column Not Found.");
                    messageBox_F.ShowDialog();
                }
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the hotel ID from the button's Tag property
            if (button3.Tag != null)
            {
                int hotelId = Convert.ToInt32(button3.Tag);

                Form2 form2 = new Form2(hotelId, userId, selectedHotelName); // Pass the hotel ID and hotel name to Form2
                form2.ShowDialog();
            }
            else
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Please Select a Hotel First.");
                messageBox_F.ShowDialog();
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LV_UserProfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BTN_Crystal_Click(object sender, EventArgs e)
        {
            Crystal_Form Fom = new Crystal_Form();
            Fom.ShowDialog();
        }

        private void TB_Profile_TextChanged(object sender, EventArgs e)
        {

        }

        // Animation:
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FadeIn();
        }

        private void FadeIn()
        {
            Timer timer = new Timer();
            timer.Interval = 30; // Adjust the interval for a smoother effect
            timer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05; // Adjust the increment for speed of fade-in
                }
                else
                {
                    timer.Stop();
                }
            };
            timer.Start();
        }
    }
}
