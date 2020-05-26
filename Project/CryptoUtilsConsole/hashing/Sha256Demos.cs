using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoUtilsConsole.hashing
{
    class Sha256Demos
    {
        public static byte[] GetHash256(string message)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] computedHas = sha256.ComputeHash(Encoding.UTF8.GetBytes(message));
            return computedHas;
        }

        public static string GetHash256Str(string message)
        {
            byte[] hashed = GetHash256(message);
            string result = BitConverter.ToString(hashed).Replace("-", "");
            return result;
        }

        public static void LaunchDemo()
        {
            Console.WriteLine("Enter SHA 256 Demo Variable");
            string message = Console.ReadLine();
          
            Console.WriteLine("SHA256 : " + GetHash256Str(message));
        }
    }
}
