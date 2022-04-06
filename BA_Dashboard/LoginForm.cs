using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace BA_Dashboard
{
    public partial class LoginForm : Form
    {
        public static Socket ClientSocket;
        public LoginForm()
        {
            IPAddress ipAddress = IPAddress.Parse("192.168.0.12");
            int port = 7756;
            IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, port);
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            ClientSocket.Connect(iPEndPoint);

            // 버퍼 
            byte[] Buffer = new byte[1024];

            // 클라이언트측에서 서버에게 "접속완료" 문구보냄.
            string message = "Login";
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            ClientSocket.Send(data);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = ID_textbox.Text;
            string Password = Pwd_textbox.Text;
            string message;
            String responseData = String.Empty;
            // 버퍼 
            byte[] Buffer = new byte[1024];

            // 접속환영문구 수신
            responseData = String.Empty;
            int rev = ClientSocket.Receive(Buffer);
            responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, rev);

            // 클라이언트측에서 서버에게 "아이디" 정보 보냄.
            message = string.Empty;
            message = UserName;
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            ClientSocket.Send(data);

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
                var MainDashBoard = new Form1();
                MainDashBoard.Show();
                //Application.Run(new Form1());
                //this.Close();
            }
            else
            {
                MessageBox.Show("아이디,비밀번호가 틀립니다.");
            }

        }
    }
}
