using System;
using System.Globalization;
using System.Windows.Forms;

namespace msshcommands.Variables {
    public partial class RangeVariableSettingsControl : UserControl {
        private RangeVariable _variable;
        public RangeVariableSettingsControl() {
            InitializeComponent();
        }

        public RangeVariable Variable {
            get {
                _variable.InclusiveFrom = Convert.ToDouble(nudInclusiveFrom.Value);
                _variable.NumberOfSteps = Convert.ToInt32(nudNumberOfSteps.Value);
                _variable.Stepsize = Convert.ToDouble(nudStepsize.Value);
                return _variable;
            }
            set {
                _variable = value;
                               
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
        private void nudDecimalPlaces_ValueChanged(object sender, EventArgs e) {
            nudInclusiveFrom.DecimalPlaces = nudStepsize.DecimalPlaces = Convert.ToInt32(nudDecimalPlaces.Value);
            nudInclusiveFrom.Value = Math.Round(nudInclusiveFrom.Value, Convert.ToInt32(nudDecimalPlaces.Value));
            nudStepsize.Value = Math.Round(nudStepsize.Value, Convert.ToInt32(nudDecimalPlaces.Value));
        }
    }
}
