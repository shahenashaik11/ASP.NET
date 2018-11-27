using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _27nov
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
                    cmd.CommandText = "delete ProductDetails where Name='" + Name + "' ";




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

                    //conn.Close();

                }

                return isSuccess;

            }
        }
        public bool SelectRecord()

        {
            DataTable dt = new DataTable();
            bool isSuccess = true;
            

            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=WebAuthentication;Integrated Security=True;Connect Timeout=15;Encrypt=False;Packet Size=4096"))

            {
                
                try
                                                                                                                                        

                {


                    
                    DataSet dataSet = new DataSet();
                     SqlDataAdapter dataAdapter;
                    
                    dataAdapter = new SqlDataAdapter("select * from ProductDetails", conn);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    var newRow = dataSet.Tables[0].NewRow();
                    newRow["Name"] = "keyboard";
                    dataSet.Tables[0].Rows.Add(newRow);
                    new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataSet);


                    //cmd = new SqlCommand("select * from ProductDetails", conn);
                    //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    //dt = new DataTable();
                    //sda.Fill(dt);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@Name", "Name"));

                    //SqlDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    Name += reader["Name"].ToString() + "<br/>";

                    //}

                }

                catch (Exception ex)

                {



                    isSuccess = false;

                }

                finally

                {

                  

                }

                return isSuccess;

            }
        }
        public bool UpdateRecord()
        {
            SqlCommandBuilder cmdBuilder;
            DataSet ds;
            bool isSuccess = true;
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=WebAuthentication;Integrated Security=True;Connect Timeout=15;Encrypt=False;Packet Size=4096"))



            {



                //SqlCommand cmd = new SqlCommand("select * from Products", conn); 



               // SqlDataAdapter sqlda = new SqlDataAdapter("select * from Products", conn);



                //SqlDataAdapter sqlda = new SqlDataAdapter("select * from ProductDetails;select * from AspNetUsers", conn);



                //cmdBuilder = new SqlCommandBuilder(sqlda);
                try
                {
                     ds = new DataSet();

                    conn.Open();
                    SqlDataAdapter sqda = new SqlDataAdapter("Select * from ProductDetails", conn);
                    cmdBuilder = new SqlCommandBuilder(sqda);
                    sqda.Fill(ds, "ProductDetails");
                    ds.Tables["ProductDetails"].Rows[0]["Name"] = "pen";

                  

                    sqda.Update(ds, "ProductDetails");


                }




                //try
                //{


                //    ds = new DataSet();
                //    sqlda.Fill(ds);
                //    ds.Tables[0].Rows[0]["Name"] = "pen";
                //    DataRow dr = ds.Tables[0].NewRow();
                //    dr = ds.Tables["Products"].NewRow();
                //    dr["Name"] = "Tabs";
                //    ds.Tables[0].Rows.Add(dr);
                //    //sqlda.Update(ds, ds.Tables[0].ToString());
                //    sqlda.Update(ds, "Products");


                //}
                catch (Exception ex)

                {



                    isSuccess = false;

                }

                finally

                {



                }

                return isSuccess;


            }



        }
    }

}
