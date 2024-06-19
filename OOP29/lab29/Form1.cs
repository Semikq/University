using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace lab29
{
    public partial class Form1 : Form
    {
        private const int TTL = 20;
        private bool _isThreadAlive = false;
        private const int REMOTEPORT = 8001;
        private string _userName;
        private const string HOST = "235.5.5.1";
        private UdpClient _client;
        private const int LOCALPORT = 8001;
        private IPAddress _groupAddress;

        public Form1()
        {
            InitializeComponent();
            LoginButton.Enabled = true;
            LogoutButton.Enabled = false;
            SendButton.Enabled = false;
            MessageTextBox.ReadOnly = true;
            _groupAddress = IPAddress.Parse(HOST);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            _userName = UserNameBox.Text;
            UserNameBox.ReadOnly = true;
            try
            {
                _client = new UdpClient(LOCALPORT);
                _client.JoinMulticastGroup(_groupAddress, TTL);
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();
                string message = _userName + " увійшов до чату";
                byte[] data = Encoding.Unicode.GetBytes(message);
                _client.Send(data, data.Length, HOST, REMOTEPORT);
                LoginButton.Enabled = false;
                LogoutButton.Enabled = true;
                SendButton.Enabled = true;
            }
            catch (Exception) { }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", _userName, MessagesBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                _client.Send(data, data.Length, HOST, REMOTEPORT);
            }
            catch (Exception) { }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }

        private void ReceiveMessages()
        {
            _isThreadAlive = true;
            try
            {
                while (_isThreadAlive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = _client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        MessageTextBox.Text = time + " " + message + "\r\n"
                        + MessageTextBox.Text;
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!_isThreadAlive)
                    return;

                throw;
            }
            catch (Exception) { }
        }

        private void ExitChat()
        {
            string message = _userName + " покидає чат";
            byte[] data = Encoding.Unicode.GetBytes(message);
            _client.Send(data, data.Length, HOST, REMOTEPORT);
            _client.DropMulticastGroup(_groupAddress);
            _isThreadAlive = false;
            _client.Close();
            LoginButton.Enabled = true;
            LogoutButton.Enabled = false;
            SendButton.Enabled = false;
            UserNameBox.ReadOnly = false;
            UserNameBox.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isThreadAlive) 
                ExitChat();
        }
    }
}
