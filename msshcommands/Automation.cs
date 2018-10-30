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

namespace msshcommands {
    public partial class Automation : Form {
        public Automation() {
            InitializeComponent();
        }

        private void btnAddList_Click(object sender, EventArgs e) {
            var vs = new VariableSettings() { Variable = new ListVariable() };
            if (vs.ShowDialog() == DialogResult.OK) {
                AddVariable(vs.Variable);
            }
        }

        private void btnAddRange_Click(object sender, EventArgs e) {
            var vs = new VariableSettings() { Variable = new RangeVariable() };
            if (vs.ShowDialog() == DialogResult.OK) {
                AddVariable(vs.Variable);
            }
        }

        private void AddVariable(Variable variable) {
            VariableCollection.GetInstance().Add(variable);
            flpVars.Controls.Add(new VariableControl() { Variable = variable });
        }
        private void btnClearVars_Click(object sender, EventArgs e) {
            flpVars.Controls.Clear();
            VariableCollection.GetInstance().Clear();
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
