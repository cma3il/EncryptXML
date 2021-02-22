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
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            

        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            
            cbElement.Items.Clear();
            cbElement.Text = "";
            txtKey.Text = "";
            txtRSA.Text = "";

            doc = new XmlDocument();
            try
            {
                
                doc.LoadXml(rtDoc.Text);
               

                foreach (XmlNode node in doc.GetElementsByTagName("*"))
                {

                    if (!cbElement.Items.Contains(node.Name))
                    {
                        cbElement.Items.Add(node.Name);
                   }

                }
                btnEncrypt.Enabled = true;
                btnDecypt.Enabled = true;
                btnSign.Enabled = true;
                btnVerify.Enabled = true;
                MessageBox.Show("XML data loaded successfuly", "INFO");
            }
            catch (Exception)
            {
                MessageBox.Show("Your XML is not well-formed", "ERROR");
                btnEncrypt.Enabled = false;
                btnDecypt.Enabled = false;
                btnSign.Enabled = false;
                btnVerify.Enabled = false;
            }




        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            
            
            if (cbElement.Text=="")
                MessageBox.Show("Please select an XML element first", "ERROR");
            else
            {
                // Create a new AES key.
                Aes key = Aes.Create();
                
                int count = 0;
                
                while (doc.GetElementsByTagName(cbElement.Text).Count != 0)
                {

                    try
                    {

                        Encrypt(doc, cbElement.Text, key);
                        count++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Encryption error", "ERROR");
                        count = 0;
                        break;
                    }


                }
                
                //Save the doc and write it back encrypted
                StringWriter sw = new StringWriter();
                doc.Save(sw);
                rtDoc.Clear();
                rtDoc.Text = sw.ToString();

                //I know I shouldn't do that, however the goal from this project is to just tinker with XML Encryption, use a secure key-exchange method!
                txtKey.Text = Convert.ToBase64String(key.Key);
                
                btnEncrypt.Enabled = false;
                if (count > 0)
                    MessageBox.Show(count + " elements encrypted successfuly!");
            }
                


            

        }

        public static void Encrypt(XmlDocument doc, string elementName, SymmetricAlgorithm key)
        {
            //instance of the encrypted xml
            EncryptedXml eXml = new EncryptedXml();

            //Select specified elements to encrypt
            XmlElement elementToEncrypt = doc.GetElementsByTagName(elementName)[0] as XmlElement;


            //Encrypt using the key
            byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, key, false);
            

            //identifiers for the encrypted XML element
            EncryptedData edElement = new EncryptedData();

                edElement = new EncryptedData();

                edElement.Type = EncryptedXml.XmlEncElementUrl;

                edElement.EncryptionMethod = new EncryptionMethod(EncryptedXml.XmlEncAES256Url);

                edElement.CipherData.CipherValue = encryptedElement;

            //Replace the original element by the encrypted one

            EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);

        }

        public static void Decrypt(XmlDocument doc, SymmetricAlgorithm key)
        {

            // Create an EncryptedData object and populate it.
            EncryptedData edElement = new EncryptedData();

            // Create a new EncryptedXml object.
            EncryptedXml exml = new EncryptedXml();

            // Find the EncryptedData element in the XmlDocument.
            XmlElement encryptedElement = doc.GetElementsByTagName("EncryptedData")[0] as XmlElement;
            edElement.LoadXml(encryptedElement as XmlElement);

            // Decrypt the element using the symmetric key.
            byte[] rgbOutput = exml.DecryptData(edElement, key);
            // Replace the encryptedData element with the plaintext XML element.
            exml.ReplaceData(encryptedElement, rgbOutput);

         
        }

        private void btnDecypt_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "")
                MessageBox.Show("Please enter a decryption key","ERROR");
            else
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
                if (doc.GetElementsByTagName("EncryptedData").Count == 0)
                    MessageBox.Show("Nothing to decrypt here.", "ERROR");
                while (doc.GetElementsByTagName("EncryptedData").Count != 0)
                {

                    try
                    {

                        Decrypt(doc, key);
                        count++;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The decryption key you provided is invalid", "ERROR");
                        count = 0;
                        break;
                    }


                }


                //Save the doc and write it back encrypted
                StringWriter sw = new StringWriter();
                doc.Save(sw);
                rtDoc.Clear();
                rtDoc.Text = sw.ToString();
                if (count > 0)
                    MessageBox.Show(count + " elements decrypted successfuly!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {

            

            // Create a new RSA signing key and save it in the container.
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();

            SignXml(doc, rsaKey);
            //Save the doc and write it back encrypted
            StringWriter sw = new StringWriter();
            doc.Save(sw);
            rtDoc.Clear();
            rtDoc.Text = sw.ToString();

            txtRSA.Text =  rsaKey.ToXmlString(false);

            MessageBox.Show("Document signed successfully!","INFO");
            btnSign.Enabled = false;
        }

        public static void SignXml(XmlDocument xmlDoc, RSA rsaKey)
        {
           

            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Add the key to the SignedXml document.
            signedXml.SigningKey = rsaKey;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.Uri = "";

            // Add an enveloped transformation to the reference.
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtRSA.Text!="")
            {
                RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();

                rsaKey.FromXmlString(txtRSA.Text);

                if (VerifyXml(doc, rsaKey))
                    MessageBox.Show("Signature valid !");
                else
                    MessageBox.Show("Signature is NOT valid !");
            }
            

        }
        public static Boolean VerifyXml(XmlDocument xmlDoc, RSA key)
        {

            // Create a new SignedXml object and pass it
            // the XML document class.
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Find the "Signature" node and create a new
            // XmlNodeList object.
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Signature");

            // Load the first <signature> node.
            signedXml.LoadXml((XmlElement)nodeList[0]);

            // Check the signature and return the result.
            return signedXml.CheckSignature(key);
        }
    }
}
