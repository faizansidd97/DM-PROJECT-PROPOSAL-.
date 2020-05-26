using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoUtilsConsole.hashing
{
    class Sha1Demos
    {
        public static byte[] GetSHA1(string message)
        {
            using (var sha1 = SHA1.Create())
            {
                byte[] computedHash = sha1.ComputeHash(Encoding.UTF8.GetBytes(message));
                return computedHash;
            }
        }

        public static string GetSHA1Str(string message)
        {
            byte[] hashed = GetSHA1(message);
            string result = BitConverter.ToString(hashed).Replace("-", "");
            return result;
        }

        public static void LaunchDemo()
        {
            Console.WriteLine("Enter SHA 1 Demo Variable");
            string message = Console.ReadLine();
            Console.WriteLine("SHA1 : " + GetSHA1Str(message));
        }
    }
}
