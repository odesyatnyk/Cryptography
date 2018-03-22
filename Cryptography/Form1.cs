using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomCryptographyUtility;

namespace Cryptography
{
    public partial class Form1 : Form
    {
        #region Fields
        private string _decryptedText;
        private string _encryptedText;
        private int _key;
        private AlphabetCode _alphabetCode;
        private PrintDocument _docToPrint = new PrintDocument();
        #endregion
        public Form1()
        {
            InitializeComponent();
            textBoxDecryptedText.TextChanged += TextBoxDecryptedText_TextChanged;
            textBoxEncryptedText.TextChanged += TextBoxEncryptedText_TextChanged;
            textBoxKey.TextChanged += TextBoxKey_TextChanged;
            comboBoxLanguage.SelectedIndexChanged += ComboBoxLanguage_SelectedIndexChanged;
            _docToPrint.PrintPage += _docToPrint_PrintPage;
            radioButtonCaesar.Checked = true;
        }

        #region Event handlers
        private void TextBoxDecryptedText_TextChanged(object sender, EventArgs e)
        {
            _decryptedText = textBoxDecryptedText.Text;
        }
        private void TextBoxEncryptedText_TextChanged(object sender, EventArgs e)
        {
            _encryptedText = textBoxEncryptedText.Text;
        }
        private void TextBoxKey_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxKey.Text, out _key);
        }
        private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _alphabetCode = (AlphabetCode)comboBoxLanguage.SelectedIndex;
        }
        #endregion

        #region About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var emailLabel = new Label()
            {
                Text = "korrsfeddel@gmail.com",
            };
            var githubLabel = new Label()
            {
                Text = "https://github.com/odesyatnyk"
            };
            MessageBox.Show("Author Desiatnyk Oleksandr, Heat an Power Department, ТМ-51\n" +
                            "+380994655372\n" +
                            emailLabel.Text + "\n" +
                            githubLabel.Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Hotkeys
        private void hotkeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File strip:\n" +
                "Open file - Ctrl+O\n" +
                "Save as - Ctrl+S\n" +
                "Print - Ctrl+P\n" +
                "Help strip:\n" +
                "About - F1\n" +
                "Hotkeys - Ctrl+H\n" +
                "Exit - Ctrl+Q", "Hotkeys", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 1
            };
            string temp;

            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName != string.Empty)
            {
                string path = openFileDialog.FileName;
                using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
                {
                    temp = streamReader.ReadToEnd();
                }
                if (MessageBox.Show("You want encrypt or decrypt text?\n - YES to Encrypt\n - NO to Decrypt", "Choose", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _decryptedText = temp;
                    textBoxDecryptedText.Text = _decryptedText;
                }
                else
                {
                    _encryptedText = temp;
                    textBoxEncryptedText.Text = _encryptedText;
                }
            }
        }
        #endregion

        #region Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Name.txt";
            save.Filter = "Text File | *.txt";
            string temp = (MessageBox.Show("You want save encrypted or decrypted text?\n - YES to save Decrypted\n - NO to save Encrypted", "Choose", MessageBoxButtons.YesNo) == DialogResult.Yes) ? _decryptedText : _encryptedText;
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.OpenFile()))
                {
                    writer.WriteLine(temp);
                };
            }
            MessageBox.Show("Successfully saved!");
        }
        #endregion

        #region Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog()
            {
                AllowSomePages = true,
                ShowHelp = true,
                Document = _docToPrint
            };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                _docToPrint.Print();
            }
        }

        private void _docToPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = (MessageBox.Show("You want print encrypted or decrypted text?\n - YES to print Decrypted\n - NO to print Encrypted", "Choose", MessageBoxButtons.YesNo) == DialogResult.Yes) ? _decryptedText : _encryptedText;
            Font printFont = new Font("Arial", 35, FontStyle.Regular);
            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);
        }
        #endregion

        #region Crypt
        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonCaesar.Checked == true)
                {
                    CaesarCipher.Alphabet = _alphabetCode;
                    CaesarCipher.Key = _key;
                    _encryptedText = CaesarCipher.Crypt(_decryptedText);
                    textBoxEncryptedText.Text = _encryptedText;
                }
                if (radio_Linear.Checked == true)
                {
                    TrithemiusCipher.Alphabet = _alphabetCode;
                    TrithemiusCipher.A = Convert.ToInt32(num_ALinear.Value);
                    TrithemiusCipher.B = Convert.ToInt32(num_BLinear.Value);
                    TrithemiusCipher.Type = KeyType.Linear;
                    _encryptedText = TrithemiusCipher.Crypt(_decryptedText);
                    textBoxEncryptedText.Text = _encryptedText;
                }
                if (radio_NonLinear.Checked == true)
                {
                    TrithemiusCipher.Alphabet = _alphabetCode;
                    TrithemiusCipher.A = Convert.ToInt32(num_ANonLinear.Value);
                    TrithemiusCipher.B = Convert.ToInt32(num_BNonLinear.Value);
                    TrithemiusCipher.C = Convert.ToInt32(num_CNonLinear.Value);
                    TrithemiusCipher.Type = KeyType.NotLinear;
                    _encryptedText = TrithemiusCipher.Crypt(_decryptedText);
                    textBoxEncryptedText.Text = _encryptedText;
                }
                if (radio_Phrase.Checked == true)
                {
                    TrithemiusCipher.Alphabet = _alphabetCode;
                    TrithemiusCipher.Type = KeyType.Phrase;
                    TrithemiusCipher.Phrase = txt_Phrase.Text;
                    _encryptedText = TrithemiusCipher.Crypt(_decryptedText);
                    textBoxEncryptedText.Text = _encryptedText;
                }
            }
            catch (InvalidInputCharacterException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong key value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Decrypt
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonCaesar.Checked == true)
                {
                    CaesarCipher.Alphabet = _alphabetCode;
                    CaesarCipher.Key = _key;
                    _decryptedText = CaesarCipher.DeCrypt(_encryptedText);
                    textBoxDecryptedText.Text = _decryptedText;
                }
                if (radio_Linear.Checked == true)
                {
                    TrithemiusCipher.Alphabet = _alphabetCode;
                    TrithemiusCipher.A = Convert.ToInt32(num_ALinear.Value);
                    TrithemiusCipher.B = Convert.ToInt32(num_BLinear.Value);
                    TrithemiusCipher.Type = KeyType.Linear;
                    _decryptedText = TrithemiusCipher.DeCrypt(_encryptedText);
                    textBoxDecryptedText.Text = _decryptedText;
                }
                if (radio_NonLinear.Checked == true)
                {
                    TrithemiusCipher.Alphabet = _alphabetCode;
                    TrithemiusCipher.A = Convert.ToInt32(num_ANonLinear.Value);
                    TrithemiusCipher.B = Convert.ToInt32(num_BNonLinear.Value);
                    TrithemiusCipher.C = Convert.ToInt32(num_CNonLinear.Value);
                    TrithemiusCipher.Type = KeyType.NotLinear;
                    _decryptedText = TrithemiusCipher.DeCrypt(_encryptedText);
                    textBoxDecryptedText.Text = _decryptedText;
                }
                if (radio_Phrase.Checked == true)
                {
                    TrithemiusCipher.Alphabet = _alphabetCode;
                    TrithemiusCipher.Type = KeyType.Phrase;
                    TrithemiusCipher.Phrase = txt_Phrase.Text;
                    _decryptedText = TrithemiusCipher.DeCrypt(_encryptedText);
                    textBoxDecryptedText.Text = _decryptedText;
                }
            }
            catch (InvalidInputCharacterException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong key value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDecryptedText.Clear();
            textBoxEncryptedText.Clear();
            txt_Phrase.Clear();
            num_ALinear.Value = num_BLinear.Value = num_ANonLinear.Value = num_BNonLinear.Value = num_CNonLinear.Value = 0;
            _encryptedText = _decryptedText = string.Empty;
        }
        #endregion

        #region Exit Button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
