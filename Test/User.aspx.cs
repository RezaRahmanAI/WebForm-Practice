using System;
using System.Data.SqlClient;

namespace Test
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var name = Username.Text;
            var email = Email.Text;
            var pass = Pass.Text;

            var conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "INSERT INTO Users (Name, Email, Password) VALUES (@NameOfUser, @Email, @Password)";

                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@NameOfUser", name);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@Password", pass);

                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}