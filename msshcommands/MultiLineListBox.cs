using System;
using System.Drawing;
using System.Windows.Forms;

namespace msshcommands {
    public class MultiLineListBox : ListBox {

        public MultiLineListBox() {
            DrawMode = DrawMode.OwnerDrawVariable;
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e) {
            if (Site != null || e.Index < 0 || e.Index >= Items.Count)
                return;
            string s = Items[e.Index].ToString();
            SizeF sf = e.Graphics.MeasureString(s, Font, Width);
            int htex = (e.Index == 0) ? 15 : 10;
            e.ItemHeight = (int)sf.Height + htex;
            e.ItemWidth = Width;
        }
        protected override void OnDrawItem(DrawItemEventArgs e) {
            if (Site != null || e.Index < 0 || e.Index >= Items.Count)
                return;

            string s = Items[e.Index].ToString();

            if ((e.State & DrawItemState.Focus) == 0) {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                e.Graphics.DrawString(s, Font, new SolidBrush(SystemColors.WindowText),
                    e.Bounds);
                e.Graphics.DrawRectangle(new Pen(SystemColors.Highlight), e.Bounds);
            }
            else {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Highlight), e.Bounds);
                e.Graphics.DrawString(s, Font, new SolidBrush(SystemColors.HighlightText),
                    e.Bounds);
            }
        }
        
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);

            if (this.IsHandleCreated) {
                object[] items = new object[Items.Count];
                Items.CopyTo(items, 0);

                this.SuspendLayout();
                Items.Clear();
                Items.AddRange(items);
                this.ResumeLayout(true);
            }
        }
    }
}
