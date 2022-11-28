using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyExample
{
    public class DESEncrypt
    {
        public static TripleDES CreateDES(string password)
        {
            MD5 mD5 = new MD5CryptoServiceProvider();
            TripleDES dES = new TripleDESCryptoServiceProvider();
            dES.Key = mD5.ComputeHash(Encoding.Unicode.GetBytes(password));
            dES.IV = new byte[dES.BlockSize / 8];
            return dES;
        }

        public string Encrypt(string text, string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            MemoryStream memoryStream = new MemoryStream();
            TripleDES dES = CreateDES(password);
            CryptoStream stream = new CryptoStream(memoryStream, dES.CreateEncryptor(), CryptoStreamMode.Write);
            stream.Write(bytes, 0, bytes.Length);
            stream.FlushFinalBlock();
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        public string Decrypt(string encryptedText, string password)
        {
            byte[] bytes = Convert.FromBase64String(encryptedText);
            MemoryStream stream = new MemoryStream();
            TripleDES dES = CreateDES(password);
            CryptoStream cryptoStream = new CryptoStream(stream, dES.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            return Encoding.Unicode.GetString(stream.ToArray());
        }
    }
}
