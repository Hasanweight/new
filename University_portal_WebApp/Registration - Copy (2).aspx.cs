﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class Registration : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand _cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        string strPath = WebConfigurationManager.ConnectionStrings["StudentDBCon"].ConnectionString;
        con = new SqlConnection(strPath);
        con.Open();
    }
    protected void create_account_Button_Click(object sender, EventArgs e)
    {

        //_cmd = new SqlCommand("INSERT INTO [tblStudent] (fname,lname,email,password) VALUES ('" + firstname_Textbox.Text + "','" + lastname_Textbox.Text + "','" + email_Textbox.Text + "','" + password_Textbox.Text + "')", con);
        _cmd = new SqlCommand();
        _cmd.Connection = con;
        _cmd.CommandText = "INSERT INTO [tblStudent] (fname,lname,email,password) VALUES('" + firstname_Textbox.Text + "','" + lastname_Textbox.Text + "','" + email_Textbox.Text + "','" + password_Textbox.Text + "')";
        
        
        _cmd.ExecuteNonQuery();
        con.Close();
        //DbConnectClass db = new DbConnectClass();
        //db.Insert("INSERT INTO [Table] (fname,lname,email,password) VALUES ('" + firstname_Textbox.Text + "','" + lastname_Textbox.Text + "','" + email_Textbox.Text + "','" + password_Textbox.Text + "')");
        Response.Write("<script>alert('Data Submitted Successfully')</script>");
        //db.Insert("INSERT INTO tblStudent(fname,lname,email,password) VALUES (@fname,@lname,@email,@password");
        

    }
}