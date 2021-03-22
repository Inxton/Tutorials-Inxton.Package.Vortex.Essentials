using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbValueSimulation", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class fbValueSimulation : Vortex.Connector.IVortexObject, IfbValueSimulation, IShadowfbValueSimulation, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return MainPlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerReal _MinValue;
		public Vortex.Connector.ValueTypes.OnlinerReal MinValue
		{
			get
			{
				return _MinValue;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IfbValueSimulation.MinValue
		{
			get
			{
				return MinValue;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowfbValueSimulation.MinValue
		{
			get
			{
				return MinValue;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _MaxValue;
		public Vortex.Connector.ValueTypes.OnlinerReal MaxValue
		{
			get
			{
				return _MaxValue;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IfbValueSimulation.MaxValue
		{
			get
			{
				return MaxValue;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowfbValueSimulation.MaxValue
		{
			get
			{
				return MaxValue;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Value;
		public Vortex.Connector.ValueTypes.OnlinerReal Value
		{
			get
			{
				return _Value;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IfbValueSimulation.Value
		{
			get
			{
				return Value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowfbValueSimulation.Value
		{
			get
			{
				return Value;
			}
		}

		public void LazyOnlineToShadow()
		{
			MinValue.Shadow = MinValue.LastValue;
			MaxValue.Shadow = MaxValue.LastValue;
			Value.Shadow = Value.LastValue;
		}

		public void LazyShadowToOnline()
		{
			MinValue.Cyclic = MinValue.Shadow;
			MaxValue.Cyclic = MaxValue.Shadow;
			Value.Cyclic = Value.Shadow;
		}

		public PlainfbValueSimulation CreatePlainerType()
		{
			var cloned = new PlainfbValueSimulation();
			return cloned;
		}

		protected PlainfbValueSimulation CreatePlainerType(PlainfbValueSimulation cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(MainPlc.PlainfbValueSimulation source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainfbValueSimulation source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(MainPlc.PlainfbValueSimulation source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return MainPlcTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public fbValueSimulation(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_MinValue = @Connector.Online.Adapter.CreateREAL(this, "", "MinValue");
			_MaxValue = @Connector.Online.Adapter.CreateREAL(this, "", "MaxValue");
			_Value = @Connector.Online.Adapter.CreateREAL(this, "", "Value");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbValueSimulation()
		{
			PexPreConstructorParameterless();
			_MinValue = Vortex.Connector.IConnectorFactory.CreateREAL();
			_MaxValue = Vortex.Connector.IConnectorFactory.CreateREAL();
			_Value = Vortex.Connector.IConnectorFactory.CreateREAL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbValueSimulation
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbValueSimulation()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbValueSimulation : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineReal MinValue
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal MaxValue
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Value
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbValueSimulation CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainfbValueSimulation source);
		void FlushOnlineToPlain(MainPlc.PlainfbValueSimulation source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbValueSimulation : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowReal MinValue
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal MaxValue
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Value
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbValueSimulation CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainfbValueSimulation source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbValueSimulation : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Single _MinValue;
		public System.Single MinValue
		{
			get
			{
				return _MinValue;
			}

			set
			{
				if (_MinValue != value)
				{
					_MinValue = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MinValue)));
				}
			}
		}

		System.Single _MaxValue;
		public System.Single MaxValue
		{
			get
			{
				return _MaxValue;
			}

			set
			{
				if (_MaxValue != value)
				{
					_MaxValue = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MaxValue)));
				}
			}
		}

		System.Single _Value;
		public System.Single Value
		{
			get
			{
				return _Value;
			}

			set
			{
				if (_Value != value)
				{
					_Value = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Value)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.fbValueSimulation target)
		{
			target.MinValue.Cyclic = MinValue;
			target.MaxValue.Cyclic = MaxValue;
			target.Value.Cyclic = Value;
		}

		public void CopyPlainToCyclic(MainPlc.IfbValueSimulation target)
		{
			this.CopyPlainToCyclic((MainPlc.fbValueSimulation)target);
		}

		public void CopyPlainToShadow(MainPlc.fbValueSimulation target)
		{
			target.MinValue.Shadow = MinValue;
			target.MaxValue.Shadow = MaxValue;
			target.Value.Shadow = Value;
		}

		public void CopyPlainToShadow(MainPlc.IShadowfbValueSimulation target)
		{
			this.CopyPlainToShadow((MainPlc.fbValueSimulation)target);
		}

		public void CopyCyclicToPlain(MainPlc.fbValueSimulation source)
		{
			MinValue = source.MinValue.LastValue;
			MaxValue = source.MaxValue.LastValue;
			Value = source.Value.LastValue;
		}

		public void CopyCyclicToPlain(MainPlc.IfbValueSimulation source)
		{
			this.CopyCyclicToPlain((MainPlc.fbValueSimulation)source);
		}

		public void CopyShadowToPlain(MainPlc.fbValueSimulation source)
		{
			MinValue = source.MinValue.Shadow;
			MaxValue = source.MaxValue.Shadow;
			Value = source.Value.Shadow;
		}

		public void CopyShadowToPlain(MainPlc.IShadowfbValueSimulation source)
		{
			this.CopyShadowToPlain((MainPlc.fbValueSimulation)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbValueSimulation()
		{
		}
	}
}