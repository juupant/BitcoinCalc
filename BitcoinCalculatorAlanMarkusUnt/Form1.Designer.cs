namespace BitcoinCalculatorAlanMarkusUnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BitcoinAmountInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrencySelector = new System.Windows.Forms.ComboBox();
            this.TulemusLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BitcoinAmountInput
            // 
            this.BitcoinAmountInput.Location = new System.Drawing.Point(12, 170);
            this.BitcoinAmountInput.Name = "BitcoinAmountInput";
            this.BitcoinAmountInput.Size = new System.Drawing.Size(100, 20);
            this.BitcoinAmountInput.TabIndex = 0;
            this.BitcoinAmountInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mitu bitkoini konverteerida tahad?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "vali valuuta, millesse konverteerida";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "konverteeri";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CurrencySelector
            // 
            this.CurrencySelector.FormattingEnabled = true;
            this.CurrencySelector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "EEK"});
            this.CurrencySelector.Location = new System.Drawing.Point(12, 238);
            this.CurrencySelector.Name = "CurrencySelector";
            this.CurrencySelector.Size = new System.Drawing.Size(121, 21);
            this.CurrencySelector.TabIndex = 5;
            this.CurrencySelector.Text = "Vali valuuta";
            this.CurrencySelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TulemusLabel
            // 
            this.TulemusLabel.AutoSize = true;
            this.TulemusLabel.Location = new System.Drawing.Point(12, 440);
            this.TulemusLabel.Name = "TulemusLabel";
            this.TulemusLabel.Size = new System.Drawing.Size(46, 13);
            this.TulemusLabel.TabIndex = 6;
            this.TulemusLabel.Text = "tulemus:";
            this.TulemusLabel.Visible = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 468);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(895, 80);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "None";
            this.ResultLabel.Visible = false;
            this.ResultLabel.TextChanged += new System.EventHandler(this.ResultLabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1934, 1001);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TulemusLabel);
            this.Controls.Add(this.CurrencySelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BitcoinAmountInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BitcoinAmountInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CurrencySelector;
        private System.Windows.Forms.Label TulemusLabel;
        private System.Windows.Forms.TextBox ResultLabel;
    }
}

