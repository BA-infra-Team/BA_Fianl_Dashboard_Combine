using System;
using System.Windows.Forms;

namespace BA_Dashboard
{
    public partial class ChartList5 : UserControl
    {
        private bool drag = false;
        public ChartList5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.plnchart.Controls[0].SendToBack();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                drag = true;
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.panel2.Height = button2.Top + e.Y;
                this.panel2.Width = button2.Left + e.X;
                button2.Top = panel2.Height - button2.Height;
                button2.Left = panel2.Width - button2.Width;

            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                drag = false;
            }
        }

        private void ChartList5_Load(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
        }
    }
}
