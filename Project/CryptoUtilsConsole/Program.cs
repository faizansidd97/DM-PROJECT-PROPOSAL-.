using CryptoUtilsConsole.AsymmetricCrypto;


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
         
            // Asymmetric crypto
            RSACspDemo.LaunchDemo();
            RsaFileDemo.LaunchDemo();
            RsaInMemoryDemo.LaunchDemo();
        }
    }
}