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
            //hashing with all
            HmacMD5Demos.LaunchDemo();
            HmacSHA1Demos.LaunchDemo();
            Md5Demos.LaunchDemo();
            Sha1Demos.LaunchDemo();
            Sha256Demos.LaunchDemo();
            Sha512Demos.LaunchDemo();

            //// Symmetric crypto
            AESDemos.LaunchDemo();
            DESDemos.LaunchDemo();
            DESDemos.LaunchFileDemo();
            TripleDESDemos.LaunchDemo();


            // Asymmetric crypto and Euclidean with RSA
            RSACspDemo.LaunchDemo();
            RsaFileDemo.LaunchDemo();
            RsaInMemoryDemo.LaunchDemo();
            EuclideanExtended.LaunchDemo();
            //comment
            
        }
    }
}
