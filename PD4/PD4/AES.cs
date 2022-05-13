using System.Security.Cryptography;
using System.Text;

namespace PD4
{
    public class AES
    {
        private readonly byte[] initializationVector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        public byte[] RunEncryptor(string input, string key)
        {
            try
            {
                using (Aes aesAlgorithm = Aes.Create())
                {
                    aesAlgorithm.Key = Encoding.UTF8.GetBytes(key);
                    aesAlgorithm.IV = initializationVector;
                    aesAlgorithm.Mode = CipherMode.ECB;

                    ICryptoTransform newEncryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV);

                    using (MemoryStream dataStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(dataStream, newEncryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                            {
                                streamWriter.Write(input);
                            }

                            return dataStream.ToArray();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Encountered an error while ecrypting your message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public string RunDecryptor(string encryptedText, string key)
        {
            try
            {
                byte[] stringBytes = Convert.FromBase64String(encryptedText);

                using (Aes aesAlgorithm = Aes.Create())
                {
                    aesAlgorithm.Key = Encoding.UTF8.GetBytes(key);
                    aesAlgorithm.IV = initializationVector;
                    aesAlgorithm.Mode = CipherMode.ECB;

                    ICryptoTransform newDecryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV);

                    using (MemoryStream dataStream = new MemoryStream(stringBytes))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(dataStream, newDecryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader streamReader = new StreamReader(cryptoStream))
                            {
                                return streamReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error encountered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }
        }
    }
}
