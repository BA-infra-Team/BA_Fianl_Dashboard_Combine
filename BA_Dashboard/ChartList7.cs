using System;
using System.Windows.Forms;

namespace BA_Dashboard
{
    public partial class ChartList7 : UserControl
    {
        public ChartList7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.plnchart.Controls[0].SendToBack();
        }

        private void ChartList7_Load(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
        }
    }
}
