namespace ExempluCrud
{
    partial class CrudForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUseri;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.CheckBox chkValid;
        private System.Windows.Forms.Label lblStare;
        private System.Windows.Forms.GroupBox grpDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvUseri = new System.Windows.Forms.DataGridView();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.chkValid = new System.Windows.Forms.CheckBox();
            this.lblStare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUseri)).BeginInit();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();

            this.dgvUseri.AllowUserToAddRows = false;
            this.dgvUseri.AllowUserToDeleteRows = false;
            this.dgvUseri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUseri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUseri.Location = new System.Drawing.Point(12, 12);
            this.dgvUseri.MultiSelect = false;
            this.dgvUseri.Name = "dgvUseri";
            this.dgvUseri.ReadOnly = true;
            this.dgvUseri.RowHeadersVisible = false;
            this.dgvUseri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUseri.Size = new System.Drawing.Size(660, 250);
            this.dgvUseri.TabIndex = 0;
            this.dgvUseri.SelectionChanged += new System.EventHandler(this.dgvUseri_SelectionChanged);

            this.grpDate.Controls.Add(this.lblUsername);
            this.grpDate.Controls.Add(this.txtUsername);
            this.grpDate.Controls.Add(this.lblEmail);
            this.grpDate.Controls.Add(this.txtEmail);
            this.grpDate.Controls.Add(this.lblPassword);
            this.grpDate.Controls.Add(this.txtPassword);
            this.grpDate.Controls.Add(this.lblTelefon);
            this.grpDate.Controls.Add(this.txtTelefon);
            this.grpDate.Controls.Add(this.lblVarsta);
            this.grpDate.Controls.Add(this.txtVarsta);
            this.grpDate.Controls.Add(this.chkValid);
            this.grpDate.Location = new System.Drawing.Point(12, 275);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(660, 110);
            this.grpDate.TabIndex = 1;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Datele userului";

            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";

            this.txtUsername.Location = new System.Drawing.Point(80, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 20);
            this.txtUsername.TabIndex = 1;

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(250, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";

            this.txtEmail.Location = new System.Drawing.Point(290, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 3;

            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(505, 28);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";

            this.txtPassword.Location = new System.Drawing.Point(565, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(80, 20);
            this.txtPassword.TabIndex = 5;

            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(15, 70);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Telefon";

            this.txtTelefon.Location = new System.Drawing.Point(80, 67);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 20);
            this.txtTelefon.TabIndex = 7;

            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Location = new System.Drawing.Point(250, 70);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(37, 13);
            this.lblVarsta.TabIndex = 8;
            this.lblVarsta.Text = "Varsta";

            this.txtVarsta.Location = new System.Drawing.Point(290, 67);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(60, 20);
            this.txtVarsta.TabIndex = 9;

            this.chkValid.AutoSize = true;
            this.chkValid.Location = new System.Drawing.Point(505, 69);
            this.chkValid.Name = "chkValid";
            this.chkValid.Size = new System.Drawing.Size(51, 17);
            this.chkValid.TabIndex = 10;
            this.chkValid.Text = "Valid";
            this.chkValid.UseVisualStyleBackColor = true;

            this.btnIncarca.Location = new System.Drawing.Point(12, 400);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(100, 32);
            this.btnIncarca.TabIndex = 2;
            this.btnIncarca.Text = "Incarca";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);

            this.btnAdauga.Location = new System.Drawing.Point(125, 400);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(100, 32);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);

            this.btnModifica.Location = new System.Drawing.Point(238, 400);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(100, 32);
            this.btnModifica.TabIndex = 4;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);

            this.btnSterge.Location = new System.Drawing.Point(351, 400);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(100, 32);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);

            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(470, 411);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(0, 13);
            this.lblStare.TabIndex = 6;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.dgvUseri);
            this.Name = "CrudForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Useri - exemplu CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUseri)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
