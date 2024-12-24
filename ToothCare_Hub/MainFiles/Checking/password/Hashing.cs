using System.Security.Cryptography;
using System.Text;

namespace ToothCare_Hub.MainFiles.Checking.password
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
