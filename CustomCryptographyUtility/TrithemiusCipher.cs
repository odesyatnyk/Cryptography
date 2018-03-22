using System;
using System.Collections.Generic;

namespace CustomCryptographyUtility
{
    public static class TrithemiusCipher
    {
        private static int _key;
        private static AlphabetCode _alphabetCode;
        private static string _currentAlphabet;
        private static int _currentAlphabetCapacity;
        public static int A { get; set; }
        public static int B { get; set; }
        public static int C { get; set; }
        public static KeyType Type { get; set; }
        public static string Phrase { get; set; }
        public static int Key
        {
            get { return _key; }
            set
            {
                if (value < 0 || value > _currentAlphabetCapacity)
                    throw new Exception("Wrong key value");
                _key = value;
            }
        }
        public static AlphabetCode Alphabet
        {
            get { return _alphabetCode; }
            set
            {
                _alphabetCode = value;
                _alphabets.TryGetValue(_alphabetCode, out _currentAlphabet);
                _currentAlphabetCapacity = _currentAlphabet.Length;
            }
        }

        private static Dictionary<AlphabetCode, string> _alphabets = new Dictionary<AlphabetCode, string>()
        {
            {AlphabetCode.UA, "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯабвгґдеєжзиіїйклмнопрстуфхцчшщьюя0123456789:;<=>? !#$%&'()*+,-./" + "\r\n"},
            {AlphabetCode.EN,"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789:;<=>? !#$%&'()*+,-./" + "\r\n"},
            {AlphabetCode.RUS, "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюяґєії0123456789:;<=>? !#$%&'()*+,-./" + "\r\n"},
            {AlphabetCode.Mixed,"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯҐЄІЇабвгдеёжзийклмнопрстуфхцчшщъыьэюяґєії0123456789:;<=>? !#$%&'()*+,-./" + "\r\n"}
        };

        public static string Crypt(string text)
        {
            CheckInput(text);
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                SetCurrentKey(i, text);
                _key = GetNormalizedKey(_key);
                result += _currentAlphabet[(_currentAlphabet.IndexOf(text[i]) + _key) % _currentAlphabetCapacity];
            }
            return result;
        }
        public static string DeCrypt(string text)
        {
            CheckInput(text);
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                SetCurrentKey(i, text);
                _key = GetNormalizedKey(_key);
                result += _currentAlphabet[(_currentAlphabet.IndexOf(text[i]) - _key + _currentAlphabetCapacity) % _currentAlphabetCapacity];
            }
            return result;
        }

        private static void SetCurrentKey(int charPosition, string text)
        {
            switch (Type)
            {
                case KeyType.Linear:
                    _key = A * charPosition + B;
                    break;
                case KeyType.NotLinear:
                    _key = A * (int)Math.Pow(charPosition, 2) + B * charPosition + C;
                    break;
                case KeyType.Phrase:
                    for (int i = 0; i < Phrase.Length; i++)
                    {
                        if (_currentAlphabet.Contains(Phrase[i].ToString()) && !Phrase.Substring(0, i).Contains(Phrase[i].ToString()))
                        {
                            _currentAlphabet.Remove(Phrase.IndexOf(Phrase[i]));
                            _currentAlphabet = _currentAlphabet.Insert(i, Phrase[i].ToString());
                        }
                    }
                    _key = charPosition;
                    break;
                default:
                    break;
            }
        }
        private static int GetNormalizedKey(int key)
        {
            int resultKey = 0;
            if (key > _currentAlphabetCapacity)
            {
                int temp = key / _currentAlphabetCapacity;
                resultKey = key - (temp * _currentAlphabetCapacity);
            }
            else
                return key;

            return resultKey;
        }
        private static void CheckInput(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!_currentAlphabet.Contains(text[i].ToString()))
                    throw new InvalidInputCharacterException("Some character is missing inside the alphabet. Are you selected a wrong alphabet?");
            }
        }
    }
}
