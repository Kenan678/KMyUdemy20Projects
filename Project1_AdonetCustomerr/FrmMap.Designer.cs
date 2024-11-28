namespace Project1_AdonetCustomerr
{
    partial class FrmMap
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
            this.btnOpenCityForm = new System.Windows.Forms.Button();
            this.btnOpenCustomerForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCityForm
            // 
            this.btnOpenCityForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOpenCityForm.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCityForm.Location = new System.Drawing.Point(139, 45);
            this.btnOpenCityForm.Name = "btnOpenCityForm";
            this.btnOpenCityForm.Size = new System.Drawing.Size(224, 53);
            this.btnOpenCityForm.TabIndex = 0;
            this.btnOpenCityForm.Text = "Şəhər işləmləri";
            this.btnOpenCityForm.UseVisualStyleBackColor = false;
            this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
            // 
            // btnOpenCustomerForm
            // 
            this.btnOpenCustomerForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOpenCustomerForm.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCustomerForm.Location = new System.Drawing.Point(139, 116);
            this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
            this.btnOpenCustomerForm.Size = new System.Drawing.Size(224, 53);
            this.btnOpenCustomerForm.TabIndex = 1;
            this.btnOpenCustomerForm.Text = "Müştəri işləmləri";
            this.btnOpenCustomerForm.UseVisualStyleBackColor = false;
            this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(139, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıxış ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(502, 327);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenCustomerForm);
            this.Controls.Add(this.btnOpenCityForm);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMap";
            this.Load += new System.EventHandler(this.FrmMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCityForm;
        private System.Windows.Forms.Button btnOpenCustomerForm;
        private System.Windows.Forms.Button btnExit;
    }
}