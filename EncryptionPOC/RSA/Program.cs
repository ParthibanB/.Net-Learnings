using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using ExtensionMethods;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class Program
    {
        public static void Main(string[] args)
        {
            // RSACryptoServiceProvider is used to create Public and Private KEYs 
            var rsa = new RSACryptoServiceProvider();
            var publicPrivateKey = rsa.ToXmlString(true);
            var publicKey = rsa.ToXmlString(false);

            using (var publicPrivateKeyfile = new StreamWriter("E:\\Keys\\PrivateKey.txt"))
            {
                publicPrivateKeyfile.WriteLine(publicPrivateKey);
                Console.WriteLine("Created PrivateKey");
            }

            using (var publicKeyFile = new StreamWriter("E:\\Keys\\PublicKey.txt"))
            {
               publicKeyFile.WriteLine(publicKey);
               Console.WriteLine("Created Public key");
            }
        }

        private void Readimagefile()
        {
            const string imageFolderPath = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            const string filename = "Penguins.jpeg";
            var filelpath = Path.Combine(imageFolderPath, filename);
            if (Directory.Exists(imageFolderPath))
            {
                Image imagefile = Image.FromFile(filelpath);
                byte[] imagebyte = imagefile.ToByteArray(ImageFormat.Jpeg);
                Console.WriteLine(imagebyte);
            }
        }
    }
}
