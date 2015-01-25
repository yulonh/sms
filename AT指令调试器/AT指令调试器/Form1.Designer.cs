namespace 时讯网
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_recieve = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_send = new System.Windows.Forms.GroupBox();
            this.label_AT = new System.Windows.Forms.Label();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.groupBox_comSetup = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_comState = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_baud = new System.Windows.Forms.Label();
            this.label_com = new System.Windows.Forms.Label();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.groupBox_recieveSetup = new System.Windows.Forms.GroupBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox_sendSetup = new System.Windows.Forms.GroupBox();
            this.button_ctrlZ = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_recieve.SuspendLayout();
            this.groupBox_send.SuspendLayout();
            this.groupBox_comSetup.SuspendLayout();
            this.groupBox_recieveSetup.SuspendLayout();
            this.groupBox_sendSetup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_recieve
            // 
            this.groupBox_recieve.Controls.Add(this.richTextBox1);
            this.groupBox_recieve.Location = new System.Drawing.Point(184, 12);
            this.groupBox_recieve.Name = "groupBox_recieve";
            this.groupBox_recieve.Size = new System.Drawing.Size(293, 175);
            this.groupBox_recieve.TabIndex = 1;
            this.groupBox_recieve.TabStop = false;
            this.groupBox_recieve.Text = "接收区数据显示";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(285, 149);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox_send
            // 
            this.groupBox_send.Controls.Add(this.label_AT);
            this.groupBox_send.Controls.Add(this.textBox_send);
            this.groupBox_send.Location = new System.Drawing.Point(183, 195);
            this.groupBox_send.Name = "groupBox_send";
            this.groupBox_send.Size = new System.Drawing.Size(293, 55);
            this.groupBox_send.TabIndex = 1;
            this.groupBox_send.TabStop = false;
            this.groupBox_send.Text = "AT指令发送";
            // 
            // label_AT
            // 
            this.label_AT.AutoSize = true;
            this.label_AT.Location = new System.Drawing.Point(6, 32);
            this.label_AT.Name = "label_AT";
            this.label_AT.Size = new System.Drawing.Size(0, 12);
            this.label_AT.TabIndex = 1;
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(6, 20);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_send.Size = new System.Drawing.Size(281, 29);
            this.textBox_send.TabIndex = 0;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(89, 21);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // groupBox_comSetup
            // 
            this.groupBox_comSetup.Controls.Add(this.button2);
            this.groupBox_comSetup.Controls.Add(this.label_comState);
            this.groupBox_comSetup.Controls.Add(this.comboBox1);
            this.groupBox_comSetup.Controls.Add(this.label_baud);
            this.groupBox_comSetup.Controls.Add(this.label_com);
            this.groupBox_comSetup.Controls.Add(this.comboBox_com);
            this.groupBox_comSetup.Location = new System.Drawing.Point(8, 12);
            this.groupBox_comSetup.Name = "groupBox_comSetup";
            this.groupBox_comSetup.Size = new System.Drawing.Size(170, 134);
            this.groupBox_comSetup.TabIndex = 3;
            this.groupBox_comSetup.TabStop = false;
            this.groupBox_comSetup.Text = "设备连接";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "连接设备";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_comState
            // 
            this.label_comState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_comState.Location = new System.Drawing.Point(28, 71);
            this.label_comState.Name = "label_comState";
            this.label_comState.Size = new System.Drawing.Size(94, 25);
            this.label_comState.TabIndex = 5;
            this.label_comState.Text = "连接状态";
            this.label_comState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox1.Location = new System.Drawing.Point(72, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_baud
            // 
            this.label_baud.AutoSize = true;
            this.label_baud.Location = new System.Drawing.Point(6, 49);
            this.label_baud.Name = "label_baud";
            this.label_baud.Size = new System.Drawing.Size(53, 12);
            this.label_baud.TabIndex = 2;
            this.label_baud.Text = "波特率：";
            // 
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.Location = new System.Drawing.Point(6, 23);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(65, 12);
            this.label_com.TabIndex = 1;
            this.label_com.Text = "可选串口：";
            // 
            // comboBox_com
            // 
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Location = new System.Drawing.Point(72, 20);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(90, 20);
            this.comboBox_com.TabIndex = 0;
            this.comboBox_com.SelectedIndexChanged += new System.EventHandler(this.comboBox_com_SelectedIndexChanged);
            // 
            // groupBox_recieveSetup
            // 
            this.groupBox_recieveSetup.Controls.Add(this.button_stop);
            this.groupBox_recieveSetup.Controls.Add(this.button_clear);
            this.groupBox_recieveSetup.Location = new System.Drawing.Point(7, 163);
            this.groupBox_recieveSetup.Name = "groupBox_recieveSetup";
            this.groupBox_recieveSetup.Size = new System.Drawing.Size(170, 58);
            this.groupBox_recieveSetup.TabIndex = 4;
            this.groupBox_recieveSetup.TabStop = false;
            this.groupBox_recieveSetup.Text = "接收区设置";
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(89, 22);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "停止显示";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(9, 22);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 0;
            this.button_clear.Text = "清空显示";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox_sendSetup
            // 
            this.groupBox_sendSetup.Controls.Add(this.button_ctrlZ);
            this.groupBox_sendSetup.Controls.Add(this.button_send);
            this.groupBox_sendSetup.Location = new System.Drawing.Point(8, 227);
            this.groupBox_sendSetup.Name = "groupBox_sendSetup";
            this.groupBox_sendSetup.Size = new System.Drawing.Size(169, 59);
            this.groupBox_sendSetup.TabIndex = 5;
            this.groupBox_sendSetup.TabStop = false;
            this.groupBox_sendSetup.Text = "发送区设置";
            // 
            // button_ctrlZ
            // 
            this.button_ctrlZ.Location = new System.Drawing.Point(8, 21);
            this.button_ctrlZ.Name = "button_ctrlZ";
            this.button_ctrlZ.Size = new System.Drawing.Size(75, 23);
            this.button_ctrlZ.TabIndex = 3;
            this.button_ctrlZ.Text = "发送^Z";
            this.button_ctrlZ.UseVisualStyleBackColor = true;
            this.button_ctrlZ.Click += new System.EventHandler(this.button_ctrlZ_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "帮助";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(402, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "退出程序";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(-3, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(192, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "AT指令调试器";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 12);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusStrip2.AutoSize = false;
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Location = new System.Drawing.Point(185, 298);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(157, 22);
            this.statusStrip2.Stretch = false;
            this.statusStrip2.TabIndex = 12;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // statusStrip3
            // 
            this.statusStrip3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusStrip3.AutoSize = false;
            this.statusStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip3.Location = new System.Drawing.Point(342, 298);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(149, 22);
            this.statusStrip3.Stretch = false;
            this.statusStrip3.TabIndex = 13;
            this.statusStrip3.Text = "程序编写：帮主";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel3.Text = "程序编写：帮主";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 12);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 318);
            this.Controls.Add(this.statusStrip3);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox_sendSetup);
            this.Controls.Add(this.groupBox_recieveSetup);
            this.Controls.Add(this.groupBox_comSetup);
            this.Controls.Add(this.groupBox_send);
            this.Controls.Add(this.groupBox_recieve);
            this.Name = "Form1";
            this.Text = "AT指令调试器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_recieve.ResumeLayout(false);
            this.groupBox_send.ResumeLayout(false);
            this.groupBox_send.PerformLayout();
            this.groupBox_comSetup.ResumeLayout(false);
            this.groupBox_comSetup.PerformLayout();
            this.groupBox_recieveSetup.ResumeLayout(false);
            this.groupBox_sendSetup.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_recieve;
        private System.Windows.Forms.GroupBox groupBox_send;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Label label_AT;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.GroupBox groupBox_comSetup;
        private System.Windows.Forms.GroupBox groupBox_recieveSetup;
        private System.Windows.Forms.GroupBox groupBox_sendSetup;
        private System.Windows.Forms.ComboBox comboBox_com;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_baud;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.Label label_comState;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_ctrlZ;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}

