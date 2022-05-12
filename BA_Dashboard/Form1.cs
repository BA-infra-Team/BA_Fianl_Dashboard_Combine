using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BA_Dashboard
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Socket ClientSocket;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel row_1_col_1_panel
        {
            get { return row_1_col_1_Panel; }
            set { row_1_col_1_Panel = value; }
        }

        public Panel panelcontainer
        {
            get { return panel5; }
            set { panel5 = value; }
        }

        public Panel plnchart
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
        }

        public Panel contentpanel
        {
            get { return ContentPanel; }
            set { ContentPanel = value; }
        }


        public Form1()
        {
            // 포트 7756 테스트
            //파일 읽기
            string filepath = "C:\\Users\\BA\\DownloadFromServer";
            IPAddress ipAddress = IPAddress.Parse("192.168.10.10");
            int port = 7756;
            IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, port);
            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            bool blockingState = ClientSocket.Blocking;
            blockingState = false;
            try
            {
                ClientSocket.Connect(iPEndPoint);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                this.Close();
                blockingState = true;
            }


            try
            {
                // 버퍼
                byte[] Buffer = new byte[1024];

                // 클라이언트측에서 서버에게 "접속완료" 문구보냄.
                string message = "ChartData";
                byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                ClientSocket.Send(data);

                // String to store the response ASCII representation.
                String responseData = String.Empty;
                // Read the first batch of the TcpServer response bytes.
                // 서버로부터 처음에 환영인사 문구 메세지 받음

                int rev = ClientSocket.Receive(Buffer);
                responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, rev);

                Buffer = new byte[4096];
                //MessageBox.Show("Received: {responseData}", responseData);

<<<<<<< HEAD
            Buffer = new byte[4096];
            rev = 0;
            rev = ClientSocket.Receive(Buffer, 0);
            //rev = ClientSocket.Receive(Buffer, 0);
            BinaryWriter bWrite = new BinaryWriter(File.Open(filepath + fileName,
            FileMode.Create, FileAccess.Write));
=======
                // 첫 파일 구조체 정보 
                rev = ClientSocket.Receive(Buffer, 0, 23, 0);
                int fileNameLen = BitConverter.ToInt32(Buffer, 0);
                string fileName = Encoding.ASCII.GetString(Buffer, 4, fileNameLen);
                int fileSize = BitConverter.ToInt32(Buffer, 4 + fileNameLen + 1);
>>>>>>> origin/jiwoo

                Buffer = new byte[4096];
                rev = 0;
                rev = ClientSocket.Receive(Buffer, 0);
                //rev = ClientSocket.Receive(Buffer, 0);
                BinaryWriter bWrite = new BinaryWriter(File.Open(filepath + fileName,
    FileMode.Create, FileAccess.Write));

                bWrite.Write(Buffer, 0, rev);
                bWrite.Close();

                // 파일 읽기 
                BinaryReader bRead = new BinaryReader(File.Open(filepath + fileName, FileMode.Open, FileAccess.Read));

                ChartData ChartDatas = new ChartData();
                ChartDatas.Read_Chart_Data(bRead);
                bRead.Close();
            }

            catch (SocketException e)
            {
                // 10035 == WSAEWOULDBLOCK
                if (e.NativeErrorCode.Equals(10035))
                {
                    MessageBox.Show("Still Connected, but the Send would block");
                }
                else
                {
                    MessageBox.Show("Disconnected: error code {0}!", e.NativeErrorCode.ToString());
                }
            }
            InitializeComponent();
            if(blockingState == true)
            {
                this.Close();
            }   

            

            Chart_UC chart_UC = new Chart_UC();
            Error_UC error_UC = new Error_UC();
            Filtering_UC Filter_UC = new Filtering_UC();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            row_1_col_1_Line_UC r_1_c_1_UChome = new row_1_col_1_Line_UC();
            r_1_c_1_UChome.Dock = DockStyle.Fill;
            row_1_col_1_Panel.Controls.Add(r_1_c_1_UChome);

            //button5.Visible = false;
            ChartList1 c1 = new ChartList1();
            c1.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(c1);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.ContainsKey("Filtering_UC"))
            {
                Filtering_UC Filter_UC = new Filtering_UC();
                Filter_UC.Dock = DockStyle.Fill;
                ContentPanel.Controls.Add(Filter_UC);
            }
            ContentPanel.Controls["Filtering_UC"].BringToFront();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (ContentPanel.Controls.ContainsKey("Filtering_UC"))
            {
                ContentPanel.Controls["Filtering_UC"].SendToBack();
            }
            if (ContentPanel.Controls.ContainsKey("Chart_UC"))
            {
                ContentPanel.Controls["Chart_UC"].SendToBack();
            }
            if (ContentPanel.Controls.ContainsKey("Error_UC"))
            {
                ContentPanel.Controls["Error_UC"].SendToBack();
            }
