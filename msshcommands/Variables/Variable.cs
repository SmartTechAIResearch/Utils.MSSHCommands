namespace msshcommands.Variables {
    public abstract class Variable {
        public bool Use { get; set; } = true;
        public string TextToReplace { get; set; } = "";
        public int Step { get; set; } = -1;
        /// <summary>
        /// By default empty string.
        /// </summary>
        public string CurrentValue { get; internal set; } = "";
        /// <summary>
        /// Gets the next value and updates CurrentValue.
        /// </summary>
        public abstract string NextValue { get; }

        public void ResetValue() {
            Step = -1;
            CurrentValue = "";
        }
    }
}
