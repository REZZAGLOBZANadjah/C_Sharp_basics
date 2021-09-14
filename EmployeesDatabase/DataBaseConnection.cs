using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;

namespace EmployeesDataBase
{/* sql database connection using app.congig file  that should conataine  the folowing configurations 	// we can get this data from the database properties " Data Source=NAJAH;Initial Catalog=EmploeesDB;Integrated Security=Tru"
  
    // mysql : server=localhost;user id=root;database=company
    <appSettings>
		<add key = "provider" value="System.Data.SqlClient"/>
		<add key = "connectionString" value="Data Source=NAJAH;Initial Catalog=EmploeesDB;Integrated Security=True"/>
</appSettings>
    */

    class DataBaseConnection
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        // dadatabase configuration 
        public DataBaseConnection()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }
        // function get data from database 
        public List<Employee> GetAllEmployees() {
            var employees = new List<Employee>();
            // try connect to database 
            using (var connection = factory.CreateConnection())
            {//intialiser vvar connection
                connection.ConnectionString = connectionString;
                // open connection with database 
                connection.Open();
                // declare the query to execute commande 
                var command = factory.CreateCommand();
                command.Connection = connection;
                // write the query in string format in SQL language  query 
                command.CommandText = "Select * from  Employees;";
                // execute the query and get the data 
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // using anonimas class 
                        employees.Add(new Employee
                        {// GET data from database reader 
                            // full the model

                            id = (int)reader["Id"],
                            firstName = (String)reader["firstName"],
                            lastName = (String)reader["lastName"],

                        });
                    }

                }
            }
            return employees;

        }


        // Function Add data into dataBase 
        public void AddEmployees(Employee emp)
        {
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Insert into Employees(firstName,lastName) values ('{emp.firstName}','{emp.lastName}');";
                command.ExecuteNonQuery();
            }
        }


        // update function

        public void UpdateEmployees(Employee emp)
        {
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"Update  Employees set firstName ='{emp.firstName}' ,lastName='{emp.lastName}' where Id='{emp.id}';";
                command.ExecuteNonQuery();
            }
        }

        // Delete function
        public void DeleteEmployees(int id)
        {
            using (var connection = factory.CreateConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = $"DELETE FROM Employees WHERE id = { id};";
                command.ExecuteNonQuery();
            }
        }

    }
}

