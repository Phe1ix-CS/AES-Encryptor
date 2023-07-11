namespace WindowsFormsAES
{
    partial class Form_AES
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AES));
            this.加密 = new System.Windows.Forms.Button();
            this.解密 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label_明文 = new System.Windows.Forms.Label();
            this.textBox_明文 = new System.Windows.Forms.TextBox();
            this.label_密钥 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox_密钥 = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label_密文 = new System.Windows.Forms.Label();
            this.textBox_密文 = new System.Windows.Forms.TextBox();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.groupBox_mode = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_paint = new System.Windows.Forms.Button();
            this.textBox_paint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox_mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // 加密
            // 
            this.加密.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.加密.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.加密.ForeColor = System.Drawing.SystemColors.ControlText;
            this.加密.Location = new System.Drawing.Point(807, 597);
            this.加密.Name = "加密";
            this.加密.Size = new System.Drawing.Size(161, 81);
            this.加密.TabIndex = 0;
            this.加密.Text = "Encrypt";
            this.加密.UseVisualStyleBackColor = false;
            this.加密.Click += new System.EventHandler(this.加密_Click);
            // 
            // 解密
            // 
            this.解密.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.解密.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.解密.ForeColor = System.Drawing.SystemColors.ControlText;
            this.解密.Location = new System.Drawing.Point(1019, 597);
            this.解密.Name = "解密";
            this.解密.Size = new System.Drawing.Size(161, 81);
            this.解密.TabIndex = 1;
            this.解密.Text = "Decrypt";
            this.解密.UseVisualStyleBackColor = false;
            this.解密.Click += new System.EventHandler(this.解密_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.name.Location = new System.Drawing.Point(511, 709);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 21);
            this.name.TabIndex = 2;
            this.name.Text = "Powered by Phe1ix";
            // 
            // label_明文
            // 
            this.label_明文.AutoSize = true;
            this.label_明文.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_明文.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_明文.Location = new System.Drawing.Point(15, 57);
            this.label_明文.Name = "label_明文";
            this.label_明文.Size = new System.Drawing.Size(131, 33);
            this.label_明文.TabIndex = 3;
            this.label_明文.Text = "PlainText";
            // 
            // textBox_明文
            // 
            this.textBox_明文.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_明文.Location = new System.Drawing.Point(3, 3);
            this.textBox_明文.Multiline = true;
            this.textBox_明文.Name = "textBox_明文";
            this.textBox_明文.Size = new System.Drawing.Size(483, 136);
            this.textBox_明文.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox_明文, "Input a 16 byte hexadecimal string, seperated by spaces.\r\ne.g. 00 11 22 33 44 55 " +
        "66 77 88 99 AA BB CC DD EE FF");
            this.textBox_明文.TextChanged += new System.EventHandler(this.textBox_明文_TextChanged);
            // 
            // label_密钥
            // 
            this.label_密钥.AutoSize = true;
            this.label_密钥.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_密钥.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_密钥.Location = new System.Drawing.Point(49, 56);
            this.label_密钥.Name = "label_密钥";
            this.label_密钥.Size = new System.Drawing.Size(61, 33);
            this.label_密钥.TabIndex = 5;
            this.label_密钥.Text = "Key";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(67, 158);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainer1.Panel1.Controls.Add(this.label_明文);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_明文);
            this.splitContainer1.Size = new System.Drawing.Size(652, 142);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(67, 352);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainer2.Panel1.Controls.Add(this.label_密钥);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox_密钥);
            this.splitContainer2.Size = new System.Drawing.Size(652, 141);
            this.splitContainer2.SplitterDistance = 158;
            this.splitContainer2.TabIndex = 7;
            // 
            // textBox_密钥
            // 
            this.textBox_密钥.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_密钥.Location = new System.Drawing.Point(4, 3);
            this.textBox_密钥.Multiline = true;
            this.textBox_密钥.Name = "textBox_密钥";
            this.textBox_密钥.Size = new System.Drawing.Size(483, 135);
            this.textBox_密钥.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_密钥, "Input a 16 byte hexadecimal string, seperated by spaces.\r\nPay attention to the nu" +
        "mber of bytes.\r\ne.g.00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F");
            this.textBox_密钥.TextChanged += new System.EventHandler(this.textBox_密钥_TextChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(68, 540);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Honeydew;
            this.splitContainer3.Panel1.Controls.Add(this.label_密文);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBox_密文);
            this.splitContainer3.Size = new System.Drawing.Size(651, 140);
            this.splitContainer3.SplitterDistance = 158;
            this.splitContainer3.TabIndex = 8;
            // 
            // label_密文
            // 
            this.label_密文.AutoSize = true;
            this.label_密文.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_密文.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_密文.Location = new System.Drawing.Point(3, 56);
            this.label_密文.Name = "label_密文";
            this.label_密文.Size = new System.Drawing.Size(148, 33);
            this.label_密文.TabIndex = 0;
            this.label_密文.Text = "CipherText";
            // 
            // textBox_密文
            // 
            this.textBox_密文.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_密文.Location = new System.Drawing.Point(3, 3);
            this.textBox_密文.Multiline = true;
            this.textBox_密文.Name = "textBox_密文";
            this.textBox_密文.Size = new System.Drawing.Size(483, 134);
            this.textBox_密文.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_密文, "Input a 16 byte hexadecimal string, seperated by spaces.\r\ne.g. 00 11 22 33 44 55 " +
        "66 77 88 99 AA BB CC DD EE FF");
            this.textBox_密文.TextChanged += new System.EventHandler(this.textBox_密文_TextChanged);
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Location = new System.Drawing.Point(47, 34);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(161, 32);
            this.comboBox_mode.TabIndex = 9;
            this.comboBox_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_mode_SelectedIndexChanged);
            // 
            // groupBox_mode
            // 
            this.groupBox_mode.Controls.Add(this.comboBox_mode);
            this.groupBox_mode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_mode.Location = new System.Drawing.Point(777, 64);
            this.groupBox_mode.Name = "groupBox_mode";
            this.groupBox_mode.Size = new System.Drawing.Size(217, 75);
            this.groupBox_mode.TabIndex = 10;
            this.groupBox_mode.TabStop = false;
            this.groupBox_mode.Text = "mode";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // button_paint
            // 
            this.button_paint.Image = ((System.Drawing.Image)(resources.GetObject("button_paint.Image")));
            this.button_paint.Location = new System.Drawing.Point(777, 171);
            this.button_paint.Name = "button_paint";
            this.button_paint.Size = new System.Drawing.Size(419, 336);
            this.button_paint.TabIndex = 11;
            this.button_paint.UseVisualStyleBackColor = true;
            this.button_paint.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_paint
            // 
            this.textBox_paint.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_paint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox_paint.Location = new System.Drawing.Point(862, 524);
            this.textBox_paint.Name = "textBox_paint";
            this.textBox_paint.Size = new System.Drawing.Size(256, 34);
            this.textBox_paint.TabIndex = 12;
            this.textBox_paint.Text = "click this cute gif to paint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 53);
            this.label1.TabIndex = 13;
            this.label1.Text = "A simple AES encreyption tool";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1035, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 91);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_AES
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1217, 739);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_paint);
            this.Controls.Add(this.button_paint);
            this.Controls.Add(this.groupBox_mode);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.解密);
            this.Controls.Add(this.加密);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AES";
            this.Text = "AES Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox_mode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 加密;
        private System.Windows.Forms.Button 解密;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label_明文;
        private System.Windows.Forms.TextBox textBox_明文;
        private System.Windows.Forms.Label label_密钥;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox_密钥;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label_密文;
        private System.Windows.Forms.TextBox textBox_密文;
        private System.Windows.Forms.ComboBox comboBox_mode;
        private System.Windows.Forms.GroupBox groupBox_mode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_paint;
        private System.Windows.Forms.TextBox textBox_paint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

