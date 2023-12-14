//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;

//namespace ConAppAssignment6Day6Ph2
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataReader reader;
//        static string constr = "server=SHIVAMSINGH;database=ProductInventoryDB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {

//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "select*from Products"
//                };
//                con.Open();
//                reader = cmd.ExecuteReader();
//                Console.WriteLine("ProductId \t ProductName \t Price \t Quantity \t MfDate \t ExpDate");
//                while (reader.Read())
//                {
//                    Console.Write(reader[0] + "\t");
//                    Console.Write(reader[1] + "\t\t ");
//                    Console.Write(reader[2] + "\t\t ");
//                    Console.Write(reader[3] +"\t\t ");
//                    Console.Write(reader[4] + "\t ");
//                    Console.Write(reader[5] + "\t ");
//                    Console.WriteLine("\n");
//                }

//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine("Error Occured"+ex.Message);
//            }
//            finally {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}

//Product inserted
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;

//namespace ConAppAssignment6Day6Ph2
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataReader reader;
//        static string constr = "server=SHIVAMSINGH;database=ProductInventoryDB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {

//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "insert into Products (ProductId,ProductName,Price,Qunatity,MfDate,ExpDate) values(@id,@name,@pr,@qt,@mfg,@exp)"
//                };
//                con.Open();
//                Console.WriteLine("Enter Product Id");
//                int id = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Product name");
//                string name = Console.ReadLine();
//                Console.WriteLine("Enter Product Price");
//                float price = float.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Quantity");
//                int qt = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter manufacturing date");
//                DateTime mfg = DateTime.Parse(Console.ReadLine());
//                Console.WriteLine("Enter Expiry date");
//                DateTime exp = DateTime.Parse(Console.ReadLine());
//                cmd.Parameters.AddWithValue("@id", id);
//                cmd.Parameters.AddWithValue("@name",name);
//                cmd.Parameters.AddWithValue("@pr", price);
//                cmd.Parameters.AddWithValue("@qt", qt);
//                cmd.Parameters.AddWithValue("@mfg", mfg);
//                cmd.Parameters.AddWithValue("@exp", exp);

//                cmd.ExecuteNonQuery();
//                Console.WriteLine("Product Inserted");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error Occured" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}

//update product Quantity


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;

//namespace ConAppAssignment6Day6Ph2
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataReader reader;
//        static string constr = "server=SHIVAMSINGH;database=ProductInventoryDB;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {

//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "update Products set Qunatity=@qt where ProductId=@id"
//                };

//                Console.WriteLine("Enter Product Id");
//                int id = int.Parse(Console.ReadLine());

//                Console.WriteLine("Enter Quantity");
//                int qt = int.Parse(Console.ReadLine());

//                cmd.Parameters.AddWithValue("@id", id);
//                cmd.Parameters.AddWithValue("@qt", qt);


//                con.Open();
//                int no= cmd.ExecuteNonQuery();
//                if (no > 0)
//                {
//                    Console.WriteLine($"Product Quantity update for {id}");
//                }

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error Occured" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}
//Remove Product
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConAppAssignment6Day6Ph2
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string constr = "server=SHIVAMSINGH;database=ProductInventoryDB;trusted_connection=true;";
        static void Main(string[] args)
        {
            try
            {

                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "delete from Products where ProductId=@id"
                };

                Console.WriteLine("Enter Product Id");
                int id = int.Parse(Console.ReadLine());

              

                cmd.Parameters.AddWithValue("@id", id);
               


                con.Open();
                int no = cmd.ExecuteNonQuery();
                if (no > 0)
                {
                    Console.WriteLine($"Product is deleted from the database");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}




