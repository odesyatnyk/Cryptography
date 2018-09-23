using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CustomCryptographyUtility
{
    public class LitCipher : Cipher
    {
        int x, y;
        public string[] key;
        public string newText = "";
        Random rnd = new Random();

        public override string Crypt(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (SearchSymbol(text[i]))
                {
                    string x1 = "";
                    string y1 = "";
                    if (x < 10) x1 = "0" + x;
                    else x1 += x;
                    if (y < 10) y1 = "0" + y;
                    else y1 += y;
                    newText += x1 + y1 + " ";
                }
                else
                {
                    MessageBox.Show("Символ " + text[i] + " отсутствует в стихе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            return newText;
        }

        public override string DeCrypt(string text)
        {
            String[] xy = text.Split(new String[] { " " }, StringSplitOptions.None);
            int i = 0;
            while (i < xy.Length - 1)
            {
                try
                {
                    x = Convert.ToInt32(xy[i]) / 100 - 1;
                    y = Convert.ToInt32(xy[i]) % 100 - 1;
                    i++;
                    newText += key[x][y];
                }
                catch (FormatException)
                {
                    i++;
                }
            }
            return newText;
        }

        private bool SearchSymbol(char symbol)
        {
            int r = rnd.Next(key.Length - 1);
            for (int i = r; i < key.Length; i++)
                for (int j = 0; j < key[i].Length; j++)
                    if (key[i][j] == symbol)
                    {
                        x = i + 1;
                        y = j + 1;
                        return true;
                    }
            for (int i = 0; i < r; i++)
                for (int j = 0; j < key[i].Length; j++)
                    if (key[i][j] == symbol)
                    {
                        x = i + 1;
                        y = j + 1;
                        return true;
                    }
            return false;
        }
    }
}
