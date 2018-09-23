using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCryptographyUtility
{
    public class GammaCipher : Cipher
    {
        public override string Crypt(string text)
        {
            string result = string.Empty;
            int keyIndex = 0;
            string _key = RandomKeyWord(text.Length, Key, CurrentAlphabet);

            foreach (char c in text)
            {
                int symbol = (Array.IndexOf(CurrentAlphabet.ToArray(), c) +
                    Array.IndexOf(CurrentAlphabet.ToArray(), _key[keyIndex])) % CurrentAlphabetCapacity;

                result += CurrentAlphabet[symbol];

                keyIndex++;

                if ((keyIndex + 1) == _key.Length)
                    keyIndex = 0;
            }

            return result;
        }

        public override string DeCrypt(string text)
        {
            string result = string.Empty;

            int keyIndex = 0;
            string _key = RandomKeyWord(text.Length, Key, CurrentAlphabet);
            foreach (char c in text)
            {
                int symbol = (Array.IndexOf(CurrentAlphabet.ToArray(), c) + CurrentAlphabetCapacity -
                    Array.IndexOf(CurrentAlphabet.ToArray(), _key[keyIndex])) % CurrentAlphabetCapacity;

                result += CurrentAlphabet[symbol];

                keyIndex++;

                if ((keyIndex + 1) == _key.Length)
                    keyIndex = 0;
            }

            return result;
        }

        private string RandomKeyWord(int length, int startSeed, string Abc)
        {
            Random rand = new Random(startSeed);

            string result = string.Empty;

            for (int i = 0; i < length; i++)
                result += Abc[rand.Next(0, Abc.Length)];

            return result;
        }
    }
}
