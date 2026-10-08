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
    public partial class CalculatoareForm : Form
    {
        
        public List<Calculator> calculatoare = new List<Calculator>();

        public CalculatoareForm()
        {
            InitializeComponent();
        }

        private void CalculatoareForm_Load(object sender, EventArgs e)
        {
            LoadCalculatoare();
            //CreateCalculatoareColumns();
            //CreateCalculatoareRows();
        }

        private void LoadCalculatoare()
        {
            Calculator c1 = new Calculator();
            c1.marca = "Lenovo";
            c1.model = "Legion 5";
            c1.anFabricatie = 2022;
            c1.procesor = "Ryzen 5";
            c1.pret = "4000 lei";
            c1.ram = 16;

            Calculator c2 = new Calculator();
            c2.marca = "Asus";
            c2.model = "ROG Strix G15";
            c2.anFabricatie = 2023;
            c2.procesor = "Ryzen 7";
            c2.pret = "6000 lei";
            c2.ram = 16;

            Calculator c3 = new Calculator();
            c3.marca = "HP";
            c3.model = "Victus 16";
            c3.anFabricatie = 2023;
            c3.procesor = "Intel i5";
            c3.pret = "4500 lei";
            c3.ram = 16;

            Calculator c4 = new Calculator();
            c4.marca = "Acer";
            c4.model = "Nitro 5";
            c4.anFabricatie = 2022;
            c4.procesor = "Intel i7";
            c4.pret = "5500 lei";
            c4.ram = 16;

            Calculator c5 = new Calculator();
            c5.marca = "Dell";
            c5.model = "G15";
            c5.anFabricatie = 2024;
            c5.procesor = "Intel i7";
            c5.pret = "6500 lei";
            c5.ram = 32;

            Calculator c6 = new Calculator();
            c6.marca = "Apple";
            c6.model = "MacBook Air";
            c6.anFabricatie = 2024;
            c6.procesor = "M3";
            c6.pret = "7000 lei";
            c6.ram = 16;

            Calculator c7 = new Calculator();
            c7.marca = "MSI";
            c7.model = "Katana 15";
            c7.anFabricatie = 2023;
            c7.procesor = "Intel i7";
            c7.pret = "5800 lei";
            c7.ram = 16;

            Calculator c8 = new Calculator();
            c8.marca = "Lenovo";
            c8.model = "IdeaPad 5";
            c8.anFabricatie = 2021;
            c8.procesor = "Ryzen 5";
            c8.pret = "3000 lei";
            c8.ram = 8;

            Calculator c9 = new Calculator();
            c9.marca = "Asus";
            c9.model = "TUF Gaming A15";
            c9.anFabricatie = 2024;
            c9.procesor = "Ryzen 7";
            c9.pret = "6200 lei";
            c9.ram = 32;

            Calculator c10 = new Calculator();
            c10.marca = "HP";
            c10.model = "Pavilion";
            c10.anFabricatie = 2022;
            c10.procesor = "Intel i5";
            c10.pret = "3500 lei";
            c10.ram = 16;

            calculatoare.Add(c1);
            calculatoare.Add(c2);
            calculatoare.Add(c3);
            calculatoare.Add(c4);
            calculatoare.Add(c5);
            calculatoare.Add(c6);
            calculatoare.Add(c7);
            calculatoare.Add(c8);
            calculatoare.Add(c9);
            calculatoare.Add(c10);
        }
        public void CreateCalculatoareColumns()
        {
            dgvCalculatoare.Columns.Clear();

            dgvCalculatoare.Columns.Add("marca", "Marca");
            dgvCalculatoare.Columns.Add("model", "Model");
            dgvCalculatoare.Columns.Add("anFabricatie", "An-Fabricatie");
            dgvCalculatoare.Columns.Add("procesor", "Procesor");
            dgvCalculatoare.Columns.Add("pret", "Pret");
            dgvCalculatoare.Columns.Add("ram", "RAM");
        }
        public void CreateCalculatoareRows()
        {
            dgvCalculatoare.Rows.Clear();

            for (int i = 0; i < calculatoare.Count; i++)
            {
                dgvCalculatoare.Rows.Add(
                    calculatoare[i].marca,
                    calculatoare[i].model,
                    calculatoare[i].anFabricatie,
                    calculatoare[i].procesor,
                    calculatoare[i].pret,
                    calculatoare[i].ram
                );
            }
        }
        public void btnIncarca_Click(object sender, EventArgs e)
        {
            CreateCalculatoareColumns();
            CreateCalculatoareRows();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIncarca_Click_1(object sender, EventArgs e)
        {
            LoadCalculatoare();
            CreateCalculatoareColumns();
            CreateCalculatoareRows();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvCalculatoare.CurrentRow == null)
            {
                MessageBox.Show("Selecteaza intai un rand.");
                return;
            }
            dgvCalculatoare.Rows.RemoveAt(dgvCalculatoare.CurrentRow.Index);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            dgvCalculatoare.Rows.Add(
            txtBoxMarca.Text,
            txtBoxModel.Text,
            txtBoxAnFab.Text,
            txtBoxProcesor.Text,
            txtBoxPret.Text,
            txtBoxRAM.Text
   );
        }
    }
   }

