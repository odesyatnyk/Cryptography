using CustomCryptographyUtility.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCryptographyUtility
{
    public abstract class Cipher
    {
        public string CurrentAlphabet { get; set; } = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯҐЄІЇабвгдеёжзийклмнопрстуфхцчшщъыьэюяґєії0123456789:;<=>? !#$%&'()*+,-./" + "\r\n";
        public int CurrentAlphabetCapacity => CurrentAlphabet.Length;
        public int Key { get; set; }
        protected void CheckInput(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!CurrentAlphabet.Contains(text[i].ToString()))
                    throw new InvalidInputCharacterException("Some character is missing inside the alphabet. Are you selected a wrong alphabet?");
            }
        }
    }
}
