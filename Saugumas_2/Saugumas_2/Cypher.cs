using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Saugumas_2
{
    class Cypher
    {
        private string message;
        private int keySize;
        private static Aes aes;
        private static byte[] test;

        public Cypher(string message, string key, string keySize, string mode)
        {
            if (String.IsNullOrEmpty(message))
                throw new Exception("Message field cannot be empty");
            if (String.IsNullOrEmpty(key))
                throw new Exception("Key field cannot be empty");
            if (String.IsNullOrEmpty(keySize))
                throw new Exception("Key size unspecified");
            if (String.IsNullOrEmpty(mode))
                throw new Exception("Cypher mode unspecifies");

            this.keySize = Convert.ToInt32(keySize);
            if (key.Length != this.keySize)
                throw new Exception("Key size doesn't match specified size");

            this.message = message;

            aes = Aes.Create(); 
            aes.KeySize = this.keySize * 8;
            aes.Key = Encoding.ASCII.GetBytes(key);
            aes.IV = Encoding.Unicode.GetBytes("01234567");
            aes.Padding = PaddingMode.PKCS7;

            if (mode == "ECB")
                aes.Mode = CipherMode.ECB;
            else
            {
                aes.Mode = CipherMode.CBC;
            }
        }

        public string CypherMessage()
        {
            byte[] encrypted;

            using (aes)
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(message);
                        }
                        encrypted = msEncrypt.ToArray();
                        test = encrypted;
                    }
                }
            }
            return Encoding.Unicode.GetString(encrypted);
        }

        public string DecypherMessage()
        {
            string plaintext = null;
            using (aes)
            {
                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(/*test*/Encoding.Unicode.GetBytes(message)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}
