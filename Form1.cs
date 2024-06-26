using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Diagnostics;
namespace SE308Project
{
    public partial class Form1 : Form
    {
        int userCountA = 0;
        int userCountB = 0;

        bool simulationAlreadyStarted = false;

        int userACompletedCount = 0;
        int userBCompletedCount = 0;
        object lockObj = new object();
        int deadlockCountA;
        int deadlockCountB;

        public int UserCountA { get => userCountA; set => userCountA = value; }
        public int UserCountB { get => userCountB; set => userCountB = value; }
        public int DeadlockCountA { get => deadlockCountA; set => deadlockCountA = value; }
        public int DeadlockCountB { get => deadlockCountB; set => deadlockCountB = value; }

        string connectionString = "Data Source=UGUROGUZHANPC;Initial Catalog=AdventureWorks2012;Integrated Security=True;Encrypt=False; Connect Timeout=999;";
        //string connectionString = "Data Source=UMUTCAN\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True Connect Timeout=999";
        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Fixes thread error
            cmb_Isolation.SelectedIndex = 0;
            stopwatch = new Stopwatch();
            timer.Stop();
        }
        private void btnStartSim_Click(object sender, EventArgs e)
        {
            if (simulationAlreadyStarted == true)
            {
                Application.Restart();
            }
            else
            {
                txt_EventLog.ResetText();
                UserCountA = Convert.ToInt16(numUserA.Value);
                UserCountB = Convert.ToInt16(numUserB.Value);

                txt_EventLog.AppendText("Isolation Level: " + cmb_Isolation.SelectedItem + "\n");

                Thread[] userAThreads = new Thread[UserCountA];
                Thread[] userBThreads = new Thread[UserCountB];

                for (int i = 0; i < userAThreads.Length; i++)
                {
                    userAThreads[i] = new Thread(() => UserA(ref userACompletedCount, lockObj));
                    userAThreads[i].Start();
                }
                for (int i = 0; i < userBThreads.Length; i++)
                {
                    userBThreads[i] = new Thread(() => UserB(ref userBCompletedCount, lockObj));
                    userBThreads[i].Start();
                }


                stopwatch.Start();
                timer.Start();

                txt_EventLog.AppendText("Transaction Started!\n");
                txt_EventLog.AppendText("Type A Users: " + UserCountA + "\n");
                txt_EventLog.AppendText("Type B Users: " + UserCountB + "\n");

                Thread[] mergedArray = userAThreads.Concat(userBThreads).ToArray();
                foreach (var thread in mergedArray)
                {
                    thread.Join();
                }

                stopwatch.Stop();
                txt_EventLog.AppendText("Transaction Finished!\n");
                txt_EventLog.AppendText("Type A User Deadlocks: " + DeadlockCountA + "\n");
                txt_EventLog.AppendText("Type B User Deadlocks: " + DeadlockCountB + "\n");
                txt_EventLog.AppendText("Finish Time: " + string.Format("{0:mm\\:ss}", stopwatch.Elapsed) + " seconds" + "\n");
                stopwatch.Reset();
                timer.Stop();
                simulationAlreadyStarted = true;
                btnStartSim.Text = "Restart Application";
            }
        }

        private void UserA(ref int userACompleteCount, object lockObj)
        {
            Random random = new Random();
            float randomNum = random.NextSingle();
            int date = 0;

            if (randomNum < 0.2)
                date = 1;
            else if (randomNum < 0.4)
                date = 2;
            else if (randomNum < 0.6)
                date = 3;
            else if (randomNum < 0.8)
                date = 4;
            else if (randomNum < 1)
                date = 5;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"SET TRANSACTION ISOLATION LEVEL {cmb_Isolation.Text}; BEGIN TRANSACTION; " +
                                              "UPDATE Sales.SalesOrderDetail SET UnitPrice = UnitPrice * 10.0 / 10.0 " +
                                              "WHERE UnitPrice > 100 AND EXISTS (SELECT * FROM Sales.SalesOrderHeader WHERE " +
                                              "Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                                              $"AND Sales.SalesOrderHeader.OrderDate BETWEEN '201{date}0101' AND '201{date}1231' " +
                                              "AND Sales.SalesOrderHeader.OnlineOrderFlag = 1); COMMIT TRANSACTION;";
                        command.CommandTimeout = 999;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    //Catches deadlocks
                    if (ex.Message.Contains("deadlocked"))
                    {
                        DeadlockCountA++;
                    }
                }
                finally
                {
                    lock (lockObj)
                    {
                        userACompletedCount++;
                    }

                    if (userACompletedCount == UserCountA)
                    {
                        txt_EventLog.AppendText("Type A transactions completed in: " + string.Format("{0:mm\\:ss}", stopwatch.Elapsed) + " seconds\n");
                    }
                }
            }
        }

        private void UserB(ref int userBCompleteCount, object lockObj)
        {
            Random random = new Random();
            float randomNum = random.NextSingle();
            int date = 0;

            if (randomNum < 0.2)
                date = 1;
            else if (randomNum < 0.4)
                date = 2;
            else if (randomNum < 0.6)
                date = 3;
            else if (randomNum < 0.8)
                date = 4;
            else if (randomNum < 1)
                date = 5;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"SET TRANSACTION ISOLATION LEVEL {cmb_Isolation.Text}; BEGIN TRANSACTION; " +
                                              "SELECT SUM(Sales.SalesOrderDetail.OrderQty) FROM Sales.SalesOrderDetail " +
                                              "WHERE UnitPrice > 100 AND EXISTS (SELECT * FROM Sales.SalesOrderHeader WHERE " +
                                              "Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                                              $"AND Sales.SalesOrderHeader.OrderDate BETWEEN '201{date}0101' AND '201{date}1231' " +
                                              "AND Sales.SalesOrderHeader.OnlineOrderFlag = 1); COMMIT TRANSACTION;";
                        command.CommandTimeout = 999;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    //Catches deadlocks
                    if (ex.Message.Contains("deadlocked"))
                    {
                        DeadlockCountB++;
                    }
                }
                finally
                {
                    lock (lockObj)
                    {
                        userBCompletedCount++;
                    }

                    if (userBCompletedCount == UserCountB)
                    {
                        txt_EventLog.AppendText("Type B transactions completed in: " + string.Format("{0:mm\\:ss}", stopwatch.Elapsed) + " seconds\n");
                    }
                }
            }
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
