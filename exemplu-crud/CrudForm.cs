using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExempluCrud
{
    public partial class CrudForm : Form
    {
        private List<User> useri = new List<User>();

        public CrudForm()
        {
            InitializeComponent();
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            useri = DateDeStart();
            ReincarcaTabelul();
            GolesteCampurile();
            lblStare.Text = "Incarcati " + useri.Count + " useri";
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            User u = CitesteCampurile();
            if (u == null) return;

            useri.Add(u);
            ReincarcaTabelul();
            GolesteCampurile();
            lblStare.Text = "Adaugat: " + u.Username;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int pozitie = PozitiaSelectata();
            if (pozitie < 0)
            {
                MessageBox.Show("Selecteaza intai un rand din tabel.");
                return;
            }

            User u = CitesteCampurile();
            if (u == null) return;

            useri[pozitie] = u;
            ReincarcaTabelul();
            lblStare.Text = "Modificat: " + u.Username;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int pozitie = PozitiaSelectata();
            if (pozitie < 0)
            {
                MessageBox.Show("Selecteaza intai un rand din tabel.");
                return;
            }

            string nume = useri[pozitie].Username;
            useri.RemoveAt(pozitie);
            ReincarcaTabelul();
            GolesteCampurile();
            lblStare.Text = "Sters: " + nume;
        }

        private void dgvUseri_SelectionChanged(object sender, EventArgs e)
        {
            int pozitie = PozitiaSelectata();
            if (pozitie < 0) return;

            User u = useri[pozitie];
            txtUsername.Text = u.Username;
            txtEmail.Text = u.Email;
            txtPassword.Text = u.Password;
            txtTelefon.Text = u.Telefon;
            txtVarsta.Text = u.Varsta.ToString();
            chkValid.Checked = u.Valid;
        }

        private int PozitiaSelectata()
        {
            if (dgvUseri.CurrentRow == null) return -1;
            int i = dgvUseri.CurrentRow.Index;
            if (i < 0 || i >= useri.Count) return -1;
            return i;
        }

        private User CitesteCampurile()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username-ul nu poate fi gol.");
                return null;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Emailul trebuie sa contina @.");
                return null;
            }

            int varsta;
            if (!int.TryParse(txtVarsta.Text, out varsta))
            {
                MessageBox.Show("Varsta trebuie sa fie un numar intreg.");
                return null;
            }

            if (varsta < 1 || varsta > 120)
            {
                MessageBox.Show("Varsta trebuie sa fie intre 1 si 120.");
                return null;
            }

            User u = new User();
            u.Username = txtUsername.Text;
            u.Email = txtEmail.Text;
            u.Password = txtPassword.Text;
            u.Telefon = txtTelefon.Text;
            u.Varsta = varsta;
            u.Valid = chkValid.Checked;
            return u;
        }

        private void GolesteCampurile()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtTelefon.Clear();
            txtVarsta.Clear();
            chkValid.Checked = false;
        }

        private void ReincarcaTabelul()
        {
            dgvUseri.DataSource = null;
            dgvUseri.DataSource = new List<User>(useri);
            if (dgvUseri.Columns.Contains("Password"))
            {
                dgvUseri.Columns["Password"].Visible = false;
            }
        }

        private List<User> DateDeStart()
        {
            List<User> lista = new List<User>();
            lista.Add(Creeaza("andrei_pop", "andrei.popescu@gmail.com", "Andrei99!", true, "0722123456", 25));
            lista.Add(Creeaza("elena_io", "elena.ionescu@yahoo.com", "ElenaSecure20", true, "0731987654", 31));
            lista.Add(Creeaza("vlad_m", "vlad.marcu@outlook.com", "vladmarcu123", false, "0745112233", 19));
            lista.Add(Creeaza("ralu_c", "raluca.constantin@gmail.com", "Ralu*2026", true, "0756445566", 42));
            lista.Add(Creeaza("cosmin_radu", "cosmin.radu@gmail.com", "cosminPass!", true, "0767889900", 28));
            lista.Add(Creeaza("ana_stan", "anamaria.stan@yahoo.com", "ana_maria_99", true, "0721334455", 22));
            lista.Add(Creeaza("marian_d", "marian.dumitru@gmail.com", "marianD76", false, "0732556677", 50));
            lista.Add(Creeaza("AlexGamer", "alex.neagu@outlook.com", "AlexGaming!!", true, "0743778899", 16));
            lista.Add(Creeaza("cristina_v", "cristina.vlad@gmail.com", "CrisVlad85", true, "0754114477", 35));
            lista.Add(Creeaza("stefan_b", "stefan.badea@yahoo.com", "stefanB_99", true, "0765225588", 27));
            return lista;
        }

        private User Creeaza(string username, string email, string password,
                             bool valid, string telefon, int varsta)
        {
            User u = new User();
            u.Username = username;
            u.Email = email;
            u.Password = password;
            u.Valid = valid;
            u.Telefon = telefon;
            u.Varsta = varsta;
            return u;
        }
    }
}
