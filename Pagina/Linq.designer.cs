﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicio
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="tiakidatabase")]
	public partial class LinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertVIGILANTE(VIGILANTE instance);
    partial void UpdateVIGILANTE(VIGILANTE instance);
    partial void DeleteVIGILANTE(VIGILANTE instance);
    partial void InsertRESIDENCIAL(RESIDENCIAL instance);
    partial void UpdateRESIDENCIAL(RESIDENCIAL instance);
    partial void DeleteRESIDENCIAL(RESIDENCIAL instance);
    partial void InsertGRUPO(GRUPO instance);
    partial void UpdateGRUPO(GRUPO instance);
    partial void DeleteGRUPO(GRUPO instance);
    #endregion
		
		public LinqDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["tiakidatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<VIGILANTE> VIGILANTE
		{
			get
			{
				return this.GetTable<VIGILANTE>();
			}
		}
		
		public System.Data.Linq.Table<RESIDENCIAL> RESIDENCIAL
		{
			get
			{
				return this.GetTable<RESIDENCIAL>();
			}
		}
		
		public System.Data.Linq.Table<GRUPO> GRUPO
		{
			get
			{
				return this.GetTable<GRUPO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VIGILANTE")]
	public partial class VIGILANTE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _NOMBRE;
		
		private string _TELEFONO;
		
		private string _CIVIL;
		
		private string _ESTADO;
		
		private string _GRUPO;
		
		private string _RESIDENCIAL;
		
		private System.Nullable<double> _PRECIOHORA;
		
		private System.Nullable<double> _EXTRAHORA;
		
		private System.Nullable<int> _HORASTRABAJADAS;
		
		private System.Nullable<int> _EXTRASTRABAJADAS;
		
		private EntityRef<RESIDENCIAL> _RESIDENCIAL1;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnNOMBREChanging(string value);
    partial void OnNOMBREChanged();
    partial void OnTELEFONOChanging(string value);
    partial void OnTELEFONOChanged();
    partial void OnCIVILChanging(string value);
    partial void OnCIVILChanged();
    partial void OnESTADOChanging(string value);
    partial void OnESTADOChanged();
    partial void OnGRUPOChanging(string value);
    partial void OnGRUPOChanged();
    partial void OnRESIDENCIALChanging(string value);
    partial void OnRESIDENCIALChanged();
    partial void OnPRECIOHORAChanging(System.Nullable<double> value);
    partial void OnPRECIOHORAChanged();
    partial void OnEXTRAHORAChanging(System.Nullable<double> value);
    partial void OnEXTRAHORAChanged();
    partial void OnHORASTRABAJADASChanging(System.Nullable<int> value);
    partial void OnHORASTRABAJADASChanged();
    partial void OnEXTRASTRABAJADASChanging(System.Nullable<int> value);
    partial void OnEXTRASTRABAJADASChanged();
    #endregion
		
		public VIGILANTE()
		{
			this._RESIDENCIAL1 = default(EntityRef<RESIDENCIAL>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(100)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this.OnNOMBREChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE = value;
					this.SendPropertyChanged("NOMBRE");
					this.OnNOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TELEFONO", DbType="VarChar(100)")]
		public string TELEFONO
		{
			get
			{
				return this._TELEFONO;
			}
			set
			{
				if ((this._TELEFONO != value))
				{
					this.OnTELEFONOChanging(value);
					this.SendPropertyChanging();
					this._TELEFONO = value;
					this.SendPropertyChanged("TELEFONO");
					this.OnTELEFONOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CIVIL", DbType="VarChar(100)")]
		public string CIVIL
		{
			get
			{
				return this._CIVIL;
			}
			set
			{
				if ((this._CIVIL != value))
				{
					this.OnCIVILChanging(value);
					this.SendPropertyChanging();
					this._CIVIL = value;
					this.SendPropertyChanged("CIVIL");
					this.OnCIVILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTADO", DbType="VarChar(100)")]
		public string ESTADO
		{
			get
			{
				return this._ESTADO;
			}
			set
			{
				if ((this._ESTADO != value))
				{
					this.OnESTADOChanging(value);
					this.SendPropertyChanging();
					this._ESTADO = value;
					this.SendPropertyChanged("ESTADO");
					this.OnESTADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GRUPO", DbType="VarChar(3)")]
		public string GRUPO
		{
			get
			{
				return this._GRUPO;
			}
			set
			{
				if ((this._GRUPO != value))
				{
					this.OnGRUPOChanging(value);
					this.SendPropertyChanging();
					this._GRUPO = value;
					this.SendPropertyChanged("GRUPO");
					this.OnGRUPOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RESIDENCIAL", DbType="VarChar(100)")]
		public string RESIDENCIAL
		{
			get
			{
				return this._RESIDENCIAL;
			}
			set
			{
				if ((this._RESIDENCIAL != value))
				{
					if (this._RESIDENCIAL1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRESIDENCIALChanging(value);
					this.SendPropertyChanging();
					this._RESIDENCIAL = value;
					this.SendPropertyChanged("RESIDENCIAL");
					this.OnRESIDENCIALChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRECIOHORA", DbType="Float")]
		public System.Nullable<double> PRECIOHORA
		{
			get
			{
				return this._PRECIOHORA;
			}
			set
			{
				if ((this._PRECIOHORA != value))
				{
					this.OnPRECIOHORAChanging(value);
					this.SendPropertyChanging();
					this._PRECIOHORA = value;
					this.SendPropertyChanged("PRECIOHORA");
					this.OnPRECIOHORAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EXTRAHORA", DbType="Float")]
		public System.Nullable<double> EXTRAHORA
		{
			get
			{
				return this._EXTRAHORA;
			}
			set
			{
				if ((this._EXTRAHORA != value))
				{
					this.OnEXTRAHORAChanging(value);
					this.SendPropertyChanging();
					this._EXTRAHORA = value;
					this.SendPropertyChanged("EXTRAHORA");
					this.OnEXTRAHORAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HORASTRABAJADAS", DbType="Int")]
		public System.Nullable<int> HORASTRABAJADAS
		{
			get
			{
				return this._HORASTRABAJADAS;
			}
			set
			{
				if ((this._HORASTRABAJADAS != value))
				{
					this.OnHORASTRABAJADASChanging(value);
					this.SendPropertyChanging();
					this._HORASTRABAJADAS = value;
					this.SendPropertyChanged("HORASTRABAJADAS");
					this.OnHORASTRABAJADASChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EXTRASTRABAJADAS", DbType="Int")]
		public System.Nullable<int> EXTRASTRABAJADAS
		{
			get
			{
				return this._EXTRASTRABAJADAS;
			}
			set
			{
				if ((this._EXTRASTRABAJADAS != value))
				{
					this.OnEXTRASTRABAJADASChanging(value);
					this.SendPropertyChanging();
					this._EXTRASTRABAJADAS = value;
					this.SendPropertyChanged("EXTRASTRABAJADAS");
					this.OnEXTRASTRABAJADASChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RESIDENCIAL_VIGILANTE", Storage="_RESIDENCIAL1", ThisKey="RESIDENCIAL", OtherKey="ID", IsForeignKey=true)]
		public RESIDENCIAL RESIDENCIAL1
		{
			get
			{
				return this._RESIDENCIAL1.Entity;
			}
			set
			{
				RESIDENCIAL previousValue = this._RESIDENCIAL1.Entity;
				if (((previousValue != value) 
							|| (this._RESIDENCIAL1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RESIDENCIAL1.Entity = null;
						previousValue.VIGILANTE.Remove(this);
					}
					this._RESIDENCIAL1.Entity = value;
					if ((value != null))
					{
						value.VIGILANTE.Add(this);
						this._RESIDENCIAL = value.ID;
					}
					else
					{
						this._RESIDENCIAL = default(string);
					}
					this.SendPropertyChanged("RESIDENCIAL1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RESIDENCIAL")]
	public partial class RESIDENCIAL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _NOMBRE;
		
		private string _DIRECCION;
		
		private EntitySet<VIGILANTE> _VIGILANTE;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnNOMBREChanging(string value);
    partial void OnNOMBREChanged();
    partial void OnDIRECCIONChanging(string value);
    partial void OnDIRECCIONChanged();
    #endregion
		
		public RESIDENCIAL()
		{
			this._VIGILANTE = new EntitySet<VIGILANTE>(new Action<VIGILANTE>(this.attach_VIGILANTE), new Action<VIGILANTE>(this.detach_VIGILANTE));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(100)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this.OnNOMBREChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE = value;
					this.SendPropertyChanged("NOMBRE");
					this.OnNOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIRECCION", DbType="VarChar(100)")]
		public string DIRECCION
		{
			get
			{
				return this._DIRECCION;
			}
			set
			{
				if ((this._DIRECCION != value))
				{
					this.OnDIRECCIONChanging(value);
					this.SendPropertyChanging();
					this._DIRECCION = value;
					this.SendPropertyChanged("DIRECCION");
					this.OnDIRECCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RESIDENCIAL_VIGILANTE", Storage="_VIGILANTE", ThisKey="ID", OtherKey="RESIDENCIAL")]
		public EntitySet<VIGILANTE> VIGILANTE
		{
			get
			{
				return this._VIGILANTE;
			}
			set
			{
				this._VIGILANTE.Assign(value);
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
		
		private void attach_VIGILANTE(VIGILANTE entity)
		{
			this.SendPropertyChanging();
			entity.RESIDENCIAL1 = this;
		}
		
		private void detach_VIGILANTE(VIGILANTE entity)
		{
			this.SendPropertyChanging();
			entity.RESIDENCIAL1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GRUPO")]
	public partial class GRUPO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private int _DIA;
		
		private int _HINICIO;
		
		private System.Nullable<int> _DURACION;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnDIAChanging(int value);
    partial void OnDIAChanged();
    partial void OnHINICIOChanging(int value);
    partial void OnHINICIOChanged();
    partial void OnDURACIONChanging(System.Nullable<int> value);
    partial void OnDURACIONChanged();
    #endregion
		
		public GRUPO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="VarChar(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIA", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DIA
		{
			get
			{
				return this._DIA;
			}
			set
			{
				if ((this._DIA != value))
				{
					this.OnDIAChanging(value);
					this.SendPropertyChanging();
					this._DIA = value;
					this.SendPropertyChanged("DIA");
					this.OnDIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HINICIO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int HINICIO
		{
			get
			{
				return this._HINICIO;
			}
			set
			{
				if ((this._HINICIO != value))
				{
					this.OnHINICIOChanging(value);
					this.SendPropertyChanging();
					this._HINICIO = value;
					this.SendPropertyChanged("HINICIO");
					this.OnHINICIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DURACION", DbType="Int")]
		public System.Nullable<int> DURACION
		{
			get
			{
				return this._DURACION;
			}
			set
			{
				if ((this._DURACION != value))
				{
					this.OnDURACIONChanging(value);
					this.SendPropertyChanging();
					this._DURACION = value;
					this.SendPropertyChanged("DURACION");
					this.OnDURACIONChanged();
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
}
#pragma warning restore 1591