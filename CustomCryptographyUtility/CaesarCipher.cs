using System;
using System.Collections.Generic;

namespace CustomCryptographyUtility
{
    public static class CaesarCipher
    {
        private static int _key;
        private static AlphabetCode _alphabetCode;
        private static string _currentAlphabet;
        private static int _currentAlphabetCapacity;
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
                result += _currentAlphabet[(_currentAlphabet.IndexOf(text[i]) - _key + _currentAlphabetCapacity) % _currentAlphabetCapacity];
            }
            return result;
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
