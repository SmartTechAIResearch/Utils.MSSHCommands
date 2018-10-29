using System;
using System.Linq;
using System.Windows.Forms;

namespace msshcommands.Variables {
    public partial class ListVariableSettings : Form {
        private ListVariable _variable = new ListVariable();

        public ListVariableSettings() {
            InitializeComponent();
        }

        public ListVariable Variable {
            get {
                _variable.Name = txtName.Text;
                _variable.List = fctbList.Lines.ToArray();
                return _variable;
            }
            set {
                _variable = value;
                txtName.Text = _variable.Name;
                fctbList.Text = string.Join(Environment.NewLine, _variable.List);
            }
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
