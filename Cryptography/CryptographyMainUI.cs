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
using CustomCryptographyUtility.Exceptions;

namespace Cryptography
{
    public partial class CryptographyMainUI : Form
    {
        #region Fields
        private string _text;
        public int _caesarKey;
        public int _aLinear;
        public int _bLinear;
        public int _aNonLinear;
        public int _bNonLinear;
        public int _cNonLinear;
        public string _txt_Phrase;
        public KeyType _keyType;
        private PrintDocument _docToPrint = new PrintDocument();
        #endregion

        public CryptographyMainUI()
        {
            InitializeComponent();
            textBoxText.TextChanged += TextBoxDecryptedText_TextChanged;
            _docToPrint.PrintPage += _docToPrint_PrintPage;
        }

        #region Event handlers
        private void TextBoxDecryptedText_TextChanged(object sender, EventArgs e)
        {
            _text = textBoxText.Text;
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
                _text = temp;
                textBoxText.Text = _text;
            }
        }
        #endregion

        #region Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                FileName = "Name.txt",
                Filter = "Text File | *.txt"
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.OpenFile()))
                {
                    writer.WriteLine(_text);
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
            string text = _text;
            Font printFont = new Font("Arial", 35, FontStyle.Regular);
            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);
        }
        #endregion

        #region Crypt
        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encrypt();
        }
        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            Encrypt();
        }

        private void Encrypt()
        {
            try
            {

                using (var form = new KeyDialog())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        _caesarKey = form._caesarKey;
                        _aLinear = form._aLinear;
                        _bLinear = form._bLinear;
                        _aNonLinear = form._aNonLinear;
                        _bNonLinear = form._bNonLinear;
                        _cNonLinear = form._cNonLinear;
                        _txt_Phrase = form._txt_Phrase;
                        _keyType = form._keyType;
                    }
                }

                switch (_keyType)
                {
                    case KeyType.Caesar:
                        CaesarCipher caesarCipher = new CaesarCipher
                        {
                            Key = _caesarKey
                        };
                        _text = caesarCipher.Crypt(_text);
                        textBoxText.Text = _text;
                        break;
                    case KeyType.Linear:
                        TrithemiusCipher trithemiusCipher = new TrithemiusCipher
                        {
                            A = _aLinear,
                            B = _bLinear,
                            Type = KeyType.Linear
                        };
                        _text = trithemiusCipher.Crypt(_text);
                        textBoxText.Text = _text;
                        break;
                    case KeyType.NotLinear:
                        TrithemiusCipher trithemiusCipherNotLinear = new TrithemiusCipher
                        {
                            A = _aNonLinear,
                            B = _bNonLinear,
                            C = _cNonLinear,
                            Type = KeyType.NotLinear
                        };
                        _text = trithemiusCipherNotLinear.Crypt(_text);
                        textBoxText.Text = _text;
                        break;
                    case KeyType.Phrase:
                        TrithemiusCipher trithemiusCipherPhrase = new TrithemiusCipher
                        {
                            Type = KeyType.Phrase,
                            Phrase = _txt_Phrase
                        };
                        _text = trithemiusCipherPhrase.Crypt(_text);
                        textBoxText.Text = _text;
                        break;
                    default:
                        break;
                }
            }
            catch (InvalidInputCharacterException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (WrongKeyValueException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Decrypt
        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decrypt();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt();
        }

        private void Decrypt()
        {
            try
            {
                using (var form = new KeyDialog(this))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        _caesarKey = form._caesarKey;
                        _aLinear = form._aLinear;
                        _bLinear = form._bLinear;
                        _aNonLinear = form._aNonLinear;
                        _bNonLinear = form._bNonLinear;
                        _cNonLinear = form._cNonLinear;
                        _txt_Phrase = form._txt_Phrase;
                    }
                }

                switch (_keyType)
                {
                    case KeyType.Caesar:
                        CaesarCipher caesarCipher = new CaesarCipher
                        {
                            Key = _caesarKey
                        };
                        _text = caesarCipher.DeCrypt(_text);
                        textBoxText.Text = _text;
                        break;
                    case KeyType.Linear:
                        TrithemiusCipher trithemiusCipher = new TrithemiusCipher
                        {
                            A = _aLinear,
                            B = _bLinear,
                            Type = KeyType.Linear
                        };
                        _text = trithemiusCipher.DeCrypt(_text);
                        textBoxText.Text = _text;
                        break;
                    case KeyType.NotLinear:
                        TrithemiusCipher trithemiusCipherNotLinear = new TrithemiusCipher
                        {
                            A = _aNonLinear,
                            B = _bNonLinear,
                            C = _cNonLinear,
                            Type = KeyType.NotLinear
                        };
                        _text = trithemiusCipherNotLinear.DeCrypt(_text);
                        textBoxText.Text = _text;
                        break;
                    case KeyType.Phrase:
                        TrithemiusCipher trithemiusCipherPhrase = new TrithemiusCipher
                        {
                            Type = KeyType.Phrase,
                            Phrase = _txt_Phrase
                        };
                        _text = trithemiusCipherPhrase.DeCrypt(_text);
                        textBoxText.Text = _text;
                        break;
                    default:
                        break;
                }
            }
            catch (InvalidInputCharacterException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (WrongKeyValueException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxText.Clear();
            _text = string.Empty;
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
