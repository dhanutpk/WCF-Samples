﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.20915.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.SuspendedInstanceManagement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MySWIS")]
	public partial class InstancesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public InstancesDataContext() : 
				base(global::SuspendedInstanceManagement.Properties.Settings.Default.MySWISConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public InstancesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InstancesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InstancesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InstancesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Instance> Instances
		{
			get
			{
				return this.GetTable<Instance>();
			}
		}
		
		public System.Data.Linq.Table<ServiceDeployment> ServiceDeployments
		{
			get
			{
				return this.GetTable<ServiceDeployment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="[System.Activities.DurableInstancing].Instances")]
	public partial class Instance
	{
		
		private System.Guid _InstanceId;
		
		private System.Nullable<System.DateTime> _PendingTimer;
		
		private System.DateTime _CreationTime;
		
		private System.Nullable<System.DateTime> _LastUpdatedTime;
		
		private System.Nullable<long> _ServiceDeploymentId;
		
		private string _SuspensionExceptionName;
		
		private string _SuspensionReason;
		
		private string _ActiveBookmarks;
		
		private string _CurrentMachine;
		
		private string _LastMachine;
		
		private string _ExecutionStatus;
		
		private System.Nullable<bool> _IsInitialized;
		
		private System.Nullable<bool> _IsSuspended;
		
		private System.Nullable<bool> _IsCompleted;
		
		private System.Nullable<byte> _EncodingOption;
		
		private System.Data.Linq.Binary _ReadWritePrimitiveDataProperties;
		
		private System.Data.Linq.Binary _WriteOnlyPrimitiveDataProperties;
		
		private System.Data.Linq.Binary _ReadWriteComplexDataProperties;
		
		private System.Data.Linq.Binary _WriteOnlyComplexDataProperties;
		
		public Instance()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstanceId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				if ((this._InstanceId != value))
				{
					this._InstanceId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PendingTimer", DbType="DateTime")]
		public System.Nullable<System.DateTime> PendingTimer
		{
			get
			{
				return this._PendingTimer;
			}
			set
			{
				if ((this._PendingTimer != value))
				{
					this._PendingTimer = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreationTime", DbType="DateTime NOT NULL")]
		public System.DateTime CreationTime
		{
			get
			{
				return this._CreationTime;
			}
			set
			{
				if ((this._CreationTime != value))
				{
					this._CreationTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpdatedTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastUpdatedTime
		{
			get
			{
				return this._LastUpdatedTime;
			}
			set
			{
				if ((this._LastUpdatedTime != value))
				{
					this._LastUpdatedTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceDeploymentId", DbType="BigInt")]
		public System.Nullable<long> ServiceDeploymentId
		{
			get
			{
				return this._ServiceDeploymentId;
			}
			set
			{
				if ((this._ServiceDeploymentId != value))
				{
					this._ServiceDeploymentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuspensionExceptionName", DbType="NVarChar(450)")]
		public string SuspensionExceptionName
		{
			get
			{
				return this._SuspensionExceptionName;
			}
			set
			{
				if ((this._SuspensionExceptionName != value))
				{
					this._SuspensionExceptionName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuspensionReason", DbType="NVarChar(MAX)")]
		public string SuspensionReason
		{
			get
			{
				return this._SuspensionReason;
			}
			set
			{
				if ((this._SuspensionReason != value))
				{
					this._SuspensionReason = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActiveBookmarks", DbType="NVarChar(MAX)")]
		public string ActiveBookmarks
		{
			get
			{
				return this._ActiveBookmarks;
			}
			set
			{
				if ((this._ActiveBookmarks != value))
				{
					this._ActiveBookmarks = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentMachine", DbType="NVarChar(128)")]
		public string CurrentMachine
		{
			get
			{
				return this._CurrentMachine;
			}
			set
			{
				if ((this._CurrentMachine != value))
				{
					this._CurrentMachine = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastMachine", DbType="NVarChar(450)")]
		public string LastMachine
		{
			get
			{
				return this._LastMachine;
			}
			set
			{
				if ((this._LastMachine != value))
				{
					this._LastMachine = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExecutionStatus", DbType="NVarChar(450)")]
		public string ExecutionStatus
		{
			get
			{
				return this._ExecutionStatus;
			}
			set
			{
				if ((this._ExecutionStatus != value))
				{
					this._ExecutionStatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsInitialized", DbType="Bit")]
		public System.Nullable<bool> IsInitialized
		{
			get
			{
				return this._IsInitialized;
			}
			set
			{
				if ((this._IsInitialized != value))
				{
					this._IsInitialized = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSuspended", DbType="Bit")]
		public System.Nullable<bool> IsSuspended
		{
			get
			{
				return this._IsSuspended;
			}
			set
			{
				if ((this._IsSuspended != value))
				{
					this._IsSuspended = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsCompleted", DbType="Bit")]
		public System.Nullable<bool> IsCompleted
		{
			get
			{
				return this._IsCompleted;
			}
			set
			{
				if ((this._IsCompleted != value))
				{
					this._IsCompleted = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EncodingOption", DbType="TinyInt")]
		public System.Nullable<byte> EncodingOption
		{
			get
			{
				return this._EncodingOption;
			}
			set
			{
				if ((this._EncodingOption != value))
				{
					this._EncodingOption = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReadWritePrimitiveDataProperties", DbType="VarBinary(MAX)", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ReadWritePrimitiveDataProperties
		{
			get
			{
				return this._ReadWritePrimitiveDataProperties;
			}
			set
			{
				if ((this._ReadWritePrimitiveDataProperties != value))
				{
					this._ReadWritePrimitiveDataProperties = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WriteOnlyPrimitiveDataProperties", DbType="VarBinary(MAX)", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary WriteOnlyPrimitiveDataProperties
		{
			get
			{
				return this._WriteOnlyPrimitiveDataProperties;
			}
			set
			{
				if ((this._WriteOnlyPrimitiveDataProperties != value))
				{
					this._WriteOnlyPrimitiveDataProperties = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReadWriteComplexDataProperties", DbType="VarBinary(MAX)", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary ReadWriteComplexDataProperties
		{
			get
			{
				return this._ReadWriteComplexDataProperties;
			}
			set
			{
				if ((this._ReadWriteComplexDataProperties != value))
				{
					this._ReadWriteComplexDataProperties = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WriteOnlyComplexDataProperties", DbType="VarBinary(MAX)", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary WriteOnlyComplexDataProperties
		{
			get
			{
				return this._WriteOnlyComplexDataProperties;
			}
			set
			{
				if ((this._WriteOnlyComplexDataProperties != value))
				{
					this._WriteOnlyComplexDataProperties = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="[System.Activities.DurableInstancing].ServiceDeployments")]
	public partial class ServiceDeployment
	{
		
		private long _ServiceDeploymentId;
		
		private string _SiteName;
		
		private string _RelativeServicePath;
		
		private string _RelativeApplicationPath;
		
		private string _ServiceName;
		
		private string _ServiceNamespace;
		
		public ServiceDeployment()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceDeploymentId", AutoSync=AutoSync.Always, DbType="BigInt NOT NULL IDENTITY", IsDbGenerated=true)]
		public long ServiceDeploymentId
		{
			get
			{
				return this._ServiceDeploymentId;
			}
			set
			{
				if ((this._ServiceDeploymentId != value))
				{
					this._ServiceDeploymentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SiteName
		{
			get
			{
				return this._SiteName;
			}
			set
			{
				if ((this._SiteName != value))
				{
					this._SiteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelativeServicePath", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string RelativeServicePath
		{
			get
			{
				return this._RelativeServicePath;
			}
			set
			{
				if ((this._RelativeServicePath != value))
				{
					this._RelativeServicePath = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelativeApplicationPath", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string RelativeApplicationPath
		{
			get
			{
				return this._RelativeApplicationPath;
			}
			set
			{
				if ((this._RelativeApplicationPath != value))
				{
					this._RelativeApplicationPath = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ServiceName
		{
			get
			{
				return this._ServiceName;
			}
			set
			{
				if ((this._ServiceName != value))
				{
					this._ServiceName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceNamespace", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ServiceNamespace
		{
			get
			{
				return this._ServiceNamespace;
			}
			set
			{
				if ((this._ServiceNamespace != value))
				{
					this._ServiceNamespace = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
