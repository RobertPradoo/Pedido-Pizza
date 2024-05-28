using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float total = 0;
            int quantidade;

            quantidade = int.Parse(txtQuantidade.Text);

            if (cmbSabores.SelectedIndex == 0)
                total += 18 * quantidade;

            else if (cmbSabores.SelectedIndex == 1)
                total += 12 * quantidade;

            else if (cmbSabores.SelectedIndex == 2)
                total += 10 * quantidade;

            //adicionais

            if (cbBorda.Checked)
            {
                total += 5 * quantidade;
            }
            if (cbMolhos.Checked)
                total += 4 * quantidade;

            if (cbMaionese.Checked)
                total += 6 * quantidade;

            //Tamanhos 

            if (rbPequena.Checked)
            {
                total = total;
            }
            else if (rbMedia.Checked)
            {
                total += 12 * quantidade;
            }
            else if (rbGrande.Checked)
            {
                total += 20 * quantidade;
            }
          

            txtTotal.Text = total.ToString();
        }

        private void cmbSabores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPedido_Click(object sender, EventArgs e)
        {

        }

        private void lblSabores_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnCalcular;
        }
    }
}

