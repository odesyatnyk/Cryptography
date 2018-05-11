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
        public KeyType _keyType;

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
            _keyType = parentFrom._keyType;
            switch (_keyType)
            {
                case KeyType.Caesar:
                    radioButtonCaesar.Checked = true;
                    numericKey.Enabled = true;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = false;
                    numericKey.Value = _caesarKey;
                    break;
                case KeyType.Linear:
                    radio_Linear.Checked = true;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = true;
                    gb_NonLinear.Enabled = false;
                    txt_Phrase.Enabled = false;
                    num_ALinear.Value = _aLinear;
                    num_BLinear.Value = _bLinear;
                    break;
                case KeyType.NotLinear:
                    radio_NonLinear.Checked = true;
                    numericKey.Enabled = false;
                    gb_Linear.Enabled = false;
                    gb_NonLinear.Enabled = true;
                    txt_Phrase.Enabled = false;
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
                    txt_Phrase.Text = _txt_Phrase;
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

            radioButtonCaesar.CheckedChanged += RadioButton_CheckedChanged;
            radio_Linear.CheckedChanged += RadioButton_CheckedChanged;
            radio_NonLinear.CheckedChanged += RadioButton_CheckedChanged;
            radio_Phrase.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaesar.Checked)
            {
                numericKey.Enabled = true;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = false;
                _keyType = KeyType.Caesar;
            }
            else if (radio_Linear.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = true;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = false;
                _keyType = KeyType.Linear;
            }
            else if (radio_NonLinear.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = true;
                txt_Phrase.Enabled = false;
                _keyType = KeyType.NotLinear;
            }
            else if (radio_Phrase.Checked)
            {
                numericKey.Enabled = false;
                gb_Linear.Enabled = false;
                gb_NonLinear.Enabled = false;
                txt_Phrase.Enabled = true;
                _keyType = KeyType.Phrase;
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

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
