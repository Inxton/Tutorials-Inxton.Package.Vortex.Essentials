using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class MAIN : Vortex.Connector.IVortexObject, IMAIN, IShadowMAIN, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		fbPneumaticActuator __fbPneumaticActuator;
		public fbPneumaticActuator _fbPneumaticActuator
		{
			get
			{
				return __fbPneumaticActuator;
			}
		}

		IfbPneumaticActuator IMAIN._fbPneumaticActuator
		{
			get
			{
				return _fbPneumaticActuator;
			}
		}

		IShadowfbPneumaticActuator IShadowMAIN._fbPneumaticActuator
		{
			get
			{
				return _fbPneumaticActuator;
			}
		}

		public void LazyOnlineToShadow()
		{
			_fbPneumaticActuator.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			_fbPneumaticActuator.LazyShadowToOnline();
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned._fbPneumaticActuator = _fbPneumaticActuator.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned._fbPneumaticActuator = _fbPneumaticActuator.CreatePlainerType();
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

		public void FlushPlainToOnline(MainPlc.PlainMAIN source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainMAIN source)
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

		public void FlushOnlineToPlain(MainPlc.PlainMAIN source)
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

		public MAIN(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			__fbPneumaticActuator = new fbPneumaticActuator(this, "", "_fbPneumaticActuator");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			__fbPneumaticActuator = new fbPneumaticActuator();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcMAIN
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcMAIN()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IMAIN : Vortex.Connector.IVortexOnlineObject
	{
		IfbPneumaticActuator _fbPneumaticActuator
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainMAIN CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainMAIN source);
		void FlushOnlineToPlain(MainPlc.PlainMAIN source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		IShadowfbPneumaticActuator _fbPneumaticActuator
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainMAIN CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainMAIN source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainfbPneumaticActuator __fbPneumaticActuator;
		public PlainfbPneumaticActuator _fbPneumaticActuator
		{
			get
			{
				return __fbPneumaticActuator;
			}

			set
			{
				if (__fbPneumaticActuator != value)
				{
					__fbPneumaticActuator = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_fbPneumaticActuator)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.MAIN target)
		{
			_fbPneumaticActuator.CopyPlainToCyclic(target._fbPneumaticActuator);
		}

		public void CopyPlainToCyclic(MainPlc.IMAIN target)
		{
			this.CopyPlainToCyclic((MainPlc.MAIN)target);
		}

		public void CopyPlainToShadow(MainPlc.MAIN target)
		{
			_fbPneumaticActuator.CopyPlainToShadow(target._fbPneumaticActuator);
		}

		public void CopyPlainToShadow(MainPlc.IShadowMAIN target)
		{
			this.CopyPlainToShadow((MainPlc.MAIN)target);
		}

		public void CopyCyclicToPlain(MainPlc.MAIN source)
		{
			_fbPneumaticActuator.CopyCyclicToPlain(source._fbPneumaticActuator);
		}

		public void CopyCyclicToPlain(MainPlc.IMAIN source)
		{
			this.CopyCyclicToPlain((MainPlc.MAIN)source);
		}

		public void CopyShadowToPlain(MainPlc.MAIN source)
		{
			_fbPneumaticActuator.CopyShadowToPlain(source._fbPneumaticActuator);
		}

		public void CopyShadowToPlain(MainPlc.IShadowMAIN source)
		{
			this.CopyShadowToPlain((MainPlc.MAIN)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMAIN()
		{
			__fbPneumaticActuator = new PlainfbPneumaticActuator();
		}
	}
}