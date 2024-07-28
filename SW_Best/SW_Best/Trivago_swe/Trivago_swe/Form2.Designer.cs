namespace Trivago_swe
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.TB_UserId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_Check_In = new System.Windows.Forms.DateTimePicker();
            this.DTP_Check_Out = new System.Windows.Forms.DateTimePicker();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.TB_Room_Price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DGV_Room_Price = new System.Windows.Forms.DataGridView();
            this.BTN_Select_Room = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Room_Id = new System.Windows.Forms.TextBox();
            this.BTN_Confirm_R = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Room_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(136)))), ((int)(((byte)(150)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1205, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel Reservation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(39, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 190);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "hotel id";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "check_in_date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "guest_count";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(679, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(247, 29);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 28);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1315, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 26);
            this.button3.TabIndex = 23;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "check_out_date";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(136)))), ((int)(((byte)(150)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(760, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(521, 50);
            this.button4.TabIndex = 26;
            this.button4.Text = "Make Reservation";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TB_UserId
            // 
            this.TB_UserId.Location = new System.Drawing.Point(679, 12);
            this.TB_UserId.Name = "TB_UserId";
            this.TB_UserId.Size = new System.Drawing.Size(100, 22);
            this.TB_UserId.TabIndex = 27;
            this.TB_UserId.Visible = false;
            this.TB_UserId.TextChanged += new System.EventHandler(this.TB_UserId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "UserId";
            this.label6.Visible = false;
            // 
            // DTP_Check_In
            // 
            this.DTP_Check_In.Location = new System.Drawing.Point(247, 117);
            this.DTP_Check_In.Name = "DTP_Check_In";
            this.DTP_Check_In.Size = new System.Drawing.Size(200, 22);
            this.DTP_Check_In.TabIndex = 29;
            this.DTP_Check_In.ValueChanged += new System.EventHandler(this.DTP_Check_In_ValueChanged);
            // 
            // DTP_Check_Out
            // 
            this.DTP_Check_Out.Location = new System.Drawing.Point(247, 154);
            this.DTP_Check_Out.Name = "DTP_Check_Out";
            this.DTP_Check_Out.Size = new System.Drawing.Size(200, 22);
            this.DTP_Check_Out.TabIndex = 30;
            this.DTP_Check_Out.ValueChanged += new System.EventHandler(this.DTP_Check_Out_ValueChanged);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackColor = System.Drawing.Color.Red;
            this.BTN_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exit.ForeColor = System.Drawing.Color.White;
            this.BTN_Exit.Location = new System.Drawing.Point(1315, 13);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(80, 26);
            this.BTN_Exit.TabIndex = 31;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // TB_Room_Price
            // 
            this.TB_Room_Price.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TB_Room_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Room_Price.Location = new System.Drawing.Point(247, 71);
            this.TB_Room_Price.Multiline = true;
            this.TB_Room_Price.Name = "TB_Room_Price";
            this.TB_Room_Price.Size = new System.Drawing.Size(150, 28);
            this.TB_Room_Price.TabIndex = 33;
            this.TB_Room_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Room_Price.TextChanged += new System.EventHandler(this.TB_Room_Price_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Room Price";
            // 
            // DGV_Room_Price
            // 
            this.DGV_Room_Price.AllowUserToAddRows = false;
            this.DGV_Room_Price.AllowUserToDeleteRows = false;
            this.DGV_Room_Price.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DGV_Room_Price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Room_Price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_Room_Price.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DGV_Room_Price.Location = new System.Drawing.Point(634, 197);
            this.DGV_Room_Price.Name = "DGV_Room_Price";
            this.DGV_Room_Price.RowHeadersWidth = 51;
            this.DGV_Room_Price.RowTemplate.Height = 24;
            this.DGV_Room_Price.Size = new System.Drawing.Size(766, 147);
            this.DGV_Room_Price.TabIndex = 35;
            this.DGV_Room_Price.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Room_Price_CellContentClick);
            // 
            // BTN_Select_Room
            // 
            this.BTN_Select_Room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(136)))), ((int)(((byte)(150)))));
            this.BTN_Select_Room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Select_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Select_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Select_Room.ForeColor = System.Drawing.Color.White;
            this.BTN_Select_Room.Location = new System.Drawing.Point(34, 208);
            this.BTN_Select_Room.Name = "BTN_Select_Room";
            this.BTN_Select_Room.Size = new System.Drawing.Size(413, 30);
            this.BTN_Select_Room.TabIndex = 36;
            this.BTN_Select_Room.Text = "Select Room";
            this.BTN_Select_Room.UseVisualStyleBackColor = false;
            this.BTN_Select_Room.Click += new System.EventHandler(this.BTN_Select_Room_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Room Id";
            this.label8.Visible = false;
            // 
            // TB_Room_Id
            // 
            this.TB_Room_Id.Location = new System.Drawing.Point(679, 62);
            this.TB_Room_Id.Name = "TB_Room_Id";
            this.TB_Room_Id.Size = new System.Drawing.Size(100, 22);
            this.TB_Room_Id.TabIndex = 38;
            this.TB_Room_Id.Visible = false;
            // 
            // BTN_Confirm_R
            // 
            this.BTN_Confirm_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(136)))), ((int)(((byte)(150)))));
            this.BTN_Confirm_R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Confirm_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Confirm_R.ForeColor = System.Drawing.Color.White;
            this.BTN_Confirm_R.Location = new System.Drawing.Point(33, 645);
            this.BTN_Confirm_R.Name = "BTN_Confirm_R";
            this.BTN_Confirm_R.Size = new System.Drawing.Size(190, 35);
            this.BTN_Confirm_R.TabIndex = 39;
            this.BTN_Confirm_R.Text = "Confirm Reservation";
            this.BTN_Confirm_R.UseVisualStyleBackColor = false;
            this.BTN_Confirm_R.Click += new System.EventHandler(this.BTN_Confirm_R_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivago_swe.Properties.Resources.Background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1412, 688);
            this.Controls.Add(this.BTN_Confirm_R);
            this.Controls.Add(this.TB_Room_Id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTN_Select_Room);
            this.Controls.Add(this.DGV_Room_Price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Room_Price);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.DTP_Check_Out);
            this.Controls.Add(this.DTP_Check_In);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_UserId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivago";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Room_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TB_UserId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_Check_In;
        private System.Windows.Forms.DateTimePicker DTP_Check_Out;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.TextBox TB_Room_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV_Room_Price;
        private System.Windows.Forms.Button BTN_Select_Room;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Room_Id;
        private System.Windows.Forms.Button BTN_Confirm_R;
    }
}