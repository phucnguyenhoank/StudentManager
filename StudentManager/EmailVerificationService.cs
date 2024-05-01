using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    internal class EmailVerificationService
    {
        private string otp;

        public EmailVerificationService()
        {
            otp = GenerateOTP();
        }

        private static string GenerateOTP()
        {
            return new Random().Next(100000, 999999).ToString();
        }

        // Send OTP to userEmail from address nguyenphuc1234sonhoapy@gmail.com
        public bool SendOTP(string userEmail)
        {
            try
            {
                otp = GenerateOTP();

                // Create the email
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("nguyenphuc1234sonhoapy@gmail.com"),
                    Subject = "Your OTP",
                    Body = $"Your OTP is {otp}"
                };
                mailMessage.To.Add(userEmail);

                // Send the email
                using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new NetworkCredential("nguyenphuc1234sonhoapy@gmail.com", "ositvroljiynzvtv");
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending OTP: {ex.Message}");
                return false;
            }
        }

        public bool VerifyOTP(string userOTP)
        {
            return userOTP == otp;
        }


    }
}
