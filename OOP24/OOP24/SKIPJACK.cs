using System.Security.Cryptography;

namespace OOP24
{
    public class SKIPJACK
    {
        private readonly byte[] ecryptedMessage;

        private byte[] key; // ключ
        private byte[] iv; // вектор ініціалізації

        public SKIPJACK(string originalMessage)
        {
            key = GenerateRandomBytes(32);
            iv = GenerateRandomBytes(16);

            ecryptedMessage = EncryptStringToBytes(originalMessage, key, iv);
        }

        public byte[] EncryptStringToBytes(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        // Метод для генерації випадкових байтів
        private byte[] GenerateRandomBytes(int length)
        {
            byte[] randomBytes = new byte[length];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        public override string ToString()
        {
            string res = string.Empty;
            foreach (var bt in ecryptedMessage)
                res += bt.ToString();

            return res;
        }
    }
}
