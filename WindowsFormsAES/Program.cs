using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAES
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AES aes = new AES();

            string plainText = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
            //AES128
            string key = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            //AES192
            //byte[] key = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 };
            //AES256
            //byte[] key = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F };
            string cipherText;

            // AES加密
            cipherText = aes.Encrypt(plainText, key, 128);

            Console.WriteLine("CipherText: ");
            foreach (byte b in cipherText)
            {
                Console.Write("{0:X2} ", b);
            }
            Console.WriteLine("\n");

            // AES解密
            string test = aes.Decrypt(cipherText, key, 128);
            Console.WriteLine("testText: ");
            foreach (byte b in test)
            {
                Console.Write("{0:X2} ", b);
            }
            Console.WriteLine("\n");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_AES());
        }
    }
}
