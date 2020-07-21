using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
	[Container(Layout.Wrap), Group(Layout.GroupBox)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbDigitalSensor", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class fbDigitalSensor : Vortex.Connector.IVortexObject, IfbDigitalSensor, IShadowfbDigitalSensor, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _Value;
		[Container(Layout.UniformGrid)]
		public Vortex.Connector.ValueTypes.OnlinerBool Value
		{
			get
			{
				return _Value;
			}
		}

		[Container(Layout.UniformGrid)]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbDigitalSensor.Value
		{
			get
			{
				return Value;
			}
		}

		[Container(Layout.UniformGrid)]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbDigitalSensor.Value
		{
			get
			{
				return Value;
			}
		}

		public void LazyOnlineToShadow()
		{
			Value.Shadow = Value.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Value.Cyclic = Value.Shadow;
		}

		public PlainfbDigitalSensor CreatePlainerType()
		{
			var cloned = new PlainfbDigitalSensor();
			return cloned;
		}

		protected PlainfbDigitalSensor CreatePlainerType(PlainfbDigitalSensor cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
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

		public void FlushPlainToOnline(MainPlc.PlainfbDigitalSensor source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainfbDigitalSensor source)
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

		public void FlushOnlineToPlain(MainPlc.PlainfbDigitalSensor source)
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

		public fbDigitalSensor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Value = @Connector.Online.Adapter.CreateBOOL(this, "Value", "Value");
			Value.AttributeName = "Value";
			Value.AttributeToolTip = "Sensor actual value";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public fbDigitalSensor()
		{
			PexPreConstructorParameterless();
			_Value = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Value.AttributeName = "Value";
			Value.AttributeToolTip = "Sensor actual value";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbDigitalSensor
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbDigitalSensor()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbDigitalSensor : Vortex.Connector.IVortexOnlineObject
	{
		[Container(Layout.UniformGrid)]
		Vortex.Connector.ValueTypes.Online.IOnlineBool Value
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbDigitalSensor CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainfbDigitalSensor source);
		void FlushOnlineToPlain(MainPlc.PlainfbDigitalSensor source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbDigitalSensor : Vortex.Connector.IVortexShadowObject
	{
		[Container(Layout.UniformGrid)]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool Value
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbDigitalSensor CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainfbDigitalSensor source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbDigitalSensor : Vortex.Connector.IPlain
	{
		System.Boolean _Value;
		[Container(Layout.UniformGrid)]
		public System.Boolean Value
		{
			get
			{
				return _Value;
			}

			set
			{
				_Value = value;
			}
		}

		public void CopyPlainToCyclic(MainPlc.fbDigitalSensor target)
		{
			target.Value.Cyclic = Value;
		}

		public void CopyPlainToCyclic(MainPlc.IfbDigitalSensor target)
		{
			this.CopyPlainToCyclic((MainPlc.fbDigitalSensor)target);
		}

		public void CopyPlainToShadow(MainPlc.fbDigitalSensor target)
		{
			target.Value.Shadow = Value;
		}

		public void CopyPlainToShadow(MainPlc.IShadowfbDigitalSensor target)
		{
			this.CopyPlainToShadow((MainPlc.fbDigitalSensor)target);
		}

		public void CopyCyclicToPlain(MainPlc.fbDigitalSensor source)
		{
			Value = source.Value.LastValue;
		}

		public void CopyCyclicToPlain(MainPlc.IfbDigitalSensor source)
		{
			this.CopyCyclicToPlain((MainPlc.fbDigitalSensor)source);
		}

		public void CopyShadowToPlain(MainPlc.fbDigitalSensor source)
		{
			Value = source.Value.Shadow;
		}

		public void CopyShadowToPlain(MainPlc.IShadowfbDigitalSensor source)
		{
			this.CopyShadowToPlain((MainPlc.fbDigitalSensor)source);
		}

		public PlainfbDigitalSensor()
		{
		}
	}
}