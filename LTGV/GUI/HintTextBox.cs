using System.Drawing;
using System.Windows.Forms;

namespace LTGV.GUI
{
    public class HintTextBox : TextBox
    {
        private string hint;

        public string Hint
        {
            get => hint;
            set
            {
                hint = value;
                Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf)
                if (!Focused && string.IsNullOrEmpty(Text)
                             && !string.IsNullOrEmpty(Hint))
                {
                    var color = Enabled ? BackColor : SystemColors.Control;

                    using (var g = CreateGraphics())
                    {
                        TextRenderer.DrawText(g, Hint, Font,
                            ClientRectangle, SystemColors.GrayText, color,
                            TextFormatFlags.Top | TextFormatFlags.Left);
                    }
                }
        }
    }
}