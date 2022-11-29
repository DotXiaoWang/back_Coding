using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生信息查询系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Form1 form11 = null;
        public static Form1 getInstance() {
            //单实例模式
            if (form11 == null) {
                form11 = new Form1();    //创建Form1对象
            }
            return form11;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //隐藏当前窗体
            new Form2().Show();//显示注册窗体

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connStr = "uid=sa;pwd=数据库密码;initial catalog=studentInfo;data source=数据库地址;Connect Timeout=900";

            try
            {
                string User = textBox1.Text;
                string Pwd = textBox2.Text;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select * from infoStu where username = '" + User + "'";
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        string password = reader.GetString(reader.GetOrdinal("password1"));
                        if (Pwd == password)
                        {
                            
                            this.Hide(); //隐藏当前窗体
                            new Form3().Show();//开启主菜单窗体
                        }
                        else
                        {
                            MessageBox.Show("密码错误！");
                            textBox1.Text = " ";
                            textBox2.Text = " ";
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户不存在！");
                        textBox1.Text = " ";
                        textBox2.Text = " ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错！" + ex.Message);
            }
            
/*           this.Hide();//隐藏当前窗体
            new Form3().Show();//显示注册窗体*/

        }

    }
}