<<<<<<< HEAD
            if(ContentPanel.Controls.ContainsKey("ChartListAll"))
            {
                ContentPanel.Controls["ChartListAll"].SendToBack();
            }
            if (plnchart.Controls.ContainsKey("ChartList1"))
            {
                ContentPanel.Controls["Form1"].BringToFront();
            }
            if (ContentPanel.Controls.ContainsKey("ChartList2"))
            {
                ContentPanel.Controls["ChartList2"].SendToBack();
            }
            if (ContentPanel.Controls.ContainsKey("ChartList3"))
            {
                ContentPanel.Controls["ChartList3"].SendToBack();
            }
            if (ContentPanel.Controls.ContainsKey("ChartList4"))
            {
                ContentPanel.Controls["ChartList4"].SendToBack();
            }
            if (ContentPanel.Controls.ContainsKey("ChartList5"))
            {
                ContentPanel.Controls["ChartList5"].SendToBack();
            }
            if (ContentPanel.Controls.ContainsKey("ChartList6"))
            {
                ContentPanel.Controls["ChartList6"].SendToBack();
            }
            if (ContentPanel.Controls.ContainsKey("ChartList7"))
            {
                ContentPanel.Controls["ChartList7"].SendToBack();
=======
            if (ContentPanel.Controls.ContainsKey("ChartList1"))
            {
                ContentPanel.Controls["ChartList1"].SendToBack();
            }

            if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList1"])
            {
                Form1.Instance.plnchart.Controls[0].SendToBack();
            }
            if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList2"])
            {
                Form1.Instance.plnchart.Controls[0].SendToBack();
            }
            if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList3"])
            {
                Form1.Instance.plnchart.Controls[0].SendToBack();
            }
            if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList4"])
            {
                Form1.Instance.plnchart.Controls[0].SendToBack();
            }
            if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList5"])
            {
                Form1.Instance.plnchart.Controls[0].SendToBack();
            }
            if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList6"])
            {
                Form1.Instance.plnchart.Controls[0].SendToBack();
            }
            if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList7"])
            {
                Form1.Instance.plnchart.Controls[0].SendToBack();
>>>>>>> origin/jiwoo
            }
        }

        private void ChartBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.ContainsKey("Chart_UC"))
            {
                Chart_UC chart_UC = new Chart_UC();
                chart_UC.Dock = DockStyle.Fill;
                ContentPanel.Controls.Add(chart_UC);
            }
            ContentPanel.Controls["Chart_UC"].BringToFront();
        }

        //Error 버튼 클릭
        private void ErrorBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.ContainsKey("Error_UC"))
            {
                Error_UC error_UC = new Error_UC();
                error_UC.Dock = DockStyle.Fill;
                ContentPanel.Controls.Add(error_UC);
            }
            ContentPanel.Controls["Error_UC"].BringToFront();
        }

        //back 버튼 클릭
        private void button5_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart1")
            {
                Form1.Instance.elementHost1.Child = new Chart7();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;
            }

            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart2")
            {
                Form1.Instance.elementHost1.Child = new Chart1();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;
            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart3")
            {
                Form1.Instance.elementHost1.Child = new Chart2();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;


            }

            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart4")
            {
                Form1.Instance.elementHost1.Child = new Chart3();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;


            }

            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart5")
            {
                Form1.Instance.elementHost1.Child = new Chart4();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;

            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart6")
            {
                Form1.Instance.elementHost1.Child = new Chart5();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;
            }

            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart7")
            {
                Form1.Instance.elementHost1.Child = new Chart6();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;

            }
        }

        //Next 버튼 클릭
        private void button6_Click(object sender, EventArgs e)
        {

            if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart1")
            {
<<<<<<< HEAD
                Form1.Instance.elementHost1.Child = new Chart2();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;
            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart2")
=======
                ChartList2_2 c2 = new ChartList2_2();
                c2.Dock = DockStyle.Fill;
                Form1.Instance.panelcontainer.Controls.Add(c2);
                Form1.Instance.panelcontainer.Controls["ChartList2_2"].BringToFront();
                Form1.Instance.button5.Visible = true;
            }
            else if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList2_2"])
>>>>>>> origin/jiwoo
            {
                Form1.Instance.elementHost1.Child = new Chart3();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;


            }

            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart3")
            {
                Form1.Instance.elementHost1.Child = new Chart4();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;


            }

            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart4")
            {
<<<<<<< HEAD
                Form1.Instance.elementHost1.Child = new Chart5();
                Form1.Instance.elementHost1.BringToFront();
=======
                ChartList5_2 c5 = new ChartList5_2();
                c5.Dock = DockStyle.Fill;
                Form1.Instance.panelcontainer.Controls.Add(c5);

                Form1.Instance.panelcontainer.Controls["ChartList5_2"].BringToFront();
>>>>>>> origin/jiwoo
                Form1.Instance.button5.Visible = true;


            }

<<<<<<< HEAD
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart5")
            {
                Form1.Instance.elementHost1.Child = new Chart6();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;

            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart6")
=======
            else if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList5_2"])
            {
                ChartList6_2 c6 = new ChartList6_2();
                c6.Dock = DockStyle.Fill;
                Form1.Instance.panelcontainer.Controls.Add(c6);

                Form1.Instance.panelcontainer.Controls["ChartList6_2"].BringToFront();
                Form1.Instance.button5.Visible = true;

            }
            else if (Form1.Instance.panelcontainer.Controls[0] == Form1.Instance.panelcontainer.Controls["ChartList6_2"])
>>>>>>> origin/jiwoo
            {
                Form1.Instance.elementHost1.Child = new Chart7();
                Form1.Instance.elementHost1.BringToFront();
                Form1.Instance.button5.Visible = true;

            }
<<<<<<< HEAD
            else if(Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart7")
=======

            else
>>>>>>> origin/jiwoo
            {
                Form1.Instance.elementHost1.Child = new Chart1();
                Form1.Instance.elementHost1.BringToFront();
                //Form1.Instance.panelcontainer.Controls["ChartList1"].BringToFront();
                Form1.Instance.button5.Visible = true;
            }

        }

        // 확대 버튼 클릭 
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart1")
            {
                ChartList1 c1 = new ChartList1();
                c1.ChartList1_Btn.Visible = true;
                c1.Dock = DockStyle.Fill;
                Form1.Instance.plnchart.Controls.Add(c1);
                Form1.Instance.plnchart.Controls["ChartList1"].BringToFront();
                Form1.Instance.button5.Visible = true;
                c1.button1.Visible = true;
                c1.button2.Visible = true;
            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart2")
            {
                ChartList2 c2 = new ChartList2();
                c2.Dock = DockStyle.Fill;
                Form1.Instance.plnchart.Controls.Add(c2);
                Form1.Instance.plnchart.Controls["ChartList2"].BringToFront();
                Form1.Instance.button5.Visible = true;
                c2.button1.Visible = true;
                c2.button2.Visible = true;
            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart3")
            {
                ChartList3 c3 = new ChartList3();
                c3.Dock = DockStyle.Fill;
                Form1.Instance.plnchart.Controls.Add(c3);
                Form1.Instance.plnchart.Controls["ChartList3"].BringToFront();
                Form1.Instance.button5.Visible = true;
                c3.button1.Visible = true;
                c3.button2.Visible = true;
            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart4")
            {
                ChartList4 c4 = new ChartList4();
                c4.Dock = DockStyle.Fill;
                Form1.Instance.plnchart.Controls.Add(c4);
                Form1.Instance.plnchart.Controls["ChartList4"].BringToFront();
                Form1.Instance.button5.Visible = true;
                c4.button1.Visible = true;
                c4.button2.Visible = true;
            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart5")
            {
                ChartList5 c5 = new ChartList5();
                c5.Dock = DockStyle.Fill;
                Form1.Instance.plnchart.Controls.Add(c5);
                Form1.Instance.plnchart.Controls["ChartList5"].BringToFront();
                Form1.Instance.button5.Visible = true;
                c5.button1.Visible = true;
                c5.button2.Visible = true;
            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart6")
            {
                ChartList6 c6 = new ChartList6();
                c6.Dock = DockStyle.Fill;
                Form1.Instance.plnchart.Controls.Add(c6);
                Form1.Instance.plnchart.Controls["ChartList6"].BringToFront();
                Form1.Instance.button5.Visible = true;
                c6.button1.Visible = true;
                c6.button2.Visible = true;
            }
            else if (Form1.Instance.elementHost1.Child.ToString() == "BA_Dashboard.Chart7")
            {
                ChartList7 c7 = new ChartList7();
                c7.Dock = DockStyle.Fill;
                Form1.Instance.plnchart.Controls.Add(c7);
                Form1.Instance.plnchart.Controls["ChartList7"].BringToFront();
                Form1.Instance.button5.Visible = true;
                c7.button1.Visible = true;
                c7.button2.Visible = true;
            }
        }

        //All 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.ContainsKey("ChartListAll"))
            {
                ChartListAll chartall = new ChartListAll();
                chartall.Dock = DockStyle.Fill;
                ContentPanel.Controls.Add(chartall);
                //chartall.button1.Visible = true;
                chartall.button3.Visible = false;
                chartall.button5.Visible = false;
                chartall.button7.Visible = false;
                chartall.button9.Visible = false;
                chartall.button11.Visible = false;
                chartall.button13.Visible = false;
                chartall.button2.Visible = true;
            }
            ContentPanel.Controls["ChartListAll"].BringToFront();
        }
    }

    public class ChartData
    {
        // 홈 UI, 백업-메소드 비율을 보여주기 위한 데이터 구조체 선언 
        public static int Backup_Method_Ratio_Pie_Chart_Total_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Archive_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Cumulative_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Differential_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Dump_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Enterprise_Differential_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Enterprise_Full_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Enterprise_Incremental_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Full_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Incremental_Backup_Count;
        public static int Backup_Method_Ratio_Pie_Chart_Synthetic_Count;

        // 홈 UI, 일별 총 백업 수를 보여주 데이터 구조체 선언
        public static int Total_Backup_Count_LineChart_2022_02_08_Completed_Count;
        public static int Total_Backup_Count_LineChart_2022_02_09_Completed_Count;
        public static int Total_Backup_Count_LineChart_2022_02_10_Completed_Count;
        public static int Total_Backup_Count_LineChart_2022_02_11_Completed_Count;
        public static int Total_Backup_Count_LineChart_2022_02_12_Completed_Count;
        public static int Total_Backup_Count_LineChart_2022_02_13_Completed_Count;
        public static int Total_Backup_Count_LineChart_2022_02_14_Completed_Count;
        public static int Total_Backup_Count_LineChart_2022_02_15_Completed_Count;

        // 파일통계화면 UI, 파일 관련 통계를 보여줄 데이터 구조체 선언 
        public static int File_Statistics_PieChart_Data_Transferred;
        public static int File_Statistics_PieChart_Total_File_Size;
        public static int File_Statistics_PieChart_Total_Write_Size;

        // 파일통계화면 UI, 평균 경과시간을 보여주는 데이터 구조체 선언 
        public static int Avg_Elapsed_Time_LineChart_2022_02_08_Avg_Elapsed_Times;
        public static int Avg_Elapsed_Time_LineChart_2022_02_09_Avg_Elapsed_Times;
        public static int Avg_Elapsed_Time_LineChart_2022_02_10_Avg_Elapsed_Times;
        public static int Avg_Elapsed_Time_LineChart_2022_02_11_Avg_Elapsed_Times;
        public static int Avg_Elapsed_Time_LineChart_2022_02_12_Avg_Elapsed_Times;
        public static int Avg_Elapsed_Time_LineChart_2022_02_13_Avg_Elapsed_Times;
        public static int Avg_Elapsed_Time_LineChart_2022_02_14_Avg_Elapsed_Times;
        public static int Avg_Elapsed_Time_LineChart_2022_02_15_Avg_Elapsed_Times;

        // 파일통계화면 UI, 작업 종류를 보여주는 데이터 구조체 선언
        public static int JobType_PieChart_Total_Count;
        public static int JobType_PieChart_File_Backup_Count;
        public static int JobType_PieChart_Informix_Onbar_Backup_Count;
        public static int JobType_PieChart_Mysql_Backup_Count;
        public static int JobType_PieChart_Oracle_RMAN_Backup_Count;
        public static int JobType_PieChart_Physical_Backup_Count;
        public static int JobType_PieChart_Vm_Ware_Backup_Count;

        // 에러 UI, 에러 비율을 보여주는 데이터 구조체 선언
        public static int Total_Error_Ratio_PieChart_Total_Count;
        public static int Total_Error_Ratio_PieChart_Total_Completed_Count;
        public static int Total_Error_Ratio_PieChart_Total_Error_Count;

        // 일별 에러 체크 
        public static int Error_02_08_Count;
        public static int Error_02_09_Count;
        public static int Error_02_10_Count;
        public static int Error_02_11_Count;
        public static int Error_02_12_Count;
        public static int Error_02_13_Count;
        public static int Error_02_14_Count;
        public static int Error_02_15_Count;

        // 에러 UI, 작업 종류별 에러타입을 위한 데이터 구조체 선언 
        public static int Error_Ratio_By_Job_Status_PieChart_Total_Error_Count;
        public static int Error_Ratio_By_Job_Status_PieChart_Partially_Completed_Count;
        public static int Error_Ratio_By_Job_Status_PieChart_Suspended_Error_Count;
        public static int Error_Ratio_By_Job_Status_PieChart_Failed_Error_Count;
        public static int Error_Ratio_By_Job_Status_PieChart_Canceled_Error_Count;

        // 스케줄 별 개수 표시 
        public static int Schedule_testsc1_Count;
        public static int Schedule_testsc2_Count;
        public static int Schedule_testsc3_Count;
        public static int Schedule_testsc4_Count;

        // 파일 총 개수
        public int Total_Files_Count;

        // 일별 파일 사이즈 (2022-03-24 추가)
        public static int Total_File_Size_LineChart_2022_02_08_Count;
        public static int Total_File_Size_LineChart_2022_02_09_Count;
        public static int Total_File_Size_LineChart_2022_02_10_Count;
        public static int Total_File_Size_LineChart_2022_02_11_Count;
        public static int Total_File_Size_LineChart_2022_02_12_Count;
        public static int Total_File_Size_LineChart_2022_02_13_Count;
        public static int Total_File_Size_LineChart_2022_02_14_Count;
        public static int Total_File_Size_LineChart_2022_02_15_Count;

        // 일별 저장 사이즈 (2022-03-24 추가)
        public static int Total_Write_Size_LineChart_2022_02_08_Count;
        public static int Total_Write_Size_LineChart_2022_02_09_Count;
        public static int Total_Write_Size_LineChart_2022_02_10_Count;
        public static int Total_Write_Size_LineChart_2022_02_11_Count;
        public static int Total_Write_Size_LineChart_2022_02_12_Count;
        public static int Total_Write_Size_LineChart_2022_02_13_Count;
        public static int Total_Write_Size_LineChart_2022_02_14_Count;
        public static int Total_Write_Size_LineChart_2022_02_15_Count;

        // 일별 전송 사이즈 (2022-03-24 추가)
        public static int Total_Data_Transferred_LineChart_2022_02_08_Count;
        public static int Total_Data_Transferred_LineChart_2022_02_09_Count;
        public static int Total_Data_Transferred_LineChart_2022_02_10_Count;
        public static int Total_Data_Transferred_LineChart_2022_02_11_Count;
        public static int Total_Data_Transferred_LineChart_2022_02_12_Count;
        public static int Total_Data_Transferred_LineChart_2022_02_13_Count;
        public static int Total_Data_Transferred_LineChart_2022_02_14_Count;
        public static int Total_Data_Transferred_LineChart_2022_02_15_Count;

        public void Read_Chart_Data(BinaryReader bRead)
        {
            // 홈 UI, 백업-메소드 비율을 보여주기 위한 데이터 구조체 선언 
            Backup_Method_Ratio_Pie_Chart_Total_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Archive_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Cumulative_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Differential_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Dump_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Enterprise_Differential_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Enterprise_Full_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Enterprise_Incremental_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Full_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Incremental_Backup_Count = bRead.ReadInt32();
            Backup_Method_Ratio_Pie_Chart_Synthetic_Count = bRead.ReadInt32();

            // 홈 UI, 일별 총 백업 수를 보여주 데이터 구조체 선언
            Total_Backup_Count_LineChart_2022_02_08_Completed_Count = bRead.ReadInt32();
            Total_Backup_Count_LineChart_2022_02_09_Completed_Count = bRead.ReadInt32();
            Total_Backup_Count_LineChart_2022_02_10_Completed_Count = bRead.ReadInt32();
            Total_Backup_Count_LineChart_2022_02_11_Completed_Count = bRead.ReadInt32();
            Total_Backup_Count_LineChart_2022_02_12_Completed_Count = bRead.ReadInt32();
            Total_Backup_Count_LineChart_2022_02_13_Completed_Count = bRead.ReadInt32();
            Total_Backup_Count_LineChart_2022_02_14_Completed_Count = bRead.ReadInt32();
            Total_Backup_Count_LineChart_2022_02_15_Completed_Count = bRead.ReadInt32();


            // 파일통계화면 UI, 파일 관련 통계를 보여줄 데이터 구조체 선언 
            File_Statistics_PieChart_Data_Transferred = bRead.ReadInt32();
            File_Statistics_PieChart_Total_File_Size = bRead.ReadInt32();
            File_Statistics_PieChart_Total_Write_Size = bRead.ReadInt32();

            // 파일통계화면 UI, 평균 경과시간을 보여주는 데이터 구조체 선언 
            Avg_Elapsed_Time_LineChart_2022_02_08_Avg_Elapsed_Times = bRead.ReadInt32();
            Avg_Elapsed_Time_LineChart_2022_02_09_Avg_Elapsed_Times = bRead.ReadInt32();
            Avg_Elapsed_Time_LineChart_2022_02_10_Avg_Elapsed_Times = bRead.ReadInt32();
            Avg_Elapsed_Time_LineChart_2022_02_11_Avg_Elapsed_Times = bRead.ReadInt32();
            Avg_Elapsed_Time_LineChart_2022_02_12_Avg_Elapsed_Times = bRead.ReadInt32();
            Avg_Elapsed_Time_LineChart_2022_02_13_Avg_Elapsed_Times = bRead.ReadInt32();
            Avg_Elapsed_Time_LineChart_2022_02_14_Avg_Elapsed_Times = bRead.ReadInt32();
            Avg_Elapsed_Time_LineChart_2022_02_15_Avg_Elapsed_Times = bRead.ReadInt32();

            // 파일통계화면 UI, 작업 종류를 보여주는 데이터 구조체 선언 
            JobType_PieChart_Total_Count = bRead.ReadInt32();
            JobType_PieChart_File_Backup_Count = bRead.ReadInt32();
            JobType_PieChart_Informix_Onbar_Backup_Count = bRead.ReadInt32();
            JobType_PieChart_Mysql_Backup_Count = bRead.ReadInt32();
            JobType_PieChart_Oracle_RMAN_Backup_Count = bRead.ReadInt32();
            JobType_PieChart_Physical_Backup_Count = bRead.ReadInt32();
            JobType_PieChart_Vm_Ware_Backup_Count = bRead.ReadInt32();

            // 에러 UI, 에러 비율을 보여주는 데이터 구조체 선언
            Total_Error_Ratio_PieChart_Total_Count = bRead.ReadInt32();
            Total_Error_Ratio_PieChart_Total_Completed_Count = bRead.ReadInt32();
            Total_Error_Ratio_PieChart_Total_Error_Count = bRead.ReadInt32();

            // 일별 에러 카운트
            Error_02_08_Count = bRead.ReadInt32();
            Error_02_09_Count = bRead.ReadInt32();
            Error_02_10_Count = bRead.ReadInt32();
            Error_02_11_Count = bRead.ReadInt32();
            Error_02_12_Count = bRead.ReadInt32();
            Error_02_13_Count = bRead.ReadInt32();
            Error_02_14_Count = bRead.ReadInt32();
            Error_02_15_Count = bRead.ReadInt32();

            // 에러 UI, 작업 종류별 에러타입을 위한 데이터 구조체 선언 
            Error_Ratio_By_Job_Status_PieChart_Total_Error_Count = bRead.ReadInt32();
            Error_Ratio_By_Job_Status_PieChart_Partially_Completed_Count = bRead.ReadInt32();
            Error_Ratio_By_Job_Status_PieChart_Suspended_Error_Count = bRead.ReadInt32();
            Error_Ratio_By_Job_Status_PieChart_Failed_Error_Count = bRead.ReadInt32();
            Error_Ratio_By_Job_Status_PieChart_Canceled_Error_Count = bRead.ReadInt32();

            // 스케줄 별 개수 표시 
            Schedule_testsc1_Count = bRead.ReadInt32();
            Schedule_testsc2_Count = bRead.ReadInt32();
            Schedule_testsc3_Count = bRead.ReadInt32();
            Schedule_testsc4_Count = bRead.ReadInt32();

            // 파일 총 개수 
            Total_Files_Count = bRead.ReadInt32();

            // 일별 파일 사이즈 (2022-03-24 추가)
            Total_File_Size_LineChart_2022_02_08_Count = bRead.ReadInt32();
            Total_File_Size_LineChart_2022_02_09_Count = bRead.ReadInt32();
            Total_File_Size_LineChart_2022_02_10_Count = bRead.ReadInt32();
            Total_File_Size_LineChart_2022_02_11_Count = bRead.ReadInt32();
            Total_File_Size_LineChart_2022_02_12_Count = bRead.ReadInt32();
            Total_File_Size_LineChart_2022_02_13_Count = bRead.ReadInt32();
            Total_File_Size_LineChart_2022_02_14_Count = bRead.ReadInt32();
            Total_File_Size_LineChart_2022_02_15_Count = bRead.ReadInt32();

            // 일별 저장 사이즈 (2022-03-24 추가)
            Total_Write_Size_LineChart_2022_02_08_Count = bRead.ReadInt32();
            Total_Write_Size_LineChart_2022_02_09_Count = bRead.ReadInt32();
            Total_Write_Size_LineChart_2022_02_10_Count = bRead.ReadInt32();
            Total_Write_Size_LineChart_2022_02_11_Count = bRead.ReadInt32();
            Total_Write_Size_LineChart_2022_02_12_Count = bRead.ReadInt32();
            Total_Write_Size_LineChart_2022_02_13_Count = bRead.ReadInt32();
            Total_Write_Size_LineChart_2022_02_14_Count = bRead.ReadInt32();
            Total_Write_Size_LineChart_2022_02_15_Count = bRead.ReadInt32();

            // 일별 전송 사이즈 (2022-03-24 추가)
            Total_Data_Transferred_LineChart_2022_02_08_Count = bRead.ReadInt32();
            Total_Data_Transferred_LineChart_2022_02_09_Count = bRead.ReadInt32();
            Total_Data_Transferred_LineChart_2022_02_10_Count = bRead.ReadInt32();
            Total_Data_Transferred_LineChart_2022_02_11_Count = bRead.ReadInt32();
            Total_Data_Transferred_LineChart_2022_02_12_Count = bRead.ReadInt32();
            Total_Data_Transferred_LineChart_2022_02_13_Count = bRead.ReadInt32();
            Total_Data_Transferred_LineChart_2022_02_14_Count = bRead.ReadInt32();
            Total_Data_Transferred_LineChart_2022_02_15_Count = bRead.ReadInt32();
        }
    }
}
