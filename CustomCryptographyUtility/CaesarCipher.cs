using CustomCryptographyUtility.Exceptions;
using System;
using System.Collections.Generic;

namespace CustomCryptographyUtility
{
    public class CaesarCipher : Cipher
    {
        public string Crypt(string text)
        {
            CheckInput(text);
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                result += CurrentAlphabet[(CurrentAlphabet.IndexOf(text[i]) + Key) % CurrentAlphabetCapacity];
            }
            return result;
        }
        public string DeCrypt(string text)
        {
            CheckInput(text);
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                result += CurrentAlphabet[(CurrentAlphabet.IndexOf(text[i]) - Key + CurrentAlphabetCapacity) % CurrentAlphabetCapacity];
            }
            return result;
        }
    }
}
