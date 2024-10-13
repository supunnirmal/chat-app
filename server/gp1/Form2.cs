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
using Microsoft.VisualBasic;

namespace gp1
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();

            //Get the IP address of the server
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    lblIP.Text = "IP address : " + address.ToString();
                }
            }

        }
        
        string password;

        private void f1_formclose(object sender, FormClosedEventArgs arg)
        {
            this.Close();

        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtPW.Text==password)
            {
                if (Convert.ToInt32(txtPort.Text) > 1024 || Convert.ToInt32(txtPort.Text) > 65000)
                {
                    /*When server log to the Form1, then Form2 will be hidden.
                     After server close the Form1, then Form2 will be closed.*/ 
                    Form1 f1 = new Form1(txtPort.Text);
                    f1.FormClosed += new FormClosedEventHandler(f1_formclose);
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invlid Port No","Error");
                }
            }
                 
            else
            {
                MessageBox.Show("Invlid Password", "Error");
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Read the password from the text file
            using (System.IO.StreamReader file = new System.IO.StreamReader("password.txt", true))
                password = file.ReadLine();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            lblPass.Visible = false;
            lblPort.Visible = false;
            txtPW.Visible = false;
            txtPort.Visible = false;
            btnLog.Visible = false;
            metroButton1.Visible = false;


            lblNewPass.Visible = true;
            lblOldPass.Visible = true;
            txtNewPass.Visible = true;
            txtOldPass.Visible = true;
            btnCancel.Visible = true;
            btnChange.Visible = true;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblPass.Visible = true;
            lblPort.Visible = true;
            txtPW.Visible = true;
            txtPort.Visible = true;
            btnLog.Visible = true;
            metroButton1.Visible = true;

            lblNewPass.Visible = false;
            lblOldPass.Visible = false;
            txtNewPass.Visible = false;
            txtOldPass.Visible = false;
            btnCancel.Visible = false;
            btnChange.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            
            if(txtOldPass.Text==password)
            {
                if (txtNewPass.Text != "")
                {
                    password = txtNewPass.Text;
                    MessageBox.Show("Password updated sucessfully", "Error");
                    //Update the password in the text file
                    System.IO.File.WriteAllText("password.txt", password);
                    lblPass.Visible = true;
                    lblPort.Visible = true;
                    txtPW.Visible = true;
                    txtPort.Visible = true;
                    btnLog.Visible = true;
                    metroButton1.Visible = true;

                    lblNewPass.Visible = false;
                    lblOldPass.Visible = false;
                    txtNewPass.Visible = false;
                    txtOldPass.Visible = false;
                    btnCancel.Visible = false;
                    btnChange.Visible = false;
                }
                else
                {
                    MessageBox.Show("New Password can't be Empty", "Error");
                }
            }
            else
            {
                MessageBox.Show("Current Password is Incorrect", "Error");
            }
        }
    }
}
