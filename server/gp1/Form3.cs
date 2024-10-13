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

namespace gp1
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        //get the previous chat history of the server
        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists("UserList.txt"))
            {
                using (var txtentry = new StreamReader("UserList.txt"))
                {
                    string entry;

                    while ((entry = txtentry.ReadLine()) != null)
                    {
                        cmbList.Items.Add(entry.Trim());
                    }
                    txtentry.Close();
                }
            }
            else
            {
                MessageBox.Show("No previous Chat history...");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstChat.Items.Clear();
            using (var txtentry2 = new StreamReader(cmbList.SelectedItem.ToString().Trim() + " .txt"))
            {
                string entry;

                while ((entry = txtentry2.ReadLine()) != null)
                {
                    lstChat.Items.Add(entry);

                }
                txtentry2.Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            lstChat.Items.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            lstChat.Items.Clear();
            string deletedName = cmbList.Text;
            File.Delete(deletedName + " .txt");
            cmbList.Items.Clear();
            cmbList.ResetText();
            string s;
            int i = 0;
            List<string> allNames = new List<string>();

            using (var txtentry = new StreamReader("UserList.txt"))
            {
                
                while ((s=txtentry.ReadLine()) != null)
                {
                    allNames.Add(s);
                    i++;
                }

                txtentry.Close();

            }
            for (i = 0; i < allNames.Count(); i++)
            {
                if(allNames[i]==deletedName)
                {
                    allNames.RemoveAt(i);
                }

            }

            String[] newNames = new string[allNames.Count];
            int j = 0;
            foreach (String name in allNames)
            {
                newNames[j++] = name;
            }

            using (var txtentry = new StreamWriter("UserList.txt"))
            {
                for(i=0;i<allNames.Count();i++)
                {
                    txtentry.WriteLine(newNames[i]);
                }
                txtentry.Close();
            }


            using (var txtentry = new StreamReader("UserList.txt"))
            {
                string entry;
                while ((entry = txtentry.ReadLine()) != null)
                {
                    cmbList.Items.Add(entry.Trim());

                }
                txtentry.Close();
            }
        }
    }
}
        
