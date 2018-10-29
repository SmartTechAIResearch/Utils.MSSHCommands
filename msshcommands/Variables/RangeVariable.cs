namespace msshcommands.Variables {
    public class RangeVariable : Variable {
        private double? _currentValue = null;
        private int _step = -1;

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
                ++_step;
                if (_step >= NumberOfSteps) _step = 0;
                if (NumberOfSteps == 0) _step = -1;

                if (_step == -1)
                    _currentValue = null;
                else if (_step == 0)
                    _currentValue = InclusiveFrom;
                else
                    _currentValue += Stepsize;

                base.CurrentValue = _currentValue.ToString();
                return CurrentValue;
            }
        }

        public override void ResetValue() {
            _step = -1;
            _currentValue = null;
            CurrentValue = "";
        }

        public override string ToString() {
            return base.Name + " (range)";
        }
    }
}
