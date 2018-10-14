namespace EncryptionWorkbench
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reversalEncryptionBtn = new System.Windows.Forms.RadioButton();
            this.subEncryptionBtn = new System.Windows.Forms.RadioButton();
            this.compositeEncryptionBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptionTxt = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(117, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Encryption Workbench";
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(15, 88);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(421, 20);
            this.inputTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type the text you want to encrypt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select type of encryption:";
            // 
            // reversalEncryptionBtn
            // 
            this.reversalEncryptionBtn.AutoSize = true;
            this.reversalEncryptionBtn.Location = new System.Drawing.Point(15, 154);
            this.reversalEncryptionBtn.Name = "reversalEncryptionBtn";
            this.reversalEncryptionBtn.Size = new System.Drawing.Size(120, 17);
            this.reversalEncryptionBtn.TabIndex = 4;
            this.reversalEncryptionBtn.TabStop = true;
            this.reversalEncryptionBtn.Text = "Reversal Encryption";
            this.reversalEncryptionBtn.UseVisualStyleBackColor = true;
            this.reversalEncryptionBtn.CheckedChanged += new System.EventHandler(this.clear);
            // 
            // subEncryptionBtn
            // 
            this.subEncryptionBtn.AutoSize = true;
            this.subEncryptionBtn.Location = new System.Drawing.Point(15, 173);
            this.subEncryptionBtn.Name = "subEncryptionBtn";
            this.subEncryptionBtn.Size = new System.Drawing.Size(133, 17);
            this.subEncryptionBtn.TabIndex = 5;
            this.subEncryptionBtn.TabStop = true;
            this.subEncryptionBtn.Text = "Substitution Encryption";
            this.subEncryptionBtn.UseVisualStyleBackColor = true;
            this.subEncryptionBtn.CheckedChanged += new System.EventHandler(this.clear);
            // 
            // compositeEncryptionBtn
            // 
            this.compositeEncryptionBtn.AutoSize = true;
            this.compositeEncryptionBtn.Location = new System.Drawing.Point(15, 192);
            this.compositeEncryptionBtn.Name = "compositeEncryptionBtn";
            this.compositeEncryptionBtn.Size = new System.Drawing.Size(127, 17);
            this.compositeEncryptionBtn.TabIndex = 6;
            this.compositeEncryptionBtn.TabStop = true;
            this.compositeEncryptionBtn.Text = "Composite Encryption";
            this.compositeEncryptionBtn.UseVisualStyleBackColor = true;
            this.compositeEncryptionBtn.CheckedChanged += new System.EventHandler(this.clear);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Encryption:";
            // 
            // encryptionTxt
            // 
            this.encryptionTxt.Location = new System.Drawing.Point(15, 249);
            this.encryptionTxt.Name = "encryptionTxt";
            this.encryptionTxt.ReadOnly = true;
            this.encryptionTxt.Size = new System.Drawing.Size(421, 20);
            this.encryptionTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Decryption:";
            // 
            // decryptionTxt
            // 
            this.decryptionTxt.Location = new System.Drawing.Point(15, 308);
            this.decryptionTxt.Name = "decryptionTxt";
            this.decryptionTxt.ReadOnly = true;
            this.decryptionTxt.Size = new System.Drawing.Size(421, 20);
            this.decryptionTxt.TabIndex = 9;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(118, 348);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 11;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(256, 348);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 12;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Image = ((System.Drawing.Image)(resources.GetObject("restartBtn.Image")));
            this.restartBtn.Location = new System.Drawing.Point(15, 346);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(29, 25);
            this.restartBtn.TabIndex = 13;
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(452, 404);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptionTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptionTxt);
            this.Controls.Add(this.compositeEncryptionBtn);
            this.Controls.Add(this.subEncryptionBtn);
            this.Controls.Add(this.reversalEncryptionBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Encryption Workbench";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton reversalEncryptionBtn;
        private System.Windows.Forms.RadioButton subEncryptionBtn;
        private System.Windows.Forms.RadioButton compositeEncryptionBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encryptionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptionTxt;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button restartBtn;
    }
}

