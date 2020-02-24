using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class breads : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "bagel";
        string query = "select stock from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        if (temp >= 1)
        {
            TextBox13.Text = "AVAILABLE";
            TextBox13.ReadOnly = true;
        }
        else
        {
            TextBox13.Text = "SOLD OUT";
            TextBox13.ReadOnly = true;
            TextBox1.Visible = false;
        }
        string name1 = "baguette";
        string query1 = "select stock from breads where name='" + name1 + "'";
        SqlCommand com1 = new SqlCommand(query1, conn);
        int temp1 = Convert.ToInt32(com1.ExecuteScalar().ToString());
        if (temp1 >= 1)
        {
            TextBox14.Text = "AVAILABLE";
            TextBox14.ReadOnly = true;
        }
        else
        {
            TextBox14.Text = "SOLD OUT";
            TextBox14.ReadOnly = true;
            TextBox2.Visible = false;
        }
        string name2 = "brioche";
        string query2 = "select stock from breads where name='" + name2 + "'";
        SqlCommand com2 = new SqlCommand(query2, conn);
        int temp2 = Convert.ToInt32(com2.ExecuteScalar().ToString());
        if (temp2 >= 1)
        {
            TextBox15.Text = "AVAILABLE";
            TextBox15.ReadOnly = true;
        }
        else
        {
            TextBox15.Text = "SOLD OUT";
            TextBox15.ReadOnly = true;
            TextBox3.Visible = false;
        }
        string name3 = "brown";
        string query3 = "select stock from breads where name='" + name3 + "'";
        SqlCommand com3 = new SqlCommand(query3, conn);
        int temp3 = Convert.ToInt32(com3.ExecuteScalar().ToString());
        if (temp3 >= 1)
        {
            TextBox16.Text = "AVAILABLE";
            TextBox16.ReadOnly = true;

        }
        else
        {
            TextBox16.Text = "SOLD OUT";
            TextBox16.ReadOnly = true;
            TextBox4.Visible = false;
        }
        string name4 = "challah";
        string query4 = "select stock from breads where name='" + name4 + "'";
        SqlCommand com4 = new SqlCommand(query4, conn);
        int temp4 = Convert.ToInt32(com4.ExecuteScalar().ToString());
        if (temp4 >= 1)
        {
            TextBox17.Text = "AVAILABLE";
            TextBox17.ReadOnly = true;
        }
        else
        {
            TextBox17.Text = "SOLD OUT";
            TextBox17.ReadOnly = true;
            TextBox5.Visible = false;
        }
        string name5 = "ciabatta";
        string query5 = "select stock from breads where name='" + name5 + "'";
        SqlCommand com5 = new SqlCommand(query5, conn);
        int temp5 = Convert.ToInt32(com5.ExecuteScalar().ToString());
        if (temp5 >= 1)
        {
            TextBox18.Text = "AVAILABLE";
            TextBox18.ReadOnly = true;
        }
        else
        {
            TextBox18.Text = "SOLD OUT";
            TextBox18.ReadOnly = true;
            TextBox6.Visible = false;
        }
        string name6 = "ezekiel";
        string query6 = "select stock from breads where name='" + name6 + "'";
        SqlCommand com6 = new SqlCommand(query6, conn);
        int temp6 = Convert.ToInt32(com6.ExecuteScalar().ToString());
        if (temp6 >= 1)
        {
            TextBox19.Text = "AVAILABLE";
            TextBox19.ReadOnly = true;
        }
        else
        {
            TextBox19.Text = "SOLD OUT";
            TextBox19.ReadOnly = true;
            TextBox7.Visible = false;
        }
        string name7 = "multigrain";
        string query7 = "select stock from breads where name='" + name7 + "'";
        SqlCommand com7 = new SqlCommand(query7, conn);
        int temp7 = Convert.ToInt32(com7.ExecuteScalar().ToString());
        if (temp7 >= 1)
        {
            TextBox20.Text = "AVAILABLE";
            TextBox20.ReadOnly = true;
        }
        else
        {
            TextBox20.Text = "SOLD OUT";
            TextBox20.ReadOnly = true;
            TextBox8.Visible = false;
        }
        string name8 = "rye";
        string query8 = "select stock from breads where name='" + name8 + "'";
        SqlCommand com8 = new SqlCommand(query8, conn);
        int temp8 = Convert.ToInt32(com8.ExecuteScalar().ToString());
        if (temp8 >= 1)
        {
            TextBox21.Text = "AVAILABLE";
            TextBox21.ReadOnly = true;
        }
        else
        {
            TextBox21.Text = "SOLD OUT";
            TextBox21.ReadOnly = true;
            TextBox9.Visible = false;
        }
        string name9 = "sourdough";
        string query9 = "select stock from breads where name='" + name9 + "'";
        SqlCommand com9 = new SqlCommand(query9, conn);
        int temp9 = Convert.ToInt32(com9.ExecuteScalar().ToString());
        if (temp9 >= 1)
        {
            TextBox22.Text = "AVAILABLE";
            TextBox22.ReadOnly = true;
        }
        else
        {
            TextBox22.Text = "SOLD OUT";
            TextBox22.ReadOnly = true;
            TextBox10.Visible = false;
        }
        string name10 = "white";
        string query10 = "select stock from breads where name='" + name10 + "'";
        SqlCommand com10 = new SqlCommand(query10, conn);
        int temp10 = Convert.ToInt32(com10.ExecuteScalar().ToString());
        if (temp10 >= 1)
        {
            TextBox23.Text = "AVAILABLE";
            TextBox23.ReadOnly = true;
        }
        else
        {
            TextBox23.Text = "SOLD OUT";
            TextBox23.ReadOnly = true;
            TextBox11.Visible = false;
        }
        string name11 = "whole-wheat";
        string query11 = "select stock from breads where name='" + name11 + "'";
        SqlCommand com11 = new SqlCommand(query11, conn);
        int temp11 = Convert.ToInt32(com11.ExecuteScalar().ToString());
        if (temp11 >= 1)
        {
            TextBox24.Text = "AVAILABLE";
            TextBox24.ReadOnly = true;
        }
        else
        {
            TextBox24.Text = "SOLD OUT";
            TextBox24.ReadOnly = true;
            TextBox12.Visible = false;

        }
        conn.Close();
    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "bagel";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox1.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox1.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "baguette";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox2.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox2.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "brioche";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox3.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox3.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "brown";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox4.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox4.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "challah";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox5.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox5.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "ciabatta";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox6.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox6.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "ezekiel";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox7.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox7.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "multigrain";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox8.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox8.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "rye";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox9.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox9.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "sourdough";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox10.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox10.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "white";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox11.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox11.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pos_string"].ConnectionString);
        conn.Open();
        string name = "whole-wheat";
        string category = "breads";
        string query = "select price from breads where name='" + name + "'";
        SqlCommand com = new SqlCommand(query, conn);
        int price = Convert.ToInt32(com.ExecuteScalar().ToString());
        string checkbill = "select count(*) from bill where Item_Name='" + name + "'";
        SqlCommand comm = new SqlCommand(checkbill, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        int value = Convert.ToInt32(TextBox12.Text);
        int amount = price * value;
        if (temp == 1)
        {
            if (value == 0)
            {
                string delete = "delete from bill where Item_Name='" + name + "'";
                SqlCommand del = new SqlCommand(delete, conn);
                del.ExecuteNonQuery();
            }
            else
            {
                string update = "update bill set Quantity='" + TextBox1.Text + "',Amount='" + amount + "' where Item_Name='" + name + "'";
                SqlCommand commm = new SqlCommand(update, conn);
                commm.ExecuteNonQuery();
            }
        }
        else
        {
            string insert = "insert into bill (Item_Name,Quantity,Amount,Category) VALUES (@name,@quantity,@amount,@category)";
            SqlCommand commm = new SqlCommand(insert, conn);
            commm.Parameters.AddWithValue("@name", name);
            commm.Parameters.AddWithValue("@quantity", TextBox12.Text);
            commm.Parameters.AddWithValue("@amount", amount);
            commm.Parameters.AddWithValue("@category", category);
            commm.ExecuteNonQuery();
        }
        conn.Close();
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        Response.Redirect("bill.aspx");
    }
}