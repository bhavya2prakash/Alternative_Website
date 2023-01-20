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
    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    string myDb;
    //    myDb = HttpContext.Current.Server.MapPath("App_Data//myWebsiteDB.accdb");
    //    OleDbConnection con = new OleDbConnection("provider=Microsoft.ACE.OleDb.12.0; Data Source = " + myDb + "");
        
    //    OleDbDataAdapter Da = new OleDbDataAdapter("select * from Login where name='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'", con);

    //    DataSet Ds = new DataSet();
    //    Da.Fill(Ds, "Login");
    //    int n = 0;
    //    n = Ds.Tables[0].Rows.Count;
    //    if (n >= 1)
    //    {
    //        Response.Redirect("home.html");
    //    }
    //    else
    //    {
    //        Response.Write("Invalid user");
    //    }

    //    /* if (Ds.Tables[0].Rows[0][1].Equals(TextBox1.Text) && Ds.Tables[0].Rows[0][2].Equals(TextBox2.Text))
    //     {
    //         Response.Redirect("home.html");
    //     }
    //     else
    //     {
    //         Response.Write("Invalid user");
    //     }*/
    //}//to login
    protected void Button1_Click(object sender, EventArgs e)   //to insert
    {
        string myDb;
        myDb = HttpContext.Current.Server.MapPath("App_Data//myWebsiteDB.accdb");
        OleDbConnection con = new OleDbConnection("provider=Microsoft.ACE.OleDb.12.0; Data Source = " + myDb + "");
        OleDbCommand cmd = new OleDbCommand("Insert InTo Login values('" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

 
}