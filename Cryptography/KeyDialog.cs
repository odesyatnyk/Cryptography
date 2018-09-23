using CustomCryptographyUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class KeyDialog : Form
    {
        public int _caesarKey;
        public int _aLinear;
        public int _bLinear;
        public int _aNonLinear;
        public int _bNonLinear;
        public int _cNonLinear;
        public string _txt_Phrase;
        public int _keyGamma;
        public KeyType _keyType;
        public string _lit;
        public string _keyDes;
        public string _iv;
        public string _rsaKey;

        public KeyDialog()
        {
            InitializeComponent();
            InitForm();
            radioButtonCaesar.Checked = true;
        }

        public KeyDialog(CryptographyMainUI parentFrom)
        {
            InitializeComponent();
            InitForm();
            _caesarKey = parentFrom._caesarKey;
            _aLinear = parentFrom._aLinear;
            _bLinear = parentFrom._bLinear;
            _aNonLinear = parentFrom._aNonLinear;
            _bNonLinear = parentFrom._bNonLinear;
            _cNonLinear = parentFrom._cNonLinear;
            _txt_Phrase = parentFrom._txt_Phrase;
            _keyGamma = parentFrom._keyGamma;
            _keyType = parentFrom._keyType;
            _lit = parentFrom._lit;
            _keyDes = parentFrom._keyDes;
            _iv = parentFrom._iv;
            _rsaKey = parentFrom._rsaKey;
            switch (_keyType)
            {
                case KeyType.Caesar:
                    radioButtonCaesar.Checked = true;
                    numericKey.Enabled = true;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = false;
                    textBoxLit.Enabled = false;
                    textBoxRsaKey.Enabled = false;
                    radioButtonDES.Checked = false;
                    numericGammaKey.Enabled = false;
                    numericKey.Value = _caesarKey;
                    break;
                case KeyType.Linear:
                    radio_Linear.Checked = true;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = true;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = false;
                    textBoxLit.Enabled = false;
                    radioButtonDES.Checked = false;
                    numericGammaKey.Enabled = false;
                    textBoxRsaKey.Enabled = false;
                    num_ALinear.Value = _aLinear;
                    num_BLinear.Value = _bLinear;
                    break;
                case KeyType.NotLinear:
                    radio_NonLinear.Checked = true;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = true;
                    txt_Phrase.Enabled = false;
                    textBoxLit.Enabled = false;
                    radioButtonDES.Checked = false;
                    textBoxRsaKey.Enabled = false;
                    numericGammaKey.Enabled = false;
                    num_ANonLinear.Value = _aNonLinear;
                    num_BNonLinear.Value = _bNonLinear;
                    num_CNonLinear.Value = _cNonLinear;
                    break;
                case KeyType.Phrase:
                    radio_Phrase.Checked = true;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = true;
                    textBoxLit.Enabled = false;
                    radioButtonDES.Checked = false;
                    textBoxRsaKey.Enabled = false;
                    numericGammaKey.Enabled = false;
                    txt_Phrase.Text = _txt_Phrase;
                    break;
                case KeyType.Gamma:
                    radioGamma.Checked = true;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = false;
                    textBoxLit.Enabled = false;
                    radioButtonDES.Checked = false;
                    textBoxRsaKey.Enabled = false;
                    numericGammaKey.Enabled = true;
                    numericGammaKey.Value= _keyGamma;
                    break;
                case KeyType.Lit:
                    radioGamma.Checked = false;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = false;
                    radioLitCipher.Checked = true;
                    textBoxLit.Enabled = true;
                    radioButtonDES.Checked = false;
                    textBoxRsaKey.Enabled = false;
                    textBoxLit.Text = _lit;
                    break;
                case KeyType.Des:
                    radioGamma.Checked = false;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = false;
                    radioLitCipher.Checked = false;
                    radioButtonDES.Checked = true;
                    textBoxDesKey.Text = _keyDes;
                    textBoxDesIv.Text = _iv;
                    textBoxRsaKey.Enabled = false;

                    break;
                case KeyType.Rsa:
                    radioGamma.Checked = false;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = false;
                    radioLitCipher.Checked = false;
                    radioButtonDES.Checked = false;
                    radioRsa.Checked = true;
                    textBoxRsaKey.Enabled = true;
                    textBoxRsaKey.Text = _rsaKey;
                    break;
                default:
                    break;
            }
        }

        private void InitForm()
        {
            numericKey.TextChanged += NumericKey_TextChanged;
            num_ALinear.TextChanged += Num_ALinear_TextChanged;
            num_BLinear.TextChanged += Num_BLinear_TextChanged;
            num_ANonLinear.TextChanged += Num_ANonLinear_TextChanged;
            num_BNonLinear.TextChanged += Num_BNonLinear_TextChanged;
            num_CNonLinear.TextChanged += Num_CNonLinear_TextChanged;
            txt_Phrase.TextChanged += Txt_Phrase_TextChanged;
            numericGammaKey.TextChanged += NumericGammaKey_TextChanged;
            textBoxLit.TextChanged += TextBoxLit_TextChanged;
            textBoxDesKey.TextChanged += TextBoxDesKey_TextChanged;
            textBoxDesIv.TextChanged += TextBoxDesIv_TextChanged;
            textBoxRsaKey.TextChanged += TextBoxRsaKey_TextChanged;

            radioButtonCaesar.CheckedChanged += RadioButton_CheckedChanged;
            radio_Linear.CheckedChanged += RadioButton_CheckedChanged;
            radio_NonLinear.CheckedChanged += RadioButton_CheckedChanged;
            radio_Phrase.CheckedChanged += RadioButton_CheckedChanged;
            radioGamma.CheckedChanged += RadioButton_CheckedChanged;
            radioLitCipher.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonDES.CheckedChanged += RadioButton_CheckedChanged;
            radioRsa.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void TextBoxRsaKey_TextChanged(object sender, EventArgs e)
        {
            _rsaKey = textBoxRsaKey.Text;
        }

        private void TextBoxDesIv_TextChanged(object sender, EventArgs e)
        {
            _iv = textBoxDesIv.Text;
        }

        private void TextBoxDesKey_TextChanged(object sender, EventArgs e)
        {
            _keyDes = textBoxDesKey.Text;
        }

        private void TextBoxLit_TextChanged(object sender, EventArgs e)
        {
            _lit = textBoxLit.Text;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaesar.Checked)
            {
                numericKey.Enabled = true;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = false;
                textBoxLit.Enabled = false;
                groupBoxDes.Enabled = false;
                numericGammaKey.Enabled = false;
                textBoxRsaKey.Enabled = false;
                _keyType = KeyType.Caesar;
            }
            else if (radio_Linear.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = true;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = false;
                textBoxLit.Enabled = false;
                groupBoxDes.Enabled = false;
                textBoxRsaKey.Enabled = false;
                numericGammaKey.Enabled = false;
                _keyType = KeyType.Linear;
            }
            else if (radio_NonLinear.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = true;
                txt_Phrase.Enabled = false;
                textBoxLit.Enabled = false;
                groupBoxDes.Enabled = false;
                textBoxRsaKey.Enabled = false;
                numericGammaKey.Enabled = false;
                _keyType = KeyType.NotLinear;
            }
            else if (radio_Phrase.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = true;
                textBoxLit.Enabled = false;
                groupBoxDes.Enabled = false;
                textBoxRsaKey.Enabled = false;
                numericGammaKey.Enabled = false;
                _keyType = KeyType.Phrase;
            }
            else if (radioGamma.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = false;
                textBoxLit.Enabled = false;
                groupBoxDes.Enabled = false;
                textBoxRsaKey.Enabled = false;
                numericGammaKey.Enabled = true;
                _keyType = KeyType.Gamma;
            }
            else if (radioLitCipher.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = false;
                numericGammaKey.Enabled = false;
                textBoxLit.Enabled = true;
                textBoxRsaKey.Enabled = false;
                groupBoxDes.Enabled = false;
                _keyType = KeyType.Lit;
            }
            else if (radioButtonDES.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = false;
                numericGammaKey.Enabled = false;
                textBoxRsaKey.Enabled = false;
                textBoxLit.Enabled = false;
                groupBoxDes.Enabled = true;
                _keyType = KeyType.Des;
            }
            else if (radioRsa.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = false;
                numericGammaKey.Enabled = false;
                textBoxLit.Enabled = false;
                groupBoxDes.Enabled = false;
                textBoxRsaKey.Enabled = true;
                _keyType = KeyType.Rsa;
            }
        }

        private void NumericKey_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(numericKey.Text, out _caesarKey);
        }

        private void Num_ALinear_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(num_ALinear.Text, out _aLinear);
        }

        private void Num_BLinear_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(num_BLinear.Text, out _bLinear);
        }

        private void Num_ANonLinear_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(num_ANonLinear.Text, out _aNonLinear);
        }

        private void Num_BNonLinear_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(num_BNonLinear.Text, out _bNonLinear);
        }

        private void Num_CNonLinear_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(num_CNonLinear.Text, out _cNonLinear);
        }
    
        private void Txt_Phrase_TextChanged(object sender, EventArgs e)
        {
            _txt_Phrase = txt_Phrase.Text;
        }

        private void NumericGammaKey_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(numericGammaKey.Text, out _keyGamma);
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
