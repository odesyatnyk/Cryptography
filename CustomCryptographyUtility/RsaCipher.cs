using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CustomCryptographyUtility
{
    public class RsaCipher
    {
        public string Key { get; set; }
        public string Encrypt(string input, out string text)
        {
            RSACryptoServiceProvider RsaKey;

            CspParameters cp = new CspParameters
            {
                KeyContainerName = Key
            };
            
            RsaKey = new RSACryptoServiceProvider(cp);
            string publickey = RsaKey.ToXmlString(false);
            string privatekey = RsaKey.ToXmlString(true);
            text = publickey;
            UTF8Encoding ByteConverter = new UTF8Encoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(input);

            try
            {
                byte[] txtEnCrypt = RsaKey.Encrypt(dataToEncrypt, false);
                return Convert.ToBase64String(txtEnCrypt);
            }
            catch (CryptographicException ex)
            {
                return ex.Message;
            }
        }

        public string Decrypt(string input)
        {
            CspParameters cp = new CspParameters
            {
                KeyContainerName = Key
            };
            RSACryptoServiceProvider RsaKey = new RSACryptoServiceProvider(cp);
            string publickey = RsaKey.ToXmlString(false);
            byte[] dataToDecrypt = Convert.FromBase64String(input);

            try
            {
                byte[] TxtToDecrypt = RsaKey.Decrypt(dataToDecrypt, false);
                int len = TxtToDecrypt.Length;
                char[] val = new char[len];
                val = Encoding.UTF8.GetChars(TxtToDecrypt);
                return string.Join("", val);

            }
            catch (CryptographicException ex)
            {
                return ex.Message;
            }
        }
    }

}
