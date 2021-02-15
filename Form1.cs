using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EncryptXML
{
    public partial class Form1 : Form
    {
        XmlDocument doc;
        ArrayList elements = new ArrayList();
        Aes key = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc = new XmlDocument();
            
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            cbElement.Items.Clear();
            try
            {
                doc.LoadXml(rtDoc.Text);
            } catch(Exception ex)
            {
                MessageBox.Show("Check your XML code", "Error");
            }
            
            

             

            foreach (System.Xml.XmlNode node in doc.GetElementsByTagName("*"))
            {
               
                    if (!elements.Contains(node.Name))
                    {
                        elements.Add(node.Name);
                        cbElement.Items.Add(node.Name);
                    }
                
            }
            
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Create a new AES key.
            key = Aes.Create();
            
            //Select specified element to encrypt
            XmlElement elementToEncrypt = doc.GetElementsByTagName(cbElement.Text)[0] as XmlElement;


            EncryptedXml eXml = new EncryptedXml();

            byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, key, false);

            EncryptedData edElement = new EncryptedData();
            edElement.Type = EncryptedXml.XmlEncElementUrl;

            string encryptionMethod = null;

            if (key is Aes)
            {
                encryptionMethod = EncryptedXml.XmlEncAES256Url;
            }
            else
            {
                // Throw an exception if the transform is not AES
                throw new CryptographicException("The specified algorithm is not supported or not recommended for XML Encryption.");
            }

            edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);

            edElement.CipherData.CipherValue = encryptedElement;

            EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);

            StringWriter sw = new StringWriter();
            doc.Save(sw);
            rtDoc.Clear();
            rtDoc.Text = sw.ToString();
            //https://docs.microsoft.com/en-us/dotnet/standard/security/how-to-encrypt-xml-elements-with-symmetric-keys
        }


    }
}
