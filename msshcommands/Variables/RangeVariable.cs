namespace msshcommands.Variables {
    public class RangeVariable : Variable {
        private double? _currentValue = null;

        public double InclusiveFrom { get; set; } = 0;
        /// <summary>
        /// Can step over the InclusiveTo if the value range is not dividable by the step.
        /// </summary>
        public double Stepsize { get; set; } = 1;
        /// <summary>
        /// When the number of steps is reached CurrentValue is reset to InclusiveFrom.
        /// </summary>
        public int NumberOfSteps { get; set; } = 0;

        public override string NextValue {
            get {
                ++base.Step;
                if (base.Step >= NumberOfSteps) base.Step = 0;
                if (NumberOfSteps == 0) base.Step = -1;

                if (base.Step == -1)
                    _currentValue = null;
                else if (base.Step == 0)
                    _currentValue = InclusiveFrom;
                else
                    _currentValue += Stepsize;

                base.CurrentValue = _currentValue == null ? "" : _currentValue.ToString();
                return CurrentValue;
            }
        }

        public override string ToString() {
            return base.TextToReplace + " (range)";
        }
    }
}
