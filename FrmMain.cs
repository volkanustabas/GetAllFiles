using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GetAllFiles
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        private void bw_run_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke((MethodInvoker) delegate { });

            var directory = tb_directory.Text.Trim();

            var allDirectoryAndFiles = Directory.GetFiles(directory, "*",
                SearchOption.AllDirectories);

            foreach (var file in allDirectoryAndFiles)
                //rtb_list.AppendText((file.Substring(directory.Length + 1) + Environment.NewLine));
                rtb_list.AppendText(file + Environment.NewLine);

            var lines = rtb_list.Lines;

            var sort = from s in lines
                orderby s
                select s;

            rtb_list.Lines = sort.ToArray();
        }

        private void bw_run_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tlp_main.Enabled = true;
            rtb_list.Text = Regex.Replace(rtb_list.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            lbl_count.Text = rtb_list.Lines.Length.ToString();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            if (tb_directory.Text != "")
            {
                if (bw_run.IsBusy != true)
                {
                    rtb_list.Clear();
                    bw_run.RunWorkerAsync();
                    tlp_main.Enabled = false;
                }
                else
                {
                    MessageBox.Show(@"Error", @"Info");
                }
            }
            else
            {
                MessageBox.Show(@"Directory must be full", @"");
            }
        }
    }
}