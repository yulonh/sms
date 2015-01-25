using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 时讯网
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            label1.Text = "    AT指令调试器由C#语言编写，运行需要dotnet2.0支持，又为绿色版方便使用。适合工程技术人员使用。\n"
                + "    当设备连接成功后想串口发送数据，向发送区写入数据，点击发送即可向设备发送数据。\n"
            + "    本软件可以随意传播复制，严禁用于商业用途。\n"
            + "    调试AT指令时，Ctrlt+Z 按钮可以发送Ctrl+Z字符\n"
            + "    由于水平有限，难免有bug，欢迎反馈有关软件的信息。\n"
            + "    QQ：1039297108  954602508\n"
            + "    Email：xiaoa0389@126.com\n"
            + "    需要源代码的可以联系我";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
