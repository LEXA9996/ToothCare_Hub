using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ToothCare_Hub.MainFiles
{
    public class Hashing
    {
        public string Hash(string input)
        {
            using (var cha128 = SHA1.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = cha128.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hash);
            }
        }
        public bool Verify(string password, string hashedPassword)
        {
            string hashedInputPassword = Hash(password);
            return hashedInputPassword == hashedPassword;
        }
    }
}
