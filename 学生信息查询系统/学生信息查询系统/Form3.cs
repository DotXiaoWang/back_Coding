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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private static Form3 form33 = null;

        public static Form3 getIntance(){
            //单实例模式
            if (form33 == null) {
                form33 = new Form3();
            }
            return form33;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            //编写连接数据库的字符串
            string connStr = "uid=sa;pwd=数据库密码;initial catalog=studentInfo;data source=数据库地址;Connect Timeout=900";
            try
            {
                string User1 = textBox1.Text;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select * from infoStu where username = '" + User1 + "'";
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        string User2 = reader.GetString(reader.GetOrdinal("username"));
                        string age = reader.GetString(reader.GetOrdinal("age"));
                        string sex = reader.GetString(reader.GetOrdinal("sex"));
                        string grade = reader.GetString(reader.GetOrdinal("grade"));

                        if (User1 == User2)
                        {
                            //MessageBox.Show("登录成功！");
                            this.Hide();
                            Form4 f4 = new Form4(User2,age,sex,grade);
                            f4.Show();
                            
                        }
                        else
                        {
                           // MessageBox.Show("密码错误！");
                            textBox1.Text = " ";
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户不存在！");
                        textBox1.Text = " ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败！" + ex.Message);
            }


        }



    }
}
