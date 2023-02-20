namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        NotificationManager notificationManager = new NotificationManager();



        public Form1()
        {
            InitializeComponent();
            if (notificationManager.mobileSubscribers.Count == 0 && notificationManager.emailSubscribers.Count == 0)
            {
                Publish_Notification.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Publish_Notification_Click(object sender, EventArgs e)
        {

           
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}