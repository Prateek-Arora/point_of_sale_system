using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void login_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string checkuser = "Select count(*) from admin_login where username='" + username.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            conn.Open();
            string checkpassword = "Select password from admin_login where username='" + username.Text + "'";
            SqlCommand passComm = new SqlCommand(checkpassword, conn);
            string passw = passComm.ExecuteScalar().ToString().Replace(" ","");
            if (passw == password.Text)
            {
                Session["New"] = username.Text;
                Response.Redirect("admin-info.aspx");
            }
            else
            {
                Response.Write("password is incorrect");
            }
            conn.Close();
        }
        else
        {
            Response.Write("username not valid");
        }
    }
}