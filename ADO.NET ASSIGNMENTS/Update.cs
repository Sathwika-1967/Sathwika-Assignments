using System;

using System.Data.SqlClient;



namespace ADO.net
{
    internal class Update
    {
       public static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=SathwikaVM;Initial Catalog=Employee;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            //update=>u
            int u_EmpID;
            string u_FirstName;
            string u_LastName;
            int u_Salary;
            Console.WriteLine("enter EmpID that i like to update");
            u_EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter FirstName that i like to update");
            u_FirstName = Console.ReadLine();
            Console.WriteLine("enter LastName that i like to update");
            u_LastName = Console.ReadLine();
            Console.WriteLine("enter Salary that i like to update");
            u_Salary = int.Parse(Console.ReadLine());
            string updateQuery = "update Employee set FirstName = '" + u_FirstName + "', LastName = '" + u_LastName + "', Salary = '" + u_Salary + "' where EmpID ='" + u_EmpID + "'";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Data updated successfully");
            Console.ReadLine();
            sqlConnection.Close();
        }
    }
}

