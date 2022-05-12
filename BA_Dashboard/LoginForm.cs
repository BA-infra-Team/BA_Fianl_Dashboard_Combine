using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BA_Dashboard
{
    public partial class LoginForm : Form
    {
        public static Socket ClientSocket;
        public static string message { get; set; }
        public static string responseData { get; set; }
        public static int rev { get; set; }
        public static byte[] Buffer { get; set; }
        public static byte[] data { get; set; }
        private Point point = new Point();        
        public LoginForm()
        {
            InitializeComponent();
            Pwd_textbox.PasswordChar = '*';
        }               

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string UserName = String.Empty;
            string Password = String.Empty;

            UserName = ID_textbox.Text;
            Password = Pwd_textbox.Text;


            IPAddress ipAddress = IPAddress.Parse("192.168.10.10");
            int port = 7756;
            IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, port);
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                ClientSocket.Connect(iPEndPoint);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return ;
            }


            // 버퍼 
            Buffer = new byte[1024];

            // 접속환영문구 수신
            rev = 0;
            responseData = String.Empty;
            rev = ClientSocket.Receive(Buffer);
            responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, rev);


            // 클라이언트측에서 서버에게 "접속완료" 문구보냄.
            string message = "Login";
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            ClientSocket.Send(data);

            // 버퍼 
            Buffer = new byte[1024];

            // 로그인 엔터 수신, "Login_Enter"
            rev = 0;
            rev = ClientSocket.Receive(Buffer);
            responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, rev);

            if (UserName == String.Empty || Password == String.Empty)
            {
                MessageBox.Show("아이디 또는 비밀번호를 입력하세요.");
                ClientSocket.Close();
            }

            else
            {
                // 클라이언트측에서 서버에게 "아이디" 정보 보냄.
                message = string.Empty;
                message = UserName;
                data = System.Text.Encoding.ASCII.GetBytes(message);
                ClientSocket.Send(data);

                // 아이디 맞는지 체크
                responseData = String.Empty;
                rev = 0;
                rev = ClientSocket.Receive(Buffer);
                responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, 10);

                if (responseData == "ID_Correct")
                {
                    // 클라이언트측에서 서버에게 "비밀번호" 정보 보냄.
                    // 메세지, 바이트 초기화 
                    message = string.Empty;
                    Array.Clear(data, 0, data.Length);

                    message = Password;
                    data = System.Text.Encoding.ASCII.GetBytes(message);
                    ClientSocket.Send(data);

                    // 메세지 받기
                    responseData = String.Empty;
                    rev = 0;
                    rev = ClientSocket.Receive(Buffer);
                    responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, 13);


                    if (responseData == "Login_Success")
                    {
                        //var MainDashBoard = new Form1();
                        //MainDashBoard.Show();
                        //ClientSocket.Close();

                        Form1 MainDashBoard = new Form1();
                        this.Hide();
                        MainDashBoard.ShowDialog();
                        this.Close();
                        ClientSocket.Close();
                    }
                    // 비밀번호 틀림 
                    else
                    {
                        MessageBox.Show("아이디 또는 비밀번호가 틀립니다.");
                        ClientSocket.Close();
                    }
                }
                // 아이디 틀림 
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 틀립니다.");
                    ClientSocket.Close();
                }
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        private void Pwd_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
