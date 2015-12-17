namespace SecurityDemo
{
    using System;
    using System.Security.Cryptography;

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Convert.ToBase64String(GenerateRandomNumber(32)));
            }
            Console.ReadLine();
        }

        public static byte[] GenerateRandomNumber(int length)
        {
            using (var randomGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                randomGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }
    }
}
