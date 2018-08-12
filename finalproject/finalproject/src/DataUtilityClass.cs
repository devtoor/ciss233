using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace finalproject
{
    public static class DataUtilityClass
    {
        private static SqlConnection _conn;

        private static void ConnectToDb()
        {
            _conn = new SqlConnection
            {
                ConnectionString =
                    "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\appdb.mdf;Integrated Security=True"
            };
            _conn.Open();
        }

        private static void CloseDbConn()
        {
            _conn?.Close();
        }

        public static int SelectCustomerCount()
        {
            var count = 0;
            try
            {
                ConnectToDb();
                const string sql = "SELECT COUNT(*) FROM Customer";
                var command = new SqlCommand(sql, _conn);
                var reader = command.ExecuteReader();
                if (reader.Read())
                    count = Convert.ToInt32(reader[0]);
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            CloseDbConn();
            return count;
        }

        public static int SelectOrderCount()
        {
            var count = 0;
            try
            {
                ConnectToDb();
                const string sql = "SELECT COUNT(*) FROM Orders";
                var command = new SqlCommand(sql, _conn);
                var reader = command.ExecuteReader();
                if (reader.Read())
                    count = Convert.ToInt32(reader[0]);
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            CloseDbConn();
            return count;
        }

        public static IEnumerable<Customer> SelectAllCustomers()
        {
            var listOfCustomers = new List<Customer>();
            try
            {
                ConnectToDb();
                const string sql = "SELECT * From Customer";
                var command = new SqlCommand(sql, _conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listOfCustomers.Add(new Customer (
                        Convert.ToInt32(reader["Id"]),
                        reader["first"].ToString(),
                        reader["last"].ToString(),
                        reader["street"].ToString(),
                        reader["city"].ToString(),
                        reader["state"].ToString(),
                        reader["zip"].ToString(),
                        reader["phone"].ToString(), 
                        reader["phonetype"].ToString()));
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                listOfCustomers = null;
            }
            CloseDbConn();
            return listOfCustomers;
        }

        public static List<Order> SelectAllOrders()
        {
            var listOfOrders = new List<Order>();
            try
            {
                ConnectToDb();
                const string sql = "SELECT * From Orders";
                var command = new SqlCommand(sql, _conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listOfOrders.Add(new Order(
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToInt32(reader["custId"]),
                        reader["orderdate"].ToString(),
                        reader["ordertime"].ToString(),
                        Convert.ToInt32(reader["prod1Qty"]),
                        Convert.ToInt32(reader["prod2Qty"]),
                        Convert.ToInt32(reader["prod3Qty"]),
                        Convert.ToInt32(reader["prod4Qty"]),
                        Convert.ToInt32(reader["prod5Qty"]),
                        Convert.ToInt32(reader["prod6Qty"]),
                        Convert.ToDecimal(reader["subtotal"]),
                        Convert.ToDecimal(reader["taxAmt"]),
                        Convert.ToDecimal(reader["grandtotal"])));
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                listOfOrders = null;
            }
            CloseDbConn();
            return listOfOrders;
        }

        public static Customer SelectCustomerById(int id)
        {
            Customer customer = null;
            try
            {
                ConnectToDb();
                var sql = "SELECT * FROM Customer WHERE Id=" + id;
                var command = new SqlCommand(sql, _conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    customer = new Customer(
                        Convert.ToInt32(reader["Id"]),
                        reader["first"].ToString(),
                        reader["last"].ToString(),
                        reader["street"].ToString(),
                        reader["city"].ToString(),
                        reader["state"].ToString(),
                        reader["zip"].ToString(),
                        reader["phone"].ToString(),
                        reader["phonetype"].ToString());
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            CloseDbConn();
            return customer;
        }

        public static Order SelectOrderById(int id)
        {
            Order order = null;
            try
            {
                ConnectToDb();
                var sql = "SELECT * FROM Orders WHERE Id=" + id;
                var command = new SqlCommand(sql, _conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    order = new Order(
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToInt32(reader["custId"]),
                        reader["orderdate"].ToString(),
                        reader["ordertime"].ToString(),
                        Convert.ToInt32(reader["prod1Qty"]),
                        Convert.ToInt32(reader["prod2Qty"]),
                        Convert.ToInt32(reader["prod3Qty"]),
                        Convert.ToInt32(reader["prod4Qty"]),
                        Convert.ToInt32(reader["prod5Qty"]),
                        Convert.ToInt32(reader["prod6Qty"]),
                        Convert.ToDecimal(reader["subtotal"]),
                        Convert.ToDecimal(reader["taxAmt"]),
                        Convert.ToDecimal(reader["grandtotal"]));
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            CloseDbConn();
            return order;
        }

        public static void InsertCustomer(Customer customer)
        {
            try
            {
                ConnectToDb();
                var sql = "INSERT INTO Customer (first, last, street, city, state, zip, phone, phonetype) VALUES (" +
                    "'" + customer.First + "', " +
                    "'" + customer.Last + "', " +
                    "'" + customer.Street + "', " +
                    "'" + customer.City + "', " +
                    "'" + customer.State + "', " +
                    "'" + customer.Zip + "', " +
                    "'" + customer.Phone + "', " +
                    "'" + customer.PhoneType + "')";
                var command = new SqlCommand(sql, _conn);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            CloseDbConn();
        }

        public static void InsertOrder(Order order)
        {
            var subtotal = order.SubTotal;
            try
            {
                ConnectToDb();
                var sql = "INSERT INTO Orders (custId, orderdate, ordertime, prod1Qty, prod2Qty, prod3Qty, prod4Qty, prod5Qty, prod6Qty, subtotal, taxAmt, grandtotal) VALUES (" +
                    + order.CustId + ", " +
                    "'" + order.OrderDate + "', " +
                    "'" + order.OrderTime + "', " +
                    order.Prod1Qty + ", " +
                    order.Prod2Qty + ", " +
                    order.Prod3Qty + ", " +
                    order.Prod4Qty + ", " +
                    order.Prod5Qty + ", " +
                    order.Prod6Qty + ", " +
                    subtotal.ToString("F") + ", " +
                    order.TaxAmt.ToString("F") + ", " +
                    order.GrandTotal.ToString("F") + ")";
                var command = new SqlCommand(sql, _conn);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            CloseDbConn();
        }
    }
}