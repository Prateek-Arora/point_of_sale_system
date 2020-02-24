using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class register_cashier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
            con.Open();
            string checkuser = "Select count(*) from cashier_login where username='" + username.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, con);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("User already exists");
            }
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        con.Open();
        string insert = "insert into cashier_login (username,password,name,email,contact) VALUES (@Uname,@pass,@name,@email,@contact)";
        SqlCommand com = new SqlCommand(insert, con);
        com.Parameters.AddWithValue("@Uname", username.Text);
        com.Parameters.AddWithValue("@pass", password.Text);
        com.Parameters.AddWithValue("@name", name.Text);
        com.Parameters.AddWithValue("@email", email.Text);
        com.Parameters.AddWithValue("@contact", contact.Text);

        com.ExecuteNonQuery();
        Response.Redirect("cashier_login.aspx");

        con.Close();
    }
}