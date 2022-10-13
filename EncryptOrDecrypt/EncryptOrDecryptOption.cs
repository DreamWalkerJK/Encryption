using EncryptOrDecrypt.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptOrDecrypt
{
    public class EncryptOrDecryptOption
    {
        public string EncryptOptionStart(string optionText, string originText)
        {
            if (string.IsNullOrEmpty(optionText))
                return string.Empty;

            EncryptOption encryptOption = new EncryptOption();

            switch (optionText)
            {
                case "MD5":
                    MD5Option mD5Option = new MD5Option();
                    return encryptOption.Start(originText, mD5Option);
                case "SHA-1":
                    SHA1Option sHA1Option = new SHA1Option();
                    return encryptOption.Start(originText, sHA1Option);
                case "SHA-256":
                    SHA256Option sHA256Option = new SHA256Option();
                    return encryptOption.Start(originText, sHA256Option);
                default:
                    return string.Empty;
            }
        }

        public string DecryptOptionStart(string optionText, string encryptText)
        {
            if (string.IsNullOrEmpty(optionText))
                return string.Empty;

            DecryptOption decryptOption = new DecryptOption();

            switch (optionText)
            {
                case "MD5":
                    MD5Option mD5Option = new MD5Option();
                    return decryptOption.Start(encryptText, mD5Option);
                case "SHA-1":
                    SHA1Option sHA1Option = new SHA1Option();
                    return decryptOption.Start(encryptText, sHA1Option);
                case "SHA-256":
                    SHA256Option sHA256Option = new SHA256Option();
                    return decryptOption.Start(encryptText, sHA256Option);
                default:
                    return string.Empty;
            }
        }
    }
}
