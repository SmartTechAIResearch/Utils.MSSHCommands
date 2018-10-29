using System;
using System.Globalization;
using System.Windows.Forms;

namespace msshcommands.Variables {
    public partial class RangeVariableSettings : Form {
        private RangeVariable _variable = new RangeVariable();
        public RangeVariableSettings() {
            InitializeComponent();
        }

        public RangeVariable Variable {
            get {
                _variable.Name = txtName.Text;
                _variable.InclusiveFrom = Convert.ToDouble(nudInclusiveFrom.Value);
                _variable.NumberOfSteps = Convert.ToInt32(nudNumberOfSteps.Value);
                _variable.Stepsize = Convert.ToDouble(nudStepsize.Value);
                return _variable;
            }
            set {
                _variable = value;
                txtName.Text = _variable.Name;
                               
                nudDecimalPlaces.Value = GetDecimalPlaces(_variable.InclusiveFrom);
                decimal stub = GetDecimalPlaces(_variable.Stepsize);
                if (stub > nudDecimalPlaces.Value) nudDecimalPlaces.Value = stub;

                nudInclusiveFrom.Value = Convert.ToDecimal(_variable.InclusiveFrom);
                nudNumberOfSteps.Value = Convert.ToDecimal(_variable.NumberOfSteps);
                nudStepsize.Value = Convert.ToDecimal(_variable.Stepsize);
            }
        }

        private decimal GetDecimalPlaces(double val) {
            string[] s = val.ToString().Split(new string[] { CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator }, StringSplitOptions.None);
            if (s.Length == 1) return 0;
            return s[1].Length;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void nudDecimalPlaces_ValueChanged(object sender, EventArgs e) {
            nudInclusiveFrom.DecimalPlaces = nudStepsize.DecimalPlaces = Convert.ToInt32(nudDecimalPlaces.Value);
        }
    }
}
