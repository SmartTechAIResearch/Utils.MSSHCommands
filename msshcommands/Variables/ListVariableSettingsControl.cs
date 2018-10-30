using System;
using System.Linq;
using System.Windows.Forms;

namespace msshcommands.Variables {
    public partial class ListVariableSettingsControl : UserControl {
        private ListVariable _variable;

        public ListVariableSettingsControl() {
            InitializeComponent();

            CustomFCTBStyle.Register(fctbList);
        }

        public ListVariable Variable {
            get {
                _variable.List = fctbList.Lines.ToArray();
                return _variable;
            }
            set {
                _variable = value;
                fctbList.Text = string.Join(Environment.NewLine, _variable.List);
            }
        }
    }
}
