using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WinFormsApp1;

List<Subscriber> emailSubscribers = new List<Subscriber>();
List<Subscriber> mobileSubscribers = new List<Subscriber>();

namespace WinFormsApp1
{
    public class Subscriber
    {
        public string Email { get; set; }
        public string Mobile { get; set; }


        public delegate void SendViaEmail(string email, string message);
        public delegate void SendViaMobile(string mobile, string message);

        private void Subscribe(string email, string mobile)
        {
            bool isEmailValid = ValidateEmail(email);
            bool isMobileValid = ValidateMobile(mobile);

            if (!isEmailValid || !isMobileValid)
            {
                MessageBox.Show("Invalid email or mobile number.");
                return;
            }

            if (emailSubscribers.Any(s => s.Email == email) || mobileSubscribers.Any(s => s.Mobile == mobile))
            {
                MessageBox.Show("You have already subscribed.");
                return;
            }

            if (isEmailValid)
            {
                emailSubscribers.Add(new Subscriber { Email = email });
            }

            if (isMobileValid)
            {
                mobileSubscribers.Add(new Subscriber { Mobile = mobile });
            }
        }

        private void Unsubscribe(string email, string mobile)
        {
            if (emailSubscribers.Remove(emailSubscribers.FirstOrDefault(s => s.Email == email)))
            {
                MessageBox.Show("You have been unsubscribed from email notification.");
            }

            if (mobileSubscribers.Remove(mobileSubscribers.FirstOrDefault(s => s.Mobile == mobile)))
            {
                MessageBox.Show("You have been unsubscribed from mobile notification.");
            }
        }

        private void SendNotification(string message)
        {
            foreach (var subscriber in emailSubscribers)
            {
                SendViaEmail?.Invoke(subscriber.Email, message);
            }

            foreach (var subscriber in mobileSubscribers)
            {
                SendViaMobile?.Invoke(subscriber.Mobile, message);
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