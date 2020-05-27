using System;
using System.Security.Cryptography;
using System.Text;

namespace CryptoUtilsConsole.hashing
{
    class Md5Demos
    {
        public static string Md5_convertstr(string str)
        {
            MD5 hash = MD5.Create();
            byte[] h = hash.ComputeHash(Encoding.Unicode.GetBytes(str));

            StringBuilder sb = new StringBuilder();
            foreach (byte b in h)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        public static string GetMd5_Converter(string message)
        {
            using (var md5 = MD5.Create())
            {
                byte[] hashmeHashed = md5.ComputeHash(Encoding.UTF8.GetBytes(message));
                string result = BitConverter.ToString(hashmeHashed).Replace("-", "");
                return result;
            }
        }

        public static void LaunchDemo()

        {
            Console.WriteLine("");
            Console.WriteLine(" MD5 HASH RUNNING ");
            Console.WriteLine("_________________________");

            //input le rha hai yyaha

            Console.WriteLine("INPUT HERE :");
            Console.WriteLine("");

            string message = Console.ReadLine();

            // yaha convert krega md5 m
            string result1=GetMd5_Converter(message);

            Console.WriteLine("MD5 : " + result1);

            //yaha lower wagera krega md5 convert hojany ke bd or size same append.


            string result2=Md5_convertstr(message);

            Console.WriteLine("MD5 : " + result2);

            Console.WriteLine("------------------");

            Console.ReadKey();
        }
    }
}
