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
using System.Net.Mail;

namespace gp1
{
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            /*When client log to the Form1, then login form will be hidden.
             After server close the Form1, then login form will be closed.*/
            Form1 log1 = new Form1(txtIP.Text.ToString(), Convert.ToInt32(txtPort.Text));
            log1.clientname = txtName.Text;
            log1.FormClosed += new FormClosedEventHandler(log1_formclose);
            log1.Show();
            this.Hide();

        }
        private void log1_formclose(object sender,FormClosedEventArgs arg)
        {
            this.Close();

        } 

        private void btnLog_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (txtName.Text != "")
            {
                if (txtPW.Text != "")
                {
                    if (IsValidEmail(txtEMail.Text) == true)
                    {
                        if (File.Exists("UserList.txt"))
                        {
                            using (var txtentry = new StreamReader("UserList.txt"))
                            {
                                string entry;

                                while ((entry = txtentry.ReadLine()) != null)
                                {

                                    string[] name = entry.Trim().Split('\t');

                                    if (name[0] == txtName.Text.Trim())
                                    {
                                        MessageBox.Show("UserName Aready Exists");
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
                                    file.WriteLine(txtName.Text + "\t" + txtPW.Text + "\t" + txtEMail.Text);
                                    file.Close();
                                    txtName.Text = "";
                                    txtPW.Text = "";
                                    metroButton2_Click(sender, e);
                                    metroButton2.Select();
                                }
                            }
                        }
                        else
                        {
                            using (FileStream fs = File.Create("UserList.txt"))
                                fs.Close();
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter("UserList.txt", true))
                            {
                                file.WriteLine(txtName.Text + "\t" + txtPW.Text + "\t" + txtEMail.Text);
                                file.Close();
                                txtName.Text = "";
                                txtPW.Text = "";
                                metroButton2_Click(sender, e);
                                metroButton2.Select();
                            }

                        }
                    
                
                }
                else
                {
                    MessageBox.Show("Invalid E mail", "Error");
                }
            }
            else
            {
                MessageBox.Show("Password can not be empty", "Error");
            }
            }
            else
            {
                MessageBox.Show("User name can not be empty", "Error");
            }
          }
            
        

        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (var txtentry = new StreamReader("UserList.txt"))
            {
                string entry;int x = 0;

                while ((entry = txtentry.ReadLine()) != null)
                {
                    
                    string[] name = entry.Trim().Split('\t');
                    
                        if (name[0] == txtName.Text.Trim())
                        {
                            if (name[1] == txtPW.Text.Trim())
                            {
                                metroButton1.Visible = false;
                                metroButton2.Visible = false;
                                metroLabel3.Visible = false;
                                metroLabel4.Visible = false;
                                txtName.Visible = false;
                                txtPW.Visible = false;
                                btnLogin.Visible = false;
                                btnSign.Visible = false;

                                metroLabel1.Visible = true;
                                metroLabel2.Visible = true;
                                txtPort.Visible = true;
                                txtIP.Visible = true;
                                btnConnect.Visible = true;

                                try
                                {
                                    string email = name[2].Trim();
                                    MailMessage mail = new MailMessage();
                                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                                    mail.From = new MailAddress("chatappvp@gmail.com");
                                    mail.To.Add(email);
                                    mail.Subject = "Security Alert!!!";
                                    mail.Body = "Someone has logged in to your account.. check whether is it you or not...";

                                    SmtpServer.Port = 587;
                                    SmtpServer.Credentials = new System.Net.NetworkCredential("chatappvp@gmail.com", "Chatapp123");
                                    SmtpServer.EnableSsl = true;

                                    SmtpServer.Send(mail);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }

                                break;

                            }
                            else
                            {
                            
                                MessageBox.Show("Invalid Password");
                                break;
                            }
                        }
                    x++;
                }

                if (x == File.ReadLines("UserList.txt").Count())
                {
                    MessageBox.Show("Invalid User Name");
                    txtPW.Text = "";
                    txtName.Text = "";
                }

                txtentry.Close();
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            txtEMail.Visible = true;
            lblEMail.Visible = true;
            btnSign.Visible = true;

            btnLogin.Visible = false;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txtEMail.Visible = false;
            lblEMail.Visible = false;
            btnSign.Visible = false;
            btnLogin.Visible = true;
        }

        //Check the validity of the E-Mail address
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
