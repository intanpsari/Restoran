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

namespace Restoran.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_restoran")]
	public partial class OperationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttMeja(tMeja instance);
    partial void UpdatetMeja(tMeja instance);
    partial void DeletetMeja(tMeja instance);
    partial void InserttMenu(tMenu instance);
    partial void UpdatetMenu(tMenu instance);
    partial void DeletetMenu(tMenu instance);
    partial void InserttOrder(tOrder instance);
    partial void UpdatetOrder(tOrder instance);
    partial void DeletetOrder(tOrder instance);
    #endregion
		
		public OperationDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["db_restoranConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OperationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tMeja> tMejas
		{
			get
			{
				return this.GetTable<tMeja>();
			}
		}
		
		public System.Data.Linq.Table<tMenu> tMenus
		{
			get
			{
				return this.GetTable<tMenu>();
			}
		}
		
		public System.Data.Linq.Table<tOrder> tOrders
		{
			get
			{
				return this.GetTable<tOrder>();
			}
		}
		
		public System.Data.Linq.Table<tuser> tusers
		{
			get
			{
				return this.GetTable<tuser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tMeja")]
	public partial class tMeja : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdMeja;
		
		private System.Nullable<int> _Status;
		
		private EntitySet<tOrder> _tOrders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdMejaChanging(string value);
    partial void OnIdMejaChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    #endregion
		
		public tMeja()
		{
			this._tOrders = new EntitySet<tOrder>(new Action<tOrder>(this.attach_tOrders), new Action<tOrder>(this.detach_tOrders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMeja", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdMeja
		{
			get
			{
				return this._IdMeja;
			}
			set
			{
				if ((this._IdMeja != value))
				{
					this.OnIdMejaChanging(value);
					this.SendPropertyChanging();
					this._IdMeja = value;
					this.SendPropertyChanged("IdMeja");
					this.OnIdMejaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tMeja_tOrder", Storage="_tOrders", ThisKey="IdMeja", OtherKey="MejaId")]
		public EntitySet<tOrder> tOrders
		{
			get
			{
				return this._tOrders;
			}
			set
			{
				this._tOrders.Assign(value);
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
		
		private void attach_tOrders(tOrder entity)
		{
			this.SendPropertyChanging();
			entity.tMeja = this;
		}
		
		private void detach_tOrders(tOrder entity)
		{
			this.SendPropertyChanging();
			entity.tMeja = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tMenu")]
	public partial class tMenu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdMenu;
		
		private string _Nama;
		
		private System.Nullable<int> _Harga;
		
		private System.Nullable<int> _Stok;
		
		private string _Images;
		
		private EntitySet<tOrder> _tOrders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdMenuChanging(string value);
    partial void OnIdMenuChanged();
    partial void OnNamaChanging(string value);
    partial void OnNamaChanged();
    partial void OnHargaChanging(System.Nullable<int> value);
    partial void OnHargaChanged();
    partial void OnStokChanging(System.Nullable<int> value);
    partial void OnStokChanged();
    partial void OnImagesChanging(string value);
    partial void OnImagesChanged();
    #endregion
		
		public tMenu()
		{
			this._tOrders = new EntitySet<tOrder>(new Action<tOrder>(this.attach_tOrders), new Action<tOrder>(this.detach_tOrders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMenu", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdMenu
		{
			get
			{
				return this._IdMenu;
			}
			set
			{
				if ((this._IdMenu != value))
				{
					this.OnIdMenuChanging(value);
					this.SendPropertyChanging();
					this._IdMenu = value;
					this.SendPropertyChanged("IdMenu");
					this.OnIdMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nama", DbType="NVarChar(50)")]
		public string Nama
		{
			get
			{
				return this._Nama;
			}
			set
			{
				if ((this._Nama != value))
				{
					this.OnNamaChanging(value);
					this.SendPropertyChanging();
					this._Nama = value;
					this.SendPropertyChanged("Nama");
					this.OnNamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Harga", DbType="Int")]
		public System.Nullable<int> Harga
		{
			get
			{
				return this._Harga;
			}
			set
			{
				if ((this._Harga != value))
				{
					this.OnHargaChanging(value);
					this.SendPropertyChanging();
					this._Harga = value;
					this.SendPropertyChanged("Harga");
					this.OnHargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stok", DbType="Int")]
		public System.Nullable<int> Stok
		{
			get
			{
				return this._Stok;
			}
			set
			{
				if ((this._Stok != value))
				{
					this.OnStokChanging(value);
					this.SendPropertyChanging();
					this._Stok = value;
					this.SendPropertyChanged("Stok");
					this.OnStokChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="NVarChar(50)")]
		public string Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tMenu_tOrder", Storage="_tOrders", ThisKey="IdMenu", OtherKey="MenuId")]
		public EntitySet<tOrder> tOrders
		{
			get
			{
				return this._tOrders;
			}
			set
			{
				this._tOrders.Assign(value);
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
		
		private void attach_tOrders(tOrder entity)
		{
			this.SendPropertyChanging();
			entity.tMenu = this;
		}
		
		private void detach_tOrders(tOrder entity)
		{
			this.SendPropertyChanging();
			entity.tMenu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tOrder")]
	public partial class tOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdOrder;
		
		private string _MejaId;
		
		private string _MenuId;
		
		private System.Nullable<int> _JumlahMenu;
		
		private EntityRef<tMeja> _tMeja;
		
		private EntityRef<tMenu> _tMenu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdOrderChanging(int value);
    partial void OnIdOrderChanged();
    partial void OnMejaIdChanging(string value);
    partial void OnMejaIdChanged();
    partial void OnMenuIdChanging(string value);
    partial void OnMenuIdChanged();
    partial void OnJumlahMenuChanging(System.Nullable<int> value);
    partial void OnJumlahMenuChanged();
    #endregion
		
		public tOrder()
		{
			this._tMeja = default(EntityRef<tMeja>);
			this._tMenu = default(EntityRef<tMenu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdOrder", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdOrder
		{
			get
			{
				return this._IdOrder;
			}
			set
			{
				if ((this._IdOrder != value))
				{
					this.OnIdOrderChanging(value);
					this.SendPropertyChanging();
					this._IdOrder = value;
					this.SendPropertyChanged("IdOrder");
					this.OnIdOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MejaId", DbType="VarChar(10)")]
		public string MejaId
		{
			get
			{
				return this._MejaId;
			}
			set
			{
				if ((this._MejaId != value))
				{
					if (this._tMeja.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMejaIdChanging(value);
					this.SendPropertyChanging();
					this._MejaId = value;
					this.SendPropertyChanged("MejaId");
					this.OnMejaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuId", DbType="VarChar(10)")]
		public string MenuId
		{
			get
			{
				return this._MenuId;
			}
			set
			{
				if ((this._MenuId != value))
				{
					if (this._tMenu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMenuIdChanging(value);
					this.SendPropertyChanging();
					this._MenuId = value;
					this.SendPropertyChanged("MenuId");
					this.OnMenuIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JumlahMenu", DbType="Int")]
		public System.Nullable<int> JumlahMenu
		{
			get
			{
				return this._JumlahMenu;
			}
			set
			{
				if ((this._JumlahMenu != value))
				{
					this.OnJumlahMenuChanging(value);
					this.SendPropertyChanging();
					this._JumlahMenu = value;
					this.SendPropertyChanged("JumlahMenu");
					this.OnJumlahMenuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tMeja_tOrder", Storage="_tMeja", ThisKey="MejaId", OtherKey="IdMeja", IsForeignKey=true, DeleteRule="CASCADE")]
		public tMeja tMeja
		{
			get
			{
				return this._tMeja.Entity;
			}
			set
			{
				tMeja previousValue = this._tMeja.Entity;
				if (((previousValue != value) 
							|| (this._tMeja.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tMeja.Entity = null;
						previousValue.tOrders.Remove(this);
					}
					this._tMeja.Entity = value;
					if ((value != null))
					{
						value.tOrders.Add(this);
						this._MejaId = value.IdMeja;
					}
					else
					{
						this._MejaId = default(string);
					}
					this.SendPropertyChanged("tMeja");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tMenu_tOrder", Storage="_tMenu", ThisKey="MenuId", OtherKey="IdMenu", IsForeignKey=true, DeleteRule="CASCADE")]
		public tMenu tMenu
		{
			get
			{
				return this._tMenu.Entity;
			}
			set
			{
				tMenu previousValue = this._tMenu.Entity;
				if (((previousValue != value) 
							|| (this._tMenu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tMenu.Entity = null;
						previousValue.tOrders.Remove(this);
					}
					this._tMenu.Entity = value;
					if ((value != null))
					{
						value.tOrders.Add(this);
						this._MenuId = value.IdMenu;
					}
					else
					{
						this._MenuId = default(string);
					}
					this.SendPropertyChanged("tMenu");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tuser")]
	public partial class tuser
	{
		
		private string _username;
		
		private string _password;
		
		public tuser()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(25)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(25)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
