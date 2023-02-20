using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WinFormsApp1;



namespace WinFormsApp1
{
    using System.Collections.Generic;

    public class NotificationManager
    {
        public List<string> emailSubscribers = new List<string>();
        public List<string> mobileSubscribers = new List<string>();
    }


    public class Subscriber
    {
        NotificationManager notificationManager = new NotificationManager();
        public string notificationLabel;

        public string Email { get; set; } 
        public string Mobile { get; set; }
 


        //public delegate void SendViaEmail(string email, string message);
        //public delegate void SendViaMobile(string mobile, string message);
        private void SendViaEmail(string message, List<string> subscribers)
        {
            string subscriberList = string.Join(", ", subscribers.Select(subscriber => subscriber));
            //notificationLabel.Text = $"Email sent to: {subscriberList}\nMessage: {message}";
        }

        private void SendViaMobile(string message, List<string> subscribers)
        {
            string subscriberList = string.Join(", ", subscribers.Select(subscriber => subscriber));
            //notificationLabel.Text = $"Text message sent to: {subscriberList}\nMessage: {message}";
        }

        public void Subscribe(string email, string mobile)
        {
            bool isEmailValid = ValidateEmail(email);
            bool isMobileValid = ValidateMobile(mobile);

            if (!isEmailValid || !isMobileValid)
            {
                MessageBox.Show("Invalid email or mobile number.");
                return;
            }

            if (notificationManager.emailSubscribers.Any(s => s == email) || notificationManager.mobileSubscribers.Any(s => s == mobile))
            {
                MessageBox.Show("You have already subscribed.");
                return;
            }

            if (isEmailValid)
            {
                notificationManager.emailSubscribers.Add(email);
            }

            if (isMobileValid)
            {
                notificationManager.mobileSubscribers.Add(mobile);
            }
        }

        public void Unsubscribe(string email, string mobile)
        {
            if (notificationManager.emailSubscribers.Remove(notificationManager.emailSubscribers.FirstOrDefault(s => s == email)))
            {
                MessageBox.Show("You have been unsubscribed from email notification.");
            }

            if (notificationManager.mobileSubscribers.Remove(notificationManager.mobileSubscribers.FirstOrDefault(s => s == mobile)))
            {
                MessageBox.Show("You have been unsubscribed from mobile notification.");
            }
        }

        public void SendNotification(string message)
        {
            foreach (var subscriber in notificationManager.emailSubscribers)
            {
                SendViaEmail(message, notificationManager.emailSubscribers);
            }

            foreach (var subscriber in notificationManager.mobileSubscribers)
            {
                SendViaMobile(message, notificationManager.mobileSubscribers);
            }
        }


        //to validate emails
        public bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //to validate mobile number
        public bool ValidateMobile(string mobile)
        {
            Regex regex = new Regex(@"^(\+[0-9]{1,3})?[-\s]?(\([0-9]{1,4}\)|[0-9]{1,4})[-\s]?[0-9]{3,4}[-\s]?[0-9]{3,4}$");
            return regex.IsMatch(mobile);
        }

    

    }

}