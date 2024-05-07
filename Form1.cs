using System.Data.SqlClient;
using System.Diagnostics;
namespace SE308Project
{
    public partial class Form1 : Form
    {
        int userCountA = 0;
        int userCountB = 0;

        public int UserCountA { get => userCountA; set => userCountA = value; }
        public int UserCountB { get => userCountB; set => userCountB = value; }
        string a = "READ UNCOMMITTED";
        string b = "READ COMMITTED";
        string c = "REPEATABLE READ";
        string d = "SERIALIZABLE";
        string connectionString = "Data Source=UMUTCAN\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True;Encrypt=False;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            //UserCountA = Convert.ToInt16(numUserA.Value);
            //UserCountB = Convert.ToInt16(numUserB.Value);

            Thread userA = new Thread(UserA);
            Thread userB = new Thread(UserB);
            
            userA.Start();
            userB.Start();

            MessageBox.Show("Simulation Started!");
        }

        private void UserA()
        {
            //lblUserA.Text = "User A Users: " + UserCountA;
            Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

            using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        for (int i = 0; i < 5; i++)
                        {
                            using (SqlCommand command = connection.CreateCommand())
                            {
                                command.CommandText = $"SET TRANSACTION ISOLATION LEVEL {a}; BEGIN TRANSACTION; " +
                                                      "SELECT SUM(Sales.SalesOrderDetail.OrderQty) FROM Sales.SalesOrderDetail " +
                                                      "WHERE UnitPrice > 100 AND EXISTS (SELECT * FROM Sales.SalesOrderHeader WHERE " +
                                                      "Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                                                      "AND Sales.SalesOrderHeader.OrderDate BETWEEN '20110101' AND '20151231' " +
                                                      "AND Sales.SalesOrderHeader.OnlineOrderFlag = 1); COMMIT TRANSACTION;";
            
                                command.ExecuteNonQuery();
                            }
                        }
                    }
            
                    stopwatch.Stop();
                    Console.WriteLine("Type A transactions completed in: " + stopwatch.Elapsed.TotalSeconds + " seconds" + "\n Isolation Level: " + a);
            //float beginTime = tic();
            //for (int i = 0; i < UserCountA; i++)
            //{

            //}
        }
        private void UserB()
        {
            //lblUserB.Text = "User B Users: " + UserCountB;
            Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();                        
                                    for (int i = 0; i < 5; i++)
                                    {
                                        using (SqlCommand command = connection.CreateCommand())
                                        {

                        command.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; BEGIN TRANSACTION; " +
                   "UPDATE Sales.SalesOrderDetail SET UnitPrice = UnitPrice * 10.0 / 10.0 " +
                   "WHERE UnitPrice > 100 AND EXISTS (SELECT * FROM Sales.SalesOrderHeader WHERE " +
                   "Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                   "AND Sales.SalesOrderHeader.OrderDate BETWEEN '20110101' AND '20151231' " +
                   "AND Sales.SalesOrderHeader.OnlineOrderFlag = 1); COMMIT TRANSACTION;";

                        command.ExecuteNonQuery();
                                        }
                                    }
                                }
                        
                                stopwatch.Stop();
                                Console.WriteLine("Type B transactions completed in: " + stopwatch.Elapsed.TotalSeconds + " seconds" + "\n Isolation Level: " + b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
