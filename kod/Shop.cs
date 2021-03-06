//*****************************************************************************
//
//      This code was generated by the JADE Exposure Wizard.
//
//      JADE Version    : 16.0.02
//      Generation date : niedziela, 6 maja 2018
//      Generated by    : DominikaRaczak
//      JADE Schema     : JadeProject
//      Exposure Name   : JadeProject
//
//      NOTE: You should NOT change this file as it may cause incorrect
//            behaviour. Any changes that you do make will be lost if
//            this code is regenerated.
//
//*****************************************************************************

namespace JadeProject
{
	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using JadeSoftware.Joob;
	using JadeSoftware.Joob.Client;
	using JadeSoftware.Joob.Metadata;
	using JadeSoftware.Joob.Management;
	using JadeSoftware.Joob.MetaSchema;
	using JadeSoftware.Jade.DotNetInterop;

	[System.Runtime.Serialization.KnownTypeAttribute(typeof(CustomersById))]
	[System.Runtime.Serialization.KnownTypeAttribute(typeof(EmployeesById))]
	[System.Runtime.Serialization.KnownTypeAttribute(typeof(ItemsByName))]
	[System.Runtime.Serialization.KnownTypeAttribute(typeof(Positions))]
	[System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
	[System.ComponentModel.DataAnnotations.MetadataTypeAttribute(typeof(ShopMetadata))]
	[JadeSoftware.Joob.Client.JoobClassAttribute("Shop", "RootSchema.JadeProject", ClassNamespace="JadeProject")]
	[JadeSoftware.Joob.Metadata.JomlTypeAttribute(JadeSoftware.Joob.Metadata.JomlTypeKind.Class, "Shop", typeof(JoobObject))]
	public partial class Shop : JoobObject
	{
		private static ShopMetadata _metaModel;
		partial void _initialize();
		static Shop()
		{
			_metaModel = MetadataCache<ShopMetadata>.GetData(null);
		}
		public Shop() :
			this(JadeSoftware.Joob.ClassPersistence.Persistent)
		{
		}
		public Shop(JadeSoftware.Joob.ClassPersistence lifetime) :
			base(lifetime, typeof(Shop), _metaModel.metaClass)
		{
			this._initialize();
		}
		protected Shop(JadeSoftware.Joob.ClassPersistence lifetime, System.Type type, JadeSoftware.Joob.ClassMetadata metaClass) :
			base(lifetime, type, metaClass)
		{
			this._initialize();
		}
	
#region Jade Properties

		[JadeSoftware.Joob.Client.JoobPropertyAttribute("cartID", typeof(Int32), DatabaseTypeName="Integer")]
		[System.Runtime.Serialization.DataMemberAttribute()]
		public Int32 CartID
		{
			get
			{
				return this.GetPropertyInt32(_metaModel.metaClass, _metaModel.cartID);
			}
			set
			{
				this.SetPropertyInt32(_metaModel.metaClass, _metaModel.cartID, value);
			}
		}

		[JadeSoftware.Joob.Client.JoobPropertyAttribute("customers", typeof(CustomersById), DatabaseTypeName="CustomersById")]
		[System.Runtime.Serialization.DataMemberAttribute()]
		public CustomersById Customers
		{
			get
			{
				return this.GetPropertyReference<CustomersById>(_metaModel.metaClass, _metaModel.customers);
			}
			private set { }
		}

		[JadeSoftware.Joob.Client.JoobPropertyAttribute("employees", typeof(EmployeesById), DatabaseTypeName="EmployeesById")]
		[System.Runtime.Serialization.DataMemberAttribute()]
		public EmployeesById Employees
		{
			get
			{
				return this.GetPropertyReference<EmployeesById>(_metaModel.metaClass, _metaModel.employees);
			}
			private set { }
		}

		[JadeSoftware.Joob.Client.JoobPropertyAttribute("itemID", typeof(Int32), DatabaseTypeName="Integer")]
		[System.Runtime.Serialization.DataMemberAttribute()]
		public Int32 ItemID
		{
			get
			{
				return this.GetPropertyInt32(_metaModel.metaClass, _metaModel.itemID);
			}
			set
			{
				this.SetPropertyInt32(_metaModel.metaClass, _metaModel.itemID, value);
			}
		}

		[JadeSoftware.Joob.Client.JoobPropertyAttribute("items", typeof(ItemsByName), DatabaseTypeName="ItemsByName")]
		[System.Runtime.Serialization.DataMemberAttribute()]
		public ItemsByName Items
		{
			get
			{
				return this.GetPropertyReference<ItemsByName>(_metaModel.metaClass, _metaModel.items);
			}
			private set { }
		}

		[JadeSoftware.Joob.Client.JoobPropertyAttribute("personID", typeof(Int32), DatabaseTypeName="Integer")]
		[System.Runtime.Serialization.DataMemberAttribute()]
		public Int32 PersonID
		{
			get
			{
				return this.GetPropertyInt32(_metaModel.metaClass, _metaModel.personID);
			}
			set
			{
				this.SetPropertyInt32(_metaModel.metaClass, _metaModel.personID, value);
			}
		}

		[JadeSoftware.Joob.Client.JoobPropertyAttribute("positions", typeof(Positions), DatabaseTypeName="Positions")]
		[System.Runtime.Serialization.DataMemberAttribute()]
		public Positions Positions
		{
			get
			{
				return this.GetPropertyReference<Positions>(_metaModel.metaClass, _metaModel.positions);
			}
			private set { }
		}
	#endregion
	
#region Jade Methods

		[JadeSoftware.Joob.Client.JoobMethodAttribute("createCustomers")]
		public void CreateCustomers()
		{
			{
				this.SendMessage(_metaModel.createCustomers, null);
				return;
			}

		}

		[JadeSoftware.Joob.Client.JoobMethodAttribute("createEmployees")]
		public void CreateEmployees()
		{
			{
				this.SendMessage(_metaModel.createEmployees, null);
				return;
			}

		}

		[JadeSoftware.Joob.Client.JoobMethodAttribute("createItems")]
		public void CreateItems()
		{
			{
				this.SendMessage(_metaModel.createItems, null);
				return;
			}

		}

		[JadeSoftware.Joob.Client.JoobMethodAttribute("createPositions")]
		public void CreatePositions()
		{
			{
				this.SendMessage(_metaModel.createPositions, null);
				return;
			}

		}

		[JadeSoftware.Joob.Client.JoobMethodAttribute("createShop")]
		public void CreateShop()
		{
			{
				this.SendMessage(_metaModel.createShop, null);
				return;
			}

		}

		[JadeSoftware.Joob.Client.JoobMethodAttribute("nextCartId")]
		public Int32 NextCartId()
		{
			using (JadeParam retnParam = new JadeParamInteger(Usage.Output))
			{
				this.SendMessage(_metaModel.nextCartId, retnParam);
				return (retnParam as JadeParamInteger).Value;
			}

		}

		[JadeSoftware.Joob.Client.JoobMethodAttribute("nextItemID")]
		public Int32 NextItemID()
		{
			using (JadeParam retnParam = new JadeParamInteger(Usage.Output))
			{
				this.SendMessage(_metaModel.nextItemID, retnParam);
				return (retnParam as JadeParamInteger).Value;
			}

		}

		[JadeSoftware.Joob.Client.JoobMethodAttribute("nextPersonID")]
		public Int32 NextPersonID()
		{
			using (JadeParam retnParam = new JadeParamInteger(Usage.Output))
			{
				this.SendMessage(_metaModel.nextPersonID, retnParam);
				return (retnParam as JadeParamInteger).Value;
			}

		}
	#endregion
	}

	public partial class ShopMetadata : JadeSoftware.Joob.IDomainMetadata
	{

		internal JadeSoftware.Joob.ClassMetadata metaClass;
		internal JadeSoftware.Joob.PropertyMetadata cartID;
		internal JadeSoftware.Joob.MethodMetadata createCustomers;
		internal JadeSoftware.Joob.MethodMetadata createEmployees;
		internal JadeSoftware.Joob.MethodMetadata createItems;
		internal JadeSoftware.Joob.MethodMetadata createPositions;
		internal JadeSoftware.Joob.MethodMetadata createShop;
		internal JadeSoftware.Joob.PropertyMetadata customers;
		internal JadeSoftware.Joob.PropertyMetadata employees;
		internal JadeSoftware.Joob.PropertyMetadata itemID;
		internal JadeSoftware.Joob.PropertyMetadata items;
		internal JadeSoftware.Joob.MethodMetadata nextCartId;
		internal JadeSoftware.Joob.MethodMetadata nextItemID;
		internal JadeSoftware.Joob.MethodMetadata nextPersonID;
		internal JadeSoftware.Joob.PropertyMetadata personID;
		internal JadeSoftware.Joob.PropertyMetadata positions;

		private ShopMetadata()
		{
		}
		partial void InitializeDynamicProperties(JadeSoftware.Joob.Client.IJoobConnection connection);

		public ShopMetadata(JadeSoftware.Joob.Client.JoobConnection connection)
		{
			metaClass = new JadeSoftware.Joob.ClassMetadata(connection, typeof(Shop), "Shop", "RootSchema.JadeProject");
			this.InitializeProperties(connection);
			this.InitializeDynamicProperties(connection);
		}

		private void InitializeProperties(JadeSoftware.Joob.Client.IJoobConnection connection)
		{
			cartID = metaClass.CheckProperty("cartID", typeof(Int32));
			createCustomers = metaClass.CheckMethod(metaClass,"createCustomers");
			createEmployees = metaClass.CheckMethod(metaClass,"createEmployees");
			createItems = metaClass.CheckMethod(metaClass,"createItems");
			createPositions = metaClass.CheckMethod(metaClass,"createPositions");
			createShop = metaClass.CheckMethod(metaClass,"createShop");
			customers = metaClass.CheckProperty("customers", typeof(CustomersById));
			employees = metaClass.CheckProperty("employees", typeof(EmployeesById));
			itemID = metaClass.CheckProperty("itemID", typeof(Int32));
			items = metaClass.CheckProperty("items", typeof(ItemsByName));
			nextCartId = metaClass.CheckMethod(metaClass,"nextCartId");
			nextItemID = metaClass.CheckMethod(metaClass,"nextItemID");
			nextPersonID = metaClass.CheckMethod(metaClass,"nextPersonID");
			personID = metaClass.CheckProperty("personID", typeof(Int32));
			positions = metaClass.CheckProperty("positions", typeof(Positions));
		}
	}
}
