namespace msshcommands.Variables {
    public class ListVariable : Variable {
        private int _index = -1;
        public string[] List { get; set; } = new string[] { "item" };

        public override string NextValue {
            get {
                ++_index;
                if (_index >= List.Length) _index = 0;
                if (List.Length == 0) _index = -1;

                if (_index == -1)
                    base.CurrentValue = "";
                else
                    base.CurrentValue = List[_index];

                return base.CurrentValue;
            }
        }

        public override void ResetValue() {
            _index = -1;
            CurrentValue = "";
        }

        public override string ToString() {
            return base.Name + " (list)";
        }
    }
}
