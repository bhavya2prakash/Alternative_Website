using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }

 
    protected void  Button1_Click1(object sender, EventArgs e)
     {
    string myDb;
        myDb = HttpContext.Current.Server.MapPath("signup.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\ \\alternative\\signup.accdb");
        OleDbCommand cmd = new OleDbCommand("Insert InTo signup values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
}
}
