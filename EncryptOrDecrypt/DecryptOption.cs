using EncryptOrDecrypt.Interface;

namespace EncryptOrDecrypt
{
    class DecryptOption
    {
        public string Start(string encryptText, IOption option)
        {
            return option.Decrypt(encryptText);
        }
    }
}
