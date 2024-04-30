
namespace SE308Project
{
    public partial class Form1 : Form
    {
        int userCountA = 0;
        int userCountB = 0;

        public int UserCountA { get => userCountA; set => userCountA = value; }
        public int UserCountB { get => userCountB; set => userCountB = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            UserCountA = Convert.ToInt16(numUserA.Value);
            UserCountB = Convert.ToInt16(numUserB.Value);

            Thread userA = new Thread(UserA);
            Thread userB = new Thread(UserB);

            userA.Start();
            userB.Start();

            MessageBox.Show("Simulation Started!");
        }

        void UserA()
        {
            lblUserA.Text = "User A Users: " + UserCountA;
            //float beginTime = tic();
            //for (int i = 0; i < UserCountA; i++)
            //{

            //}
        }
        void UserB()
        {
            lblUserB.Text = "User B Users: " + UserCountB;
            //float beginTime = tic();
            //for (int i = 0; i < UserCountB; i++)
            //{

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
