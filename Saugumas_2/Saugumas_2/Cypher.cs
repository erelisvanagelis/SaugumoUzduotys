using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saugumas_2
{
    class Cypher
    {
        private string message;
        private string key;

        public Cypher(string message, string key)
        {
            if (String.IsNullOrEmpty(message))
                throw new Exception("Message field cannot be empty");
            if (String.IsNullOrEmpty(key))
                throw new Exception("Key field cannot be empty");
            this.message = message;
            this.key = key;
        }

        public string CypherMessage()
        {
            string cyphered = "";
            int keyPosition = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (keyPosition >= key.Length)
                    keyPosition = 0;

                int number = (int)message[i];
                Console.WriteLine($"message character {message[i]} number in ASCII {number}");
                number += (int)key[keyPosition];
                Console.WriteLine($"key character {key[keyPosition]} number in ASCII {(int)key[keyPosition]}");
                number %= 256;

                cyphered += (char)number;
                Console.WriteLine($"cyphered message character {(char) number} number in ASCII {number}");
                Console.WriteLine($"cyphered message so far " + cyphered);

                keyPosition++;
            }

            return cyphered;
        }

        public string DecypherMessage()
        {
            string decyphered = "";
            int keyPosition = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (keyPosition >= key.Length)
                    keyPosition = 0;

                int number = (int)message[i];
                Console.WriteLine($"message character number in ASCII {number}");
                number -= (int)key[keyPosition];
                Console.WriteLine($"key character number in ASCII {(int)key[keyPosition]}");
                number = (number + 256) % 256; 

                decyphered += (char)number;
                Console.WriteLine($"cyphered message character number in ASCII {number}");

                keyPosition++;
            }

            return decyphered;
        }
    }
}
