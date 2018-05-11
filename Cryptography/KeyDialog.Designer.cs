namespace Cryptography
{
    partial class KeyDialog
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericKey = new System.Windows.Forms.NumericUpDown();
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
            this.button_Confirm = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKey)).BeginInit();
            this.gb_NonLinear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CNonLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_BNonLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ANonLinear)).BeginInit();
            this.gb_Linear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ALinear)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 444);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specify key";
            // 
            // numericKey
            // 
            this.numericKey.Location = new System.Drawing.Point(86, 32);
            this.numericKey.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericKey.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.numericKey.Name = "numericKey";
            this.numericKey.Size = new System.Drawing.Size(218, 20);
            this.numericKey.TabIndex = 13;
            this.numericKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txt_Phrase.Location = new System.Drawing.Point(6, 302);
            this.txt_Phrase.Name = "txt_Phrase";
            this.txt_Phrase.Size = new System.Drawing.Size(304, 20);
            this.txt_Phrase.TabIndex = 6;
            // 
            // radio_Phrase
            // 
            this.radio_Phrase.AutoSize = true;
            this.radio_Phrase.Location = new System.Drawing.Point(6, 279);
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
            this.gb_NonLinear.Location = new System.Drawing.Point(6, 165);
            this.gb_NonLinear.Name = "gb_NonLinear";
            this.gb_NonLinear.Size = new System.Drawing.Size(304, 108);
            this.gb_NonLinear.TabIndex = 4;
            this.gb_NonLinear.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "t^2";
            // 
            // num_CNonLinear
            // 
            this.num_CNonLinear.Location = new System.Drawing.Point(54, 73);
            this.num_CNonLinear.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.num_CNonLinear.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.num_CNonLinear.Name = "num_CNonLinear";
            this.num_CNonLinear.Size = new System.Drawing.Size(244, 20);
            this.num_CNonLinear.TabIndex = 1;
            this.num_CNonLinear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "k";
            // 
            // num_BNonLinear
            // 
            this.num_BNonLinear.Location = new System.Drawing.Point(54, 43);
            this.num_BNonLinear.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.num_BNonLinear.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.num_BNonLinear.Name = "num_BNonLinear";
            this.num_BNonLinear.Size = new System.Drawing.Size(244, 20);
            this.num_BNonLinear.TabIndex = 1;
            this.num_BNonLinear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_ANonLinear
            // 
            this.num_ANonLinear.Location = new System.Drawing.Point(54, 17);
            this.num_ANonLinear.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.num_ANonLinear.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.num_ANonLinear.Name = "num_ANonLinear";
            this.num_ANonLinear.Size = new System.Drawing.Size(244, 20);
            this.num_ANonLinear.TabIndex = 1;
            this.num_ANonLinear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb_Linear
            // 
            this.gb_Linear.Controls.Add(this.label2);
            this.gb_Linear.Controls.Add(this.label1);
            this.gb_Linear.Controls.Add(this.num_BLinear);
            this.gb_Linear.Controls.Add(this.num_ALinear);
            this.gb_Linear.Location = new System.Drawing.Point(6, 92);
            this.gb_Linear.Name = "gb_Linear";
            this.gb_Linear.Size = new System.Drawing.Size(304, 46);
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
            this.radio_NonLinear.Location = new System.Drawing.Point(6, 144);
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
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(130, 483);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 15;
            this.button_Confirm.Text = "Ok";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // KeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 518);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyDialog";
            this.Text = "KeyDialog";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKey)).EndInit();
            this.gb_NonLinear.ResumeLayout(false);
            this.gb_NonLinear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CNonLinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_BNonLinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ANonLinear)).EndInit();
            this.gb_Linear.ResumeLayout(false);
            this.gb_Linear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BLinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ALinear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericKey;
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
        private System.Windows.Forms.Button button_Confirm;
    }
}