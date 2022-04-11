using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_Dashboard
{
    public partial class row_0_col_0_Left_UC : UserControl
    {
        public bool onDrag { get; set; }
        public row_0_col_0_Left_UC()
        {
            InitializeComponent();
            onDrag = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                onDrag = true;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (onDrag)
            {
                this.panel1.Height = pictureBox2.Top + e.Y;
                this.panel1.Width = pictureBox2.Left + e.X;

                pictureBox2.Top = this.panel1.Height - pictureBox2.Height;
                pictureBox2.Left = this.panel1.Width - pictureBox2.Width;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (onDrag)
            {
                onDrag = false;
            }
        }
    }
}
