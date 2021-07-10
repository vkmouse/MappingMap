using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MappingMap
{
    public partial class SelectPathControl : UserControl
    {
        public new event EventHandler TextChanged
        {
            add { textBox.TextChanged += value; }
            remove { textBox.TextChanged -= value; }
        }

        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public SelectPathControl()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(textBox.Text, textBox, 0, 0);
            toolTip.ShowAlways = true;
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(textBox);
            toolTip.ShowAlways = false;
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            textBox.Text = openFileDialog.FileName;
        }
    }
}
