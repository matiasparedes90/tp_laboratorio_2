using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Registros_Consumos
{
    public class Registro_Consumo
    {
        #region Atributos
        private List<Mesa> listMesas;
        private List<Delivery> listDelivery;
        private List<Empleado> empleados;
        #endregion

        #region Constructor
        public Registro_Consumo()
        {
            this.empleados = new List<Empleado>();
            this.listDelivery = new List<Delivery>();
            this.listMesas = new List<Mesa>();
            
        }

        #endregion

        #region Métodos
        public double ConsumoTotal()
        {
            double consumo = 0;

            for (int i = 0; i < this.empleados.Count; i++)
                consumo += this.empleados[i].Consumo;

            return consumo;

        }

        public double ConsumoDelivery()
        {
            double consumo = 0;
            for (int i = 0; i < this.empleados.Count; i++)
                if (this.empleados[i].Tipo == "Delivery")
                    consumo += this.empleados[i].Consumo;

            return consumo;
        }

        public bool EstadoMesa(Mesa mesa)
        {
            bool estado = false;

            for(int i = 0; i < this.listMesas.Count; i++)
            {
                if (this.listMesas[i] == mesa)
                    estado = this.listMesas[i].Estado;
            }
            return estado;
        }

        public void RegistrarPago(string metodo, Mesa mesa)
        {
            for (int i = 0; i < this.listMesas.Count; i++)
                if (this.listMesas[i] == mesa)
                    this.listMesas[i].MetedoPago = metodo;

        }

        public double ConsumoMesero(string mesero)
        {
            double consumo = 0; 

            for(int i = 0; i < this.empleados.Count; i++)
            {
                if (this.empleados[i].Nombre == mesero)
                {
                    consumo += this.empleados[i].Consumo;
                }
            }

            return consumo;
        }

        public void CargarMesa(Mesa mesa)
        {
            bool noCargar = false;

            this.listMesas.Add(mesa);

            for (int i = 0; i < this.empleados.Count; i++)
            {
                if (this.empleados[i].Nombre == mesa.Mesero)
                {
                    noCargar = true;
                    break;
                }
                    
            }

            if (!(noCargar))
                this.empleados.Add(new Empleado(mesa.Mesero, "Mesero"));

        }

        public void CargarDelivery(Delivery delivery)
        {
            bool noCargar = false;

            this.listDelivery.Add(delivery);

            for (int i = 0; i < this.empleados.Count; i++)
            {
                if (this.empleados[i].Nombre == delivery.DeliveryAsig)
                {
                    noCargar = true;
                    break;
                }

            }

            if (!(noCargar))
                this.empleados.Add(new Empleado(delivery.DeliveryAsig, "Delivery"));

        }

        public void AgregarConsumo(int identificador, Administración_Menú.Plato plato)
        {
            for(int i = 0; i < this.listMesas.Count; i++)
            {
                if (this.listMesas[i].NroMesa == identificador)
                {
                    this.listMesas[i].Consumo = plato.Precio;
                    break;
                }
            }

            for (int i = 0; i < this.listDelivery.Count; i++)
            {
                if (this.listDelivery[i].NroDelivery == identificador)
                {
                    this.listDelivery[i].Consumo = plato.Precio;
                    break;
                }
            }

            // SI no encuentra tirar excepción

        }
        #endregion
    }
}
