using msshcommands.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msshcommands
{
    public partial class Automation : Form
    {
        public Automation()
        {
            InitializeComponent();
        }

        private void btnAddList_Click(object sender, EventArgs e) {
            var lvs = new ListVariableSettings();
            lvs.ShowDialog();
        }

        private void btnAddRange_Click(object sender, EventArgs e) {
            var rvs = new RangeVariableSettings();
            rvs.ShowDialog();
        }
    }
}
