namespace incapsulare_teorie
{
    partial class UseriForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUseri;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblStare;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvUseri = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblStare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUseri)).BeginInit();
            this.SuspendLayout();

            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 30);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Incarca userii";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(148, 20);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(0, 13);
            this.lblStare.TabIndex = 1;

            this.dgvUseri.AllowUserToAddRows = false;
            this.dgvUseri.AllowUserToDeleteRows = false;
            this.dgvUseri.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUseri.Location = new System.Drawing.Point(12, 55);
            this.dgvUseri.MultiSelect = false;
            this.dgvUseri.Name = "dgvUseri";
            this.dgvUseri.ReadOnly = true;
            this.dgvUseri.RowHeadersVisible = false;
            this.dgvUseri.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUseri.Size = new System.Drawing.Size(700, 300);
            this.dgvUseri.TabIndex = 2;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 370);
            this.Controls.Add(this.dgvUseri);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.btnLoad);
            this.Name = "UseriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Useri - coloane create din cod";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUseri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
