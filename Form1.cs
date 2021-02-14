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

            //instance of the encrypted xml
            EncryptedXml eXml = new EncryptedXml();
            //byte[] encryptedElement;
            List<byte[]> encryptedElement = new List<byte[]>();
            XmlNodeList elementsToEncrypt = doc.GetElementsByTagName(cbElement.Text);

            foreach (XmlNode elementToEncrypt in elementsToEncrypt)
            {
                encryptedElement.Add(eXml.EncryptData(elementToEncrypt as XmlElement, key, false));
            }
            //Select specified element to encrypt
            //XmlElement elementToEncrypt = doc.GetElementsByTagName(cbElement.Text)[0] as XmlElement;



            //URL identifier of the encrypted XML element
            EncryptedData[] edElements = new EncryptedData[encryptedElement.Count];

            for (int i = 0; i< encryptedElement.Count;i++)
            {
                edElements[i] = new EncryptedData();

                edElements[i].Type = EncryptedXml.XmlEncElementUrl;

                edElements[i].EncryptionMethod = new EncryptionMethod(EncryptedXml.XmlEncAES256Url);

                edElements[i].CipherData.CipherValue = encryptedElement[i];
                
                //Replace the original element by the encrypted one

                EncryptedXml.ReplaceElement(elementsToEncrypt[0] as XmlElement, edElements[i], false);


            }


            //Save the doc and write it back encrypted
            StringWriter sw = new StringWriter();
            doc.Save(sw);
            rtDoc.Clear();
            rtDoc.Text = sw.ToString();
            txtKey.Text = key.Key.ToString();
        }


    }
}
