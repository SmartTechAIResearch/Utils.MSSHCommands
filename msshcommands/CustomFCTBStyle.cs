using FastColoredTextBoxNS;
using System.Drawing;

namespace msshcommands {
    public static class CustomFCTBStyle {
        private static readonly TextStyle _whiteSpaceStyle = new TextStyle(Brushes.Black, new SolidBrush(Color.FromArgb(255, 240, 240, 240)), FontStyle.Regular);

        public static void Register(FastColoredTextBox fastColoredTextBox, params FastColoredTextBox[] other) {
            Register(fastColoredTextBox);
            foreach (var f in other) {
                Register(f);
            }
        }

        private static void Register(FastColoredTextBox fctb) {
            SetStyle(fctb.Range);
            fctb.TextChanged += Fctb_TextChanged;
        }

        private static void Fctb_TextChanged(object sender, TextChangedEventArgs e) {
            SetStyle(e.ChangedRange);
        }

        private static void SetStyle(Range range) {
            range.ClearStyle(FastColoredTextBoxNS.StyleIndex.All);
            range.SetStyle(_whiteSpaceStyle, @"\s");
        }
    }
}
