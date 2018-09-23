using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CustomCryptographyUtility
{
    public class DESCipher : Cipher
    {
        public string _Key { get; set; }
        public string IV { get; set; }
        private string result;
        public DESCipher(string key, string iv)
        {
            _Key = key;
            IV = iv;
            result = string.Empty;
        }
        public override string Crypt(string input)
        {
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            try
            {
                //ABCDEFGH
                cryptic.Key = Encoding.UTF8.GetBytes(_Key);
                cryptic.IV = Encoding.UTF8.GetBytes(IV);
                cryptic.Mode = CipherMode.CBC;

                FileStream fs = new FileStream(@"e:\crypt.txt", FileMode.OpenOrCreate, FileAccess.Write);
                CryptoStream cs = new CryptoStream(fs, cryptic.CreateEncryptor(), CryptoStreamMode.Write);
                byte[] data = Encoding.UTF8.GetBytes(input);
                cs.Write(data, 0, data.Length);

                cs.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }
        public override string DeCrypt(string input)
        {
            DESCryptoServiceProvider cryptic1 = new DESCryptoServiceProvider();
            try
            {
                cryptic1.Key = Encoding.UTF8.GetBytes(_Key);
                cryptic1.IV = Encoding.UTF8.GetBytes(IV);
                cryptic1.Mode = CipherMode.CBC;

                FileStream fs = new FileStream(@"e:\crypt.txt", FileMode.Open, FileAccess.Read);

                CryptoStream cs = new CryptoStream(fs, cryptic1.CreateDecryptor(), CryptoStreamMode.Read);
                StreamReader read = new StreamReader(cs);

                result = read.ReadToEnd();

                fs.Close();
                read.Close();

            }
            catch (CryptographicException e)
            {
                result = e.Message;
            }

            return result;
        }
    }
}
