using CryptographyExample;
using System;

namespace EncryptionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "TEST TEST (AAAAA) SI 12345";
            string password = "@eaaght";
            Console.WriteLine($"{text}\n");
            DESEncrypt encrypt = new DESEncrypt();
            string encryptedText = encrypt.Encrypt(text, password);
            Console.WriteLine($"TEXTO ENCRIPTADO: {encryptedText}\n");
            string decryptedText = encrypt.Decrypt(encryptedText, password);
            Console.WriteLine($"TEXTO DESENCRIPTADO: {decryptedText}\n");
            Console.ReadLine();
        }
    }
}
