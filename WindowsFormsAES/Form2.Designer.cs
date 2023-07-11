
namespace WindowsFormsAES
{
    partial class Form_paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_paint));
            this.label_paint1 = new System.Windows.Forms.Label();
            this.button_paint = new System.Windows.Forms.Button();
            this.groupBox_encrypt_round = new System.Windows.Forms.GroupBox();
            this.textBox_encrypt_round = new System.Windows.Forms.TextBox();
            this.groupBox_round = new System.Windows.Forms.GroupBox();
            this.textBox_round = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_encrypt_round.SuspendLayout();
            this.groupBox_round.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_paint1
            // 
            this.label_paint1.AutoSize = true;
            this.label_paint1.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paint1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label_paint1.Location = new System.Drawing.Point(73, 45);
            this.label_paint1.Name = "label_paint1";
            this.label_paint1.Size = new System.Drawing.Size(733, 53);
            this.label_paint1.TabIndex = 1;
            this.label_paint1.Text = "AES Encryption side information";
            // 
            // button_paint
            // 
            this.button_paint.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_paint.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_paint.Location = new System.Drawing.Point(872, 526);
            this.button_paint.Name = "button_paint";
            this.button_paint.Size = new System.Drawing.Size(157, 98);
            this.button_paint.TabIndex = 2;
            this.button_paint.Text = "Paint";
            this.button_paint.UseVisualStyleBackColor = false;
            this.button_paint.Click += new System.EventHandler(this.button_paint_Click);
            // 
            // groupBox_encrypt_round
            // 
            this.groupBox_encrypt_round.Controls.Add(this.textBox_encrypt_round);
            this.groupBox_encrypt_round.Location = new System.Drawing.Point(865, 299);
            this.groupBox_encrypt_round.Name = "groupBox_encrypt_round";
            this.groupBox_encrypt_round.Size = new System.Drawing.Size(164, 82);
            this.groupBox_encrypt_round.TabIndex = 3;
            this.groupBox_encrypt_round.TabStop = false;
            this.groupBox_encrypt_round.Text = "encrypt round";
            // 
            // textBox_encrypt_round
            // 
            this.textBox_encrypt_round.Location = new System.Drawing.Point(17, 36);
            this.textBox_encrypt_round.Name = "textBox_encrypt_round";
            this.textBox_encrypt_round.Size = new System.Drawing.Size(134, 28);
            this.textBox_encrypt_round.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_encrypt_round, "Input encrypt round. ");
            this.textBox_encrypt_round.TextChanged += new System.EventHandler(this.textBox_round_TextChanged);
            // 
            // groupBox_round
            // 
            this.groupBox_round.Controls.Add(this.textBox_round);
            this.groupBox_round.Location = new System.Drawing.Point(866, 407);
            this.groupBox_round.Name = "groupBox_round";
            this.groupBox_round.Size = new System.Drawing.Size(163, 87);
            this.groupBox_round.TabIndex = 4;
            this.groupBox_round.TabStop = false;
            this.groupBox_round.Text = "round";
            // 
            // textBox_round
            // 
            this.textBox_round.Location = new System.Drawing.Point(16, 33);
            this.textBox_round.Name = "textBox_round";
            this.textBox_round.Size = new System.Drawing.Size(134, 28);
            this.textBox_round.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_round, "Input the side information after the nth round of byte substitution you want to o" +
        "btain.");
            this.textBox_round.TextChanged += new System.EventHandler(this.textBox_round_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(833, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 249);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.name.Location = new System.Drawing.Point(445, 638);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 21);
            this.name.TabIndex = 6;
            this.name.Text = "Powered by Phe1ix";
            // 
            // Form_paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 668);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_round);
            this.Controls.Add(this.groupBox_encrypt_round);
            this.Controls.Add(this.button_paint);
            this.Controls.Add(this.label_paint1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form_paint_Load);
            this.groupBox_encrypt_round.ResumeLayout(false);
            this.groupBox_encrypt_round.PerformLayout();
            this.groupBox_round.ResumeLayout(false);
            this.groupBox_round.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_paint1;
        private System.Windows.Forms.Button button_paint;
        private System.Windows.Forms.GroupBox groupBox_encrypt_round;
        private System.Windows.Forms.TextBox textBox_encrypt_round;
        private System.Windows.Forms.GroupBox groupBox_round;
        private System.Windows.Forms.TextBox textBox_round;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}