
namespace Trivago_swe
{
    partial class Crystal_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crystal_Form));
            this.BTN_Generat = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BTN_Exist = new System.Windows.Forms.Button();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Generat
            // 
            this.BTN_Generat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(136)))), ((int)(((byte)(150)))));
            this.BTN_Generat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Generat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Generat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Generat.ForeColor = System.Drawing.Color.White;
            this.BTN_Generat.Location = new System.Drawing.Point(604, 16);
            this.BTN_Generat.Name = "BTN_Generat";
            this.BTN_Generat.Size = new System.Drawing.Size(330, 45);
            this.BTN_Generat.TabIndex = 0;
            this.BTN_Generat.Text = "Generat Crystal Report";
            this.BTN_Generat.UseVisualStyleBackColor = false;
            this.BTN_Generat.Click += new System.EventHandler(this.BTN_Generat_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 75);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1388, 601);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // BTN_Exist
            // 
            this.BTN_Exist.BackColor = System.Drawing.Color.Red;
            this.BTN_Exist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Exist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exist.ForeColor = System.Drawing.Color.White;
            this.BTN_Exist.Location = new System.Drawing.Point(1315, 13);
            this.BTN_Exist.Name = "BTN_Exist";
            this.BTN_Exist.Size = new System.Drawing.Size(80, 26);
            this.BTN_Exist.TabIndex = 2;
            this.BTN_Exist.Text = "Exist";
            this.BTN_Exist.UseVisualStyleBackColor = false;
            this.BTN_Exist.Click += new System.EventHandler(this.BTN_Exist_Click);
            // 
            // BTN_Back
            // 
            this.BTN_Back.BackColor = System.Drawing.Color.Gold;
            this.BTN_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Back.ForeColor = System.Drawing.Color.White;
            this.BTN_Back.Location = new System.Drawing.Point(1315, 46);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(80, 26);
            this.BTN_Back.TabIndex = 3;
            this.BTN_Back.Text = "Back";
            this.BTN_Back.UseVisualStyleBackColor = false;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // Crystal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivago_swe.Properties.Resources.Background_1;
            this.ClientSize = new System.Drawing.Size(1412, 688);
            this.Controls.Add(this.BTN_Back);
            this.Controls.Add(this.BTN_Exist);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.BTN_Generat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crystal_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystal_Form";
            this.Load += new System.EventHandler(this.Crystal_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Generat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button BTN_Exist;
        private System.Windows.Forms.Button BTN_Back;
    }
}