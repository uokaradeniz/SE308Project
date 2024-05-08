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

        //string connectionString = "Data Source=UGUROGUZHANPC\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True;Encrypt=False;";
        string connectionString = "Data Source=UMUTCAN\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True";
        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            cmb_Isolation.SelectedIndex = 0;
            stopwatch = new Stopwatch();
        }
        private void btnStartSim_Click(object sender, EventArgs e)
        {
            UserCountA = Convert.ToInt16(numUserA.Value);
            UserCountB = Convert.ToInt16(numUserB.Value);

            txt_EventLog.AppendText("Isolation Level: " + cmb_Isolation.SelectedItem + "\n");

            Thread userA = new Thread(UserA);
            Thread userB = new Thread(UserB);

            stopwatch.Start();
            timer.Enabled = true;
            userA.Start();
            userB.Start();

            txt_EventLog.AppendText("Transaction Started!\n");
        }

        private void UserA()
        {
            
            txt_EventLog.AppendText("User A Users: " + UserCountA + "\n");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); 
                for (int i = 0; i < 2; i++)
               {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; BEGIN TRANSACTION; " +
                                              "SELECT SUM(Sales.SalesOrderDetail.OrderQty) FROM Sales.SalesOrderDetail " +
                                              "WHERE UnitPrice > 100 AND EXISTS (SELECT * FROM Sales.SalesOrderHeader WHERE " +
                                              "Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                                              "AND Sales.SalesOrderHeader.OrderDate BETWEEN '20110101' AND '20151231' " +
                                              "AND Sales.SalesOrderHeader.OnlineOrderFlag = 1); COMMIT TRANSACTION;";

                        command.ExecuteNonQuery();
                    }
                }
            }

            txt_EventLog.AppendText("Type A transactions completed in: " + string.Format("{0:mm\\:ss}", stopwatch.Elapsed) + " seconds" + "\n");

        }

        private void UserB()
        {
            txt_EventLog.AppendText("User B Users: " + UserCountB + "\n");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                for (int i = 0; i < 2; i++)
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

            txt_EventLog.AppendText("Type B transactions completed in: " + string.Format("{0:mm\\:ss}", stopwatch.Elapsed) + " seconds\n");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txt_EventLog.HideSelection = false;
            txt_EventLog.AppendText(string.Format("Elapsed time: " + string.Format("{0:mm\\:ss}", stopwatch.Elapsed) + " seconds\n"));
        }
    }
}
