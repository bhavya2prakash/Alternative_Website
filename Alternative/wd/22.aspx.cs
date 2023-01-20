using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class wd_22 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string myDb;
          myDb = HttpContext.Current.Server.MapPath("App_Data//alternative.accdb");
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\webwebsite\\App_Data\\alternative.accdb");
        OleDbCommand cmd = new OleDbCommand("Insert InTo comment values('" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}