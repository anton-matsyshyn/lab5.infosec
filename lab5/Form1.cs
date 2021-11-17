using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void button2_Click(object sender, EventArgs e)
        {
            string ivHex = textBox2.Text;

            string keyHex = textBox1.Text;
           
            Chilkat.Crypt2 decrypt = new Chilkat.Crypt2();

            decrypt.CryptAlgorithm = "aes";
            decrypt.CipherMode = "ctr";
            decrypt.KeyLength = 256;
            decrypt.EncodingMode = "base64";
            decrypt.SetEncodedIV(ivHex, "ascii");
            decrypt.SetEncodedKey(keyHex, "ascii");

            string decStr = decrypt.DecryptStringENC(richTextBox1.Text);

            richTextBox2.Text = decStr;
        }

    }
}
