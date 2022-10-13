namespace EncryptOrDecrypt.Interface
{
    public interface IOption
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="originText"></param>
        /// <returns></returns>
        string Encrypt(string originText, bool toUpper = true);

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="encryptText"></param>
        /// <returns></returns>
        string Decrypt(string encryptText);
    }
}
