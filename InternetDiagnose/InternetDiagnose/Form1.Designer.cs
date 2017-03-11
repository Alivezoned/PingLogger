namespace InternetDiagnose
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_site_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_save_loc = new System.Windows.Forms.TextBox();
            this.button_folder_browser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_output_filename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_process_status = new System.Windows.Forms.Label();
            this.button_stop_process = new System.Windows.Forms.Button();
            this.button_start_ping = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_site_address
            // 
            this.textBox_site_address.Location = new System.Drawing.Point(9, 37);
            this.textBox_site_address.Name = "textBox_site_address";
            this.textBox_site_address.Size = new System.Drawing.Size(222, 20);
            this.textBox_site_address.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Website OR Server Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save Location";
            // 
            // textBox_save_loc
            // 
            this.textBox_save_loc.Location = new System.Drawing.Point(9, 143);
            this.textBox_save_loc.Name = "textBox_save_loc";
            this.textBox_save_loc.Size = new System.Drawing.Size(222, 20);
            this.textBox_save_loc.TabIndex = 2;
            this.textBox_save_loc.MouseHover += new System.EventHandler(this.textBox_save_loc_MouseHover);
            // 
            // button_folder_browser
            // 
            this.button_folder_browser.Location = new System.Drawing.Point(9, 170);
            this.button_folder_browser.Name = "button_folder_browser";
            this.button_folder_browser.Size = new System.Drawing.Size(75, 23);
            this.button_folder_browser.TabIndex = 4;
            this.button_folder_browser.Text = "Browse";
            this.button_folder_browser.UseVisualStyleBackColor = true;
            this.button_folder_browser.Click += new System.EventHandler(this.button_folder_browser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output File Name";
            // 
            // textBox_output_filename
            // 
            this.textBox_output_filename.Location = new System.Drawing.Point(9, 91);
            this.textBox_output_filename.Name = "textBox_output_filename";
            this.textBox_output_filename.Size = new System.Drawing.Size(222, 20);
            this.textBox_output_filename.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "alivezoned.com";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_process_status);
            this.groupBox1.Controls.Add(this.button_stop_process);
            this.groupBox1.Controls.Add(this.button_start_ping);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_site_address);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_output_filename);
            this.groupBox1.Controls.Add(this.textBox_save_loc);
            this.groupBox1.Controls.Add(this.button_folder_browser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 265);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ping";
            // 
            // label_process_status
            // 
            this.label_process_status.AutoSize = true;
            this.label_process_status.Location = new System.Drawing.Point(6, 208);
            this.label_process_status.Name = "label_process_status";
            this.label_process_status.Size = new System.Drawing.Size(35, 13);
            this.label_process_status.TabIndex = 10;
            this.label_process_status.Text = "label5";
            // 
            // button_stop_process
            // 
            this.button_stop_process.Location = new System.Drawing.Point(91, 198);
            this.button_stop_process.Name = "button_stop_process";
            this.button_stop_process.Size = new System.Drawing.Size(140, 23);
            this.button_stop_process.TabIndex = 9;
            this.button_stop_process.Text = "Stop Processes";
            this.button_stop_process.UseVisualStyleBackColor = true;
            this.button_stop_process.Click += new System.EventHandler(this.button_stop_process_Click);
            // 
            // button_start_ping
            // 
            this.button_start_ping.Location = new System.Drawing.Point(91, 169);
            this.button_start_ping.Name = "button_start_ping";
            this.button_start_ping.Size = new System.Drawing.Size(140, 23);
            this.button_start_ping.TabIndex = 8;
            this.button_start_ping.Text = "Start Ping Logging";
            this.button_start_ping.UseVisualStyleBackColor = true;
            this.button_start_ping.Click += new System.EventHandler(this.button_start_ping_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 283);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Internet Diagnose";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox_site_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_save_loc;
        private System.Windows.Forms.Button button_folder_browser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_output_filename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_start_ping;
        private System.Windows.Forms.Label label_process_status;
        private System.Windows.Forms.Button button_stop_process;
    }
}

