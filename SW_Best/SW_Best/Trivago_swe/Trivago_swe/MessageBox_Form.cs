using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Trivago_swe
{
    public partial class MessageBox_Form : Form
    {
        string message;
        public MessageBox_Form(string message)
        {
            InitializeComponent();
            this.message = message;
        }

        private void MessageBox_Form_Load(object sender, EventArgs e)
        {
            TB_Output.Text = message;
            TB_Output.ReadOnly = true;
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
