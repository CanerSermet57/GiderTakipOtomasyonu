using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu
{
    public partial class SifreSıfırlama : Form
    {
        public SifreSıfırlama()
        {
            InitializeComponent();
        }

        private void FormClossing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private string randomPasswordResetKey = "";
        private bool SendingOrChecking = true;
        Forms.SifreGüncelle sifre = new Forms.SifreGüncelle();

        private void button1_Click(object sender, EventArgs e)
        {
            if (SendingOrChecking)
            {
                if (sendPasswordResetMail())
                {
                    sifre.mail = textBox1.Text;
                    label1.Text = "Doğrulama Kodu";
                    button1.Text = "Doğrula";
                    textBox1.Text = "";
                    SendingOrChecking = false;
                }
                else
                {
                    MessageBox.Show("Mail Gönderme Başarısız Oldu");
                }
            }
            else
            {
                if (textBox1.Text == randomPasswordResetKey)
                {
                    SendingOrChecking = true;                                     
                    sifre.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Doğrulama Kodunu Yanlış Girdiniz");
                    textBox1.Text = "";
                }
            }
            
        }

        public bool sendPasswordResetMail()
        {
            string DogrulamaKodu = randomPasswordResetKeyCreate();
            Mail mail = new Mail("gtpproje@hotmail.com", "1.Gtoproje");
            MailMessage mailMessage = new MailMessage();
            mailMessage = mail.BodyAdd("Bu mail Gider Takip Otomasyon Şifrenizi Sıfırlamak İçin Gönderilmiştir\n" +
                "Eğer bu isteği siz yapmadıysanız herhangi bir işlem yapmanıza gerek yoktur\n\n" +
                "Doğrulama Kodunuz : " + DogrulamaKodu + "\n Doğrulama kodunu başkasıyla lütfen paylaşmayın", mailMessage);
            mailMessage = mail.SubjectAdd("Şifre Sıfırlama Doğrulama Kodunuz", mailMessage);
            try
            {
                mailMessage = mail.RecipientAdd(textBox1.Text, mailMessage);
                try
                {
                    mail.sendMail(mailMessage);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mail Adresi Geçersiz");
                return false;
            }            
        }


        public string randomPasswordResetKeyCreate()
        {
            randomPasswordResetKey = DateTime.Now.ToString() + ":" + DateTime.Now.Millisecond.ToString();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(randomPasswordResetKey);
            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
            randomPasswordResetKey = Convert.ToBase64String(SHA256.Create().ComputeHash(passwordBytes));
            return randomPasswordResetKey;
        }

        private void SifreSıfırlama_Load(object sender, EventArgs e)
        {

        }
    }
}
