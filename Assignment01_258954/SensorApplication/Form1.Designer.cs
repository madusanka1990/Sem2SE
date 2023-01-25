namespace SensorApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSamplingTime = new System.Windows.Forms.TextBox();
            this.btnSampling = new System.Windows.Forms.Button();
            this.Logging = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoggingTime = new System.Windows.Forms.TextBox();
            this.btnLogging = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDg1 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAn2 = new System.Windows.Forms.TextBox();
            this.txtAn1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSampling = new System.Windows.Forms.Timer(this.components);
            this.radioSingleSam = new System.Windows.Forms.RadioButton();
            this.radioContSam = new System.Windows.Forms.RadioButton();
            this.txt_rec_time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timerLogging = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtNoRec = new System.Windows.Forms.TextBox();
            this.radioContLog = new System.Windows.Forms.RadioButton();
            this.radioSingLog = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.Logging.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioContSam);
            this.groupBox1.Controls.Add(this.radioSingleSam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSamplingTime);
            this.groupBox1.Controls.Add(this.btnSampling);
            this.groupBox1.Location = new System.Drawing.Point(49, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Next Sampling Time : ";
            // 
            // txtSamplingTime
            // 
            this.txtSamplingTime.Location = new System.Drawing.Point(179, 45);
            this.txtSamplingTime.Name = "txtSamplingTime";
            this.txtSamplingTime.ReadOnly = true;
            this.txtSamplingTime.Size = new System.Drawing.Size(137, 22);
            this.txtSamplingTime.TabIndex = 1;
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(31, 112);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(109, 37);
            this.btnSampling.TabIndex = 0;
            this.btnSampling.Text = "Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            this.btnSampling.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // Logging
            // 
            this.Logging.Controls.Add(this.radioContLog);
            this.Logging.Controls.Add(this.radioSingLog);
            this.Logging.Controls.Add(this.txtNoRec);
            this.Logging.Controls.Add(this.txtFileName);
            this.Logging.Controls.Add(this.label9);
            this.Logging.Controls.Add(this.label8);
            this.Logging.Controls.Add(this.label2);
            this.Logging.Controls.Add(this.txtLoggingTime);
            this.Logging.Controls.Add(this.btnLogging);
            this.Logging.Location = new System.Drawing.Point(49, 267);
            this.Logging.Name = "Logging";
            this.Logging.Size = new System.Drawing.Size(363, 265);
            this.Logging.TabIndex = 1;
            this.Logging.TabStop = false;
            this.Logging.Text = "Logging";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Next Logging Time : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLoggingTime
            // 
            this.txtLoggingTime.Location = new System.Drawing.Point(179, 45);
            this.txtLoggingTime.Name = "txtLoggingTime";
            this.txtLoggingTime.ReadOnly = true;
            this.txtLoggingTime.Size = new System.Drawing.Size(137, 22);
            this.txtLoggingTime.TabIndex = 1;
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(31, 112);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(109, 37);
            this.btnLogging.TabIndex = 0;
            this.btnLogging.Text = "Logging to file";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_rec_time);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDg1);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAn2);
            this.groupBox2.Controls.Add(this.txtAn1);
            this.groupBox2.Location = new System.Drawing.Point(484, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Values";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Moving average filterted value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Moving average filterted value";
            // 
            // txtDg1
            // 
            this.txtDg1.Location = new System.Drawing.Point(149, 141);
            this.txtDg1.Name = "txtDg1";
            this.txtDg1.ReadOnly = true;
            this.txtDg1.Size = new System.Drawing.Size(107, 22);
            this.txtDg1.TabIndex = 6;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(15, 144);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(97, 16);
            this.label44.TabIndex = 5;
            this.label44.Text = "Digital Sensor :";
            this.label44.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Analog Sensor 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Analog Sensor 1 :";
            // 
            // txtAn2
            // 
            this.txtAn2.Location = new System.Drawing.Point(149, 92);
            this.txtAn2.Name = "txtAn2";
            this.txtAn2.ReadOnly = true;
            this.txtAn2.Size = new System.Drawing.Size(107, 22);
            this.txtAn2.TabIndex = 1;
            // 
            // txtAn1
            // 
            this.txtAn1.Location = new System.Drawing.Point(149, 45);
            this.txtAn1.Name = "txtAn1";
            this.txtAn1.ReadOnly = true;
            this.txtAn1.Size = new System.Drawing.Size(107, 22);
            this.txtAn1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // timerSampling
            // 
            this.timerSampling.Tick += new System.EventHandler(this.timerSampling_Tick);
            // 
            // radioSingleSam
            // 
            this.radioSingleSam.AutoSize = true;
            this.radioSingleSam.Checked = true;
            this.radioSingleSam.Location = new System.Drawing.Point(196, 112);
            this.radioSingleSam.Name = "radioSingleSam";
            this.radioSingleSam.Size = new System.Drawing.Size(126, 20);
            this.radioSingleSam.TabIndex = 3;
            this.radioSingleSam.TabStop = true;
            this.radioSingleSam.Text = "Single Sampling";
            this.radioSingleSam.UseVisualStyleBackColor = true;
            // 
            // radioContSam
            // 
            this.radioContSam.AutoSize = true;
            this.radioContSam.Location = new System.Drawing.Point(196, 143);
            this.radioContSam.Name = "radioContSam";
            this.radioContSam.Size = new System.Drawing.Size(150, 20);
            this.radioContSam.TabIndex = 4;
            this.radioContSam.Text = "Continious Sampling";
            this.radioContSam.UseVisualStyleBackColor = true;
            // 
            // txt_rec_time
            // 
            this.txt_rec_time.Location = new System.Drawing.Point(149, 188);
            this.txt_rec_time.Name = "txt_rec_time";
            this.txt_rec_time.ReadOnly = true;
            this.txt_rec_time.Size = new System.Drawing.Size(284, 22);
            this.txt_rec_time.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Recorded Time: ";
            // 
            // timerLogging
            // 
            this.timerLogging.Tick += new System.EventHandler(this.timerLogging_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "File Name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "No of Records : ";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(179, 191);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(137, 22);
            this.txtFileName.TabIndex = 5;
            // 
            // txtNoRec
            // 
            this.txtNoRec.Location = new System.Drawing.Point(179, 223);
            this.txtNoRec.Name = "txtNoRec";
            this.txtNoRec.ReadOnly = true;
            this.txtNoRec.Size = new System.Drawing.Size(137, 22);
            this.txtNoRec.TabIndex = 6;
            // 
            // radioContLog
            // 
            this.radioContLog.AutoSize = true;
            this.radioContLog.Location = new System.Drawing.Point(196, 144);
            this.radioContLog.Name = "radioContLog";
            this.radioContLog.Size = new System.Drawing.Size(142, 20);
            this.radioContLog.TabIndex = 6;
            this.radioContLog.Text = "Continious Logging";
            this.radioContLog.UseVisualStyleBackColor = true;
            // 
            // radioSingLog
            // 
            this.radioSingLog.AutoSize = true;
            this.radioSingLog.Checked = true;
            this.radioSingLog.Location = new System.Drawing.Point(196, 113);
            this.radioSingLog.Name = "radioSingLog";
            this.radioSingLog.Size = new System.Drawing.Size(118, 20);
            this.radioSingLog.TabIndex = 5;
            this.radioSingLog.TabStop = true;
            this.radioSingLog.Text = "Single Logging";
            this.radioSingLog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Logging);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Logging.ResumeLayout(false);
            this.Logging.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSamplingTime;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.GroupBox Logging;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoggingTime;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAn1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDg1;
        private System.Windows.Forms.Timer timerSampling;
        private System.Windows.Forms.RadioButton radioContSam;
        private System.Windows.Forms.RadioButton radioSingleSam;
        private System.Windows.Forms.TextBox txt_rec_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerLogging;
        private System.Windows.Forms.TextBox txtNoRec;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioContLog;
        private System.Windows.Forms.RadioButton radioSingLog;
    }
}

