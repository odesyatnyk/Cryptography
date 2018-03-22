namespace Cryptography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxDecryptedText = new System.Windows.Forms.TextBox();
            this.labelDecryptedText = new System.Windows.Forms.Label();
            this.labelEncryptedText = new System.Windows.Forms.Label();
            this.textBoxEncryptedText = new System.Windows.Forms.TextBox();
            this.buttonCrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSelectLanguage = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonCaesar = new System.Windows.Forms.RadioButton();
            this.txt_Phrase = new System.Windows.Forms.TextBox();
            this.radio_Phrase = new System.Windows.Forms.RadioButton();
            this.gb_NonLinear = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_CNonLinear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_BNonLinear = new System.Windows.Forms.NumericUpDown();
            this.num_ANonLinear = new System.Windows.Forms.NumericUpDown();
            this.gb_Linear = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_BLinear = new System.Windows.Forms.NumericUpDown();
            this.num_ALinear = new System.Windows.Forms.NumericUpDown();
            this.radio_NonLinear = new System.Windows.Forms.RadioButton();
            this.radio_Linear = new System.Windows.Forms.RadioButton();
            this.numericKey = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_NonLinear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CNonLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_BNonLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ANonLinear)).BeginInit();
            this.gb_Linear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ALinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKey)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.hotkeysToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            this.hotkeysToolStripMenuItem.Click += new System.EventHandler(this.hotkeysToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBoxDecryptedText
            // 
            this.textBoxDecryptedText.Location = new System.Drawing.Point(125, 27);
            this.textBoxDecryptedText.Multiline = true;
            this.textBoxDecryptedText.Name = "textBoxDecryptedText";
            this.textBoxDecryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecryptedText.Size = new System.Drawing.Size(467, 151);
            this.textBoxDecryptedText.TabIndex = 1;
            // 
            // labelDecryptedText
            // 
            this.labelDecryptedText.AutoSize = true;
            this.labelDecryptedText.Location = new System.Drawing.Point(12, 30);
            this.labelDecryptedText.Name = "labelDecryptedText";
            this.labelDecryptedText.Size = new System.Drawing.Size(83, 13);
            this.labelDecryptedText.TabIndex = 2;
            this.labelDecryptedText.Text = "Decrypted Text:";
            // 
            // labelEncryptedText
            // 
            this.labelEncryptedText.AutoSize = true;
            this.labelEncryptedText.Location = new System.Drawing.Point(12, 187);
            this.labelEncryptedText.Name = "labelEncryptedText";
            this.labelEncryptedText.Size = new System.Drawing.Size(82, 13);
            this.labelEncryptedText.TabIndex = 4;
            this.labelEncryptedText.Text = "Encrypted Text:";
            // 
            // textBoxEncryptedText
            // 
            this.textBoxEncryptedText.Location = new System.Drawing.Point(125, 184);
            this.textBoxEncryptedText.Multiline = true;
            this.textBoxEncryptedText.Name = "textBoxEncryptedText";
            this.textBoxEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncryptedText.Size = new System.Drawing.Size(467, 151);
            this.textBoxEncryptedText.TabIndex = 3;
            // 
            // buttonCrypt
            // 
            this.buttonCrypt.Location = new System.Drawing.Point(272, 343);
            this.buttonCrypt.Name = "buttonCrypt";
            this.buttonCrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonCrypt.TabIndex = 5;
            this.buttonCrypt.Text = "Crypt";
            this.buttonCrypt.UseVisualStyleBackColor = true;
            this.buttonCrypt.Click += new System.EventHandler(this.buttonCrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(353, 343);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "UA",
            "EN",
            "RUS",
            "Mixed"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(125, 344);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(134, 21);
            this.comboBoxLanguage.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(435, 343);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(517, 343);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSelectLanguage
            // 
            this.labelSelectLanguage.AutoSize = true;
            this.labelSelectLanguage.Location = new System.Drawing.Point(12, 347);
            this.labelSelectLanguage.Name = "labelSelectLanguage";
            this.labelSelectLanguage.Size = new System.Drawing.Size(87, 13);
            this.labelSelectLanguage.TabIndex = 10;
            this.labelSelectLanguage.Text = "Select language:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericKey);
            this.groupBox3.Controls.Add(this.radioButtonCaesar);
            this.groupBox3.Controls.Add(this.txt_Phrase);
            this.groupBox3.Controls.Add(this.radio_Phrase);
            this.groupBox3.Controls.Add(this.gb_NonLinear);
            this.groupBox3.Controls.Add(this.gb_Linear);
            this.groupBox3.Controls.Add(this.radio_NonLinear);
            this.groupBox3.Controls.Add(this.radio_Linear);
            this.groupBox3.Location = new System.Drawing.Point(15, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 148);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specify key";
            // 
            // radioButtonCaesar
            // 
            this.radioButtonCaesar.AutoSize = true;
            this.radioButtonCaesar.Location = new System.Drawing.Point(6, 32);
            this.radioButtonCaesar.Name = "radioButtonCaesar";
            this.radioButtonCaesar.Size = new System.Drawing.Size(79, 17);
            this.radioButtonCaesar.TabIndex = 12;
            this.radioButtonCaesar.TabStop = true;
            this.radioButtonCaesar.Text = "Caesar Key";
            this.radioButtonCaesar.UseVisualStyleBackColor = true;
            // 
            // txt_Phrase
            // 
            this.txt_Phrase.Location = new System.Drawing.Point(431, 109);
            this.txt_Phrase.Name = "txt_Phrase";
            this.txt_Phrase.Size = new System.Drawing.Size(131, 20);
            this.txt_Phrase.TabIndex = 6;
            // 
            // radio_Phrase
            // 
            this.radio_Phrase.AutoSize = true;
            this.radio_Phrase.Location = new System.Drawing.Point(431, 71);
            this.radio_Phrase.Name = "radio_Phrase";
            this.radio_Phrase.Size = new System.Drawing.Size(58, 17);
            this.radio_Phrase.TabIndex = 5;
            this.radio_Phrase.TabStop = true;
            this.radio_Phrase.Text = "Phrase";
            this.radio_Phrase.UseVisualStyleBackColor = true;
            // 
            // gb_NonLinear
            // 
            this.gb_NonLinear.Controls.Add(this.label5);
            this.gb_NonLinear.Controls.Add(this.label3);
            this.gb_NonLinear.Controls.Add(this.num_CNonLinear);
            this.gb_NonLinear.Controls.Add(this.label4);
            this.gb_NonLinear.Controls.Add(this.num_BNonLinear);
            this.gb_NonLinear.Controls.Add(this.num_ANonLinear);
            this.gb_NonLinear.Location = new System.Drawing.Point(171, 92);
            this.gb_NonLinear.Name = "gb_NonLinear";
            this.gb_NonLinear.Size = new System.Drawing.Size(254, 46);
            this.gb_NonLinear.TabIndex = 4;
            this.gb_NonLinear.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "t+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "t^2+";
            // 
            // num_CNonLinear
            // 
            this.num_CNonLinear.Location = new System.Drawing.Point(205, 16);
            this.num_CNonLinear.Name = "num_CNonLinear";
            this.num_CNonLinear.Size = new System.Drawing.Size(39, 20);
            this.num_CNonLinear.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "k=";
            // 
            // num_BNonLinear
            // 
            this.num_BNonLinear.Location = new System.Drawing.Point(131, 17);
            this.num_BNonLinear.Name = "num_BNonLinear";
            this.num_BNonLinear.Size = new System.Drawing.Size(39, 20);
            this.num_BNonLinear.TabIndex = 1;
            // 
            // num_ANonLinear
            // 
            this.num_ANonLinear.Location = new System.Drawing.Point(41, 17);
            this.num_ANonLinear.Name = "num_ANonLinear";
            this.num_ANonLinear.Size = new System.Drawing.Size(39, 20);
            this.num_ANonLinear.TabIndex = 1;
            // 
            // gb_Linear
            // 
            this.gb_Linear.Controls.Add(this.label2);
            this.gb_Linear.Controls.Add(this.label1);
            this.gb_Linear.Controls.Add(this.num_BLinear);
            this.gb_Linear.Controls.Add(this.num_ALinear);
            this.gb_Linear.Location = new System.Drawing.Point(6, 92);
            this.gb_Linear.Name = "gb_Linear";
            this.gb_Linear.Size = new System.Drawing.Size(156, 46);
            this.gb_Linear.TabIndex = 3;
            this.gb_Linear.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "t+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "k=";
            // 
            // num_BLinear
            // 
            this.num_BLinear.Location = new System.Drawing.Point(112, 18);
            this.num_BLinear.Name = "num_BLinear";
            this.num_BLinear.Size = new System.Drawing.Size(39, 20);
            this.num_BLinear.TabIndex = 1;
            // 
            // num_ALinear
            // 
            this.num_ALinear.Location = new System.Drawing.Point(37, 18);
            this.num_ALinear.Name = "num_ALinear";
            this.num_ALinear.Size = new System.Drawing.Size(39, 20);
            this.num_ALinear.TabIndex = 1;
            // 
            // radio_NonLinear
            // 
            this.radio_NonLinear.AutoSize = true;
            this.radio_NonLinear.Location = new System.Drawing.Point(171, 71);
            this.radio_NonLinear.Name = "radio_NonLinear";
            this.radio_NonLinear.Size = new System.Drawing.Size(73, 17);
            this.radio_NonLinear.TabIndex = 0;
            this.radio_NonLinear.TabStop = true;
            this.radio_NonLinear.Text = "Non linear";
            this.radio_NonLinear.UseVisualStyleBackColor = true;
            // 
            // radio_Linear
            // 
            this.radio_Linear.AutoSize = true;
            this.radio_Linear.Location = new System.Drawing.Point(6, 71);
            this.radio_Linear.Name = "radio_Linear";
            this.radio_Linear.Size = new System.Drawing.Size(54, 17);
            this.radio_Linear.TabIndex = 0;
            this.radio_Linear.TabStop = true;
            this.radio_Linear.Text = "Linear";
            this.radio_Linear.UseVisualStyleBackColor = true;
            // 
            // numericKey
            // 
            this.numericKey.Location = new System.Drawing.Point(86, 32);
            this.numericKey.Name = "numericKey";
            this.numericKey.Size = new System.Drawing.Size(42, 20);
            this.numericKey.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 541);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelSelectLanguage);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonCrypt);
            this.Controls.Add(this.labelEncryptedText);
            this.Controls.Add(this.textBoxEncryptedText);
            this.Controls.Add(this.labelDecryptedText);
            this.Controls.Add(this.textBoxDecryptedText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_NonLinear.ResumeLayout(false);
            this.gb_NonLinear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CNonLinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_BNonLinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ANonLinear)).EndInit();
            this.gb_Linear.ResumeLayout(false);
            this.gb_Linear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BLinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ALinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxDecryptedText;
        private System.Windows.Forms.Label labelDecryptedText;
        private System.Windows.Forms.Label labelEncryptedText;
        private System.Windows.Forms.TextBox textBoxEncryptedText;
        private System.Windows.Forms.Button buttonCrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSelectLanguage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonCaesar;
        private System.Windows.Forms.TextBox txt_Phrase;
        private System.Windows.Forms.RadioButton radio_Phrase;
        private System.Windows.Forms.GroupBox gb_NonLinear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_CNonLinear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_BNonLinear;
        private System.Windows.Forms.NumericUpDown num_ANonLinear;
        private System.Windows.Forms.GroupBox gb_Linear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_BLinear;
        private System.Windows.Forms.NumericUpDown num_ALinear;
        private System.Windows.Forms.RadioButton radio_NonLinear;
        private System.Windows.Forms.RadioButton radio_Linear;
        private System.Windows.Forms.NumericUpDown numericKey;
    }
}

