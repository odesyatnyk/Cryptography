using CustomCryptographyUtility.Exceptions;
using System;
using System.Collections.Generic;

namespace CustomCryptographyUtility
{
    public class TrithemiusCipher : Cipher
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public KeyType Type { get; set; }
        public string Phrase { get; set; }
        public string Crypt(string text)
        {
            CheckInput(text);
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                SetCurrentKey(i, text);
                int tKey = Key % CurrentAlphabetCapacity;
                if (CurrentAlphabet.IndexOf(text[i]) + tKey < 0)
                {
                    tKey = CurrentAlphabetCapacity + tKey;
                }
                else
                    if (CurrentAlphabet.IndexOf(text[i]) + tKey > CurrentAlphabetCapacity)
                {
                    tKey -= CurrentAlphabetCapacity;
                }
                result += CurrentAlphabet[(CurrentAlphabet.IndexOf(text[i]) + tKey) % CurrentAlphabetCapacity];
            }
            return result;
        }
        public string DeCrypt(string text)
        {
            CheckInput(text);
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                SetCurrentKey(i, text);
                int tKey = Key % CurrentAlphabetCapacity;
                if (CurrentAlphabet.IndexOf(text[i]) + tKey < 0)
                {
                    tKey = CurrentAlphabetCapacity + tKey;
                }
                else
                    if (CurrentAlphabet.IndexOf(text[i]) + tKey > CurrentAlphabetCapacity)
                {
                    tKey -= CurrentAlphabetCapacity;
                }
                result += CurrentAlphabet[(CurrentAlphabet.IndexOf(text[i]) - Key + CurrentAlphabetCapacity) % CurrentAlphabetCapacity];
            }
            return result;
        }

        private void SetCurrentKey(int charPosition, string text)
        {
            switch (Type)
            {
                case KeyType.Linear:
                    Key = A * charPosition + B;
                    break;
                case KeyType.NotLinear:
                    Key = A * (int)Math.Pow(charPosition, 2) + B * charPosition + C;
                    break;
                case KeyType.Phrase:
                    for (int i = 0; i < Phrase.Length; i++)
                    {
                        if (CurrentAlphabet.Contains(Phrase[i].ToString()) && !Phrase.Substring(0, i).Contains(Phrase[i].ToString()))
                        {
                            CurrentAlphabet.Remove(Phrase.IndexOf(Phrase[i]));
                            CurrentAlphabet = CurrentAlphabet.Insert(i, Phrase[i].ToString());
                        }
                    }
                    Key = charPosition;
                    break;
                default:
                    break;
            }
        }
    }
}
