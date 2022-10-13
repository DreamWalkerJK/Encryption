using EncryptOrDecrypt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptOrDecrypt.BLL
{
    class SHA1Option : IOption
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
            using (SHA1 sha1 = new SHA1CryptoServiceProvider())
            {
                byte[] data = sha1.ComputeHash(Encoding.UTF8.GetBytes(originText));
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
