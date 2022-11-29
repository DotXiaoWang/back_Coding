using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生信息查询系统
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }
        public Form4(string xm,string age1,string sex,string grade)
        {        
           InitializeComponent();
            //这句必须放在InitializeComponent();的后面，否则会引起“空引用异常”
           label7.Text = xm;
           label8.Text = age1;
           label9.Text = sex;
           label10.Text = grade;
        }

    private void button1_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Form3.getIntance().Show();
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           // this.toolStripStatusLabel1.Text = "当前系统时间" + System.DateTime.Now.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000; //时间间隔为1秒  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = System.DateTime.Now.ToString();
        }



    }
}
