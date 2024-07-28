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
    public partial class main_Form : Form
    {
        public main_Form()
        {
            InitializeComponent();
        }

        private void main_Form_Load(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.ShowDialog();
        }
    }
}
