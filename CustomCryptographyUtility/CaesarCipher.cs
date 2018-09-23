using CustomCryptographyUtility.Exceptions;
using System;
using System.Collections.Generic;

namespace CustomCryptographyUtility
{
    public class CaesarCipher : Cipher
    {
        public override string Crypt(string text)
        {
            CheckInput(text);
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                result += CurrentAlphabet[(CurrentAlphabet.IndexOf(text[i]) + Key) % CurrentAlphabetCapacity];
            }
            return result;
        }
        public override string DeCrypt(string text)
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
