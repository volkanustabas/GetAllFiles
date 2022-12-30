namespace GetAllFiles
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn_run = new System.Windows.Forms.Button();
            this.rtb_list = new System.Windows.Forms.RichTextBox();
            this.tb_directory = new System.Windows.Forms.TextBox();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_count = new System.Windows.Forms.Label();
            this.bw_run = new System.ComponentModel.BackgroundWorker();
            this.tlp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.Location = new System.Drawing.Point(8, 48);
            this.btn_run.MinimumSize = new System.Drawing.Size(0, 30);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(848, 30);
            this.btn_run.TabIndex = 0;
            this.btn_run.Text = "GO";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // rtb_list
            // 
            this.rtb_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_list.Location = new System.Drawing.Point(8, 88);
            this.rtb_list.Name = "rtb_list";
            this.rtb_list.Size = new System.Drawing.Size(848, 330);
            this.rtb_list.TabIndex = 1;
            this.rtb_list.Text = "";
            // 
            // tb_directory
            // 
            this.tb_directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_directory.Location = new System.Drawing.Point(8, 8);
            this.tb_directory.MinimumSize = new System.Drawing.Size(4, 30);
            this.tb_directory.Name = "tb_directory";
            this.tb_directory.Size = new System.Drawing.Size(848, 22);
            this.tb_directory.TabIndex = 2;
            this.tb_directory.Text = "F:\\_01_OS\\ISO";
            this.tb_directory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tb_directory, 0, 0);
            this.tlp_main.Controls.Add(this.rtb_list, 0, 2);
            this.tlp_main.Controls.Add(this.btn_run, 0, 1);
            this.tlp_main.Controls.Add(this.lbl_count, 0, 3);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_main.RowCount = 4;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_main.Size = new System.Drawing.Size(864, 456);
            this.tlp_main.TabIndex = 3;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_count.Location = new System.Drawing.Point(8, 421);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_count.Size = new System.Drawing.Size(848, 30);
            this.lbl_count.TabIndex = 3;
            this.lbl_count.Text = "-";
            // 
            // bw_run
            // 
            this.bw_run.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_run_DoWork);
            this.bw_run.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_run_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 456);
            this.Controls.Add(this.tlp_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(880, 495);
            this.Name = "FrmMain";
            this.Text = "GetAllFiles";
            this.tlp_main.ResumeLayout(false);
            this.tlp_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.RichTextBox rtb_list;
        private System.Windows.Forms.TextBox tb_directory;
        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.ComponentModel.BackgroundWorker bw_run;
        private System.Windows.Forms.Label lbl_count;
    }
}

