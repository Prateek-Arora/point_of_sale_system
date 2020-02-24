using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class bill : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        con.Open();

        string last = "select top 1 id from bill order by id DESC";
        SqlCommand com1 = new SqlCommand(last, con);
        int end = Convert.ToInt32(com1.ExecuteScalar().ToString());
        int sum = 0;
        for (int i = 1; i < end + 1; i++)
        {
            string amount = "select Amount from bill where id='" + i + "'";
            SqlCommand com = new SqlCommand(amount,con);
            int s = Convert.ToInt32(com.ExecuteScalar().ToString());
            sum = sum + s;
        }
        Label2.Text = sum.ToString();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        con.Open();
   
        string last = "select top 1 id from bill order by id DESC";
        SqlCommand com1 = new SqlCommand(last,con);
        int end = Convert.ToInt32(com1.ExecuteScalar().ToString());
        for (int i = 1; i < end+1; i++)
        {
            string cat = "select Category from bill where id='" + i + "'";
            SqlCommand com2 = new SqlCommand(cat, con);
            string catg = com2.ExecuteScalar().ToString().Replace(" ","");

            string n = "select Item_name from bill where id='" + i + "'";
            SqlCommand com3 = new SqlCommand(n, con);
            string name = com3.ExecuteScalar().ToString().Replace(" ", "");

            string curr = "select stock from " + catg + " where name='" + name + "'";
            SqlCommand com4 = new SqlCommand(curr, con);
            int curr_stock = Convert.ToInt32(com4.ExecuteScalar().ToString());

            string dec = "select Quantity from bill where id='" + i + "'";
            SqlCommand com5 = new SqlCommand(dec, con);
            int dec_stock = Convert.ToInt32(com5.ExecuteScalar().ToString());

            int new_stock = curr_stock - dec_stock;

            string update = "update " + catg + " set stock='" + new_stock + "' where name='" + name +"'";
            SqlCommand up = new SqlCommand(update, con);
            up.ExecuteNonQuery();


        }
        string trun = "truncate table bill";
        SqlCommand com = new SqlCommand(trun, con);
        com.ExecuteNonQuery();

        Response.Redirect("thanks.aspx");
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("shop-page.aspx");
    }
}