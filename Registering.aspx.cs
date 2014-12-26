using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Configuration;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;




public partial class Registering : System.Web.UI.Page
{
    private string _connString;
    protected void Page_Load(object sender, EventArgs e)
    {
       /* if(IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from Table where UserName='"+TextBoxUn.Text+"'";
            SqlCommand com = new SqlCommand(checkuser,conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("This User Name Already Exists.");

            }


            conn.Close();

        }*/
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
        _connString = WebConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(_connString);
        conn.Open();
        SqlCommand com = new SqlCommand();
        com.Connection = conn;
        com.CommandType = CommandType.Text;
        com.CommandText = "INSERT into pilot VALUES('4','" + TextBoxUn.Text + "','" +TextBoxEmail.Text+ "', 'chern', 'yeay')";
            //change the primary key value to null after auto increment.






        /* string insertQuery = "insert into Table(UserName, Email, Password, Country) values(@uname,@email,@password,@country)";
         SqlCommand com = new SqlCommand(insertQuery, conn);
         com.Parameters.AddWithValue("@uname", TextBoxUn.Text);
          com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
          com.Parameters.AddWithValue("@password", TextBoxPass.Text);
          com.Parameters.AddWithValue("@country", DropDownListCountry.SelectedItem.ToString());
        com.Connection = conn;
        com.CommandType = CommandType.Text;
        com.CommandText= "Insert into table (UserName,Email,Password,Country) VALUES ('1'," + TextBoxUn.Text +"','xx')";*/


        com.ExecuteNonQuery();

        Response.Write("Congratulations!! You Are Now Part Of Our Airlines!");

        conn.Close();
        }
        catch(Exception ex)
        {
            Response.Write("Error:" +ex.ToString());

        }
    }
}