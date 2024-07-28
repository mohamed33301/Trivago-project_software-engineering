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
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl;User Id=scott;    Password=tiger;";
        int hotelId;
        int userId;
        string hotelName;
        

        public Form2(int hotelId,int userId, string hotelName)
        {
            InitializeComponent();

            this.hotelId = hotelId;
            this.userId = userId;
            this.hotelName = hotelName;
            textBox1.Text = hotelId.ToString();
            TB_UserId.Text = userId.ToString();


            // Add columns to the DataGridView
            dataGridView1.Columns.Add("userIdColumn", "User_Id");
            dataGridView1.Columns.Add("hotelIdColumn", "hotel_id");
            dataGridView1.Columns.Add("roomIdColumn", "Room_id");
            dataGridView1.Columns.Add("hotelNameColumn", "Hotel_Name");
            dataGridView1.Columns.Add("checkInDateColumn", "check_in_date");
            dataGridView1.Columns.Add("checkOutDateColumn", "check_out_date");
            dataGridView1.Columns.Add("guestCountColumn", "guest_count");
            dataGridView1.Columns.Add("Column8", "Room_Price");

            dataGridView1.Columns["userIdColumn"].ReadOnly = true;
            dataGridView1.Columns["hotelIdColumn"].ReadOnly = true;
            dataGridView1.Columns["roomIdColumn"].ReadOnly = true;
            dataGridView1.Columns["hotelNameColumn"].ReadOnly = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TB_UserId.ReadOnly = true;
            textBox1.ReadOnly = true;

            DGV_Room_Price.CellClick += DGV_Room_Price_CellClick;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Check if any of the input fields is empty
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(TB_UserId.Text) ||
                string.IsNullOrWhiteSpace(TB_Room_Id.Text) ||
                string.IsNullOrWhiteSpace(hotelName) ||
                string.IsNullOrWhiteSpace(TB_Room_Price.Text))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Please Fill in All Fields.");
                messageBox_F.ShowDialog();
                return;
            }

            // Check if check-out date is greater than check-in date
            if (DTP_Check_In.Value >= DTP_Check_Out.Value)
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Check-out Date Must be Greater Than Check-in Date.");
                messageBox_F.ShowDialog();
                return;
            }

            // Check if the data already exists in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == TB_UserId.Text &&
                    row.Cells[1].Value != null && row.Cells[1].Value.ToString() == textBox1.Text &&
                    row.Cells[2].Value != null && row.Cells[2].Value.ToString() == TB_Room_Id.Text &&
                    row.Cells[3].Value != null && row.Cells[3].Value.ToString() == hotelName &&
                    row.Cells[4].Value != null && row.Cells[4].Value.ToString() == DTP_Check_In.Value.ToShortDateString() &&
                    row.Cells[5].Value != null && row.Cells[5].Value.ToString() == DTP_Check_Out.Value.ToShortDateString() &&
                    row.Cells[6].Value != null && row.Cells[6].Value.ToString() == textBox3.Text)
                {
                    MessageBox_Form messageBox_F = new MessageBox_Form("This Entry Already Exists.");
                    messageBox_F.ShowDialog();
                    return;
                }
            }

            // Create a new row for the DataGridView
            DataGridViewRow newRow = new DataGridViewRow();

            // Create cells for each column and populate them with data from text boxes
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = TB_UserId.Text });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = textBox1.Text });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = TB_Room_Id.Text });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = hotelName });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = DTP_Check_In.Value.ToShortDateString() });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = DTP_Check_Out.Value.ToShortDateString() });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = textBox3.Text });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = TB_Room_Price.Text });

            // Add the new row to the DataGridView
            dataGridView1.Rows.Add(newRow);

            textBox3.Text = "";
            TB_Room_Price.Text = "";

            // Declare nullable DateTime variables
            DateTime? checkInDate = null;
            DateTime? checkOutDate = null;

            // Set the value of the DateTimePickers to the nullable DateTime variables
            DTP_Check_In.Value = checkInDate ?? DateTime.Now; // Use DateTime.Now as a fallback if checkInDate is null
            DTP_Check_Out.Value = checkOutDate ?? DateTime.Now; // Use DateTime.Now as a fallback if checkOutDate is null

            DGV_Room_Price.DataSource = null;
        }



        private void TB_UserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTP_Check_In_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTP_Check_Out_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Select_Room_Click(object sender, EventArgs e)
        {
            // Check if the price entered is valid
            if (!decimal.TryParse(TB_Room_Price.Text, out decimal price) || price <= 0)
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Please Enter a Valid Price Greater Than 0.");
                messageBox_F.ShowDialog();
                return;
            }

            // Create a DataTable to hold the results
            DataTable dataTable = new DataTable();

            // Define your SQL query to fetch rooms with price less than or equal to the entered price
            string sql = "SELECT room_id, room_type, price, capacity FROM Rooms WHERE price <= :price";

            // Create a new OracleDataAdapter
            using (OracleDataAdapter adapter = new OracleDataAdapter())
            {
                // Create a new OracleConnection
                using (OracleConnection connection = new OracleConnection(ordb))
                {
                    // Create a new OracleCommand
                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // Add parameter for the price
                        command.Parameters.Add(":price", OracleDbType.Decimal).Value = price;

                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command for the adapter
                            adapter.SelectCommand = command;

                            // Fill the DataTable with the results of the query
                            adapter.Fill(dataTable);

                            // Check if there are any rows in the DataTable
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox_Form messageBox_F = new MessageBox_Form("No Rooms Found with The Specified Price or Less.");
                                messageBox_F.ShowDialog();
                                return;
                            }

                            // Check if there are any rooms with capacity less than required
                            int guestCount;
                            if (!int.TryParse(textBox3.Text, out guestCount) || guestCount < 1 || guestCount > 10)
                            {
                                MessageBox_Form messageBox_F = new MessageBox_Form("Guest Count Must be a Valid Integer Between 1 and 10.");
                                messageBox_F.ShowDialog();
                                return;
                            }

                            DataRow[] filteredRows = dataTable.Select($"capacity >= {guestCount}");
                            if (filteredRows.Length == 0)
                            {
                                MessageBox_Form messageBox_F = new MessageBox_Form("No Rooms Available with Enough Capacity For The Specified Number of Guests.");
                                messageBox_F.ShowDialog();
                                return;
                            }

                            // Bind the filtered DataTable to the DataGridView
                            DGV_Room_Price.DataSource = filteredRows.CopyToDataTable();

                            // Make the DataGridView read-only
                            DGV_Room_Price.ReadOnly = true;

                            // Customize DataGridView columns
                            DGV_Room_Price.Columns["ROOM_ID"].HeaderText = "Room ID";
                            DGV_Room_Price.Columns["ROOM_TYPE"].HeaderText = "Room Type";
                            DGV_Room_Price.Columns["PRICE"].HeaderText = "Price";
                            DGV_Room_Price.Columns["CAPACITY"].HeaderText = "Capacity";

                            // Set column widths and other properties as needed
                            DGV_Room_Price.Columns["ROOM_ID"].Width = 130;
                            DGV_Room_Price.Columns["ROOM_TYPE"].Width = 130;
                            DGV_Room_Price.Columns["PRICE"].Width = 130;
                            DGV_Room_Price.Columns["CAPACITY"].Width = 130;
             
                            // Allow users to select rows in the DataGridView
                            DGV_Room_Price.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        }
                        catch (Exception ex)
                        {
                            MessageBox_Form messageBox_F = new MessageBox_Form("An error occurred: " + ex.Message);
                            messageBox_F.ShowDialog();
                        }
                    }
                }
            }
        }

        private void DGV_Room_Price_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is selected
            if (e.RowIndex >= 0 && e.RowIndex < DGV_Room_Price.Rows.Count)
            {
                // Get the value of the Room_Id column from the selected row
                object roomId = DGV_Room_Price.Rows[e.RowIndex].Cells["Room_Id"].Value;

                // Display the Room_Id in the TB_Room_Id textbox
                TB_Room_Id.Text = roomId.ToString();
            }
        }

        private void TB_Room_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_Room_Price_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the dataGridView1
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Remove the selected row from the dataGridView1
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Please Select Reservation Row to Cancel.");
                messageBox_F.ShowDialog();
            }
        }

        private void BTN_Confirm_R_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the dataGridView1
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Please Select a Row to Confirm The Reservation.");
                messageBox_F.ShowDialog();
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Extract data from the selected row
            int userId;
            if (!int.TryParse(selectedRow.Cells["userIdColumn"].Value.ToString(), out userId))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Invalid user ID format."); ;
                messageBox_F.ShowDialog();
                return;
            }

            int hotelId;
            if (!int.TryParse(selectedRow.Cells["hotelIdColumn"].Value.ToString(), out hotelId))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Invalid hotel ID format.");
                messageBox_F.ShowDialog();
                return;
            }

            int roomId;
            if (!int.TryParse(selectedRow.Cells["roomIdColumn"].Value.ToString(), out roomId))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Invalid room ID format.");
                messageBox_F.ShowDialog();
                return;
            }

            DateTime checkInDate;
            if (!DateTime.TryParse(selectedRow.Cells["checkInDateColumn"].Value.ToString(), out checkInDate))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Invalid check-in date format.");
                messageBox_F.ShowDialog();
                return;
            }

            DateTime checkOutDate;
            if (!DateTime.TryParse(selectedRow.Cells["checkOutDateColumn"].Value.ToString(), out checkOutDate))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Invalid check-out date format.");
                messageBox_F.ShowDialog();
                return;
            }

            int guestCount;
            if (!int.TryParse(selectedRow.Cells["guestCountColumn"].Value.ToString(), out guestCount))
            {
                MessageBox_Form messageBox_F = new MessageBox_Form("Invalid guest count format.");
                messageBox_F.ShowDialog();
                return;
            }

            // Connect to the database
            using (OracleConnection conn = new OracleConnection(ordb))
            {
                try
                {
                    conn.Open();

                    // Insert data into MyReservations table
                    string insertQuery = "INSERT INTO MyReservations (reservation_id, user_id, hotel_id, room_id, check_in_date, check_out_date, guest_count, status) " +
                                         "VALUES (MyReservations_SEQ.nextval, :user_id, :hotel_id, :room_id, :check_in_date, :check_out_date, :guest_count, :status)";
                    OracleCommand insertCommand = new OracleCommand(insertQuery, conn);
                    insertCommand.Parameters.Add(":user_id", OracleDbType.Int32).Value = userId;
                    insertCommand.Parameters.Add(":hotel_id", OracleDbType.Int32).Value = hotelId;
                    insertCommand.Parameters.Add(":room_id", OracleDbType.Int32).Value = roomId;
                    insertCommand.Parameters.Add(":check_in_date", OracleDbType.Date).Value = checkInDate;
                    insertCommand.Parameters.Add(":check_out_date", OracleDbType.Date).Value = checkOutDate;
                    insertCommand.Parameters.Add(":guest_count", OracleDbType.Int32).Value = guestCount;
                    insertCommand.Parameters.Add(":status", OracleDbType.Varchar2, 50).Value = "confirmed";
                    insertCommand.ExecuteNonQuery();

                    MessageBox_Form messageBox_F = new MessageBox_Form("Reservation Confirmed and Added To The Database Successfully. 👍👍👍");
                    messageBox_F.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox_Form messageBox_F = new MessageBox_Form("An error occurred: " + ex.Message);
                    messageBox_F.ShowDialog();
                }
            }
        }

    }
}
