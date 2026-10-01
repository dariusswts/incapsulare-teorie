namespace incapsulare_teorie
{
    partial class C1form
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblContor = new System.Windows.Forms.Label();
            this.btnApasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(203, 191);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(101, 13);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Acesta este un text ";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(306, 191);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(74, 13);
            this.lblText2.TabIndex = 1;
            this.lblText2.Text = "apasa butonul";
            // 
            // lblContor
            // 
            this.lblContor.AutoSize = true;
            this.lblContor.Location = new System.Drawing.Point(416, 191);
            this.lblContor.Name = "lblContor";
            this.lblContor.Size = new System.Drawing.Size(13, 13);
            this.lblContor.TabIndex = 2;
            this.lblContor.Text = "0";
            // 
            // btnApasa
            // 
            this.btnApasa.Location = new System.Drawing.Point(283, 252);
            this.btnApasa.Name = "btnApasa";
            this.btnApasa.Size = new System.Drawing.Size(75, 23);
            this.btnApasa.TabIndex = 3;
            this.btnApasa.Text = "button1";
            this.btnApasa.UseVisualStyleBackColor = true;
            this.btnApasa.Click += new System.EventHandler(this.btnApasa_Click);
            // 
            // C1form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApasa);
            this.Controls.Add(this.lblContor);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Name = "C1form";
            this.Text = "C1form";
            this.Load += new System.EventHandler(this.C1form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblContor;
        private System.Windows.Forms.Button btnApasa;
    }
}