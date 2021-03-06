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

namespace MultiTable.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDept(Dept instance);
    partial void UpdateDept(Dept instance);
    partial void DeleteDept(Dept instance);
    partial void InsertEmp(Emp instance);
    partial void UpdateEmp(Emp instance);
    partial void DeleteEmp(Emp instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Dept> Depts
		{
			get
			{
				return this.GetTable<Dept>();
			}
		}
		
		public System.Data.Linq.Table<Emp> Emps
		{
			get
			{
				return this.GetTable<Emp>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dept")]
	public partial class Dept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DNo;
		
		private string _DName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDNoChanging(int value);
    partial void OnDNoChanged();
    partial void OnDNameChanging(string value);
    partial void OnDNameChanged();
    #endregion
		
		public Dept()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DNo
		{
			get
			{
				return this._DNo;
			}
			set
			{
				if ((this._DNo != value))
				{
					this.OnDNoChanging(value);
					this.SendPropertyChanging();
					this._DNo = value;
					this.SendPropertyChanged("DNo");
					this.OnDNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DName", DbType="VarChar(50)")]
		public string DName
		{
			get
			{
				return this._DName;
			}
			set
			{
				if ((this._DName != value))
				{
					this.OnDNameChanging(value);
					this.SendPropertyChanging();
					this._DName = value;
					this.SendPropertyChanged("DName");
					this.OnDNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Emp")]
	public partial class Emp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ECode;
		
		private string _EName;
		
		private System.Nullable<int> _ESal;
		
		private System.Nullable<int> _DNo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnECodeChanging(int value);
    partial void OnECodeChanged();
    partial void OnENameChanging(string value);
    partial void OnENameChanged();
    partial void OnESalChanging(System.Nullable<int> value);
    partial void OnESalChanged();
    partial void OnDNoChanging(System.Nullable<int> value);
    partial void OnDNoChanged();
    #endregion
		
		public Emp()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ECode", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ECode
		{
			get
			{
				return this._ECode;
			}
			set
			{
				if ((this._ECode != value))
				{
					this.OnECodeChanging(value);
					this.SendPropertyChanging();
					this._ECode = value;
					this.SendPropertyChanged("ECode");
					this.OnECodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EName", DbType="VarChar(50)")]
		public string EName
		{
			get
			{
				return this._EName;
			}
			set
			{
				if ((this._EName != value))
				{
					this.OnENameChanging(value);
					this.SendPropertyChanging();
					this._EName = value;
					this.SendPropertyChanged("EName");
					this.OnENameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESal", DbType="Int")]
		public System.Nullable<int> ESal
		{
			get
			{
				return this._ESal;
			}
			set
			{
				if ((this._ESal != value))
				{
					this.OnESalChanging(value);
					this.SendPropertyChanging();
					this._ESal = value;
					this.SendPropertyChanged("ESal");
					this.OnESalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNo", DbType="Int")]
		public System.Nullable<int> DNo
		{
			get
			{
				return this._DNo;
			}
			set
			{
				if ((this._DNo != value))
				{
					this.OnDNoChanging(value);
					this.SendPropertyChanging();
					this._DNo = value;
					this.SendPropertyChanged("DNo");
					this.OnDNoChanged();
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
