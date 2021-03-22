using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Container(Layout.Stack)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"<#Components#>\" }", "stComponents", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class stComponents : Vortex.Connector.IVortexObject, IstComponents, IShadowstComponents, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		fbPneumaticActuator __horizontalPiston;
		public fbPneumaticActuator _horizontalPiston
		{
			get
			{
				return __horizontalPiston;
			}
		}

		IfbPneumaticActuator IstComponents._horizontalPiston
		{
			get
			{
				return _horizontalPiston;
			}
		}

		IShadowfbPneumaticActuator IShadowstComponents._horizontalPiston
		{
			get
			{
				return _horizontalPiston;
			}
		}

		fbPneumaticActuator __verticalPiston;
		public fbPneumaticActuator _verticalPiston
		{
			get
			{
				return __verticalPiston;
			}
		}

		IfbPneumaticActuator IstComponents._verticalPiston
		{
			get
			{
				return _verticalPiston;
			}
		}

		IShadowfbPneumaticActuator IShadowstComponents._verticalPiston
		{
			get
			{
				return _verticalPiston;
			}
		}

		fbPneumaticActuator __gripper;
		public fbPneumaticActuator _gripper
		{
			get
			{
				return __gripper;
			}
		}

		IfbPneumaticActuator IstComponents._gripper
		{
			get
			{
				return _gripper;
			}
		}

		IShadowfbPneumaticActuator IShadowstComponents._gripper
		{
			get
			{
				return _gripper;
			}
		}

		fbPneumaticActuator __horizontalPistonLockerFailed;
		public fbPneumaticActuator _horizontalPistonLockerFailed
		{
			get
			{
				return __horizontalPistonLockerFailed;
			}
		}

		IfbPneumaticActuator IstComponents._horizontalPistonLockerFailed
		{
			get
			{
				return _horizontalPistonLockerFailed;
			}
		}

		IShadowfbPneumaticActuator IShadowstComponents._horizontalPistonLockerFailed
		{
			get
			{
				return _horizontalPistonLockerFailed;
			}
		}

		public void LazyOnlineToShadow()
		{
			_horizontalPiston.LazyOnlineToShadow();
			_verticalPiston.LazyOnlineToShadow();
			_gripper.LazyOnlineToShadow();
			_horizontalPistonLockerFailed.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			_horizontalPiston.LazyShadowToOnline();
			_verticalPiston.LazyShadowToOnline();
			_gripper.LazyShadowToOnline();
			_horizontalPistonLockerFailed.LazyShadowToOnline();
		}

		public PlainstComponents CreatePlainerType()
		{
			var cloned = new PlainstComponents();
			cloned._horizontalPiston = _horizontalPiston.CreatePlainerType();
			cloned._verticalPiston = _verticalPiston.CreatePlainerType();
			cloned._gripper = _gripper.CreatePlainerType();
			cloned._horizontalPistonLockerFailed = _horizontalPistonLockerFailed.CreatePlainerType();
			return cloned;
		}

		protected PlainstComponents CreatePlainerType(PlainstComponents cloned)
		{
			cloned._horizontalPiston = _horizontalPiston.CreatePlainerType();
			cloned._verticalPiston = _verticalPiston.CreatePlainerType();
			cloned._gripper = _gripper.CreatePlainerType();
			cloned._horizontalPistonLockerFailed = _horizontalPistonLockerFailed.CreatePlainerType();
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

		public void FlushPlainToOnline(MainPlc.PlainstComponents source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainstComponents source)
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

		public void FlushOnlineToPlain(MainPlc.PlainstComponents source)
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

		public stComponents(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			__horizontalPiston = new fbPneumaticActuator(this, "<#Horizontal piston#> A1", "_horizontalPiston");
			__horizontalPiston.AttributeName = "<#Horizontal piston#> A1";
			__verticalPiston = new fbPneumaticActuator(this, "<#Vertical piston#> A2", "_verticalPiston");
			__verticalPiston.AttributeName = "<#Vertical piston#> A2";
			__gripper = new fbPneumaticActuator(this, "<#Gripper#> A3", "_gripper");
			__gripper.AttributeName = "<#Gripper#> A3";
			__horizontalPistonLockerFailed = new fbPneumaticActuator(this, "<#Locker#> A4", "_horizontalPistonLockerFailed");
			__horizontalPistonLockerFailed.AttributeName = "<#Locker#> A4";
			AttributeName = "<#Components#>";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stComponents()
		{
			PexPreConstructorParameterless();
			__horizontalPiston = new fbPneumaticActuator();
			__horizontalPiston.AttributeName = "<#Horizontal piston#> A1";
			__verticalPiston = new fbPneumaticActuator();
			__verticalPiston.AttributeName = "<#Vertical piston#> A2";
			__gripper = new fbPneumaticActuator();
			__gripper.AttributeName = "<#Gripper#> A3";
			__horizontalPistonLockerFailed = new fbPneumaticActuator();
			__horizontalPistonLockerFailed.AttributeName = "<#Locker#> A4";
			AttributeName = "<#Components#>";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstComponents
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstComponents()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstComponents : Vortex.Connector.IVortexOnlineObject
	{
		IfbPneumaticActuator _horizontalPiston
		{
			get;
		}

		IfbPneumaticActuator _verticalPiston
		{
			get;
		}

		IfbPneumaticActuator _gripper
		{
			get;
		}

		IfbPneumaticActuator _horizontalPistonLockerFailed
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainstComponents CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainstComponents source);
		void FlushOnlineToPlain(MainPlc.PlainstComponents source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstComponents : Vortex.Connector.IVortexShadowObject
	{
		IShadowfbPneumaticActuator _horizontalPiston
		{
			get;
		}

		IShadowfbPneumaticActuator _verticalPiston
		{
			get;
		}

		IShadowfbPneumaticActuator _gripper
		{
			get;
		}

		IShadowfbPneumaticActuator _horizontalPistonLockerFailed
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainstComponents CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainstComponents source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstComponents : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainfbPneumaticActuator __horizontalPiston;
		public PlainfbPneumaticActuator _horizontalPiston
		{
			get
			{
				return __horizontalPiston;
			}

			set
			{
				if (__horizontalPiston != value)
				{
					__horizontalPiston = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_horizontalPiston)));
				}
			}
		}

		PlainfbPneumaticActuator __verticalPiston;
		public PlainfbPneumaticActuator _verticalPiston
		{
			get
			{
				return __verticalPiston;
			}

			set
			{
				if (__verticalPiston != value)
				{
					__verticalPiston = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_verticalPiston)));
				}
			}
		}

		PlainfbPneumaticActuator __gripper;
		public PlainfbPneumaticActuator _gripper
		{
			get
			{
				return __gripper;
			}

			set
			{
				if (__gripper != value)
				{
					__gripper = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_gripper)));
				}
			}
		}

		PlainfbPneumaticActuator __horizontalPistonLockerFailed;
		public PlainfbPneumaticActuator _horizontalPistonLockerFailed
		{
			get
			{
				return __horizontalPistonLockerFailed;
			}

			set
			{
				if (__horizontalPistonLockerFailed != value)
				{
					__horizontalPistonLockerFailed = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_horizontalPistonLockerFailed)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.stComponents target)
		{
			_horizontalPiston.CopyPlainToCyclic(target._horizontalPiston);
			_verticalPiston.CopyPlainToCyclic(target._verticalPiston);
			_gripper.CopyPlainToCyclic(target._gripper);
			_horizontalPistonLockerFailed.CopyPlainToCyclic(target._horizontalPistonLockerFailed);
		}

		public void CopyPlainToCyclic(MainPlc.IstComponents target)
		{
			this.CopyPlainToCyclic((MainPlc.stComponents)target);
		}

		public void CopyPlainToShadow(MainPlc.stComponents target)
		{
			_horizontalPiston.CopyPlainToShadow(target._horizontalPiston);
			_verticalPiston.CopyPlainToShadow(target._verticalPiston);
			_gripper.CopyPlainToShadow(target._gripper);
			_horizontalPistonLockerFailed.CopyPlainToShadow(target._horizontalPistonLockerFailed);
		}

		public void CopyPlainToShadow(MainPlc.IShadowstComponents target)
		{
			this.CopyPlainToShadow((MainPlc.stComponents)target);
		}

		public void CopyCyclicToPlain(MainPlc.stComponents source)
		{
			_horizontalPiston.CopyCyclicToPlain(source._horizontalPiston);
			_verticalPiston.CopyCyclicToPlain(source._verticalPiston);
			_gripper.CopyCyclicToPlain(source._gripper);
			_horizontalPistonLockerFailed.CopyCyclicToPlain(source._horizontalPistonLockerFailed);
		}

		public void CopyCyclicToPlain(MainPlc.IstComponents source)
		{
			this.CopyCyclicToPlain((MainPlc.stComponents)source);
		}

		public void CopyShadowToPlain(MainPlc.stComponents source)
		{
			_horizontalPiston.CopyShadowToPlain(source._horizontalPiston);
			_verticalPiston.CopyShadowToPlain(source._verticalPiston);
			_gripper.CopyShadowToPlain(source._gripper);
			_horizontalPistonLockerFailed.CopyShadowToPlain(source._horizontalPistonLockerFailed);
		}

		public void CopyShadowToPlain(MainPlc.IShadowstComponents source)
		{
			this.CopyShadowToPlain((MainPlc.stComponents)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstComponents()
		{
			__horizontalPiston = new PlainfbPneumaticActuator();
			__verticalPiston = new PlainfbPneumaticActuator();
			__gripper = new PlainfbPneumaticActuator();
			__horizontalPistonLockerFailed = new PlainfbPneumaticActuator();
		}
	}
}