using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _26nov
{
    public class ProductDal
    {
        public string Name { get; set; }



        public bool AddRecord()

        {

            bool isSuccess = true;

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=WebAuthentication;Integrated Security=True;Connect Timeout=15;Encrypt=False;Packet Size=4096"))

            {

                try

                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = conn;
                   

                    cmd.CommandText = "insert into ProductDetails(Name) values('" + Name + "')";
                    

                    int RowsAffected = cmd.ExecuteNonQuery();

                    if (RowsAffected < 1)

                    {

                        throw new Exception("Could not save the data");

                    }



                }

                catch (Exception ex)

                {

                    

                    isSuccess = false;

                }

                finally

                {

                    conn.Close();

                }

                return isSuccess;

            }
        }
        public bool DeleteRecord()

        {

            bool isSuccess = true;

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=WebAuthentication;Integrated Security=True;Connect Timeout=15;Encrypt=False;Packet Size=4096"))

            {

                try

                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = conn;
                     cmd.CommandText = "delete ProductDetails where Name='"+ Name+"' ";

                    


                    int RowsAffected = cmd.ExecuteNonQuery();

                    if (RowsAffected < 1)

                    {

                        throw new Exception("Could not save the data");

                    }



                }

                catch (Exception ex)

                {



                    isSuccess = false;

                }

                finally

                {

                    conn.Close();

                }

                return isSuccess;

            }
        }
    }
}