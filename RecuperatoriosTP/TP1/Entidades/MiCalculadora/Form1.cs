using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.SelectedIndex = 0;
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
        }

        /// <summary>
        /// Realiza una operacion con dos numeros y un operando
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Entidades.Numero num1 = new Entidades.Numero(numero1);
            Entidades.Numero num2 = new Entidades.Numero(numero2);
            return Entidades.Calculadora.Operar(num1, num2, operador);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (!(lblResultado.Text == ""))
            {
                Entidades.Numero numeroABinario = new Entidades.Numero(this.lblResultado.Text);
                double.TryParse(this.lblResultado.Text, out double numeroBinario);
                if (numeroABinario.BinarioDecimal(this.lblResultado.Text) == "Valor inválido")
                {
                    lblResultado.Text = numeroABinario.DecimalBinario(numeroBinario);
                }
                
            }
            else
            {
                MessageBox.Show("Debe realizar primero una operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

            
            if (!(lblResultado.Text == ""))
            {
                Entidades.Numero numeroABinario = new Entidades.Numero(this.lblResultado.Text);
                double.TryParse(this.lblResultado.Text, out double numeroBinario);
                lblResultado.Text = numeroABinario.BinarioDecimal(this.lblResultado.Text);
            }
            else
            {
                MessageBox.Show("Debe realizar primero una operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
