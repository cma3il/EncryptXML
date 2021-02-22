
namespace EncryptXML
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
            this.rtDoc = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbElement = new System.Windows.Forms.ComboBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtRSA = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtDoc
            // 
            this.rtDoc.AcceptsTab = true;
            this.rtDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtDoc.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDoc.Location = new System.Drawing.Point(315, 12);
            this.rtDoc.Name = "rtDoc";
            this.rtDoc.Size = new System.Drawing.Size(747, 638);
            this.rtDoc.TabIndex = 0;
            this.rtDoc.Text = "<info>  \nInsert your XML document here\n</info>  \n";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEncrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(36, 263);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(263, 55);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecypt
            // 
            this.btnDecypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDecypt.Enabled = false;
            this.btnDecypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDecypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDecypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDecypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecypt.ForeColor = System.Drawing.Color.White;
            this.btnDecypt.Location = new System.Drawing.Point(37, 410);
            this.btnDecypt.Name = "btnDecypt";
            this.btnDecypt.Size = new System.Drawing.Size(263, 55);
            this.btnDecypt.TabIndex = 3;
            this.btnDecypt.Text = " Decrypt";
            this.btnDecypt.UseVisualStyleBackColor = false;
            this.btnDecypt.Click += new System.EventHandler(this.btnDecypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Element to encrypt ?";
            // 
            // cbElement
            // 
            this.cbElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbElement.FormattingEnabled = true;
            this.cbElement.Location = new System.Drawing.Point(36, 225);
            this.cbElement.Name = "cbElement";
            this.cbElement.Size = new System.Drawing.Size(263, 28);
            this.cbElement.TabIndex = 6;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(37, 370);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(263, 27);
            this.txtKey.TabIndex = 8;
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoadXML.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoadXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoadXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadXML.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadXML.ForeColor = System.Drawing.Color.White;
            this.btnLoadXML.Location = new System.Drawing.Point(37, 140);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(263, 35);
            this.btnLoadXML.TabIndex = 9;
            this.btnLoadXML.Text = " Load XML Data";
            this.btnLoadXML.UseVisualStyleBackColor = false;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1000, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = " XML Encryption allows you to store or transport sensitive XML, without worrying " +
    "about the data being easily read. And XML Signature assures its authenticity.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.txtRSA);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSign);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLoadXML);
            this.panel1.Controls.Add(this.btnEncrypt);
            this.panel1.Controls.Add(this.btnDecypt);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbElement);
            this.panel1.Location = new System.Drawing.Point(-22, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 650);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(29, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 4);
            this.panel3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Encryption key ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "by  ENSIAS M3S 20/21";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = " XMLSecurity";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 647);
            this.panel2.TabIndex = 12;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSign.Enabled = false;
            this.btnSign.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(36, 524);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(263, 55);
            this.btnSign.TabIndex = 14;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Document Signature";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(915, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = " This tool encrypts an XML element using the Advanced Encryption Standard (AES) a" +
    "lgorithm. And signs the whole document using an RSA key.";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerify.Enabled = false;
            this.btnVerify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(240, 597);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(59, 27);
            this.btnVerify.TabIndex = 16;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtRSA
            // 
            this.txtRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRSA.Location = new System.Drawing.Point(36, 597);
            this.txtRSA.Name = "txtRSA";
            this.txtRSA.Size = new System.Drawing.Size(196, 27);
            this.txtRSA.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1068, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XMLSecurity - Made by M3S Students - ENSIAS 2020/2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtDoc;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbElement;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtRSA;
    }
}

