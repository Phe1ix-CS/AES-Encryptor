using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAES
{
    public partial class Form_AES : Form
    {
        private string plainText;
        private string key;
        private string cipherText;
        private int mode;

        public Form_AES()
        {
            InitializeComponent();
            textBox_明文.TextChanged += textBox_明文_TextChanged;
            textBox_密钥.TextChanged += textBox_密钥_TextChanged;
            textBox_密文.TextChanged += textBox_密文_TextChanged;
        }

        private void textBox_密文_TextChanged(object sender, EventArgs e)
        {
            cipherText = textBox_密文.Text;
        }

        private void textBox_密钥_TextChanged(object sender, EventArgs e)
        {
            key = textBox_密钥.Text;
        }

        private void textBox_明文_TextChanged(object sender, EventArgs e)
        {
            plainText = textBox_明文.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_mode.Items.Add("128");
            comboBox_mode.Items.Add("192");
            comboBox_mode.Items.Add("256");
            comboBox_mode.SelectedIndex = 0;
            textBox_明文.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
        }

        private void comboBox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_mode.SelectedItem.ToString())
            {
                case "128": key = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";break;
                case "192": key = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17"; break;
                case "256": key = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F"; break;
            }
            textBox_密钥.Text = key;
            mode = int.Parse(comboBox_mode.SelectedItem.ToString());
        }

        private void 加密_Click(object sender, EventArgs e)
        {
            AES aes = new AES();

            Regex regex = new Regex(@"^([0-9A-Fa-f]{2}\s*)+$");

            //plainText格式检验
            if (!regex.IsMatch(plainText))
            {
                MessageBox.Show("Input format of plainText error,please input it correctly.\n(e.g.00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF)");
                return;
            }

            int byteCount = (plainText.Length-15) / 2;
            if (byteCount != 16)
            {
                MessageBox.Show("The number of plainText bytes inputed is incorrect.\nPlease input 16 bytes(32 hexadecimal characters).");
                return;
            }

            //key输入格式检验
            if (!regex.IsMatch(plainText))
            {
                MessageBox.Show("Input format of key error,please input it correctly.\n(e.g.00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F)");
                return;
            }

            switch (comboBox_mode.SelectedItem.ToString())
            {
                case "128": 
                    byteCount = (key.Length - 15) / 2;
                    if (byteCount != 16)
                    {
                        MessageBox.Show("The number of key bytes inputed is incorrect.\nPlease input 16 bytes(32 hexadecimal characters).");
                        return;
                    }
                    break;
                case "192":
                    byteCount = (key.Length - 23) / 2;
                    if (byteCount != 24)
                    {
                        MessageBox.Show("The number of key bytes inputed is incorrect.\nPlease input 24 bytes(48 hexadecimal characters).");
                        return;
                    }
                    break;
                case "256":
                    byteCount = (key.Length - 31) / 2;
                    if (byteCount != 32)
                    {
                        MessageBox.Show("The number of key bytes inputed is incorrect.\nPlease input 32 bytes(64 hexadecimal characters).");
                        return;
                    }
                    break;
            }

            cipherText = aes.Encrypt(plainText, key, mode);

            textBox_密文.Text = cipherText;
        }

        private void 解密_Click(object sender, EventArgs e)
        {
            AES aes = new AES();

            Regex regex = new Regex(@"^([0-9A-Fa-f]{2}\s*)+$");

            //cipherText格式检验
            if (!regex.IsMatch(cipherText))
            {
                MessageBox.Show("Input format of cipherText error,please input it correctly.\n(e.g.00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF)");
                return;
            }

            int byteCount = (cipherText.Length - 15) / 2;
            if (byteCount != 16)
            {
                MessageBox.Show("The number of cipherText bytes inputed is incorrect.\nPlease input 16 bytes(32 hexadecimal characters).");
                return;
            }

            //key输入格式检验
            if (!regex.IsMatch(key))
            {
                MessageBox.Show("Input format of key error,please input it correctly.\n(e.g.00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F)");
                return;
            }

            switch (comboBox_mode.SelectedItem.ToString())
            {
                case "128":
                    byteCount = (key.Length - 15) / 2;
                    if (byteCount != 16)
                    {
                        MessageBox.Show("The number of key bytes inputed is incorrect.\nPlease input 16 bytes(32 hexadecimal characters).");
                        return;
                    }
                    break;
                case "192":
                    byteCount = (key.Length - 23) / 2;
                    if (byteCount != 24)
                    {
                        MessageBox.Show("The number of key bytes inputed is incorrect.\nPlease input 24 bytes(48 hexadecimal characters).");
                        return;
                    }
                    break;
                case "256":
                    byteCount = (key.Length - 31) / 2;
                    if (byteCount != 32)
                    {
                        MessageBox.Show("The number of key bytes inputed is incorrect.\nPlease input 32 bytes(64 hexadecimal characters).");
                        return;
                    }
                    break;
            }

            plainText = aes.Decrypt(cipherText, key, mode);

            textBox_明文.Text = plainText;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_paint paintform = new Form_paint();
            paintform.plainText = plainText;
            paintform.key = key;
            paintform.mode = mode;
            paintform.Show();
        }
    }
}
