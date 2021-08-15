using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_Music
{
    class Registration
    {
        public Registration(string First_Name, string Last_Name, string DateOfBirth, string Mobile, string Country, string UserName, string Email, string Password)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5H1SSN8;Initial Catalog=Project_Music;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) // to ensure connection is open or not
            {
                string user_details = $"INSERT INTO user_details(First_Name, Last_Name, DateOfBirth, Mobile, Country, UserName, Email, User_Password) VALUES" +
                    $"('{First_Name}', '{Last_Name}', '{DateOfBirth}', '{Mobile}', '{Country}', '{UserName}', '{Email}', '{Password}' ); ";
                SqlCommand signin = new SqlCommand(user_details, con);
                signin.ExecuteNonQuery();


            }

        }
    }
}
