
using CryptoUtilsConsole.symmetric_crypto;

namespace CryptoUtilsConsole
{
    public enum CryptoOperation
    {
        ENCRYPT,
        DECRYPT
    };

    class Program
    {
        static void Main(string[] args)
        {
          

            //// Symmetric crypto
             AESDemos.LaunchDemo();
            DESDemos.LaunchDemo();
            DESDemos.LaunchFileDemo();
            TripleDESDemos.LaunchDemo();


           
        }
    }
}