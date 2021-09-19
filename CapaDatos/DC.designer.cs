﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GestionVentas")]
	public partial class DCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InserteVenta(eVenta instance);
    partial void UpdateeVenta(eVenta instance);
    partial void DeleteeVenta(eVenta instance);
    partial void InserteDetalleVenta(eDetalleVenta instance);
    partial void UpdateeDetalleVenta(eDetalleVenta instance);
    partial void DeleteeDetalleVenta(eDetalleVenta instance);
    partial void InserteProducto(eProducto instance);
    partial void UpdateeProducto(eProducto instance);
    partial void DeleteeProducto(eProducto instance);
    #endregion
		
		public DCDataContext() : 
				base(global::CapaDatos.Properties.Settings.Default.GestionVentasConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<eVenta> eVenta
		{
			get
			{
				return this.GetTable<eVenta>();
			}
		}
		
		public System.Data.Linq.Table<eDetalleVenta> eDetalleVenta
		{
			get
			{
				return this.GetTable<eDetalleVenta>();
			}
		}
		
		public System.Data.Linq.Table<eProducto> eProducto
		{
			get
			{
				return this.GetTable<eProducto>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Venta")]
	public partial class eVenta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombreCliente;
		
		private System.DateTime _fecha;
		
		private string _observaciones;
		
		private double _precio;
		
		private string _apellidoCliente;
		
		private EntitySet<eDetalleVenta> _DetalleVenta;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreClienteChanging(string value);
    partial void OnnombreClienteChanged();
    partial void OnfechaChanging(System.DateTime value);
    partial void OnfechaChanged();
    partial void OnobservacionesChanging(string value);
    partial void OnobservacionesChanged();
    partial void OnprecioChanging(double value);
    partial void OnprecioChanged();
    partial void OnapellidoClienteChanging(string value);
    partial void OnapellidoClienteChanged();
    #endregion
		
		public eVenta()
		{
			this._DetalleVenta = new EntitySet<eDetalleVenta>(new Action<eDetalleVenta>(this.attach_DetalleVenta), new Action<eDetalleVenta>(this.detach_DetalleVenta));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreCliente", DbType="VarChar(50)")]
		public string nombreCliente
		{
			get
			{
				return this._nombreCliente;
			}
			set
			{
				if ((this._nombreCliente != value))
				{
					this.OnnombreClienteChanging(value);
					this.SendPropertyChanging();
					this._nombreCliente = value;
					this.SendPropertyChanged("nombreCliente");
					this.OnnombreClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="Date NOT NULL")]
		public System.DateTime fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this.OnfechaChanging(value);
					this.SendPropertyChanging();
					this._fecha = value;
					this.SendPropertyChanged("fecha");
					this.OnfechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_observaciones", DbType="VarChar(150)")]
		public string observaciones
		{
			get
			{
				return this._observaciones;
			}
			set
			{
				if ((this._observaciones != value))
				{
					this.OnobservacionesChanging(value);
					this.SendPropertyChanging();
					this._observaciones = value;
					this.SendPropertyChanged("observaciones");
					this.OnobservacionesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Float NOT NULL")]
		public double precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this.OnprecioChanging(value);
					this.SendPropertyChanging();
					this._precio = value;
					this.SendPropertyChanged("precio");
					this.OnprecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoCliente", DbType="VarChar(50)")]
		public string apellidoCliente
		{
			get
			{
				return this._apellidoCliente;
			}
			set
			{
				if ((this._apellidoCliente != value))
				{
					this.OnapellidoClienteChanging(value);
					this.SendPropertyChanging();
					this._apellidoCliente = value;
					this.SendPropertyChanged("apellidoCliente");
					this.OnapellidoClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Venta_DetalleVenta", Storage="_DetalleVenta", ThisKey="id", OtherKey="idVenta")]
		public EntitySet<eDetalleVenta> eDetalleVenta
		{
			get
			{
				return this._DetalleVenta;
			}
			set
			{
				this._DetalleVenta.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DetalleVenta(eDetalleVenta entity)
		{
			this.SendPropertyChanging();
			entity.eVenta = this;
		}
		
		private void detach_DetalleVenta(eDetalleVenta entity)
		{
			this.SendPropertyChanging();
			entity.eVenta = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DetalleVenta")]
	public partial class eDetalleVenta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _idVenta;
		
		private int _idProducto;
		
		private double _precio;
		
		private EntityRef<eVenta> _Venta;
		
		private EntityRef<eProducto> _Producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnidVentaChanging(int value);
    partial void OnidVentaChanged();
    partial void OnidProductoChanging(int value);
    partial void OnidProductoChanged();
    partial void OnprecioChanging(double value);
    partial void OnprecioChanged();
    #endregion
		
		public eDetalleVenta()
		{
			this._Venta = default(EntityRef<eVenta>);
			this._Producto = default(EntityRef<eProducto>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVenta", DbType="Int NOT NULL")]
		public int idVenta
		{
			get
			{
				return this._idVenta;
			}
			set
			{
				if ((this._idVenta != value))
				{
					if (this._Venta.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidVentaChanging(value);
					this.SendPropertyChanging();
					this._idVenta = value;
					this.SendPropertyChanged("idVenta");
					this.OnidVentaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProducto", DbType="Int NOT NULL")]
		public int idProducto
		{
			get
			{
				return this._idProducto;
			}
			set
			{
				if ((this._idProducto != value))
				{
					if (this._Producto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidProductoChanging(value);
					this.SendPropertyChanging();
					this._idProducto = value;
					this.SendPropertyChanged("idProducto");
					this.OnidProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Float NOT NULL")]
		public double precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this.OnprecioChanging(value);
					this.SendPropertyChanging();
					this._precio = value;
					this.SendPropertyChanged("precio");
					this.OnprecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Venta_DetalleVenta", Storage="_Venta", ThisKey="idVenta", OtherKey="id", IsForeignKey=true)]
		public eVenta eVenta
		{
			get
			{
				return this._Venta.Entity;
			}
			set
			{
				eVenta previousValue = this._Venta.Entity;
				if (((previousValue != value) 
							|| (this._Venta.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Venta.Entity = null;
						previousValue.eDetalleVenta.Remove(this);
					}
					this._Venta.Entity = value;
					if ((value != null))
					{
						value.eDetalleVenta.Add(this);
						this._idVenta = value.id;
					}
					else
					{
						this._idVenta = default(int);
					}
					this.SendPropertyChanged("eVenta");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_DetalleVenta", Storage="_Producto", ThisKey="idProducto", OtherKey="id", IsForeignKey=true)]
		public eProducto eProducto
		{
			get
			{
				return this._Producto.Entity;
			}
			set
			{
				eProducto previousValue = this._Producto.Entity;
				if (((previousValue != value) 
							|| (this._Producto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto.Entity = null;
						previousValue.eDetalleVenta.Remove(this);
					}
					this._Producto.Entity = value;
					if ((value != null))
					{
						value.eDetalleVenta.Add(this);
						this._idProducto = value.id;
					}
					else
					{
						this._idProducto = default(int);
					}
					this.SendPropertyChanged("eProducto");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producto")]
	public partial class eProducto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private double _precio;
		
		private string _descripcion;
		
		private EntitySet<eDetalleVenta> _DetalleVenta;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnprecioChanging(double value);
    partial void OnprecioChanged();
    partial void OndescripcionChanging(string value);
    partial void OndescripcionChanged();
    #endregion
		
		public eProducto()
		{
			this._DetalleVenta = new EntitySet<eDetalleVenta>(new Action<eDetalleVenta>(this.attach_DetalleVenta), new Action<eDetalleVenta>(this.detach_DetalleVenta));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(100)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Float NOT NULL")]
		public double precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this.OnprecioChanging(value);
					this.SendPropertyChanging();
					this._precio = value;
					this.SendPropertyChanged("precio");
					this.OnprecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="VarChar(150)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this.OndescripcionChanging(value);
					this.SendPropertyChanging();
					this._descripcion = value;
					this.SendPropertyChanged("descripcion");
					this.OndescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_DetalleVenta", Storage="_DetalleVenta", ThisKey="id", OtherKey="idProducto")]
		public EntitySet<eDetalleVenta> eDetalleVenta
		{
			get
			{
				return this._DetalleVenta;
			}
			set
			{
				this._DetalleVenta.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DetalleVenta(eDetalleVenta entity)
		{
			this.SendPropertyChanging();
			entity.eProducto = this;
		}
		
		private void detach_DetalleVenta(eDetalleVenta entity)
		{
			this.SendPropertyChanging();
			entity.eProducto = null;
		}
	}
}
#pragma warning restore 1591
