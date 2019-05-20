﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        private readonly EMarca marca;
        private string codigoDeBarras;
        private readonly ConsoleColor colorPrimarioEmpaque;

        /// <summary>
        /// Retornara la cantidad de calorias de un producto
        /// </summary>
        protected abstract short CantidadCalorias { get; }

        public Producto(string patente, EMarca marca, ConsoleColor color) {
            this.marca = marca;
            this.codigoDeBarras = patente;
            this.colorPrimarioEmpaque = color;
        }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CODIGO DE BARRAS: " + this.codigoDeBarras);
            sb.AppendLine("MARCA          :  " + this.marca);
            sb.AppendLine("COLOR EMPAQUE  :  " + this.colorPrimarioEmpaque);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.Mostrar();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1.codigoDeBarras == v2.codigoDeBarras);
        }
    }
}
