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
        private string key;
        private int keySize;
        private string mode;
        private static Aes aes;
        private static byte[] test;

        static Cypher()
        {
            aes = Aes.Create();            
        }

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
            this.key = key;
            this.mode = mode;

            aes.KeySize = this.keySize * 8;
            aes.Key = Encoding.ASCII.GetBytes(key);

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

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = aes.Key;
                aesAlg.IV = aes.IV;
                aesAlg.Mode = aes.Mode;
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

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
                    }
                }
            }
            return Encoding.Unicode.GetString(encrypted);
        }

        public string DecypherMessage()
        {
            string plaintext = null;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = aes.Key;
                aesAlg.IV = aes.IV;
                aesAlg.Mode = aes.Mode;
                //aesAlg.IV = IV;
                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(Encoding.Unicode.GetBytes(message)))
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


        public void Main()
        {
            string original = message;

            // Create a new instance of the Aes
            // class.  This generates a new key and initialization
            // vector (IV).
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = Encoding.ASCII.GetBytes(key);
                // Encrypt the string to an array of bytes.
                byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);

                //myAes.Key = Encoding.ASCII.GetBytes("Thats my Kung Fu");
                // Decrypt the bytes to a string.
                string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                //Display the original data and the decrypted data.
                Console.WriteLine("Original:   {0}", original);
                Console.WriteLine("Round Trip: {0}", roundtrip);
            }
        }
        private byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();

                        string test = BitConverter.ToString(encrypted).Replace("-", " ");
                        Console.WriteLine(test);
                        /*
                        foreach(byte b in encrypted)
                        {
                            
                            Console.Write(b + " ");
                        }
                        Console.WriteLine();*/
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        private string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            //string cyphered = ASCIIEncoding.
            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
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
