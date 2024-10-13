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
        string sendmsg;
        string portNo;
        string[] name;
        int x = 0;
        public Form1(string port)
        {
            portNo = port;
            InitializeComponent();  
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            while (client.Connected)
            {
                try
                {
                    //read the recieve message from client
                    receive = STR.ReadLine();
                    x++;
                    if (x == 1)
                    {
                        name = receive.Trim().Split(':');
                    }
 
                    this.ChatScreen.Invoke(new MethodInvoker(delegate ()
                    {

                        ChatScreen.Items.Add(receive);
                    }));
                    receive = "";
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
                //write the send message from server in the server chat screen
                STW.WriteLine (sendmsg);
                this.ChatScreen.Invoke(new MethodInvoker(delegate ()
                {
                  
                    ChatScreen.Items.Add("\t" + "You : "+ TextToSend);
                }));
            } 
            else
            {
                MessageBox.Show("Sending failled");
            }
            backgroundWorker2.CancelAsync();
        }


        private void SendButton_Click_1(object sender, EventArgs e)
        {
            if (Message.Text != "")
            {
                //send the message from server to client
                TextToSend = Message.Text;
                sendmsg = "Server" + " : " + TextToSend;
                backgroundWorker2.RunWorkerAsync();

            }
            Message.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            connect();
        }
        private void connect()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(portNo));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            Message.Text = "<<" + ChatScreen.SelectedItem.ToString() + ">>" + "\n";
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            Message.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ChatScreen.Items.RemoveAt(ChatScreen.SelectedIndex);
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            Message.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            Message.Enabled = true;
        }

        private void ChatScreen_DoubleClick(object sender, EventArgs e)
        {
            delBtn.Visible = true;
            repBtn.Visible = true;
            backBtn.Visible = true;
            SendButton.Enabled = false;
            Message.Enabled = false;
        }

        private void btnPrvChat_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(x>0)
            {
                if (File.Exists(name[0] + ".txt"))
                {
                    //save the chat history in the text file 
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(name[0] + ".txt", true))
                    {
                        int y = 0;
                        while (y != ChatScreen.Items.Count)
                        {
                            file.WriteLine(ChatScreen.Items[y]);
                            y++;
                        }
                        file.Close();
                    }
                }
                else
                {
                    using (FileStream fs = File.Create(name[0] + ".txt"))
                        fs.Close();
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(name[0] + ".txt", true))
                    {
                        int y = 0;
                        while (y != ChatScreen.Items.Count)
                        {
                            file.WriteLine(ChatScreen.Items[y]);
                            y++;
                        }
                        file.Close();
                    }
                }

                int x = 0;
                if (File.Exists("UserList.txt"))
                {
                    using (var txtentry = new StreamReader("UserList.txt"))
                    {
                        string entry;

                        while ((entry = txtentry.ReadLine()) != null)
                        {
                            if (name[0].Trim() == entry.Trim())
                            {
                                break;
                            }
                            x++;
                        }
                        txtentry.Close();
                    }
                    if (x == File.ReadLines("UserList.txt").Count())
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter("UserList.txt", true))
                        {
                            file.WriteLine(name[0].Trim());
                            file.Close();
                        }
                    }
                }
                else
                {
                    using (FileStream fs = File.Create("UserList.txt"))
                        fs.Close();
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter("UserList.txt", true))
                    {
                        file.WriteLine(name[0].Trim());
                        file.Close();
                    }
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            ChatScreen.Items.RemoveAt(ChatScreen.SelectedIndex);
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            Message.Enabled = true;
        }

        private void repBtn_Click(object sender, EventArgs e)
        {
            Message.Text = "<<" + ChatScreen.SelectedItem.ToString() + ">>" + "\n";
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false; ;
            SendButton.Enabled = true;
            Message.Enabled = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            delBtn.Visible = false;
            repBtn.Visible = false;
            backBtn.Visible = false;
            SendButton.Enabled = true;
            Message.Enabled = true;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

    }
}
