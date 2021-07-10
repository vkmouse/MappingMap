using System;
using System.Windows.Forms;

namespace MappingMap
{
    public partial class TextScrollBar : UserControl
    {
        public event EventHandler ValueChanged
        {
            add { vScrollBar.ValueChanged += value; }
            remove { vScrollBar.ValueChanged -= value; }
        }

        public int Minimum
        {
            get => vScrollBar.Minimum;
            set => vScrollBar.Minimum = value;
        }

        public int Maximum
        {
            get => vScrollBar.Maximum;
            set => vScrollBar.Maximum = value;
        }

        public int Value
        {
            get => vScrollBar.Value;
            set
            {
                vScrollBar.Value = Math.Max(Math.Min(value, vScrollBar.Maximum), vScrollBar.Minimum);
                textBox.Text = vScrollBar.Value.ToString();
            }
        }

        public TextScrollBar()
        {
            InitializeComponent();
            Minimum = -9999;
            Maximum = 9999;
        }

        private void textBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                Value += 1;
            }
            else if (e.Delta < 0)
            {
                Value -= 1;
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            e.NewValue = e.OldValue - (e.NewValue - e.OldValue);
        }

        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            textBox.Text = vScrollBar.Value.ToString();
        }

        private void TextScrollBar_Load(object sender, EventArgs e)
        {
            textBox.Text = vScrollBar.Value.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "")
                Value = 0;
            else if (textBox.Text == "-" || textBox.Text == "-0")
                return;
            int value;
            Value = int.TryParse(textBox.Text, out value) ? value : Value;
        }
    }
}
