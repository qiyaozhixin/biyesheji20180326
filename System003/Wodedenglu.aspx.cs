﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Wodedenglu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string str = TextBox1.Text;

            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=ppzsppzs;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            SqlCommand sqlcmd = new SqlCommand("select 密码 from aspnet_Yuangongtest where 员工OA = '"+ str +"';", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
            {
                Label3.Text += sqldr[0];
            }
            if (TextBox2.Text == Label3.Text)
            {
                Response.Write("<script>window.alert('登陆成功!');location.href='Default.aspx';</script>");
            }
            else
            {
                Response.Write("<script>window.alert('登陆失败，请检查密码是否正确！');location.href='Wodedenglu.aspx';</script>");
            }
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
        }
    }
}