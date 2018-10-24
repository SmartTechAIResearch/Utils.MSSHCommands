using System.Collections.Generic;

namespace msshcommands.Variables {
    public class Variables: List<Variable> {
        public static Variables _instance = new Variables();
        public static Variables GetInstance() { return _instance; }

        private Variables() { }
    }
}
