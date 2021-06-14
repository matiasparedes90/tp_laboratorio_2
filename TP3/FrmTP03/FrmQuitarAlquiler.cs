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
    public partial class FrmQuitarAlquiler : Form
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
            set
            {
                this.alquileres = value;
            }
        }
        #endregion

        #region Constructor
        public FrmQuitarAlquiler()
        {
            InitializeComponent();
            this.alquileres = new List<Videoclub>();
        }
        #endregion

        /// <summary>
        /// Cargamos valores iniciales para operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQuitarAlquiler_Load(object sender, EventArgs e)
        {
            this.cmbCliente.Items.Clear();
            this.cmbProducto.Items.Clear();
            this.txtLegajo.Text = "";
            foreach (Videoclub v in this.alquileres)
            {
                this.cmbCliente.Items.Add(v.cliente.NombreCliente);
            }
        }
        /// <summary>
        /// Cierre del proceso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        /// <summary>
        /// Actualizamos combo y texto dependiendo del valor seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Videoclub v in this.alquileres)
            {
                if (this.cmbCliente.Text == v.cliente.NombreCliente)
                {
                    this.txtLegajo.Text = v.cliente.NroLegajo.ToString();
                    List<Producto> producto = v.ListadoProductos;
                    cmbProducto.Items.Clear();
                    foreach (Producto p in producto)
                    {
                        cmbProducto.Items.Add(p.NombreProducto);
                    }
                }
            }
        }
        /// <summary>
        /// Se realiza la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if ( cmbCliente.Text == "" ||
                     cmbProducto.Text == "" ||
                     txtLegajo.Text == ""
                   )
                {
                    throw new VideoClubException("Sacar alquiler", "No se han completado los datos necesarios para realizar el tramite");
                }
                else
                {
                    int.TryParse(txtLegajo.Text, out int legajo);
                    for (int i = 0; i < this.alquileres.Count; i++)
                    {
                        if (this.alquileres[i].cliente.NroLegajo == legajo)
                        {
                            List<Producto> producto = this.alquileres[i].ListadoProductos;
                            foreach (Producto p in producto)
                            {
                                if (cmbProducto.Text == p.NombreProducto)
                                {
                                    this.alquileres[i] -= p;
                                    break;
                                }
                            }
                        }
                    }
                    this.Hide();

                }
            }
            catch (VideoClubException exepcion)
            {
                MessageBox.Show(exepcion.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
        }
    }
}
