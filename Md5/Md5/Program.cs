using System;
using System.Security.Cryptography;
using System.Text;

namespace Md5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(new Program().getMd5Hash("Dhiman"));

            // dummy code - ignore
            string compare1 = new Program().getMd5Hash("Dhiman");
            string compare2 = new Program().getMd5Hash("Dhiman");
            Console.WriteLine(string.Compare(compare1, compare2));

            PasswordValidation passwordValidation = new PasswordValidation();
            Console.WriteLine(passwordValidation.isValidPasswordPattern("Admin"));
         
        }

        // This function converts password to md5 string
        private string getMd5Hash(string password) {
            MD5 md5 = MD5.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytesOfPassword = md5.ComputeHash(passwordBytes);
            string hashStringOfPassword = Encoding.UTF8.GetString(hashBytesOfPassword);

            return hashStringOfPassword;

        }
    }

}
