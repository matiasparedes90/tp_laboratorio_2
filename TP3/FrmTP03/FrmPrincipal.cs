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
    public partial class FrmPrincipal : Form
    {
        #region Atributos
        public string nombreVideoClub;
        public FrmIngresarAlquiler alquiler;
        public FrmQuitarAlquiler quitarAlquiler;
        private bool estado;
        #endregion

        #region Constructor
        public FrmPrincipal(string nombre)
        {
            InitializeComponent();
            this.nombreVideoClub = nombre;
            this.alquiler = new FrmIngresarAlquiler();
            this.quitarAlquiler = new FrmQuitarAlquiler();
            this.estado = false;
        }
        #endregion

        #region Propiedades
        public bool Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Cargamos los valores iniciales para operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = this.nombreVideoClub;
            this.rtxMostrarAlquileres.Text = "";
            List<Videoclub> listaAlquileres = this.alquiler.ListadoAlquileres;
            for (int i = 0; i < listaAlquileres.Count; i++)
            {
                rtxMostrarAlquileres.Text += listaAlquileres[i].MostrarTodasLasVentas();
            }
        }
        /// <summary>
        /// Ingresamos un alquiler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresarVentas_Click(object sender, EventArgs e)
        {
            this.btnMostrarVenta.Enabled = true;
            this.btnQuitar.Enabled = false;
            this.alquiler.ShowDialog();
        }
        /// <summary>
        /// Proceso de cerrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea salir?", "Salir del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        /// <summary>
        /// Accion Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Actualizamos la lista de los alquileres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarVenta_Click(object sender, EventArgs e)
        {
            List<Videoclub> listaAlquileres = this.alquiler.ListadoAlquileres;
            if (this.Estado == true)
            {
                listaAlquileres = this.quitarAlquiler.ListadoAlquileres;
                this.estado = false;
            }
            this.rtxMostrarAlquileres.Text = "";
            if (listaAlquileres.Count > 0)
            {
                for (int i = 0; i < listaAlquileres.Count; i++)
                {
                    if (listaAlquileres[i].ListadoProductos.Count > 0)
                    {
                        this.btnQuitar.Enabled = true;
                        this.btnMostrarVenta.Enabled = false;
                    }
                    this.rtxMostrarAlquileres.Text += listaAlquileres[i].MostrarTodasLasVentas();
                }
            }
            else
            {
                MessageBox.Show("No hay ventas registradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Pasamos el listado y llamamos al nuevo formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Estado = true;
            this.btnQuitar.Enabled = false;
            this.btnMostrarVenta.Enabled = true;
            this.quitarAlquiler.ListadoAlquileres = this.alquiler.ListadoAlquileres;
            this.quitarAlquiler.ShowDialog();
        }

        #endregion

    }
}
