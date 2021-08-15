using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Project_Music
{
    class Login
    {
        public Login(string UserName, string Email, string Password)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5H1SSN8;Initial Catalog=Project_Music;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) 
            {
                string user_details = $"SELECT * FROM user_details where UserName = ('{UserName}') OR Email = ('{Email}'); ";
                SqlCommand signin = new SqlCommand(user_details, con);
                SqlDataReader result = signin.ExecuteReader();
                if (result.Read() == false)
                {
                    MessageBox.Show("UserName/Email not recognized");
                }

            }
            con.Close();

            con.Open();
            if (con.State == System.Data.ConnectionState.Open) 
            {
                string user_details = $"SELECT * FROM user_details where UserName = ('{UserName}') OR Email = ('{Email}'); ";
                SqlCommand signin = new SqlCommand(user_details, con);
                SqlDataReader result = signin.ExecuteReader();
                while (result.Read())
                {

                    if ((result.GetString(6) == Email || result.GetString(5) == UserName) && (result.GetString(7) == Password))
                    {

                        Form5 Home = new Form5();

                        Home.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }

                }
            }


        }
        }
    }

