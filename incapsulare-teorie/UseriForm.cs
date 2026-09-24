using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace incapsulare_teorie
{
    public partial class UseriForm : Form
    {
        private List<User> useri = new List<User>();

        public UseriForm()
        {
            InitializeComponent();
            CreateColumns();
        }

        private void CreateColumns()
        {
            dgvUseri.Columns.Clear();
            dgvUseri.Columns.Add("username", "Username");
            dgvUseri.Columns.Add("email", "Email");
            dgvUseri.Columns.Add("password", "Password");
            dgvUseri.Columns.Add("phoneNr", "Telefon");
            dgvUseri.Columns.Add("age", "Varsta");
            dgvUseri.Columns.Add("valid", "Valid");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            useri = IncarcaUseri();

            dgvUseri.Rows.Clear();
            for (int i = 0; i < useri.Count; i++)
            {
                User u = useri[i];
                dgvUseri.Rows.Add(u.username, u.email, u.password,
                                  u.phoneNr, u.age, u.valid);
            }

            lblStare.Text = "Incarcati " + useri.Count + " useri";
        }

        private List<User> IncarcaUseri()
        {
            List<User> lista = new List<User>();

            lista.Add(Creeaza("andrei_pop", "andrei.popescu@gmail.com",
                              "Andrei99!", true, "0722123456", 25));
            lista.Add(Creeaza("elena_io", "elena.ionescu@yahoo.com",
                              "ElenaSecure20", true, "0731987654", 31));
            lista.Add(Creeaza("vlad_m", "vlad.marcu@outlook.com",
                              "vladmarcu123", false, "0745112233", 19));
            lista.Add(Creeaza("ralu_c", "raluca.constantin@gmail.com",
                              "Ralu*2026", true, "0756445566", 42));
            lista.Add(Creeaza("cosmin_radu", "cosmin.radu@gmail.com",
                              "cosminPass!", true, "0767889900", 28));
            lista.Add(Creeaza("ana_stan", "anamaria.stan@yahoo.com",
                              "ana_maria_99", true, "0721334455", 22));
            lista.Add(Creeaza("marian_d", "marian.dumitru@gmail.com",
                              "marianD76", false, "0732556677", 50));
            lista.Add(Creeaza("AlexGamer", "alex.neagu@outlook.com",
                              "AlexGaming!!", true, "0743778899", 16));
            lista.Add(Creeaza("cristina_v", "cristina.vlad@gmail.com",
                              "CrisVlad85", true, "0754114477", 35));
            lista.Add(Creeaza("stefan_b", "stefan.badea@yahoo.com",
                              "stefanB_99", true, "0765225588", 27));

            return lista;
        }

        private User Creeaza(string username, string email, string password,
                             bool valid, string phoneNr, int age)
        {
            User u = new User();
            u.username = username;
            u.email = email;
            u.password = password;
            u.valid = valid;
            u.phoneNr = phoneNr;
            u.age = age;
            return u;
        }
    }
}
