using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Container(Layout.Wrap), Group(Layout.GroupBox)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbStepConveyor", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class fbStepConveyor : Vortex.Connector.IVortexObject, IfbStepConveyor, IShadowfbStepConveyor, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _inStop;
		[Container(Layout.Stack)]
		public Vortex.Connector.ValueTypes.OnlinerBool inStop
		{
			get
			{
				return _inStop;
			}
		}

		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbStepConveyor.inStop
		{
			get
			{
				return inStop;
			}
		}

		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbStepConveyor.inStop
		{
			get
			{
				return inStop;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _outMove;
		[Container(Layout.Stack)]
		public Vortex.Connector.ValueTypes.OnlinerBool outMove
		{
			get
			{
				return _outMove;
			}
		}

		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbStepConveyor.outMove
		{
			get
			{
				return outMove;
			}
		}

		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbStepConveyor.outMove
		{
			get
			{
				return outMove;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool __manualMove;
		[Container(Layout.UniformGrid)]
		public Vortex.Connector.ValueTypes.OnlinerBool _manualMove
		{
			get
			{
				return __manualMove;
			}
		}

		[Container(Layout.UniformGrid)]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbStepConveyor._manualMove
		{
			get
			{
				return _manualMove;
			}
		}

		[Container(Layout.UniformGrid)]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbStepConveyor._manualMove
		{
			get
			{
				return _manualMove;
			}
		}

		public void LazyOnlineToShadow()
		{
			inStop.Shadow = inStop.LastValue;
			outMove.Shadow = outMove.LastValue;
			_manualMove.Shadow = _manualMove.LastValue;
		}

		public void LazyShadowToOnline()
		{
			inStop.Cyclic = inStop.Shadow;
			outMove.Cyclic = outMove.Shadow;
			_manualMove.Cyclic = _manualMove.Shadow;
		}

		public PlainfbStepConveyor CreatePlainerType()
		{
			var cloned = new PlainfbStepConveyor();
			return cloned;
		}

		protected PlainfbStepConveyor CreatePlainerType(PlainfbStepConveyor cloned)
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

		public void FlushPlainToOnline(MainPlc.PlainfbStepConveyor source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainfbStepConveyor source)
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

		public void FlushOnlineToPlain(MainPlc.PlainfbStepConveyor source)
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

		public fbStepConveyor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_inStop = @Connector.Online.Adapter.CreateBOOL(this, "Stop condition", "inStop");
			inStop.AttributeName = "Stop condition";
			inStop.AttributeToolTip = "Signal that stops the conveyor";
			_outMove = @Connector.Online.Adapter.CreateBOOL(this, "Move", "outMove");
			outMove.AttributeName = "Move";
			outMove.AttributeToolTip = "Signal for moving conveyor";
			__manualMove = @Connector.Online.Adapter.CreateBOOL(this, "Move manual command", "_manualMove");
			_manualMove.AttributeName = "Move manual command";
			_manualMove.AttributeToolTip = "Triggers movement in manual mode if possible";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbStepConveyor()
		{
			PexPreConstructorParameterless();
			_inStop = Vortex.Connector.IConnectorFactory.CreateBOOL();
			inStop.AttributeName = "Stop condition";
			inStop.AttributeToolTip = "Signal that stops the conveyor";
			_outMove = Vortex.Connector.IConnectorFactory.CreateBOOL();
			outMove.AttributeName = "Move";
			outMove.AttributeToolTip = "Signal for moving conveyor";
			__manualMove = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_manualMove.AttributeName = "Move manual command";
			_manualMove.AttributeToolTip = "Triggers movement in manual mode if possible";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbStepConveyor
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbStepConveyor()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbStepConveyor : Vortex.Connector.IVortexOnlineObject
	{
		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Online.IOnlineBool inStop
		{
			get;
		}

		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Online.IOnlineBool outMove
		{
			get;
		}

		[Container(Layout.UniformGrid)]
		Vortex.Connector.ValueTypes.Online.IOnlineBool _manualMove
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbStepConveyor CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainfbStepConveyor source);
		void FlushOnlineToPlain(MainPlc.PlainfbStepConveyor source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbStepConveyor : Vortex.Connector.IVortexShadowObject
	{
		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool inStop
		{
			get;
		}

		[Container(Layout.Stack)]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool outMove
		{
			get;
		}

		[Container(Layout.UniformGrid)]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool _manualMove
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbStepConveyor CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainfbStepConveyor source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbStepConveyor : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _inStop;
		[Container(Layout.Stack)]
		public System.Boolean inStop
		{
			get
			{
				return _inStop;
			}

			set
			{
				if (_inStop != value)
				{
					_inStop = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(inStop)));
				}
			}
		}

		System.Boolean _outMove;
		[Container(Layout.Stack)]
		public System.Boolean outMove
		{
			get
			{
				return _outMove;
			}

			set
			{
				if (_outMove != value)
				{
					_outMove = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(outMove)));
				}
			}
		}

		System.Boolean __manualMove;
		[Container(Layout.UniformGrid)]
		public System.Boolean _manualMove
		{
			get
			{
				return __manualMove;
			}

			set
			{
				if (__manualMove != value)
				{
					__manualMove = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_manualMove)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.fbStepConveyor target)
		{
			target.inStop.Cyclic = inStop;
			target.outMove.Cyclic = outMove;
			target._manualMove.Cyclic = _manualMove;
		}

		public void CopyPlainToCyclic(MainPlc.IfbStepConveyor target)
		{
			this.CopyPlainToCyclic((MainPlc.fbStepConveyor)target);
		}

		public void CopyPlainToShadow(MainPlc.fbStepConveyor target)
		{
			target.inStop.Shadow = inStop;
			target.outMove.Shadow = outMove;
			target._manualMove.Shadow = _manualMove;
		}

		public void CopyPlainToShadow(MainPlc.IShadowfbStepConveyor target)
		{
			this.CopyPlainToShadow((MainPlc.fbStepConveyor)target);
		}

		public void CopyCyclicToPlain(MainPlc.fbStepConveyor source)
		{
			inStop = source.inStop.LastValue;
			outMove = source.outMove.LastValue;
			_manualMove = source._manualMove.LastValue;
		}

		public void CopyCyclicToPlain(MainPlc.IfbStepConveyor source)
		{
			this.CopyCyclicToPlain((MainPlc.fbStepConveyor)source);
		}

		public void CopyShadowToPlain(MainPlc.fbStepConveyor source)
		{
			inStop = source.inStop.Shadow;
			outMove = source.outMove.Shadow;
			_manualMove = source._manualMove.Shadow;
		}

		public void CopyShadowToPlain(MainPlc.IShadowfbStepConveyor source)
		{
			this.CopyShadowToPlain((MainPlc.fbStepConveyor)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbStepConveyor()
		{
		}
	}
}