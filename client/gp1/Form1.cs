using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace gp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string TextToSend;

        public string clientname;
        public string sendmsg;

        public string serverIP;
        public int  serverPort;

        public Form1(string s,int p)
        {
            InitializeComponent();
            serverIP= s;
            serverPort = p;
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    //Get the recieve message from server
                    receive = STR.ReadLine();
                    this.ChatScreen.Invoke(new MethodInvoker(delegate ()
                    {

                        ChatScreen.Items.Add( receive);
                    }));
                    receive = "";

                    writefile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine (sendmsg);
                this.ChatScreen.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreen.Items.Add("\t" + "You : " + TextToSend);
                }));

                writefile();
            } 
            else
            {
                MessageBox.Show("Sending failled");
            }
            backgroundWorker2.CancelAsync();
        }


        private void SendButton_Click_1(object sender, EventArgs e)
        {
            
            if (txtMessage.Text != "")
            {
                TextToSend = txtMessage.Text;
                sendmsg = clientname+" : " + TextToSend;
                backgroundWorker2.RunWorkerAsync();

            }
            
            txtMessage.Text = "";
            ChatScreen.TopIndex = ChatScreen.Items.Count - 1;
        }


        private void connect()
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(serverIP), int.Parse(serverPort.ToString()));
            try
            {
                client.Connect(IpEnd);
                if (client.Connected)
                {
                    lblConnect.Text="connected to server";
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            connect();

            if (File.Exists(clientname + ".txt"))
            {
                using (var txtentry = new StreamReader(clientname + ".txt"))

                {
                    string entry;
                    while ((entry = txtentry.ReadLine()) != null)
                    {
                        ChatScreen.Items.Add(entry);
                    }
                    txtentry.Close();
                }
            }
            else
            {
                using (FileStream fs = File.Create(clientname + ".txt"))
                    fs.Close();
            }
        }

        void writefile()
        {
            File.Delete(clientname + ".txt");
            using (FileStream fs = File.Create(clientname+".txt"))
                fs.Close();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(clientname+".txt", true))
            {
                int x = 0;
                while (x != ChatScreen.Items.Count)
                {
                    file.WriteLine(ChatScreen.Items[x]);
                    x++;
                }
                file.Close();
            }
        }

        private void ChatScreen_DoubleClick(object sender, EventArgs e)
        {
            delBtn.Visible = true;
            repBtn.Visible = true;
            backBtn.Visible = true;
            SendButton.Enabled = false;
            txtMessage.Enabled = false;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            txtMessage.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ChatScreen.Items.RemoveAt(ChatScreen.SelectedIndex);
            writefile();
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            txtMessage.Enabled = true;
        }

        private void btnReply_Click(object sender, EventArgs e)
        { 
            txtMessage.Text = "<<"+ ChatScreen.SelectedItem.ToString().Trim() + ">>"+"\n";
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            txtMessage.Enabled = true;
        }

        private void ChatScreen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChatScreen.Items.RemoveAt(ChatScreen.SelectedIndex);
                writefile();
                delBtn.Visible = false;
                repBtn.Visible = false;
                backBtn.Visible = false;
                SendButton.Enabled = true;
                txtMessage.Enabled = true;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            txtMessage.Enabled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "<< " + ChatScreen.SelectedItem.ToString().Trim() + " >>\n";
  
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            txtMessage.Enabled = true;
        }
    }
}
