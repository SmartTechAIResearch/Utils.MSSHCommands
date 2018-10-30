using System.Collections.Generic;

namespace msshcommands.Variables {
    public class VariableCollection: List<Variable> {
        private static VariableCollection _instance = new VariableCollection();
        public static VariableCollection GetInstance() { return _instance; }

        private VariableCollection() { }
    }
}
