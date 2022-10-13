using EncryptOrDecrypt.Interface;
using System.Security.Cryptography;
using System.Text;

namespace EncryptOrDecrypt.BLL
{
    class MD5Option : IOption
    {
        public string Decrypt(string encryptText)
        {
            return string.Empty;
        }

        public string Encrypt(string originText, bool toUpper = true)
        {
            if (string.IsNullOrEmpty(originText))
                return string.Empty;

            StringBuilder result = new StringBuilder();
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(originText));
                if (toUpper)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        result.Append(data[i].ToString("X2"));
                    }
                }
                else
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        result.Append(data[i].ToString("x2"));
                    }
                }
            }

            return result.ToString();
        }
    }
}
