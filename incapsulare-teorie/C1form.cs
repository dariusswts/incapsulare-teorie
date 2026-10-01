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
    public partial class C1form : Form
    {
        public C1form()
        {
            InitializeComponent();
        }

        private void C1form_Load(object sender, EventArgs e)
        {

        }

        private void btnApasa_Click(object sender, EventArgs e)
        {
            int contor = 0;
            contor++;
            lblText2.Text = "Ai apasat butonul";
            lblContor.Text= contor.ToString();
        }
    }
}
