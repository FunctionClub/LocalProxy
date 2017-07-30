using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //打开注册表键 
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
            //设置代理可用 
            rk.SetValue("ProxyEnable", 1);
            //设置代理IP和端口 
            rk.SetValue("ProxyServer", this.IP.Text.ToString() + ":" + this.Duankou.Text.ToString());
            rk.Close();
            MessageBox.Show("成功","系统消息",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //打开注册表键 
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
            //设置代理不可用 
            rk.SetValue("ProxyEnable", 0);
            rk.Close();
            MessageBox.Show("成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
