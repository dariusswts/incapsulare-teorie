using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incapsulare_teorie
{
    public partial class Masiniform : Form
    {
        
        public List<Masina> masini= new List<Masina>();



        public Masiniform()
        {
            InitializeComponent();
        }

        private void Masiniform_Load(object sender, EventArgs e)
        {
            LoadMasini();
            //CreateMasiniColumns();
            //CreateMasiniRows();


        }

        private  void  LoadMasini()
        {
            Masina m1 = new Masina();
            m1.marca = "Bmw";
            m1.model = "e 46";
            m1.anfabricatie = 2001;
            m1.capacitateMotor = "3L";
            m1.pret = "8000$";
            m1.horsepower = 337;


            Masina m2= new Masina();
            m2.marca = "Mercedes-Benz";
            m2.model = "S classe 500";
            m2.anfabricatie = 2024;
            m2.capacitateMotor = "4.0L";
            m2.pret = "80.000$";
            m2.horsepower = 340;

            Masina m3 = new Masina();
            m3.marca = "Audi";
            m3.model = "RS6 Avant";
            m3.anfabricatie = 2021;
            m3.capacitateMotor = "4.0L";
            m3.pret = "110.000$";
            m3.horsepower = 600;

            Masina m4 = new Masina();
            m4.marca = "Porsche";
            m4.model = "911 Turbo S";
            m4.anfabricatie = 2023;
            m4.capacitateMotor = "3.7L";
            m4.pret = "220.000$";
            m4.horsepower = 650;

            Masina m5 = new Masina();
            m5.marca = "Volkswagen";
            m5.model = "Golf 7 GTI";
            m5.anfabricatie = 2018;
            m5.capacitateMotor = "2.0L";
            m5.pret = "22.000$";
            m5.horsepower = 245;

            Masina m6 = new Masina();
            m6.marca = "Dacia";
            m6.model = "Duster";
            m6.anfabricatie = 2022;
            m6.capacitateMotor = "1.3L";
            m6.pret = "19.500$";
            m6.horsepower = 150;

            Masina m7 = new Masina();
            m7.marca = "Toyota";
            m7.model = "Supra MK4";
            m7.anfabricatie = 1998;
            m7.capacitateMotor = "3.0L";
            m7.pret = "75.000$";
            m7.horsepower = 326;

            Masina m8 = new Masina();
            m8.marca = "Ford";
            m8.model = "Mustang GT";
            m8.anfabricatie = 2020;
            m8.capacitateMotor = "5.0L";
            m8.pret = "45.000$";
            m8.horsepower = 460;

            Masina m9 = new Masina();
            m9.marca = "Tesla";
            m9.model = "Model S Plaid";
            m9.anfabricatie = 2024;
            m9.capacitateMotor = "Electric";
            m9.pret = "90.000$";
            m9.horsepower = 1020;

            Masina m10 = new Masina();
            m10.marca = "Nissan";
            m10.model = "GT-R R35";
            m10.anfabricatie = 2017;
            m10.capacitateMotor = "3.8L";
            m10.pret = "95.000$";
            m10.horsepower = 565;

          
            masini.Add(m1);
            masini.Add(m2);
            masini.Add(m3);
            masini.Add(m4);
            masini.Add(m5);
            masini.Add(m6);
            masini.Add(m7);
            masini.Add(m8);
            masini.Add(m9);
            masini.Add(m10);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CreateMasiniColumns()
        {
            dgvMasini.Columns.Clear();
            dgvMasini.Columns.Add("marca", "Marca");
            dgvMasini.Columns.Add("model", "Model");
            dgvMasini.Columns.Add("anfabricatie", "An-Fabricatie");
            dgvMasini.Columns.Add("capacitateMotor", "Capacitate-Motor");
            dgvMasini.Columns.Add("pret", "Pret");
            dgvMasini.Columns.Add("horsepower", "Horse-Power");

        }

        public void CreateMasiniRows()
        {
          
            dgvMasini.Rows.Clear();
            for(int i = 0; i < masini.Count; i++)
            {

                dgvMasini.Rows.Add(masini[i].marca, masini[i].model, masini[i].anfabricatie, masini[i].capacitateMotor, masini[i].pret, masini[i].horsepower);
            }
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            CreateMasiniColumns();
            CreateMasiniRows();
          
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
       
            dgvMasini.Rows.Add(txtBoxMarca);
        }

        /*
        public Masina incarcaCampurile()
        {
            if (txtBoxMarca.Text == "")
            {
                MessageBox.Show("Marca nu poate fi gol.");
                return null;
            }
            if (txtBoxModel.Text == "")
            {
                MessageBox.Show("Model-ul nu poate fi gol");
                return null;
            }
        }
        */
    }
}
