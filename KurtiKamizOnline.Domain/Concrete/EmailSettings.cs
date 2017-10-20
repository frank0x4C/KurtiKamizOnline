using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtiKamizOnline.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "kurtikamizonline@gmail.com";
        public string MailFromAddress = "kurtikamizonline@gmail.com";
        public bool UseSsl = true;
        public string Username = "kurtikamizonline@gmail.com";
        public string Password = "rxibzplkqnffiaxp"; // Create your own google app password, In the video I have shown you how to create app password.
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
