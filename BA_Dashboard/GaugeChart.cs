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

    public partial class GaugeChart : Form
    {
             
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        public GaugeChart()
        {
            InitializeComponent();
            
            this.ControlBox = false;


        }
      
        public int count = 0;
        private void transparentPanel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
            }
        }


    }
}
