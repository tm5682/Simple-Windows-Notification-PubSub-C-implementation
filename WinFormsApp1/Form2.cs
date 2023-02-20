using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
  
    public partial class Form2 : Form
    {

        public string WhatNotificationType;
        public string NotificationNumberOrEmail;

        NotificationManager notificationManager = new NotificationManager();


        Subscriber subscriber = new Subscriber();

        public Form2()
        {
            InitializeComponent();
            label3.Text = "Email List " + notificationManager.emailSubscribers.ToString();
            label4.Text = "Mobile List" + notificationManager.mobileSubscribers.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                WhatNotificationType = "Email";

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                WhatNotificationType = "Mobile";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NotificationNumberOrEmail = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            NotificationNumberOrEmail = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                subscriber.ValidateEmail(textBox1.Text);
                if (subscriber.ValidateEmail(textBox1.Text) == false)
                {
                    label1.Text = "Not Valid Email Address";
                }
                else
                {
                    label1.Text = " Valid Email";

                    // Add the new subscriber to the emailSubscribers list
                    notificationManager.emailSubscribers.Add(textBox1.Text);
                }

            }


            if (checkBox2.Checked)
            {
                subscriber.ValidateMobile(textBox2.Text);
                if (subscriber.ValidateMobile(textBox2.Text) == false)
                {
                    label2.Text = "Not Valid Mobile";
                }
                else
                {
                    label2.Text = " Valid Mobile";
                    notificationManager.mobileSubscribers.Add(textBox2.Text);
                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                subscriber.Unsubscribe(textBox1.Text, textBox2.Text);
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Email List " + notificationManager.emailSubscribers.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Mobile List" + notificationManager.mobileSubscribers.ToString();
        }

       



    }



}
