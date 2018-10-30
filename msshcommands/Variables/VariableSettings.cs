using System;
using System.Linq;
using System.Windows.Forms;

namespace msshcommands.Variables {
    public partial class VariableSettings : Form {
        private Variable _variable;

        public VariableSettings() {
            InitializeComponent();

            CustomFCTBStyle.Register(fctbTextToReplace, fctbValue);
        }

        public Variable Variable {
            get {
                dynamic ctrl = pnlPlaceholder.Controls[0];
                _variable = ctrl.Variable;

                _variable.TextToReplace = fctbTextToReplace.Text;
                return _variable;
            }
            set {
                _variable = value;
                fctbTextToReplace.Text = _variable.TextToReplace;

                pnlPlaceholder.Controls.Clear();
                UserControl ctrl = null;
                if (_variable is ListVariable) {
                    ctrl = new ListVariableSettingsControl() { Variable = _variable as ListVariable };
                }
                else {
                    ctrl = new RangeVariableSettingsControl() { Variable = _variable as RangeVariable };
                }
                ctrl.Dock = DockStyle.Fill;
                pnlPlaceholder.Controls.Add(ctrl);
            }
        }
        private void btnApply_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
