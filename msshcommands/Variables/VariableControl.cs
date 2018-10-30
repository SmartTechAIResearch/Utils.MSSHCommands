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
                fctbTextToReplace.Text = _variable.ToString();

                chkUse.CheckedChanged -= chkUse_CheckedChanged;
                chkUse.Checked = _variable.Use;
                chkUse.CheckedChanged += chkUse_CheckedChanged;
            }
        }

        public VariableControl() {
            InitializeComponent();

            CustomFCTBStyle.Register(fctbTextToReplace);
        }

        private void chkUse_CheckedChanged(object sender, System.EventArgs e) {
            _variable.Use = chkUse.Checked;
        }
        private void btnEdit_Click(object sender, System.EventArgs e) {
            var vs = new VariableSettings() { Variable = _variable };
            vs.ShowDialog();
        }
        private void btnRemove_Click(object sender, System.EventArgs e) {
            VariableCollection.GetInstance().Remove(_variable);

#warning this.Parent.Controls.Remove(this);
            this.Parent.Controls.Remove(this);
        }
    }
}
