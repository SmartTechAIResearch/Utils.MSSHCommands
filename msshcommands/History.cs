using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace msshcommands {
    public partial class History : Form {
        private CommandHistory _commandHistory = CommandHistory.GetInstance();
        private List<string> _filter = new List<string>();
        private Timer _tmrFilter = new Timer() { Interval = 500 };

        public event EventHandler SelectedValueChanged;

        public string SelectedValue { get { return lbHistory.SelectedItem == null ? "" : lbHistory.SelectedItem.ToString(); } }

        public History() {
            InitializeComponent();
            if (this.IsHandleCreated)
                Init();
            else
                this.HandleCreated += History_HandleCreated;
        }
        private void History_HandleCreated(object sender, EventArgs e) {
            this.HandleCreated -= History_HandleCreated;
            Init();
        }
        private void Init() {
            Filter();
            _tmrFilter.Tick += _tmrFilter_Tick;
        }
        private void _tmrFilter_Tick(object sender, EventArgs e) {
            if (_tmrFilter.Enabled) {
                _tmrFilter.Stop();
                Filter(txtFilter.Text);
            }
        }
        private void Filter(string contains = "") {
            var filter = new SortedSet<object>();

            if (string.IsNullOrEmpty(contains))
                foreach (string node in _commandHistory) filter.Add(node);
            else
                foreach (string node in _commandHistory)
                    if (node.Contains(contains)) filter.Add(node);

            lbHistory.SuspendLayout();
            lbHistory.Items.Clear();
            var h = new string[filter.Count];
            filter.CopyTo(h);
            lbHistory.Items.AddRange(h);
            lbHistory.ResumeLayout(true);
        }
        private void txtFilter_TextChanged(object sender, EventArgs e) {
            _tmrFilter.Stop();
            _tmrFilter.Start();
        }
        private void btnClearHistory_Click(object sender, EventArgs e) {
            _tmrFilter.Stop();
            _commandHistory.CurrentCommandHistoryNode = null;
            _commandHistory.Clear();

            Filter();
        }
        protected override void OnClosing(CancelEventArgs e) {
            _tmrFilter.Stop();
            base.OnClosing(e);
        }
        private void lbHistory_SelectedValueChanged(object sender, EventArgs e) { SelectedValueChanged?.Invoke(this, e); }
    }
}
