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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsAES
{
    public partial class Form_paint : Form
    {
        public string plainText { get; set; }
        public string key { get; set; }
        public int mode { get; set; }
        private string encrypt_round;
        private string round;

        public Form_paint()
        {
            InitializeComponent();
            textBox_encrypt_round.TextChanged += textBox_round_TextChanged;
            textBox_round.TextChanged += textBox_round_TextChanged_1;
        }

        private void TextBox_round_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form_paint_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_round_TextChanged(object sender, EventArgs e)
        {
            encrypt_round = textBox_encrypt_round.Text;
        }

        private void button_paint_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            Regex regex = new Regex(@"^[1-9]\d*$");

            //encrypt_round格式检验
            if (!regex.IsMatch(encrypt_round.ToString()) || int.Parse(encrypt_round) <= 0)
            {
                MessageBox.Show("Please input a positive integer.\n(e.g.1000)");
                return;
            }

            //round格式检验
            if (!regex.IsMatch(round.ToString()) || int.Parse(round) <= 0)
            {
                MessageBox.Show("Please input a positive integer.\n(e.g.1)");
                return;
            }

            switch (mode.ToString())
            {
                case "128":
                    if (int.Parse(round) > 10)
                    {
                        MessageBox.Show("The value of round inputed is out of range.\n(0 < round < 11)");
                        return;
                    }
                    break;
                case "192":
                    if (int.Parse(round) > 12)
                    {
                        MessageBox.Show("The value of round inputed is out of range.\n(0 < round < 13)");
                        return;
                    }
                    break;
                case "256":
                    if (int.Parse(round) > 14)
                    {
                        MessageBox.Show("The value of round inputed is out of range.\n(0 < round < 15)");
                        return;
                    }
                    break;

            }
            Chart chart1 = new Chart();
            chart1.Size = new Size(500, 300);
            chart1.Location = new Point(50, 100);
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;

            for (int round_temp = 1; round_temp <= int.Parse(encrypt_round); round_temp++)
            {
                byte firstByte = aes.GetFirstByteofFirstSubByte(plainText, key, mode, int.Parse(round));

                plainText = aes.Encrypt(plainText, key, mode);
                
                series.Points.AddXY(round_temp, firstByte);
            }

            chart1.Series.Add(series);

            Controls.Add(chart1);
        }

        private void textBox_round_TextChanged_1(object sender, EventArgs e)
        {
            round = textBox_round.Text;
        }
    }
}
