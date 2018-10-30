namespace msshcommands.Variables {
    public class ListVariable : Variable {
        public string[] List { get; set; } = new string[] { "item" };

        public override string NextValue {
            get {
                ++base.Step;
                if (base.Step >= List.Length) base.Step = 0;
                if (List.Length == 0) base.Step = -1;

                if (base.Step == -1)
                    base.CurrentValue = "";
                else
                    base.CurrentValue = List[base.Step];

                return base.CurrentValue;
            }
        }

        public override string ToString() {
            return base.TextToReplace + " (list)";
        }
    }
}
