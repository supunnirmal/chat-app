namespace gp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblPass = new MetroFramework.Controls.MetroLabel();
            this.txtPW = new MetroFramework.Controls.MetroTextBox();
            this.btnLog = new MetroFramework.Controls.MetroButton();
            this.lblPort = new MetroFramework.Controls.MetroLabel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.lblIP = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnChange = new MetroFramework.Controls.MetroButton();
            this.txtOldPass = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.lblOldPass = new MetroFramework.Controls.MetroLabel();
            this.lblNewPass = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(213, 85);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(63, 19);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password";
            // 
            // txtPW
            // 
            // 
            // 
            // 
            this.txtPW.CustomButton.Image = null;
            this.txtPW.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtPW.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPW.CustomButton.Name = "";
            this.txtPW.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPW.CustomButton.TabIndex = 1;
            this.txtPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPW.CustomButton.UseSelectable = true;
            this.txtPW.CustomButton.Visible = false;
            this.txtPW.Lines = new string[0];
            this.txtPW.Location = new System.Drawing.Point(310, 86);
            this.txtPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPW.MaxLength = 32767;
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPW.SelectedText = "";
            this.txtPW.SelectionLength = 0;
            this.txtPW.SelectionStart = 0;
            this.txtPW.ShortcutsEnabled = true;
            this.txtPW.Size = new System.Drawing.Size(111, 19);
            this.txtPW.TabIndex = 1;
            this.txtPW.UseSelectable = true;
            this.txtPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLog
            // 
            this.btnLog.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnLog.Location = new System.Drawing.Point(234, 178);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(170, 33);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Initialize the connection";
            this.btnLog.UseCustomBackColor = true;
            this.btnLog.UseSelectable = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(213, 126);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 19);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtPort.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(310, 126);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(111, 19);
            this.txtPort.TabIndex = 6;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(225, 224);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 0);
            this.lblIP.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(33, 237);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Change Password";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(234, 178);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(82, 33);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Confirm";
            this.btnChange.UseCustomBackColor = true;
            this.btnChange.UseSelectable = true;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtOldPass
            // 
            // 
            // 
            // 
            this.txtOldPass.CustomButton.Image = null;
            this.txtOldPass.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtOldPass.CustomButton.Name = "";
            this.txtOldPass.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtOldPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPass.CustomButton.TabIndex = 1;
            this.txtOldPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPass.CustomButton.UseSelectable = true;
            this.txtOldPass.CustomButton.Visible = false;
            this.txtOldPass.Lines = new string[0];
            this.txtOldPass.Location = new System.Drawing.Point(310, 86);
            this.txtOldPass.MaxLength = 32767;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.SelectionLength = 0;
            this.txtOldPass.SelectionStart = 0;
            this.txtOldPass.ShortcutsEnabled = true;
            this.txtOldPass.Size = new System.Drawing.Size(111, 19);
            this.txtOldPass.TabIndex = 11;
            this.txtOldPass.UseSelectable = true;
            this.txtOldPass.Visible = false;
            this.txtOldPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(310, 126);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(111, 19);
            this.txtNewPass.TabIndex = 12;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.Visible = false;
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(213, 85);
            this.lblOldPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(89, 19);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Old Password";
            this.lblOldPass.Visible = false;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(213, 126);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(93, 19);
            this.lblNewPass.TabIndex = 0;
            this.lblNewPass.Text = "New Password";
            this.lblNewPass.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(322, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 282);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.lblPass);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Server Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblPass;
        private MetroFramework.Controls.MetroTextBox txtPW;
        private MetroFramework.Controls.MetroButton btnLog;
        private MetroFramework.Controls.MetroLabel lblPort;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroLabel lblIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnChange;
        private MetroFramework.Controls.MetroTextBox txtOldPass;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
        private MetroFramework.Controls.MetroLabel lblOldPass;
        private MetroFramework.Controls.MetroLabel lblNewPass;
        private MetroFramework.Controls.MetroButton btnCancel;
    }
}