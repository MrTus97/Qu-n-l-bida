namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "md5",
            "sha1",
            "md4",
            "sha256",
            "sha512"});
            this.cboType.Location = new System.Drawing.Point(464, 172);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(98, 21);
            this.cboType.TabIndex = 18;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(428, 176);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(30, 13);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Loại:";
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Location = new System.Drawing.Point(85, 237);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(484, 103);
            this.WebBrowser1.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(81, 214);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Kết quả:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(487, 199);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 14;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Green;
            this.Label2.Location = new System.Drawing.Point(170, 121);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(413, 20);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "GIÃI MÃ CHUỔI MD5, SHA1, SHA256, SHA512 ...";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(149, 173);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(273, 20);
            this.txtInput.TabIndex = 11;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(85, 176);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(30, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "MD5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 442);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.WebBrowser WebBrowser1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnDecrypt;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtInput;
        internal System.Windows.Forms.Label Label1;
    }
}

