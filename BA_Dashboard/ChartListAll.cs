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
    public partial class ChartListAll : UserControl
    {
        private bool drag = false;
        private Point point = new Point();
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
        public ChartListAll()
        {
            InitializeComponent();
        }

        private void ChartListAll_Load(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button5.Visible = false;
            this.button7.Visible = false;
            this.button9.Visible = false;
            this.button11.Visible = false;
            this.button13.Visible = false;

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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

                if (this.panel3.Width < 200 || this.panel3.Height < 100)
                {
                    this.panel3.Visible = false;
                    //Form1.Instance.button3.Visible = true;
                }
                else
                {
                    this.panel3.Visible = true;
                    //Form1.Instance.button3.Visible = false;
                }
                if (this.panel2.Width < 200 || this.panel2.Height < 100)
                {
                    this.panel2.Visible = false;
                    //Form1.Instance.button2.Visible = true;
                }
                else
                {
                    this.panel2.Visible = true;
                    //Form1.Instance.button2.Visible = false;
                }

                this.panel3.Location = new System.Drawing.Point(button1.Right + 3, button1.Top);


                if (this.panel3.Location.X < 823)
                {

                    this.panel3.Width = panel1.Width - panel2.Width - 3;
                }
                else
                {
                    this.panel3.Width = panel1.Width - panel2.Width - 3;
                }

            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                drag = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.plnchart.Controls[0].SendToBack();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
            }
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.panel3.Height = button4.Top + e.Y;
                this.panel3.Width = button4.Left + e.X;
                button4.Top = panel3.Height - button4.Height;
                button4.Left = panel3.Width - button4.Width;

                if (this.panel3.Width < 200 || this.panel3.Height < 100)
                {
                    this.panel3.Visible = false;
                    //Form1.Instance.button3.Visible = true;
                }
                else
                {
                    this.panel3.Visible = true;
                    //Form1.Instance.button3.Visible = false;
                }
                if (this.panel2.Width < 200 || this.panel2.Height < 100)
                {
                    this.panel2.Visible = false;
                    //Form1.Instance.button2.Visible = true;
                }
                else
                {
                    this.panel2.Visible = true;
                    //Form1.Instance.button2.Visible = false;
                }
                this.panel3.Location = new System.Drawing.Point(panel1.Width - panel3.Width + 3, button3.Top);

                this.panel2.Width = panel1.Width - panel3.Width;

            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                drag = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.ContainsKey("ChartList2"))
            {
                ChartList2 chart02 = new ChartList2();
                chart02.Dock = DockStyle.Fill;
                panel1.Controls.Add(chart02);
                chart02.button1.Visible = true;
                chart02.button2.Visible = true;
            }
            panel1.Controls["ChartList2"].BringToFront();
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
            }
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.panel4.Height = button6.Top + e.Y;
                this.panel4.Width = button6.Left + e.X;
                button6.Top = panel4.Height - button6.Height;
                button6.Left = panel4.Width - button6.Width;

                if (this.panel4.Width < 200 || this.panel4.Height < 100)
                    this.panel4.Visible = false;
                else
                    this.panel4.Visible = true;

                if (this.panel5.Width < 200 || this.panel5.Height < 100)
                    this.panel5.Visible = false;
                else
                    this.panel5.Visible = true;



                this.panel5.Location = new System.Drawing.Point(button5.Right + 3, 196);
                if (this.panel5.Location.X < 823)
                {

                    this.panel5.Width = panel1.Width - panel4.Width - 3;
                }
                else
                {
                    this.panel5.Width = panel1.Width - panel4.Width - 3;
                }
            }
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                drag = false;
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
            }
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.panel5.Height = button8.Top + e.Y;
                this.panel5.Width = button8.Left + e.X;
                button8.Top = panel5.Height - button8.Height;
                button8.Left = panel5.Width - button8.Width;

                if (this.panel5.Width < 200 || this.panel5.Height < 100)
                    this.panel5.Visible = false;
                else
                    this.panel5.Visible = true;

                if (this.panel4.Width < 200 || this.panel4.Height < 100)
                    this.panel4.Visible = false;
                else
                    this.panel4.Visible = true;

                this.panel5.Location = new System.Drawing.Point(panel1.Width - panel5.Width + 3, 196);

                this.panel4.Width = panel1.Width - panel5.Width;

            }
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                drag = false;
            }
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
            }
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.panel6.Height = button10.Top + e.Y;
                this.panel6.Width = button10.Left + e.X;
                button10.Top = panel6.Height - button10.Height;
                button10.Left = panel6.Width - button10.Width;

                if (this.panel6.Width < 200 || this.panel6.Height < 100)
                    this.panel6.Visible = false;
                else
                    this.panel6.Visible = true;

                if (this.panel7.Width < 200 || this.panel7.Height < 100)
                    this.panel7.Visible = false;
                else
                    this.panel7.Visible = true;


                this.panel7.Location = new System.Drawing.Point(button9.Right + 3, 389);
                if (this.panel7.Location.X < 823)
                {

                    this.panel7.Width = panel1.Width - panel6.Width - 3;
                }
                else
                {
                    this.panel7.Width = panel1.Width - panel6.Width - 3;
                }
            }
        }

        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                drag = false;
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
            }
        }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                this.panel7.Height = button12.Top + e.Y;
                this.panel7.Width = button12.Left + e.X;
                button12.Top = panel7.Height - button12.Height;
                button12.Left = panel7.Width - button12.Width;

                if (this.panel7.Width < 200 || this.panel7.Height < 100)
                    this.panel7.Visible = false;
                else
                    this.panel7.Visible = true;

                if (this.panel6.Width < 200 || this.panel6.Height < 100)
                    this.panel6.Visible = false;
                else
                    this.panel6.Visible = true;

                this.panel7.Location = new System.Drawing.Point(panel1.Width - panel7.Width + 3, 389);

                this.panel6.Width = panel1.Width - panel7.Width;

            }
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                drag = false;
            }
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
            }
        }

        private void button14_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                this.panel8.Height = button14.Top + e.Y;
                this.panel8.Width = button14.Left + e.X;
                button14.Top = panel8.Height - button14.Height;
                button14.Left = panel8.Width - button14.Width;

                if(this.panel8.Width < 200 || this.panel8.Height < 100)
                {
                    this.panel8.Visible = false;
                }
                else
                {
                    this.panel8.Visible = true;
                }
            }
        }

        private void button14_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                drag = false;
            }
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

        private void transparentPanel2_MouseDown(object sender, MouseEventArgs e)
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

        private void transparentPanel3_MouseDown(object sender, MouseEventArgs e)
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

        private void transparentPanel4_MouseDown(object sender, MouseEventArgs e)
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

        private void transparentPanel5_MouseDown(object sender, MouseEventArgs e)
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

        private void transparentPanel6_MouseDown(object sender, MouseEventArgs e)
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

        private void transparentPanel7_MouseDown(object sender, MouseEventArgs e)
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
