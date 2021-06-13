namespace Windows_Product_Key_Finder
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.find_txt = new System.Windows.Forms.Label();
            this.windows_verison = new System.Windows.Forms.Label();
            this.CSD_version = new System.Windows.Forms.Label();
            this.Install_Date_txt = new System.Windows.Forms.Label();
            this.windows_Caption_txt = new System.Windows.Forms.Label();
            this.info1_txt = new System.Windows.Forms.Label();
            this.Registered_User_txt = new System.Windows.Forms.Label();
            this.Windows_serial_txt = new System.Windows.Forms.Label();
            this.Windows_Organization_txt = new System.Windows.Forms.Label();
            this.Close_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 0;
            // 
            // find_txt
            // 
            this.find_txt.AutoSize = true;
            this.find_txt.BackColor = System.Drawing.Color.Transparent;
            this.find_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_txt.ForeColor = System.Drawing.Color.Black;
            this.find_txt.Location = new System.Drawing.Point(146, 176);
            this.find_txt.Name = "find_txt";
            this.find_txt.Size = new System.Drawing.Size(48, 13);
            this.find_txt.TabIndex = 1;
            this.find_txt.Text = "Find Key";
            this.find_txt.Click += new System.EventHandler(this.find_txt_Click);
            // 
            // windows_verison
            // 
            this.windows_verison.AutoSize = true;
            this.windows_verison.BackColor = System.Drawing.Color.Transparent;
            this.windows_verison.ForeColor = System.Drawing.Color.White;
            this.windows_verison.Location = new System.Drawing.Point(24, 36);
            this.windows_verison.Name = "windows_verison";
            this.windows_verison.Size = new System.Drawing.Size(45, 13);
            this.windows_verison.TabIndex = 2;
            this.windows_verison.Text = "Version:";
            // 
            // CSD_version
            // 
            this.CSD_version.AutoSize = true;
            this.CSD_version.BackColor = System.Drawing.Color.Transparent;
            this.CSD_version.ForeColor = System.Drawing.Color.White;
            this.CSD_version.Location = new System.Drawing.Point(24, 49);
            this.CSD_version.Name = "CSD_version";
            this.CSD_version.Size = new System.Drawing.Size(70, 13);
            this.CSD_version.TabIndex = 3;
            this.CSD_version.Text = "CSD Version:";
            // 
            // Install_Date_txt
            // 
            this.Install_Date_txt.AutoSize = true;
            this.Install_Date_txt.BackColor = System.Drawing.Color.Transparent;
            this.Install_Date_txt.ForeColor = System.Drawing.Color.White;
            this.Install_Date_txt.Location = new System.Drawing.Point(24, 62);
            this.Install_Date_txt.Name = "Install_Date_txt";
            this.Install_Date_txt.Size = new System.Drawing.Size(66, 13);
            this.Install_Date_txt.TabIndex = 4;
            this.Install_Date_txt.Text = "Install Date :";
            // 
            // windows_Caption_txt
            // 
            this.windows_Caption_txt.AutoSize = true;
            this.windows_Caption_txt.BackColor = System.Drawing.Color.Transparent;
            this.windows_Caption_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows_Caption_txt.ForeColor = System.Drawing.Color.White;
            this.windows_Caption_txt.Location = new System.Drawing.Point(24, 23);
            this.windows_Caption_txt.Name = "windows_Caption_txt";
            this.windows_Caption_txt.Size = new System.Drawing.Size(58, 13);
            this.windows_Caption_txt.TabIndex = 5;
            this.windows_Caption_txt.Text = "Windows";
            // 
            // info1_txt
            // 
            this.info1_txt.AutoSize = true;
            this.info1_txt.BackColor = System.Drawing.Color.Transparent;
            this.info1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1_txt.ForeColor = System.Drawing.Color.White;
            this.info1_txt.Location = new System.Drawing.Point(24, 94);
            this.info1_txt.Name = "info1_txt";
            this.info1_txt.Size = new System.Drawing.Size(146, 13);
            this.info1_txt.TabIndex = 6;
            this.info1_txt.Text = "Windows Is Licensed to:";
            // 
            // Registered_User_txt
            // 
            this.Registered_User_txt.AutoSize = true;
            this.Registered_User_txt.BackColor = System.Drawing.Color.Transparent;
            this.Registered_User_txt.ForeColor = System.Drawing.Color.White;
            this.Registered_User_txt.Location = new System.Drawing.Point(24, 108);
            this.Registered_User_txt.Name = "Registered_User_txt";
            this.Registered_User_txt.Size = new System.Drawing.Size(83, 13);
            this.Registered_User_txt.TabIndex = 7;
            this.Registered_User_txt.Text = "Registered User";
            // 
            // Windows_serial_txt
            // 
            this.Windows_serial_txt.AutoSize = true;
            this.Windows_serial_txt.BackColor = System.Drawing.Color.Transparent;
            this.Windows_serial_txt.ForeColor = System.Drawing.Color.White;
            this.Windows_serial_txt.Location = new System.Drawing.Point(24, 75);
            this.Windows_serial_txt.Name = "Windows_serial_txt";
            this.Windows_serial_txt.Size = new System.Drawing.Size(78, 13);
            this.Windows_serial_txt.TabIndex = 8;
            this.Windows_serial_txt.Text = "Windows serial";
            // 
            // Windows_Organization_txt
            // 
            this.Windows_Organization_txt.AutoSize = true;
            this.Windows_Organization_txt.BackColor = System.Drawing.Color.Transparent;
            this.Windows_Organization_txt.ForeColor = System.Drawing.Color.White;
            this.Windows_Organization_txt.Location = new System.Drawing.Point(24, 121);
            this.Windows_Organization_txt.Name = "Windows_Organization_txt";
            this.Windows_Organization_txt.Size = new System.Drawing.Size(69, 13);
            this.Windows_Organization_txt.TabIndex = 9;
            this.Windows_Organization_txt.Text = "Organization:";
            // 
            // Close_txt
            // 
            this.Close_txt.AutoSize = true;
            this.Close_txt.BackColor = System.Drawing.Color.Transparent;
            this.Close_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_txt.Location = new System.Drawing.Point(307, 0);
            this.Close_txt.Name = "Close_txt";
            this.Close_txt.Size = new System.Drawing.Size(12, 13);
            this.Close_txt.TabIndex = 10;
            this.Close_txt.Text = "x";
            this.Close_txt.Click += new System.EventHandler(this.Close_txt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(296, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Product_Key_Finder.Properties.Resources.bg9;
            this.ClientSize = new System.Drawing.Size(340, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_txt);
            this.Controls.Add(this.Windows_Organization_txt);
            this.Controls.Add(this.Windows_serial_txt);
            this.Controls.Add(this.Registered_User_txt);
            this.Controls.Add(this.info1_txt);
            this.Controls.Add(this.windows_Caption_txt);
            this.Controls.Add(this.Install_Date_txt);
            this.Controls.Add(this.CSD_version);
            this.Controls.Add(this.windows_verison);
            this.Controls.Add(this.find_txt);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Product Key Finder";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label find_txt;
        private System.Windows.Forms.Label windows_verison;
        private System.Windows.Forms.Label CSD_version;
        private System.Windows.Forms.Label Install_Date_txt;
        private System.Windows.Forms.Label windows_Caption_txt;
        private System.Windows.Forms.Label info1_txt;
        private System.Windows.Forms.Label Registered_User_txt;
        private System.Windows.Forms.Label Windows_serial_txt;
        private System.Windows.Forms.Label Windows_Organization_txt;
        private System.Windows.Forms.Label Close_txt;
        private System.Windows.Forms.Label label1;
    }
}

