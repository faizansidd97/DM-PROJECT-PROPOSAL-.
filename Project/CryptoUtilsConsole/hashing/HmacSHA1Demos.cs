using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoUtilsConsole.hashing
{
    class HmacSHA1Demos
    {

        public static byte[] getHMACSHA1(string message)
        {
            using (var randonNumberGenerator = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[32];
                randonNumberGenerator.GetBytes(key);
                Console.WriteLine("HMAC : " + BitConverter.ToString(key).Replace("-", ""));
                using (var hmacsha1 = new HMACSHA1(key))
                {
                    byte[] hashmeHashed = hmacsha1.ComputeHash(Encoding.UTF8.GetBytes(message));
                    return hashmeHashed;
                }
            }
        }
        
  
        public static void LaunchDemo()
        {
            Console.WriteLine("");

            Console.WriteLine(" Hmac SHA1 HASH RUNNING ");
            Console.WriteLine("_________________________");

            Console.WriteLine("INPUT HERE :");
            Console.WriteLine("");

            string message = Console.ReadLine();
            byte[] hashmeHashed = getHMACSHA1(message);


            string result = BitConverter.ToString(hashmeHashed).Replace("-", "");
            Console.WriteLine("SHA1 : " + result);

            Console.WriteLine("---------------");
          
            
        }

    }
}
