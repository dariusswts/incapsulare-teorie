namespace incapsulare_teorie
{
    partial class Masiniform
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
            this.dgvMasini = new System.Windows.Forms.DataGridView();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.grbDateM = new System.Windows.Forms.GroupBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblAnFabricatie = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBoxCapacitateM = new System.Windows.Forms.TextBox();
            this.txtBoxPret = new System.Windows.Forms.TextBox();
            this.txtBoxHP = new System.Windows.Forms.TextBox();
            this.txtBoxAnFab = new System.Windows.Forms.TextBox();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasini)).BeginInit();
            this.grbDateM.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMasini
            // 
            this.dgvMasini.AllowUserToAddRows = false;
            this.dgvMasini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasini.Location = new System.Drawing.Point(25, 3);
            this.dgvMasini.Name = "dgvMasini";
            this.dgvMasini.ReadOnly = true;
            this.dgvMasini.RowHeadersVisible = false;
            this.dgvMasini.Size = new System.Drawing.Size(732, 256);
            this.dgvMasini.TabIndex = 0;
            this.dgvMasini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnIncarca
            // 
            this.btnIncarca.Location = new System.Drawing.Point(25, 406);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(101, 36);
            this.btnIncarca.TabIndex = 1;
            this.btnIncarca.Text = "Incarca";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(145, 410);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(144, 32);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga Masina";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(286, 23);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModel.TabIndex = 3;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(109, 22);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMarca.TabIndex = 4;
            // 
            // grbDateM
            // 
            this.grbDateM.Controls.Add(this.lblHP);
            this.grbDateM.Controls.Add(this.lblPret);
            this.grbDateM.Controls.Add(this.lblCP);
            this.grbDateM.Controls.Add(this.lblAnFabricatie);
            this.grbDateM.Controls.Add(this.lblModel);
            this.grbDateM.Controls.Add(this.lblMarca);
            this.grbDateM.Controls.Add(this.txtBoxCapacitateM);
            this.grbDateM.Controls.Add(this.txtBoxPret);
            this.grbDateM.Controls.Add(this.txtBoxHP);
            this.grbDateM.Controls.Add(this.txtBoxAnFab);
            this.grbDateM.Controls.Add(this.txtBoxMarca);
            this.grbDateM.Controls.Add(this.txtBoxModel);
            this.grbDateM.Location = new System.Drawing.Point(25, 265);
            this.grbDateM.Name = "grbDateM";
            this.grbDateM.Size = new System.Drawing.Size(732, 135);
            this.grbDateM.TabIndex = 5;
            this.grbDateM.TabStop = false;
            this.grbDateM.Text = "Datele Masini";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(434, 71);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(68, 13);
            this.lblHP.TabIndex = 14;
            this.lblHP.Text = "Horse Power";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(246, 71);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(34, 13);
            this.lblPret.TabIndex = 13;
            this.lblPret.Text = "Pretul";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(15, 71);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(88, 13);
            this.lblCP.TabIndex = 12;
            this.lblCP.Text = "Capacitate Motor";
            // 
            // lblAnFabricatie
            // 
            this.lblAnFabricatie.AutoSize = true;
            this.lblAnFabricatie.Location = new System.Drawing.Point(433, 29);
            this.lblAnFabricatie.Name = "lblAnFabricatie";
            this.lblAnFabricatie.Size = new System.Drawing.Size(69, 13);
            this.lblAnFabricatie.TabIndex = 11;
            this.lblAnFabricatie.Text = "An-Fabricatie";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(244, 30);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(40, 29);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca";
            // 
            // txtBoxCapacitateM
            // 
            this.txtBoxCapacitateM.Location = new System.Drawing.Point(109, 64);
            this.txtBoxCapacitateM.Name = "txtBoxCapacitateM";
            this.txtBoxCapacitateM.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCapacitateM.TabIndex = 8;
            // 
            // txtBoxPret
            // 
            this.txtBoxPret.Location = new System.Drawing.Point(286, 64);
            this.txtBoxPret.Name = "txtBoxPret";
            this.txtBoxPret.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPret.TabIndex = 7;
            // 
            // txtBoxHP
            // 
            this.txtBoxHP.Location = new System.Drawing.Point(508, 64);
            this.txtBoxHP.Name = "txtBoxHP";
            this.txtBoxHP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHP.TabIndex = 6;
            // 
            // txtBoxAnFab
            // 
            this.txtBoxAnFab.Location = new System.Drawing.Point(508, 23);
            this.txtBoxAnFab.Name = "txtBoxAnFab";
            this.txtBoxAnFab.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAnFab.TabIndex = 5;
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(311, 414);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(100, 28);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // Masiniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.grbDateM);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.dgvMasini);
            this.Name = "Masiniform";
            this.Text = "Masiniform";
            this.Load += new System.EventHandler(this.Masiniform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasini)).EndInit();
            this.grbDateM.ResumeLayout(false);
            this.grbDateM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMasini;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox txtBoxMarca;
        private System.Windows.Forms.GroupBox grbDateM;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxCapacitateM;
        private System.Windows.Forms.TextBox txtBoxPret;
        private System.Windows.Forms.TextBox txtBoxHP;
        private System.Windows.Forms.TextBox txtBoxAnFab;
        private System.Windows.Forms.Label lblAnFabricatie;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Button btnSterge;
    }
}