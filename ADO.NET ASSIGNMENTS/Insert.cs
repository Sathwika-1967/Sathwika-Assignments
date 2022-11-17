using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net
{ 
    internal class Insert
    {
       public static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=SathwikaVM;Initial Catalog=Employee;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("Please Enter Employee Id : ");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Employee First Name : ");
            String FirstName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Last Name : ");
            String Lastname = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Salary : ");
            int Salary = Convert.ToInt32(Console.ReadLine());


            string insertQuery = "insert into Employee(EmpID, FirstName, LastName , Salary) Values('" + EmpId + "','" + FirstName + "','" + Lastname + "','" + Salary + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
            sqlConnection.Close();
        }
    }
}

