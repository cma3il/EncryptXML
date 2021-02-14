
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
            this.rtDoc = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbElement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtDoc
            // 
            this.rtDoc.Location = new System.Drawing.Point(12, 12);
            this.rtDoc.Name = "rtDoc";
            this.rtDoc.Size = new System.Drawing.Size(450, 554);
            this.rtDoc.TabIndex = 0;
            this.rtDoc.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(509, 286);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(140, 35);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecypt
            // 
            this.btnDecypt.Location = new System.Drawing.Point(509, 478);
            this.btnDecypt.Name = "btnDecypt";
            this.btnDecypt.Size = new System.Drawing.Size(140, 35);
            this.btnDecypt.TabIndex = 3;
            this.btnDecypt.Text = " Decrypt";
            this.btnDecypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "What element would you like to encrypt ?";
            // 
            // cbElement
            // 
            this.cbElement.FormattingEnabled = true;
            this.cbElement.Location = new System.Drawing.Point(509, 234);
            this.cbElement.Name = "cbElement";
            this.cbElement.Size = new System.Drawing.Size(140, 24);
            this.cbElement.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = " Encryption key ?";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(509, 415);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(140, 22);
            this.txtKey.TabIndex = 8;
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(509, 12);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(140, 35);
            this.btnLoadXML.TabIndex = 9;
            this.btnLoadXML.Text = " Load XML";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(726, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = " XML Encryption allows you to store or transport sensitive XML, without worrying " +
    "about the data being easily read. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(641, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = " This procedure encrypts an XML element using the Advanced Encryption Standard (A" +
    "ES) algorithm.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 657);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoadXML);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbElement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rtDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " EncryptXML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtDoc;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

