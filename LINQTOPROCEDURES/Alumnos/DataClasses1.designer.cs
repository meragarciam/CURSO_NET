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

namespace Alumnos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LINQ")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertALUMNOS(ALUMNOS instance);
    partial void UpdateALUMNOS(ALUMNOS instance);
    partial void DeleteALUMNOS(ALUMNOS instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Alumnos.Properties.Settings.Default.LINQConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ALUMNOS> ALUMNOS
		{
			get
			{
				return this.GetTable<ALUMNOS>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ALUMNOS")]
	public partial class ALUMNOS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _codigo;
		
		private string _nombre;
		
		private string _dni;
		
		private string _turno;
		
		private string _sexo;
		
		private System.Nullable<bool> _repetidor;
		
		private string _modulo;
		
		private string _especialidad;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodigoChanging(string value);
    partial void OncodigoChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OndniChanging(string value);
    partial void OndniChanged();
    partial void OnturnoChanging(string value);
    partial void OnturnoChanged();
    partial void OnsexoChanging(string value);
    partial void OnsexoChanged();
    partial void OnrepetidorChanging(System.Nullable<bool> value);
    partial void OnrepetidorChanged();
    partial void OnmoduloChanging(string value);
    partial void OnmoduloChanged();
    partial void OnespecialidadChanging(string value);
    partial void OnespecialidadChanged();
    #endregion
		
		public ALUMNOS()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dni", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string dni
		{
			get
			{
				return this._dni;
			}
			set
			{
				if ((this._dni != value))
				{
					this.OndniChanging(value);
					this.SendPropertyChanging();
					this._dni = value;
					this.SendPropertyChanged("dni");
					this.OndniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_turno", DbType="VarChar(10)")]
		public string turno
		{
			get
			{
				return this._turno;
			}
			set
			{
				if ((this._turno != value))
				{
					this.OnturnoChanging(value);
					this.SendPropertyChanging();
					this._turno = value;
					this.SendPropertyChanged("turno");
					this.OnturnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexo", DbType="VarChar(10)")]
		public string sexo
		{
			get
			{
				return this._sexo;
			}
			set
			{
				if ((this._sexo != value))
				{
					this.OnsexoChanging(value);
					this.SendPropertyChanging();
					this._sexo = value;
					this.SendPropertyChanged("sexo");
					this.OnsexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_repetidor", DbType="Bit")]
		public System.Nullable<bool> repetidor
		{
			get
			{
				return this._repetidor;
			}
			set
			{
				if ((this._repetidor != value))
				{
					this.OnrepetidorChanging(value);
					this.SendPropertyChanging();
					this._repetidor = value;
					this.SendPropertyChanged("repetidor");
					this.OnrepetidorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modulo", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string modulo
		{
			get
			{
				return this._modulo;
			}
			set
			{
				if ((this._modulo != value))
				{
					this.OnmoduloChanging(value);
					this.SendPropertyChanging();
					this._modulo = value;
					this.SendPropertyChanged("modulo");
					this.OnmoduloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_especialidad", DbType="VarChar(25)")]
		public string especialidad
		{
			get
			{
				return this._especialidad;
			}
			set
			{
				if ((this._especialidad != value))
				{
					this.OnespecialidadChanging(value);
					this.SendPropertyChanging();
					this._especialidad = value;
					this.SendPropertyChanged("especialidad");
					this.OnespecialidadChanged();
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
