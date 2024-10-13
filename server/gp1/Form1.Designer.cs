namespace gp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Message = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ChatScreen = new System.Windows.Forms.ListBox();
            this.SendButton = new MetroFramework.Controls.MetroButton();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.repBtn = new MetroFramework.Controls.MetroButton();
            this.delBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(32, 335);
            this.Message.Margin = new System.Windows.Forms.Padding(2);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(315, 38);
            this.Message.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // ChatScreen
            // 
            this.ChatScreen.FormattingEnabled = true;
            this.ChatScreen.Location = new System.Drawing.Point(32, 63);
            this.ChatScreen.Name = "ChatScreen";
            this.ChatScreen.Size = new System.Drawing.Size(405, 264);
            this.ChatScreen.TabIndex = 6;
            this.ChatScreen.TabStop = false;
            this.ChatScreen.DoubleClick += new System.EventHandler(this.ChatScreen_DoubleClick);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(350, 335);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(87, 38);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Send";
            this.SendButton.UseSelectable = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click_1);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(350, 21);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(25, 25);
            this.backBtn.TabIndex = 18;
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // repBtn
            // 
            this.repBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("repBtn.BackgroundImage")));
            this.repBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.repBtn.Location = new System.Drawing.Point(381, 21);
            this.repBtn.Name = "repBtn";
            this.repBtn.Size = new System.Drawing.Size(25, 25);
            this.repBtn.TabIndex = 17;
            this.repBtn.UseSelectable = true;
            this.repBtn.Click += new System.EventHandler(this.repBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delBtn.BackgroundImage")));
            this.delBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delBtn.Location = new System.Drawing.Point(412, 21);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(25, 25);
            this.delBtn.TabIndex = 16;
            this.delBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delBtn.UseSelectable = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(32, 21);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(103, 25);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Chat History";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 392);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.repBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ChatScreen);
            this.Controls.Add(this.Message);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Message;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ListBox ChatScreen;
        private MetroFramework.Controls.MetroButton SendButton;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroButton repBtn;
        private MetroFramework.Controls.MetroButton delBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

