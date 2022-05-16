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
       public bool Checked = false;
        void listall(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartListAll"))
            {
                ChartListAll chartlistall = new ChartListAll();
                chartlistall.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartlistall);
                //chartlistall.button1.Visible = true;
                chartlistall.button2.Visible = true;

            }
            panel1.Controls["ChartListAll"].BringToFront();
        }
        void list01(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartList1"))
            {
                ChartList1 chartlist01 = new ChartList1();
                chartlist01.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartlist01);
                //chartlist01.button1.Visible = true;
                chartlist01.button2.Visible = true;
            }
            panel1.Controls["ChartList1"].BringToFront();
        }

        void list02(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartList2"))
            {
                ChartList2 chartlist02 = new ChartList2();
                chartlist02.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartlist02);
                //chartlist02.button1.Visible = true;
                chartlist02.button2.Visible = true;
            }
            panel1.Controls["ChartList2"].BringToFront();
        }

        void list03(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartList3"))
            {
                ChartList3 chartlist03 = new ChartList3();
                chartlist03.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartlist03);
                //chartlist03.button1.Visible = true;
                chartlist03.button2.Visible = true;
            }
            panel1.Controls["ChartList3"].BringToFront();
        }

        void list04(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartList4"))
            {
                ChartList4 chartlist04 = new ChartList4();
                chartlist04.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartlist04);
                //chartlist04.button1.Visible = true;
                chartlist04.button2.Visible = true;
            }
            panel1.Controls["ChartList4"].BringToFront();
        }

        void list05(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartList5"))
            {
                ChartList5 chartlist05 = new ChartList5();
                chartlist05.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartlist05);
                //chartlist05.button1.Visible = true;
                chartlist05.button2.Visible = true;
            }
            panel1.Controls["ChartList5"].BringToFront();
        }

        void list06(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartList6"))
            {
                ChartList6 chartlist06 = new ChartList6();
                chartlist06.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartlist06);
                //chartlist06.button1.Visible = true;
                chartlist06.button2.Visible = true;
            }
            panel1.Controls["ChartList6"].BringToFront();
        }

        void list07(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartList7"))
            {
                ChartList7 chartlist07 = new ChartList7();
                chartlist07.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartlist07);
                //chartlist07.button1.Visible = true;
                chartlist07.button2.Visible = true;
            }
            panel1.Controls["ChartList7"].BringToFront();
        }

        public GaugeChart()
        {
            InitializeComponent();
        }

        private void transparentPanel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ContextMenu ctms = new ContextMenu(); //메뉴 스트립 추가
                Point mousePoint = new Point(e.X, e.Y); //마우스가 클릭된 위치
                //ctms.MenuItems.Add("All");//아이템 추가
                //ctms.MenuItems.Add("ChartList1");
                ctms.Show(this, mousePoint);//마우스 클릭된 위치에 스트립 메뉴를 보여준다

                MenuItem m0 = new MenuItem("All");
                MenuItem m1 = new MenuItem("ChartList1");
                MenuItem m2 = new MenuItem("ChartList2");
                MenuItem m3 = new MenuItem("ChartList3");
                MenuItem m4 = new MenuItem("ChartList4");
                MenuItem m5 = new MenuItem("ChartList5");
                MenuItem m6 = new MenuItem("ChartList6");
                MenuItem m7 = new MenuItem("ChartList7");

                m0.Click += new EventHandler(listall);
                ctms.MenuItems.Add(m0);
                panel1.ContextMenu = ctms;

                m1.Click += new EventHandler(list01);
                ctms.MenuItems.Add(m1);
                panel1.ContextMenu = ctms;

                m2.Click += new EventHandler(list02);
                ctms.MenuItems.Add(m2);
                panel1.ContextMenu = ctms;

                m3.Click += new EventHandler(list03);
                ctms.MenuItems.Add(m3);
                panel1.ContextMenu = ctms;

                m4.Click += new EventHandler(list04);
                ctms.MenuItems.Add(m4);
                panel1.ContextMenu = ctms;

                m5.Click += new EventHandler(list05);
                ctms.MenuItems.Add(m5);
                panel1.ContextMenu = ctms;

                m6.Click += new EventHandler(list06);
                ctms.MenuItems.Add(m6);
                panel1.ContextMenu = ctms;

                m7.Click += new EventHandler(list07);
                ctms.MenuItems.Add(m7);
                panel1.ContextMenu = ctms;
            }
        }
        
        
    }
}
