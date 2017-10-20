using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtiKamizOnline.Domain.Entities
{
    public class User
    {
        public string UserId { get; set; } //If you use any othername, you have to use [Key] attribute, meaning it is a pk
        public string Password { get; set; }
    }
}
