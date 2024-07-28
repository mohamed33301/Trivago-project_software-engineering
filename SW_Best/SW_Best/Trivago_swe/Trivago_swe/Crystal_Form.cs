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
    public partial class Crystal_Form : Form
    {
        CrystalReport CR;
        public Crystal_Form()
        {
            InitializeComponent();
        }

        private void Crystal_Form_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport();
        }

        private void BTN_Generat_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void BTN_Exist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
