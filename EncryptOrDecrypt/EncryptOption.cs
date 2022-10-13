using EncryptOrDecrypt.Interface;

namespace EncryptOrDecrypt
{
    class EncryptOption
    {
        public string Start(string originText, IOption option)
        {
            return option.Encrypt(originText);
        }
    }
}
