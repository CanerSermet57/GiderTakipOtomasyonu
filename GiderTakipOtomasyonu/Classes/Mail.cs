﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GiderTakipOtomasyonu
{
    class Mail
    {
        public Mail(string senderMail, string senderPassword)
        {
            this.senderMail = senderMail;
            this.senderPassword = senderPassword;
        }
        private string senderMail;
        private string senderPassword;

        public MailMessage mailRecipientAdd(List<string> recipientList, MailMessage mail)
        {
            foreach (var item in recipientList)
            {
                mail.To.Add(item);
            }
            return mail;
        }
        public MailMessage mailSubjectAdd(string subject, MailMessage mail)
        {
            mail.Subject = subject;
            return mail;
        }
        public MailMessage mailBodyAdd(string body, MailMessage mail)
        {
            mail.Body = body;
            return mail;
        }
        public MailMessage mailAttachmentAdd(Attachment atach, MailMessage mail)
        {
            mail.Attachments.Add(atach);
            return mail;
        }

        public void sendMail(MailMessage mail)
        {
            mail.From = new MailAddress(senderMail);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(senderMail, senderPassword);
            smtp.EnableSsl = true;
            smtp.SendAsync(mail, (object)mail);
        }

        public void sendExample(string senderMail, string senderPassword)
        {
            Mail mail = new Mail(senderMail,senderPassword);
            MailMessage mailMessage = new MailMessage();
            mailMessage = mail.mailBodyAdd("This Is EXAMPLE MAIL", mailMessage);
            mailMessage = mail.mailSubjectAdd("Example MAIL", mailMessage);
            List<string> RecipientList = new List<string>();
            RecipientList.Add(senderMail);
            mailMessage = mail.mailRecipientAdd(RecipientList, mailMessage);
            mail.sendMail(mailMessage); //Dont forget to accept 3rd party send 
        }

    }
}
