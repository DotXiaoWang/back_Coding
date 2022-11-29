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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "uid=sa;pwd=数据库密码;initial catalog=studentInfo;data source=数据库地址;Connect Timeout=900";

            try
            {
                string User1 = tbUserName.Text;
                string Pwd = tbPassword.Text;
                string Pwd2 = tbPassword2.Text;
                string xm = xming.Text;
                string age = age1.Text;
                string sex1 = radioButton1.Text;
                string sex2 =radioButton2.Text;
                string grade = comboBox1.Text;

                using (SqlConnection conn = new SqlConnection(connStr))
                {

               
                    conn.Open(); //打开数据库连接
                    SqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "select * from infoStu where username = '" + User1 + "'";
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        string User2 = reader.GetString(reader.GetOrdinal("username"));
                        if (User1 == User2)
                        {
                            MessageBox.Show("用户已经存在, 请不要重复注册！");
                            this.Close();
                        }
                    }
                    conn.Close();
                    conn.Open();

                    string sql = "insert into infoStu(username,password1,password2,xm,age,sex,grade) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                        sql = string.Format(sql, User1, Pwd, Pwd2, xm, age, sex1, grade);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int returnvalue = cmd.ExecuteNonQuery();//执行SQL语句
                        if (returnvalue != -1)
                        { //判断SQL语句是否执行成功
                            MessageBox.Show("注册成功！");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("注册失败！");


                        }




                }

                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("注册失败！" + ex.Message);

            }


            this.Close();//关闭窗体
            Form1.getInstance().Show();  //返回


        }


    }
    
}
