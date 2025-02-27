namespace Project8_RapidApiCurrency
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
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtBrimPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbDollar = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbPound = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblGpb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Location = new System.Drawing.Point(40, 84);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(44, 16);
            this.lblDollar.TabIndex = 0;
            this.lblDollar.Text = "label1";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(171, 84);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(44, 16);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "label3";
            // 
            // txtBrimPrice
            // 
            this.txtBrimPrice.Location = new System.Drawing.Point(192, 207);
            this.txtBrimPrice.Name = "txtBrimPrice";
            this.txtBrimPrice.Size = new System.Drawing.Size(174, 22);
            this.txtBrimPrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birim Tutar";
            // 
            // rdbDollar
            // 
            this.rdbDollar.AutoSize = true;
            this.rdbDollar.Location = new System.Drawing.Point(43, 162);
            this.rdbDollar.Name = "rdbDollar";
            this.rdbDollar.Size = new System.Drawing.Size(64, 20);
            this.rdbDollar.TabIndex = 6;
            this.rdbDollar.TabStop = true;
            this.rdbDollar.Text = "Dollar";
            this.rdbDollar.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(174, 162);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(56, 20);
            this.rdbEuro.TabIndex = 7;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbPound
            // 
            this.rdbPound.AutoSize = true;
            this.rdbPound.Location = new System.Drawing.Point(301, 162);
            this.rdbPound.Name = "rdbPound";
            this.rdbPound.Size = new System.Drawing.Size(65, 20);
            this.rdbPound.TabIndex = 8;
            this.rdbPound.TabStop = true;
            this.rdbPound.Text = "Sterlin";
            this.rdbPound.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Islemi Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Odenecek Tutar";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(192, 235);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(174, 22);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // lblGpb
            // 
            this.lblGpb.AutoSize = true;
            this.lblGpb.Location = new System.Drawing.Point(311, 84);
            this.lblGpb.Name = "lblGpb";
            this.lblGpb.Size = new System.Drawing.Size(44, 16);
            this.lblGpb.TabIndex = 12;
            this.lblGpb.Text = "label3";
            this.lblGpb.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 474);
            this.Controls.Add(this.lblGpb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbPound);
            this.Controls.Add(this.rdbEuro);
            this.Controls.Add(this.rdbDollar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrimPrice);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDollar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox txtBrimPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbDollar;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbPound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblGpb;
    }
}

