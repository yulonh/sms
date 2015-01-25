using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace 时讯网
{
    public partial class Form1 : Form
    {
        //声明GSMMODEM类
        GSMMODEM gm = new GSMMODEM();
        
        //停止显示标志
        bool stoptb2 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能尚未实现！");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //状态栏初始化
            toolStripStatusLabel1.Text = "AT指令调试器正在初始化";
            
            //填充comboBox_com控件，填入串口号以供选择
            string[] Ports = SerialPort.GetPortNames();     //从注册表中获取串口号
            foreach (string Port in Ports)
            {
                if (Regex.IsMatch(Port, @"COM[0-9]*"))
                {
                    comboBox_com.Items.Add(Port);
                }
            }

            //默认选第一个端口
            if (comboBox_com.Items.Count > 0)
            {
                comboBox_com.SelectedIndex = 0;
            }

            comboBox1.SelectedIndex = 0;

            //设备初始化
            if (comboBox_com.Items.Count > 0)
            {
                gm.ComPort = comboBox_com.SelectedItem.ToString();
            }
            gm.BaudRate = Convert.ToInt32(comboBox1.SelectedItem.ToString());

            //状态栏
            toolStripStatusLabel1.Text = "AT调试器初始化成功";
        }

        private void comboBox_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gm.IsOpen == false)
            {
                gm.ComPort = comboBox_com.SelectedItem.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gm.IsOpen == false)
            {
                gm.BaudRate = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gm.IsOpen == false)         //连接设备
            {
                try
                {
                    gm.OpenComm();
                    label_comState.Text = "已连接";
                    label_comState.ForeColor = Color.Green;

                    button2.Text = "断开连接";
                    //状态栏
                    toolStripStatusLabel1.Text = gm.ComPort + "," + gm.BaudRate.ToString();
                }
                catch (Exception)
                {
                    label_comState.Text = "设备无法连接";
                    label_comState.ForeColor = Color.Red;
                }
            }
            else                            //断开设备
            {
                try
                {
                    gm.CloseComm();
                    label_comState.Text = "已断开";
                    label_comState.ForeColor = Color.Black;

                    button2.Text = "连接设备";

                    //状态栏
                    toolStripStatusLabel1.Text = "设备未连接，无法操作";
                }
                catch (Exception)
                {
                    label_comState.Text = "无法断开";
                    label_comState.ForeColor = Color.Red;
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (stoptb2 == false)
            {
                stoptb2 = true;
                button_stop.Text = "继续显示";
            }
            else
            {
                stoptb2 = false;
                button_stop.Text = "停止显示";
            }
        }

        private void button_ctrlZ_Click(object sender, EventArgs e)
        {
            Byte[] byte1 = new Byte[1];
            byte1[0] = 0x1A;
            try
            {
                if (gm.IsOpen == true)
                {
                    richTextBox1.Text += gm.Write(byte1, 0, 1);
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                }
                else
                {
                    MessageBox.Show("设备未打开，无法操作");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (gm.IsOpen == true)
            {
                try
                {
                    if (stoptb2 == false)
                    {
                        richTextBox1.Text += gm.SendATCommand(textBox_send.Text);
                        richTextBox1.SelectionStart = richTextBox1.Text.Length;
                        richTextBox1.ScrollToCaret();
                    }
                    else
                    {
                        gm.SendATCommand(textBox_send.Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("设备未打开，无法操作");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            About abtFrm = new About();
            abtFrm.Owner = this;
            abtFrm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
