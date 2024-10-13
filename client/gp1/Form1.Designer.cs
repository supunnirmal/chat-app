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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ChatScreen = new System.Windows.Forms.ListBox();
            this.SendButton = new MetroFramework.Controls.MetroButton();
            this.lblConnect = new MetroFramework.Controls.MetroLabel();
            this.delBtn = new MetroFramework.Controls.MetroButton();
            this.repBtn = new MetroFramework.Controls.MetroButton();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(22, 297);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(315, 34);
            this.txtMessage.TabIndex = 0;

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
            this.ChatScreen.Location = new System.Drawing.Point(23, 58);
            this.ChatScreen.Name = "ChatScreen";
            this.ChatScreen.Size = new System.Drawing.Size(424, 225);
            this.ChatScreen.TabIndex = 6;
            this.ChatScreen.TabStop = false;
            this.ChatScreen.SelectedIndexChanged += new System.EventHandler(this.ChatScreen_SelectedIndexChanged);
            this.ChatScreen.DoubleClick += new System.EventHandler(this.ChatScreen_DoubleClick);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(355, 297);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(91, 34);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Send";
            this.SendButton.UseSelectable = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click_1);
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Location = new System.Drawing.Point(36, 27);
            this.lblConnect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(0, 0);
            this.lblConnect.TabIndex = 8;
            // 
            // delBtn
            // 
            this.delBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delBtn.BackgroundImage")));
            this.delBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delBtn.Location = new System.Drawing.Point(421, 27);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(25, 25);
            this.delBtn.TabIndex = 13;
            this.delBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delBtn.UseSelectable = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // repBtn
            // 
            this.repBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("repBtn.BackgroundImage")));
            this.repBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.repBtn.Location = new System.Drawing.Point(390, 27);
            this.repBtn.Name = "repBtn";
            this.repBtn.Size = new System.Drawing.Size(25, 25);
            this.repBtn.TabIndex = 14;
            this.repBtn.UseSelectable = true;
            this.repBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(359, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(25, 25);
            this.backBtn.TabIndex = 15;
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 364);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.repBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.lblConnect);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ChatScreen);
            this.Controls.Add(this.txtMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ListBox ChatScreen;
        private MetroFramework.Controls.MetroButton SendButton;
        private MetroFramework.Controls.MetroLabel lblConnect;
        private MetroFramework.Controls.MetroButton delBtn;
        private MetroFramework.Controls.MetroButton repBtn;
        private MetroFramework.Controls.MetroButton backBtn;
    }
}

