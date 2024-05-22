using System;
using System.Text;

namespace OOP24
{
    public class Snefru
    {
        // Розмір хешу (256 біт)
        private const int hashSize = 32;

        // Буфер для хешування
        private byte[] hashBuffer = new byte[hashSize];


        public Snefru(string strMessage)
        {
            ReturnHash(strMessage);
        }

        private void ReturnHash(string strMessage)
        {
            byte[] message = Encoding.UTF8.GetBytes(strMessage);
            Array.Copy(message, hashBuffer, Math.Min(message.Length, hashSize));

            // Раунди хешування
            for (int round = 0; round < 2; round++)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    hashBuffer[i % hashSize] ^= message[i];
                }
            }
        }

        public override string ToString()
        {
            string res = string.Empty;
            foreach (var bt in hashBuffer)
                res += bt.ToString();

            return res;
        }
    }
}
