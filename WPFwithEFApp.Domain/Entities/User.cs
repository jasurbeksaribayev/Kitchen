using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using WPFwithEFApp.Domain.Commons;

namespace WPFwithEFApp.Domain.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        
        private string HashPassword;
        public string Password
        {
            get { return HashPassword; }
            set
            {
                var sha256 = new SHA256Managed();

                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(value));

                this.HashPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

    }
}
