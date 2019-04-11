using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            bool validar = false;
            double nro = 0;
            // Si no estan vacios puedo operar, caso contrario genero un error
            if ((txtNumero1.Text.Length != 0 && txtNumero2.Text.Length != 0) && ((validar = double.TryParse(txtNumero1.Text, out nro)) && (validar = double.TryParse(txtNumero2.Text, out nro)))) {
                Numero nro1 = new Numero(txtNumero1.Text);
                Numero nro2 = new Numero(txtNumero2.Text);
                lblResultado.Text = (Calculadora.Operar(nro1, nro2, cmbOperador.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar números para operar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            if (lblResultado.Text.Length!=0 && !(lblResultado.Text.Equals("Valor Invalido")))
            {
                Numero nro = new Numero(lblResultado.Text);
                lblResultado.Text = nro.DecimalBinario(lblResultado.Text);
            }
            else
            {
                MessageBox.Show("Debe realizar una operación para la conversión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length != 0 && !(lblResultado.Text.Equals("Valor Invalido")))
            {
                
                Numero nro = new Numero(lblResultado.Text);
                lblResultado.Text = nro.BinarioDecimal(lblResultado.Text);
                
            }
            else
            {
                MessageBox.Show("Debe realizar una operación para la conversión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargo valores por default al Combo Box
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
            cmbOperador.SelectedIndex = 0;

        }
    }
}
