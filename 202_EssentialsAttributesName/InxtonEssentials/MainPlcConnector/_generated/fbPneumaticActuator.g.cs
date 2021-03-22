using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbPneumaticActuator", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class fbPneumaticActuator : Vortex.Connector.IVortexObject, IfbPneumaticActuator, IShadowfbPneumaticActuator, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _inRetracted;
		public Vortex.Connector.ValueTypes.OnlinerBool inRetracted
		{
			get
			{
				return _inRetracted;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbPneumaticActuator.inRetracted
		{
			get
			{
				return inRetracted;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbPneumaticActuator.inRetracted
		{
			get
			{
				return inRetracted;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _inExtended;
		public Vortex.Connector.ValueTypes.OnlinerBool inExtended
		{
			get
			{
				return _inExtended;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbPneumaticActuator.inExtended
		{
			get
			{
				return inExtended;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbPneumaticActuator.inExtended
		{
			get
			{
				return inExtended;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _outRetract;
		public Vortex.Connector.ValueTypes.OnlinerBool outRetract
		{
			get
			{
				return _outRetract;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbPneumaticActuator.outRetract
		{
			get
			{
				return outRetract;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbPneumaticActuator.outRetract
		{
			get
			{
				return outRetract;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _outExtend;
		public Vortex.Connector.ValueTypes.OnlinerBool outExtend
		{
			get
			{
				return _outExtend;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbPneumaticActuator.outExtend
		{
			get
			{
				return outExtend;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbPneumaticActuator.outExtend
		{
			get
			{
				return outExtend;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool __manualRetract;
		public Vortex.Connector.ValueTypes.OnlinerBool _manualRetract
		{
			get
			{
				return __manualRetract;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbPneumaticActuator._manualRetract
		{
			get
			{
				return _manualRetract;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbPneumaticActuator._manualRetract
		{
			get
			{
				return _manualRetract;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool __manualExtend;
		public Vortex.Connector.ValueTypes.OnlinerBool _manualExtend
		{
			get
			{
				return __manualExtend;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbPneumaticActuator._manualExtend
		{
			get
			{
				return _manualExtend;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbPneumaticActuator._manualExtend
		{
			get
			{
				return _manualExtend;
			}
		}

		public void LazyOnlineToShadow()
		{
			inRetracted.Shadow = inRetracted.LastValue;
			inExtended.Shadow = inExtended.LastValue;
			outRetract.Shadow = outRetract.LastValue;
			outExtend.Shadow = outExtend.LastValue;
			_manualRetract.Shadow = _manualRetract.LastValue;
			_manualExtend.Shadow = _manualExtend.LastValue;
		}

		public void LazyShadowToOnline()
		{
			inRetracted.Cyclic = inRetracted.Shadow;
			inExtended.Cyclic = inExtended.Shadow;
			outRetract.Cyclic = outRetract.Shadow;
			outExtend.Cyclic = outExtend.Shadow;
			_manualRetract.Cyclic = _manualRetract.Shadow;
			_manualExtend.Cyclic = _manualExtend.Shadow;
		}

		public PlainfbPneumaticActuator CreatePlainerType()
		{
			var cloned = new PlainfbPneumaticActuator();
			return cloned;
		}

		protected PlainfbPneumaticActuator CreatePlainerType(PlainfbPneumaticActuator cloned)
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

		public void FlushPlainToOnline(MainPlc.PlainfbPneumaticActuator source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainfbPneumaticActuator source)
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

		public void FlushOnlineToPlain(MainPlc.PlainfbPneumaticActuator source)
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

		public fbPneumaticActuator(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_inRetracted = @Connector.Online.Adapter.CreateBOOL(this, "Retracted", "inRetracted");
			inRetracted.AttributeName = "Retracted";
			inRetracted.AttributeToolTip = "Sensor indicating that the actuator is retracted";
			_inExtended = @Connector.Online.Adapter.CreateBOOL(this, "Extended", "inExtended");
			inExtended.AttributeName = "Extended";
			inExtended.AttributeToolTip = "Sensor indicating that the actuator is extended";
			_outRetract = @Connector.Online.Adapter.CreateBOOL(this, "Retract", "outRetract");
			outRetract.AttributeName = "Retract";
			outRetract.AttributeToolTip = "Signal for retracting";
			_outExtend = @Connector.Online.Adapter.CreateBOOL(this, "Extend", "outExtend");
			outExtend.AttributeName = "Extend";
			outExtend.AttributeToolTip = "Signal for extending";
			__manualRetract = @Connector.Online.Adapter.CreateBOOL(this, "Manual Retract", "_manualRetract");
			_manualRetract.AttributeName = "Manual Retract";
			_manualRetract.AttributeToolTip = "Executes retraction in manual mode";
			__manualExtend = @Connector.Online.Adapter.CreateBOOL(this, "Manual Extend", "_manualExtend");
			_manualExtend.AttributeName = "Manual Extend";
			_manualExtend.AttributeToolTip = "Executes extension in manual mode";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbPneumaticActuator()
		{
			PexPreConstructorParameterless();
			_inRetracted = Vortex.Connector.IConnectorFactory.CreateBOOL();
			inRetracted.AttributeName = "Retracted";
			inRetracted.AttributeToolTip = "Sensor indicating that the actuator is retracted";
			_inExtended = Vortex.Connector.IConnectorFactory.CreateBOOL();
			inExtended.AttributeName = "Extended";
			inExtended.AttributeToolTip = "Sensor indicating that the actuator is extended";
			_outRetract = Vortex.Connector.IConnectorFactory.CreateBOOL();
			outRetract.AttributeName = "Retract";
			outRetract.AttributeToolTip = "Signal for retracting";
			_outExtend = Vortex.Connector.IConnectorFactory.CreateBOOL();
			outExtend.AttributeName = "Extend";
			outExtend.AttributeToolTip = "Signal for extending";
			__manualRetract = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_manualRetract.AttributeName = "Manual Retract";
			_manualRetract.AttributeToolTip = "Executes retraction in manual mode";
			__manualExtend = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_manualExtend.AttributeName = "Manual Extend";
			_manualExtend.AttributeToolTip = "Executes extension in manual mode";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbPneumaticActuator
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbPneumaticActuator()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbPneumaticActuator : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool inRetracted
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool inExtended
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool outRetract
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool outExtend
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool _manualRetract
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool _manualExtend
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbPneumaticActuator CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainfbPneumaticActuator source);
		void FlushOnlineToPlain(MainPlc.PlainfbPneumaticActuator source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbPneumaticActuator : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool inRetracted
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool inExtended
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool outRetract
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool outExtend
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool _manualRetract
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool _manualExtend
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbPneumaticActuator CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainfbPneumaticActuator source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbPneumaticActuator : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _inRetracted;
		public System.Boolean inRetracted
		{
			get
			{
				return _inRetracted;
			}

			set
			{
				if (_inRetracted != value)
				{
					_inRetracted = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(inRetracted)));
				}
			}
		}

		System.Boolean _inExtended;
		public System.Boolean inExtended
		{
			get
			{
				return _inExtended;
			}

			set
			{
				if (_inExtended != value)
				{
					_inExtended = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(inExtended)));
				}
			}
		}

		System.Boolean _outRetract;
		public System.Boolean outRetract
		{
			get
			{
				return _outRetract;
			}

			set
			{
				if (_outRetract != value)
				{
					_outRetract = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(outRetract)));
				}
			}
		}

		System.Boolean _outExtend;
		public System.Boolean outExtend
		{
			get
			{
				return _outExtend;
			}

			set
			{
				if (_outExtend != value)
				{
					_outExtend = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(outExtend)));
				}
			}
		}

		System.Boolean __manualRetract;
		public System.Boolean _manualRetract
		{
			get
			{
				return __manualRetract;
			}

			set
			{
				if (__manualRetract != value)
				{
					__manualRetract = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_manualRetract)));
				}
			}
		}

		System.Boolean __manualExtend;
		public System.Boolean _manualExtend
		{
			get
			{
				return __manualExtend;
			}

			set
			{
				if (__manualExtend != value)
				{
					__manualExtend = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_manualExtend)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.fbPneumaticActuator target)
		{
			target.inRetracted.Cyclic = inRetracted;
			target.inExtended.Cyclic = inExtended;
			target.outRetract.Cyclic = outRetract;
			target.outExtend.Cyclic = outExtend;
			target._manualRetract.Cyclic = _manualRetract;
			target._manualExtend.Cyclic = _manualExtend;
		}

		public void CopyPlainToCyclic(MainPlc.IfbPneumaticActuator target)
		{
			this.CopyPlainToCyclic((MainPlc.fbPneumaticActuator)target);
		}

		public void CopyPlainToShadow(MainPlc.fbPneumaticActuator target)
		{
			target.inRetracted.Shadow = inRetracted;
			target.inExtended.Shadow = inExtended;
			target.outRetract.Shadow = outRetract;
			target.outExtend.Shadow = outExtend;
			target._manualRetract.Shadow = _manualRetract;
			target._manualExtend.Shadow = _manualExtend;
		}

		public void CopyPlainToShadow(MainPlc.IShadowfbPneumaticActuator target)
		{
			this.CopyPlainToShadow((MainPlc.fbPneumaticActuator)target);
		}

		public void CopyCyclicToPlain(MainPlc.fbPneumaticActuator source)
		{
			inRetracted = source.inRetracted.LastValue;
			inExtended = source.inExtended.LastValue;
			outRetract = source.outRetract.LastValue;
			outExtend = source.outExtend.LastValue;
			_manualRetract = source._manualRetract.LastValue;
			_manualExtend = source._manualExtend.LastValue;
		}

		public void CopyCyclicToPlain(MainPlc.IfbPneumaticActuator source)
		{
			this.CopyCyclicToPlain((MainPlc.fbPneumaticActuator)source);
		}

		public void CopyShadowToPlain(MainPlc.fbPneumaticActuator source)
		{
			inRetracted = source.inRetracted.Shadow;
			inExtended = source.inExtended.Shadow;
			outRetract = source.outRetract.Shadow;
			outExtend = source.outExtend.Shadow;
			_manualRetract = source._manualRetract.Shadow;
			_manualExtend = source._manualExtend.Shadow;
		}

		public void CopyShadowToPlain(MainPlc.IShadowfbPneumaticActuator source)
		{
			this.CopyShadowToPlain((MainPlc.fbPneumaticActuator)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbPneumaticActuator()
		{
		}
	}
}