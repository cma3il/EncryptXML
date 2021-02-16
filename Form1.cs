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
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            

        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            //TODO fix reloading new xml 
            cbElement.Items.Clear();
            doc = new XmlDocument();
            try
            {
                
                doc.LoadXml(rtDoc.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Check your XML code", "Error");
            }


            foreach (XmlNode node in doc.GetElementsByTagName("*"))
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
            Aes key = Aes.Create();

            Encrypt(doc, cbElement.Text, key);


            //Save the doc and write it back encrypted
            StringWriter sw = new StringWriter();
            doc.Save(sw);
            rtDoc.Clear();
            rtDoc.Text = sw.ToString();

            //I know I shouldn't do that, however the goal from this project is to just tinker with XML Encryption, use a secure key-exchange method!
            txtKey.Text = Convert.ToBase64String(key.Key);
        }

        public static void Encrypt(XmlDocument doc, string elementName, SymmetricAlgorithm key)
        {
            //couldve handled the iteration like I did in Decrypt function, wouldve been cleaner but its 2AM n im too lazy to go through this one may be later
            //instance of the encrypted xml
            EncryptedXml eXml = new EncryptedXml();
            List<byte[]> encryptedElement = new List<byte[]>();
            XmlNodeList elementsToEncrypt = doc.GetElementsByTagName(elementName);

            //Select specified elements to encrypt

            foreach (XmlNode elementToEncrypt in elementsToEncrypt)
            {
                encryptedElement.Add(eXml.EncryptData(elementToEncrypt as XmlElement, key, false));
            }



            //identifiers for the encrypted XML element
            EncryptedData[] edElements = new EncryptedData[encryptedElement.Count];

            for (int i = 0; i < encryptedElement.Count; i++)
            {
                edElements[i] = new EncryptedData();

                edElements[i].Type = EncryptedXml.XmlEncElementUrl;

                edElements[i].EncryptionMethod = new EncryptionMethod(EncryptedXml.XmlEncAES256Url);

                edElements[i].CipherData.CipherValue = encryptedElement[i];

                //Replace the original element by the encrypted one

                EncryptedXml.ReplaceElement(elementsToEncrypt[0] as XmlElement, edElements[i], false);


            }
            if (encryptedElement.Count > 0)
                MessageBox.Show(encryptedElement.Count + " elements encrypted successfuly!");
        }

        public static void Decrypt(XmlDocument doc, SymmetricAlgorithm Alg)
        {

            // Create an EncryptedData object and populate it.
            EncryptedData edElement = new EncryptedData();

            // Create a new EncryptedXml object.
            EncryptedXml exml = new EncryptedXml();

            // Find the EncryptedData element in the XmlDocument.
            XmlElement encryptedElement = doc.GetElementsByTagName("EncryptedData")[0] as XmlElement;
            edElement.LoadXml(encryptedElement as XmlElement);

            // Decrypt the element using the symmetric key.
            byte[] rgbOutput = exml.DecryptData(edElement, Alg);
            // Replace the encryptedData element with the plaintext XML element.
            exml.ReplaceData(encryptedElement, rgbOutput);

         
        }

        private void btnDecypt_Click(object sender, EventArgs e)
        {
            Aes key = Aes.Create();
            try
            {
                //yeah yeah
                key.Key = Convert.FromBase64String(txtKey.Text);
            }
            catch (FormatException)
            {
                ; ;
            }
            

            int count = 0;
            while(doc.GetElementsByTagName("EncryptedData").Count != 0)
            {
                
                try
                {

                    Decrypt(doc, key);
                    count++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong key", "Error");
                    count = 0;
                    break;
                }
                
                
            }
            

            //Save the doc and write it back encrypted
            StringWriter sw = new StringWriter();
            doc.Save(sw);
            rtDoc.Clear();
            rtDoc.Text = sw.ToString();
            if(count>0)
                MessageBox.Show(count + " elements encrypted successfuly!");
        }
    }
}
