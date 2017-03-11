using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InternetDiagnose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String PathLoc = "";
        Process p = new Process();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 285;
            this.Height = 325;
            label_process_status.Text = "";
            textBox_save_loc.ReadOnly = true;
            textBox_save_loc.Text = Environment.CurrentDirectory;
            PathLoc = Environment.CurrentDirectory;
        }

        public void ExecuteCommand(String command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = command;
            p.StartInfo = startInfo;
            p.Start();
        }

        private void button_start_ping_Click(object sender, EventArgs e)
        {
            String cmd = "";
            String address = textBox_site_address.Text;
            String filename = textBox_output_filename.Text;

            cmd = @"/c ping " + address + " -t >" + PathLoc + "/" + filename+".txt";
            ExecuteCommand(cmd);
        }

        private void button_folder_browser_Click(object sender, EventArgs e)
        {
            var path = "";
            DialogResult r = folderBrowserDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            PathLoc = path;
            textBox_save_loc.Text = PathLoc;
        }

        private void textBox_save_loc_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox_save_loc, textBox_save_loc.Text);
        }

        private void button_stop_process_Click(object sender, EventArgs e)
        {
            try
            {
                p.Kill();
                p.Close();
            }
            catch (Exception) { label_process_status.Text = "Error!"; }
        }
    }
}
