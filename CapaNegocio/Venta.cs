﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Venta
    {
        #region VM
        private int idVenta;
        private string nombreCliente;
        private string apellidoCliente;
        private DateTime fecha;
        private string observaciones;
        private double precio;
        private Producto producto;
        #endregion

        #region PROPERTIES
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public double Precio { get => precio; set => precio = value; }
        public Producto Producto { get => producto; set => producto = value; }
        #endregion

        #region BUILDERS
        public Venta(int idVenta, string nombreCliente, string apellidoCliente, DateTime fecha, string observaciones, double precio, Producto producto)
        {
            this.idVenta = idVenta;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.fecha = fecha;
            this.observaciones = observaciones;
            this.precio = precio;
            this.producto = producto;
        }

        public Venta() {
            idVenta = 0;
            nombreCliente = "";
            apellidoCliente = "";
            fecha = DateTime.Today;
            observaciones = "";
            precio = 0.0;
            producto = null;
        }
        #endregion

        #region METHODS
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eVenta venta = new eVenta();

            if (this.idVenta == 0)
            {
                CargarFilaVenta(venta);
                dc.eVenta.InsertOnSubmit(venta);
            }
            else
            {
                venta = (from x in dc.eVenta where x.id == this.idVenta select x).FirstOrDefault();
                CargarFilaVenta(venta);
            }
            dc.SubmitChanges();
        }

        public void CargarFilaVenta(eVenta venta)
        {
            venta.id = this.IdVenta;
            venta.nombreCliente = this.NombreCliente;
            venta.apellidoCliente = this.ApellidoCliente;
            venta.fecha = this.Fecha;
            venta.observaciones = this.Observaciones;
            venta.precio = this.Precio;
            venta.idProducto = this.Producto.IdProducto;
        }

        public static IQueryable BuscarIQ(string buscado)
        {
            buscado = buscado.ToLower();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eVenta
                        where x.id.ToString().Contains(buscado) ||
                        x.nombreCliente.Contains(buscado) ||
                        x.apellidoCliente.Contains(buscado) ||
                        x.fecha.ToString().Contains(buscado) ||
                        x.precio.ToString().Contains(buscado)
                        select new
                        {
                            ID = x.id,
                            Cliente = x.nombreCliente + ", " + x.apellidoCliente.ToUpper(),
                            Fecha = x.fecha,
                            Producto = x.eProducto.eTipoPrenda.tipo + " " + x.eProducto.eColor.colorName,
                            Precio = "$ " + (int)x.precio,
                            Observaciones = x.observaciones
                        };
            return filas;
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var encontrado = (from x in dc.eVenta where x.id == this.idVenta select x).FirstOrDefault();
            if (encontrado != null)
            {
                dc.eVenta.DeleteOnSubmit(encontrado);
                dc.SubmitChanges();
            }
            else
                throw new Exception("No se pudo eliminar la venta, el id " + this.idVenta + " no fue encontrado.");
        }

        public static Venta BuscarPorId(int idBuscado)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eVenta where x.id == idBuscado select x).FirstOrDefault();
            if (enc != null)
                return new Venta(enc.id, enc.nombreCliente, enc.apellidoCliente, enc.fecha, enc.observaciones, enc.precio, Producto.BuscarPorId(enc.idProducto));
            return null;
        }
        #endregion
    }
}
