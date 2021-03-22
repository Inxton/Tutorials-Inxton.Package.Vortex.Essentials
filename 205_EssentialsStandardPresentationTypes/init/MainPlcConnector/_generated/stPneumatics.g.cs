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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"<#Pneumatics#>\" }", "stPneumatics", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class stPneumatics : Vortex.Connector.IVortexObject, IstPneumatics, IShadowstPneumatics, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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

		IfbPneumaticActuator IstPneumatics._horizontalPiston
		{
			get
			{
				return _horizontalPiston;
			}
		}

		IShadowfbPneumaticActuator IShadowstPneumatics._horizontalPiston
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

		IfbPneumaticActuator IstPneumatics._verticalPiston
		{
			get
			{
				return _verticalPiston;
			}
		}

		IShadowfbPneumaticActuator IShadowstPneumatics._verticalPiston
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

		IfbPneumaticActuator IstPneumatics._gripper
		{
			get
			{
				return _gripper;
			}
		}

		IShadowfbPneumaticActuator IShadowstPneumatics._gripper
		{
			get
			{
				return _gripper;
			}
		}

		fbPneumaticActuator __conveyorEndStopper;
		public fbPneumaticActuator _conveyorEndStopper
		{
			get
			{
				return __conveyorEndStopper;
			}
		}

		IfbPneumaticActuator IstPneumatics._conveyorEndStopper
		{
			get
			{
				return _conveyorEndStopper;
			}
		}

		IShadowfbPneumaticActuator IShadowstPneumatics._conveyorEndStopper
		{
			get
			{
				return _conveyorEndStopper;
			}
		}

		public void LazyOnlineToShadow()
		{
			_horizontalPiston.LazyOnlineToShadow();
			_verticalPiston.LazyOnlineToShadow();
			_gripper.LazyOnlineToShadow();
			_conveyorEndStopper.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			_horizontalPiston.LazyShadowToOnline();
			_verticalPiston.LazyShadowToOnline();
			_gripper.LazyShadowToOnline();
			_conveyorEndStopper.LazyShadowToOnline();
		}

		public PlainstPneumatics CreatePlainerType()
		{
			var cloned = new PlainstPneumatics();
			cloned._horizontalPiston = _horizontalPiston.CreatePlainerType();
			cloned._verticalPiston = _verticalPiston.CreatePlainerType();
			cloned._gripper = _gripper.CreatePlainerType();
			cloned._conveyorEndStopper = _conveyorEndStopper.CreatePlainerType();
			return cloned;
		}

		protected PlainstPneumatics CreatePlainerType(PlainstPneumatics cloned)
		{
			cloned._horizontalPiston = _horizontalPiston.CreatePlainerType();
			cloned._verticalPiston = _verticalPiston.CreatePlainerType();
			cloned._gripper = _gripper.CreatePlainerType();
			cloned._conveyorEndStopper = _conveyorEndStopper.CreatePlainerType();
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

		public void FlushPlainToOnline(MainPlc.PlainstPneumatics source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainstPneumatics source)
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

		public void FlushOnlineToPlain(MainPlc.PlainstPneumatics source)
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

		public stPneumatics(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			__conveyorEndStopper = new fbPneumaticActuator(this, "<#Input end conveyor stopper#> A4", "_conveyorEndStopper");
			__conveyorEndStopper.AttributeName = "<#Input end conveyor stopper#> A4";
			AttributeName = "<#Pneumatics#>";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stPneumatics()
		{
			PexPreConstructorParameterless();
			__horizontalPiston = new fbPneumaticActuator();
			__horizontalPiston.AttributeName = "<#Horizontal piston#> A1";
			__verticalPiston = new fbPneumaticActuator();
			__verticalPiston.AttributeName = "<#Vertical piston#> A2";
			__gripper = new fbPneumaticActuator();
			__gripper.AttributeName = "<#Gripper#> A3";
			__conveyorEndStopper = new fbPneumaticActuator();
			__conveyorEndStopper.AttributeName = "<#Input end conveyor stopper#> A4";
			AttributeName = "<#Pneumatics#>";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstPneumatics
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstPneumatics()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstPneumatics : Vortex.Connector.IVortexOnlineObject
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

		IfbPneumaticActuator _conveyorEndStopper
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainstPneumatics CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainstPneumatics source);
		void FlushOnlineToPlain(MainPlc.PlainstPneumatics source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstPneumatics : Vortex.Connector.IVortexShadowObject
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

		IShadowfbPneumaticActuator _conveyorEndStopper
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainstPneumatics CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainstPneumatics source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstPneumatics : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
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

		PlainfbPneumaticActuator __conveyorEndStopper;
		public PlainfbPneumaticActuator _conveyorEndStopper
		{
			get
			{
				return __conveyorEndStopper;
			}

			set
			{
				if (__conveyorEndStopper != value)
				{
					__conveyorEndStopper = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_conveyorEndStopper)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.stPneumatics target)
		{
			_horizontalPiston.CopyPlainToCyclic(target._horizontalPiston);
			_verticalPiston.CopyPlainToCyclic(target._verticalPiston);
			_gripper.CopyPlainToCyclic(target._gripper);
			_conveyorEndStopper.CopyPlainToCyclic(target._conveyorEndStopper);
		}

		public void CopyPlainToCyclic(MainPlc.IstPneumatics target)
		{
			this.CopyPlainToCyclic((MainPlc.stPneumatics)target);
		}

		public void CopyPlainToShadow(MainPlc.stPneumatics target)
		{
			_horizontalPiston.CopyPlainToShadow(target._horizontalPiston);
			_verticalPiston.CopyPlainToShadow(target._verticalPiston);
			_gripper.CopyPlainToShadow(target._gripper);
			_conveyorEndStopper.CopyPlainToShadow(target._conveyorEndStopper);
		}

		public void CopyPlainToShadow(MainPlc.IShadowstPneumatics target)
		{
			this.CopyPlainToShadow((MainPlc.stPneumatics)target);
		}

		public void CopyCyclicToPlain(MainPlc.stPneumatics source)
		{
			_horizontalPiston.CopyCyclicToPlain(source._horizontalPiston);
			_verticalPiston.CopyCyclicToPlain(source._verticalPiston);
			_gripper.CopyCyclicToPlain(source._gripper);
			_conveyorEndStopper.CopyCyclicToPlain(source._conveyorEndStopper);
		}

		public void CopyCyclicToPlain(MainPlc.IstPneumatics source)
		{
			this.CopyCyclicToPlain((MainPlc.stPneumatics)source);
		}

		public void CopyShadowToPlain(MainPlc.stPneumatics source)
		{
			_horizontalPiston.CopyShadowToPlain(source._horizontalPiston);
			_verticalPiston.CopyShadowToPlain(source._verticalPiston);
			_gripper.CopyShadowToPlain(source._gripper);
			_conveyorEndStopper.CopyShadowToPlain(source._conveyorEndStopper);
		}

		public void CopyShadowToPlain(MainPlc.IShadowstPneumatics source)
		{
			this.CopyShadowToPlain((MainPlc.stPneumatics)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstPneumatics()
		{
			__horizontalPiston = new PlainfbPneumaticActuator();
			__verticalPiston = new PlainfbPneumaticActuator();
			__gripper = new PlainfbPneumaticActuator();
			__conveyorEndStopper = new PlainfbPneumaticActuator();
		}
	}
}