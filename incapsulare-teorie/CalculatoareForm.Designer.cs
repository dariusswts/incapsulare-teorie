namespace incapsulare_teorie
{
    partial class CalculatoareForm
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
            this.dgvCalculatoare = new System.Windows.Forms.DataGridView();
            this.groupBoxCalculatoare = new System.Windows.Forms.GroupBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxAnFab = new System.Windows.Forms.TextBox();
            this.txtBoxProcesor = new System.Windows.Forms.TextBox();
            this.txtBoxPret = new System.Windows.Forms.TextBox();
            this.txtBoxRAM = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblAnFab = new System.Windows.Forms.Label();
            this.lblProcesor = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculatoare)).BeginInit();
            this.groupBoxCalculatoare.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCalculatoare
            // 
            this.dgvCalculatoare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculatoare.Location = new System.Drawing.Point(2, 12);
            this.dgvCalculatoare.Name = "dgvCalculatoare";
            this.dgvCalculatoare.Size = new System.Drawing.Size(795, 246);
            this.dgvCalculatoare.TabIndex = 0;
            this.dgvCalculatoare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBoxCalculatoare
            // 
            this.groupBoxCalculatoare.Controls.Add(this.lblRAM);
            this.groupBoxCalculatoare.Controls.Add(this.lblPret);
            this.groupBoxCalculatoare.Controls.Add(this.lblProcesor);
            this.groupBoxCalculatoare.Controls.Add(this.lblAnFab);
            this.groupBoxCalculatoare.Controls.Add(this.lblModel);
            this.groupBoxCalculatoare.Controls.Add(this.lblMarca);
            this.groupBoxCalculatoare.Controls.Add(this.txtBoxRAM);
            this.groupBoxCalculatoare.Controls.Add(this.txtBoxPret);
            this.groupBoxCalculatoare.Controls.Add(this.txtBoxProcesor);
            this.groupBoxCalculatoare.Controls.Add(this.txtBoxAnFab);
            this.groupBoxCalculatoare.Controls.Add(this.txtBoxModel);
            this.groupBoxCalculatoare.Controls.Add(this.txtBoxMarca);
            this.groupBoxCalculatoare.Location = new System.Drawing.Point(12, 264);
            this.groupBoxCalculatoare.Name = "groupBoxCalculatoare";
            this.groupBoxCalculatoare.Size = new System.Drawing.Size(776, 133);
            this.groupBoxCalculatoare.TabIndex = 1;
            this.groupBoxCalculatoare.TabStop = false;
            this.groupBoxCalculatoare.Text = "insert_data";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(93, 415);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnIncarca
            // 
            this.btnIncarca.Location = new System.Drawing.Point(12, 415);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(75, 23);
            this.btnIncarca.TabIndex = 1;
            this.btnIncarca.Text = "incarca lista";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click_1);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(174, 415);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 2;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(255, 415);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 3;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(336, 415);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 4;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(56, 19);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMarca.TabIndex = 0;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(56, 62);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModel.TabIndex = 1;
            // 
            // txtBoxAnFab
            // 
            this.txtBoxAnFab.Location = new System.Drawing.Point(81, 106);
            this.txtBoxAnFab.Name = "txtBoxAnFab";
            this.txtBoxAnFab.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAnFab.TabIndex = 2;
            // 
            // txtBoxProcesor
            // 
            this.txtBoxProcesor.Location = new System.Drawing.Point(299, 19);
            this.txtBoxProcesor.Name = "txtBoxProcesor";
            this.txtBoxProcesor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProcesor.TabIndex = 3;
            // 
            // txtBoxPret
            // 
            this.txtBoxPret.Location = new System.Drawing.Point(299, 62);
            this.txtBoxPret.Name = "txtBoxPret";
            this.txtBoxPret.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPret.TabIndex = 4;
            // 
            // txtBoxRAM
            // 
            this.txtBoxRAM.Location = new System.Drawing.Point(299, 107);
            this.txtBoxRAM.Name = "txtBoxRAM";
            this.txtBoxRAM.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRAM.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(13, 19);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(14, 65);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model";
            // 
            // lblAnFab
            // 
            this.lblAnFab.AutoSize = true;
            this.lblAnFab.Location = new System.Drawing.Point(6, 109);
            this.lblAnFab.Name = "lblAnFab";
            this.lblAnFab.Size = new System.Drawing.Size(66, 13);
            this.lblAnFab.TabIndex = 8;
            this.lblAnFab.Text = "AnFabricatie";
            // 
            // lblProcesor
            // 
            this.lblProcesor.AutoSize = true;
            this.lblProcesor.Location = new System.Drawing.Point(244, 26);
            this.lblProcesor.Name = "lblProcesor";
            this.lblProcesor.Size = new System.Drawing.Size(49, 13);
            this.lblProcesor.TabIndex = 9;
            this.lblProcesor.Text = "Procesor";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(267, 69);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 10;
            this.lblPret.Text = "Pret";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(262, 113);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(31, 13);
            this.lblRAM.TabIndex = 11;
            this.lblRAM.Text = "RAM";
            // 
            // CalculatoareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.groupBoxCalculatoare);
            this.Controls.Add(this.dgvCalculatoare);
            this.Name = "CalculatoareForm";
            this.Text = "CalculatoareForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculatoare)).EndInit();
            this.groupBoxCalculatoare.ResumeLayout(false);
            this.groupBoxCalculatoare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalculatoare;
        private System.Windows.Forms.GroupBox groupBoxCalculatoare;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblProcesor;
        private System.Windows.Forms.Label lblAnFab;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxRAM;
        private System.Windows.Forms.TextBox txtBoxPret;
        private System.Windows.Forms.TextBox txtBoxProcesor;
        private System.Windows.Forms.TextBox txtBoxAnFab;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox txtBoxMarca;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCauta;
    }
}