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

    public partial class ChartAll : UserControl
    {
        
        // new
        LineChart linechart = new LineChart();
        GaugeChart gaugechart = new GaugeChart();
        ColumnChart columnchart = new ColumnChart();
        PercentageStackedChart perchart = new PercentageStackedChart();
        PieChart piechart = new PieChart();
        StackedColumnChart stcolchart = new StackedColumnChart();
        RowChart rowchart = new RowChart();
       
        MenuItem m0 = new MenuItem("All");
        MenuItem m1 = new MenuItem("linechart");
        MenuItem m2 = new MenuItem("columnchart");
        MenuItem m3 = new MenuItem("gaugechart");
        MenuItem m4 = new MenuItem("perchart");
        MenuItem m5 = new MenuItem("rowchart");
        MenuItem m6 = new MenuItem("stcolchart");
        MenuItem m7 = new MenuItem("piechart");

        

        void listall(object sender, EventArgs e)
        {
            ChartAll chartall = new ChartAll();
            if (!panel1.Controls.ContainsKey("ChartAll"))
            {

                chartall.Dock = DockStyle.Fill;
                panel1.Controls.Add(chartall);

            }
            panel1.Controls["ChartAll"].BringToFront();
        }

        void linechart1(object sender, EventArgs e)
        {
            if (m1.Checked == true)
            {
                linechart.WindowState = FormWindowState.Minimized;
                m1.Checked = false;
            }
            else
            {
                m1.Checked = true;
                linechart.WindowState = FormWindowState.Normal;

            }            

        }

        void columnchart1(object sender, EventArgs e)
        {
            if (m2.Checked == true)
            {
                columnchart.WindowState = FormWindowState.Minimized;
                m2.Checked = false;
            }
            else
            {
                m2.Checked = true;
                columnchart.WindowState = FormWindowState.Normal;

            }

        }
        

        void gaugechart1(object sender, EventArgs e)
        {

            if (m3.Checked == true)
            {                
                gaugechart.WindowState = FormWindowState.Minimized;
                m3.Checked = false;
            }
            else
            {
                m3.Checked = true;
                gaugechart.WindowState = FormWindowState.Normal;
                
            }

        }
        void perchart1(object sender, EventArgs e)
        {
            if (m4.Checked == true)
            {
                perchart.WindowState = FormWindowState.Minimized;
                m4.Checked = false;
            }
            else
            {
                m4.Checked = true;
                perchart.WindowState = FormWindowState.Normal;

            }

        }

        void rowchart1(object sender, EventArgs e)
        {
            if (m5.Checked == true)
            {
                rowchart.WindowState = FormWindowState.Minimized;
                m5.Checked = false;
            }
            else
            {
                m5.Checked = true;
                rowchart.WindowState = FormWindowState.Normal;

            }

        }

        void stcolchart1(object sender, EventArgs e)
        {
            if (m6.Checked == true)
            {
                stcolchart.WindowState = FormWindowState.Minimized;
                m6.Checked = false;
            }
            else
            {
                m6.Checked = true;
                stcolchart.WindowState = FormWindowState.Normal;

            }

        }

        void piechart1(object sender, EventArgs e)
        {
            if (m7.Checked == true)
            {
                piechart.WindowState = FormWindowState.Minimized;
                m7.Checked = false;
            }
            else
            {
                m7.Checked = true;
                piechart.WindowState = FormWindowState.Normal;

            }

        }


        Point point = new Point();

        public ChartAll()
        {
            InitializeComponent();
           
        }             

        private void ChartAll_Load(object sender, EventArgs e)
        {
            m0.Click += new EventHandler(listall);
            m0.Checked = true;

            //LineChart
            linechart.TopLevel = false;
            panel1.Controls.Add(linechart);
            
            linechart.Location = new Point(0, 0);
            linechart.Show();

            m1.Click += new EventHandler(linechart1);
            m1.Checked = true;


            //ColumnChart
            columnchart.TopLevel = false;
            panel1.Controls.Add(columnchart);

            columnchart.Show();

            columnchart.Location = new Point(817, 0);
            m2.Click += new EventHandler(columnchart1);
            m2.Checked = true;

           //GaugeChart
            gaugechart.TopLevel = false;
            panel1.Controls.Add(gaugechart);

            gaugechart.Show();
            gaugechart.Location = new Point(0, 193);         

            m3.Click += new EventHandler(gaugechart1);
            m3.Checked = true;

            //PercentageStackedChart
            perchart.TopLevel = false;
            panel1.Controls.Add(perchart);

            perchart.Show();
            perchart.Location = new Point(817, 193);
            
            m4.Click += new EventHandler(perchart1);
            m4.Checked = true;

            //RowChart
            rowchart.TopLevel = false;
            panel1.Controls.Add(rowchart);

            rowchart.Show();

            rowchart.Location = new Point(0, 386);
            m5.Click += new EventHandler(rowchart1);
            m5.Checked = true;

            //StackedColumnChart
            stcolchart.TopLevel = false;
            panel1.Controls.Add(stcolchart);

            stcolchart.Show();
            stcolchart.Location = new Point(817, 386);
            
            m6.Click += new EventHandler(stcolchart1);
            m6.Checked = true;

            //PieChart
            piechart.TopLevel = false;
            panel1.Controls.Add(piechart);

            piechart.Show();
            piechart.Location = new Point(0, 579);

            m7.Click += new EventHandler(piechart1);
            m7.Checked = true;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            //MessageBox.Show(ContextMenu.MenuItems.Count.ToString());
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu ctms = new ContextMenu(); //메뉴 스트립 추가
                Point mousePoint = new Point(e.X, e.Y); //마우스가 클릭된 위치
                //ctms.MenuItems.Add("All");//아이템 추가
                //ctms.MenuItems.Add("ChartList1");
                ctms.Show(this, mousePoint);//마우스 클릭된 위치에 스트립 메뉴를 보여준다

               /* for (int i = 0; i < ContextMenu.MenuItems.Count; i++)
                {
                    if(ContextMenu.MenuItems[i]. == FormWindowState.Minimized)
                    if (ContextMenu.MenuItems[i].Checked == true)
                    {
                        ContextMenu
                    }
                }*/
                if (linechart.WindowState == FormWindowState.Minimized)
                {
                    m1.Checked = false;
                    m0.Checked = false;
                }                
                if (columnchart.WindowState == FormWindowState.Minimized)
                {
                    m2.Checked = false;
                    m0.Checked = false;
                }
                if (gaugechart.WindowState == FormWindowState.Minimized)
                {
                    m3.Checked = false;
                    m0.Checked = false;
                }
                if (perchart.WindowState == FormWindowState.Minimized)
                {
                    m4.Checked = false;
                    m0.Checked = false;
                }
                if (rowchart.WindowState == FormWindowState.Minimized)
                {
                    m5.Checked = false;
                    m0.Checked = false;
                }
                if (stcolchart.WindowState == FormWindowState.Minimized)
                {
                    m6.Checked = false;
                    m0.Checked = false;
                }
                if (piechart.WindowState == FormWindowState.Minimized)
                {
                    m7.Checked = false;
                    m0.Checked = false;
                }


                ctms.MenuItems.Add(m0);
                panel1.ContextMenu = ctms;

                
                ctms.MenuItems.Add(m1);
                panel1.ContextMenu = ctms;

 
                ctms.MenuItems.Add(m2);
                panel1.ContextMenu = ctms;

                
                ctms.MenuItems.Add(m3);
                panel1.ContextMenu = ctms;


                
                ctms.MenuItems.Add(m4);
                panel1.ContextMenu = ctms;


                ctms.MenuItems.Add(m5);
                panel1.ContextMenu = ctms;


                ctms.MenuItems.Add(m6);
                panel1.ContextMenu = ctms;


                ctms.MenuItems.Add(m7);
                panel1.ContextMenu = ctms;

                //MessageBox.Show(ContextMenu.MenuItems.Count.ToString());
            }
        }
    }
}
