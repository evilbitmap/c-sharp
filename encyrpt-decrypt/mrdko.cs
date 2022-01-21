using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace encrypt_decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDialog_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {

                openDialog.InitialDirectory = @"C:\";
                openDialog.Filter = "any file (*.*) | *.*";
                openDialog.RestoreDirectory = false;

                if(openDialog.ShowDialog() == DialogResult.OK)
                {
                    textFilePath.Text = openDialog.FileName;
                }

            }
        }
        private void EncryptFile(string filepath, byte[] Key, byte[] IV)
        {
            var des = new DESCryptoServiceProvider();

            //content = byte filepath
            byte[] content = File.ReadAllBytes(filepath);

            //DES
            using(des)
            {
                des.IV = IV;
                des.Key = Key;
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;
            }

            //memory stream
            using (var memStream = new MemoryStream())
            {
                //crypto stream
                CryptoStream cStream = new CryptoStream(memStream, des.CreateEncryptor(), CryptoStreamMode.Write);
                cStream.Write(content, 0, content.Length);
                cStream.FlushFinalBlock();
                File.WriteAllBytes(filepath, memStream.ToArray());

            }
        }
        private void DecryptFile(string filepath, byte[] Key, byte[] IV)
        {
            byte[] encrypted = File.ReadAllBytes(filepath);
            var des = new DESCryptoServiceProvider();
            using (des)
            {
                des.IV = IV;
                des.Key = Key;
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, des.CreateDecryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filepath, memStream.ToArray());
                    
                }
            }

        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            DES DESalg = DES.Create();
            byte[] Key = Encoding.UTF8.GetBytes(textKey.Text);
            EncryptFile(textFilePath.Text, Key, Key);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            DES DESalg = DES.Create();
            byte[] Key = Encoding.UTF8.GetBytes(textKey.Text);
            DecryptFile(textFilePath.Text, Key, Key);

        }
    }
}
