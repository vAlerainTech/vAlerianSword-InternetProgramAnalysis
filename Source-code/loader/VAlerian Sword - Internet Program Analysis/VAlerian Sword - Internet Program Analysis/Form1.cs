using System.Diagnostics;

namespace VAlerian_Sword___Internet_Program_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start using the loader!", "debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process p = Process.Start("C:\\loader.exe");
            p.WaitForExit();//关键，等待外部程序退出后才能往下执行
        }
    }
}
