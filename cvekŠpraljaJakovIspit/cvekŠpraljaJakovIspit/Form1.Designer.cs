namespace cvekŠpraljaJakovIspit
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
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.richTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(105, 395);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 34);
            this.btnUnesi.TabIndex = 0;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.BtnUnesi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(243, 395);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 34);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // richTxt
            // 
            this.richTxt.Location = new System.Drawing.Point(105, 13);
            this.richTxt.Name = "richTxt";
            this.richTxt.Size = new System.Drawing.Size(370, 349);
            this.richTxt.TabIndex = 2;
            this.richTxt.Text = "";
            this.richTxt.TextChanged += new System.EventHandler(this.RichTxt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 510);
            this.Controls.Add(this.richTxt);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUnesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.RichTextBox richTxt;
    }
}

