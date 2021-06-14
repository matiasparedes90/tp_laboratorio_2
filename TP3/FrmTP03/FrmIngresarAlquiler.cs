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

namespace FrmTP03
{
    public partial class FrmIngresarAlquiler : Form
    {
        #region Atributos
        public List<Videoclub> alquileres;
        #endregion

        #region Propiedades
        public List<Videoclub> ListadoAlquileres
        {
            get
            {
                return this.alquileres;
            }
        }
        public Videoclub this [int i]
        {
            get
            {
                return this.alquileres[i];
            }
        }
        #endregion

        #region Constructor
        public FrmIngresarAlquiler()
        {
            InitializeComponent();
            this.alquileres = new List<Videoclub>();
            Clientes c1 = new Clientes("Matias Paredes.", 1001);
            Clientes c2 = new Clientes("Jorge Saenz.", 1002);
            Clientes c3 = new Clientes("Micaela Guitierrez.", 1003);
            Videoclub a1 = new Videoclub(c1);
            Videoclub a2= new Videoclub(c2);
            Videoclub a3 = new Videoclub(c3);
            this.alquileres.Add(a1);
            this.alquileres.Add(a2);
            this.alquileres.Add(a3);
        }
        #endregion

        #region Metodos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    this.txtCatDur.Text   == "" ||
                    this.cmbClientes.Text  == "" || 
                    this.txtGenero.Text   == "" ||
                    this.txtLegajo.Text   == "" ||
                    this.txtNombre.Text   == "" ||
                    this.cmbProducto.Text == ""

                    )
                {
                    throw new VideoClubException("Ingresar Alquiler", "Debe completar los campos faltantes sin excepción.");
                }
                else
                {
                
                    int.TryParse(txtLegajo.Text, out int legajo);
                    for (int i = 0; i < this.alquileres.Count; i++)
                       {
                        if (this.alquileres[i].cliente.NroLegajo == legajo)
                        {
                            if (cmbProducto.Text == "Juego")
                            {
                                Juego producto = new Juego(txtNombre.Text, txtCatDur.Text, txtGenero.Text);
                                this.alquileres[i] += producto;
                            }
                            else
                            {
                                Pelicula producto = new Pelicula(txtNombre.Text, txtCatDur.Text, txtGenero.Text);
                                this.alquileres[i] += producto;
                            }
                            break;
                        }
                    }
                    
                    this.txtCatDur.Text = "";
                    this.cmbClientes.SelectedIndex = 0;
                    this.txtGenero.Text = "";
                    this.txtLegajo.Text = "";
                    this.txtNombre.Text = "";
                    this.cmbProducto.SelectedIndex = 0;
                    this.Hide();
                }

            }
            catch (VideoClubException excepcion)
            {
                MessageBox.Show(excepcion.Message, "Error al cargar el alquiler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmIngresarAlquiler_Load(object sender, EventArgs e)
        {
            this.cmbProducto.Items.Clear();
            this.cmbClientes.Items.Clear();
            this.cmbProducto.Items.Add(Producto.TipoProducto.Juego);
            this.cmbProducto.Items.Add(Producto.TipoProducto.Pelicula);
            foreach (Videoclub v in this.alquileres)
            {
                this.cmbClientes.Items.Add(v.cliente.NombreCliente);
            }
            
        }

        /// <summary>
        /// Carga el text dependiendo del campo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbProducto.Text == "Juego")
            {
                this.lblCatDur.Text = "Plataforma";
            }
            else
            {
                this.lblCatDur.Text = "Duración";
            }
        }
        
        /// <summary>
        /// Actualiza el valor legajo dependiendo del cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Videoclub v in this.alquileres)
            {
                if (v.cliente.NombreCliente == this.cmbClientes.Text)
                {
                    this.txtLegajo.Text = v.cliente.NroLegajo.ToString();
                }
            }
        }
        #endregion

    }
}
