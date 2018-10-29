using System.Windows.Forms;

namespace msshcommands.Variables {
    public partial class VariableControl : UserControl {
        private Variable _variable;
        public Variable Variable {
            get {
                return _variable;
            }
            set {
                _variable = value;
                lbl.Text = _variable.ToString();

                chkUse.CheckedChanged -= chkUse_CheckedChanged;
                chkUse.Checked = _variable.Use;
                chkUse.CheckedChanged += chkUse_CheckedChanged;
            }
        }

        public VariableControl() {
            InitializeComponent();
        }

        private void chkUse_CheckedChanged(object sender, System.EventArgs e) {
            _variable.Use = chkUse.Checked;
        }
        private void btnEdit_Click(object sender, System.EventArgs e) {
            if (_variable is ListVariable) {
                var lvs = new ListVariableSettings();
                lvs.Variable = _variable as ListVariable;
                lvs.ShowDialog();
            }
            else {
                var rvs = new RangeVariableSettings();
                rvs.Variable = _variable as RangeVariable;
                rvs.ShowDialog();
            }
        }
        private void btnRemove_Click(object sender, System.EventArgs e) {
            Variables.GetInstance().Remove(_variable);

#warning this.Parent.Controls.Remove(this);
            this.Parent.Controls.Remove(this);
        }
    }
}
