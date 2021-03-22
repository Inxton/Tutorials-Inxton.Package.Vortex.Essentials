using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Container(Layout.Tabs)]
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
		stPneumatics __pneumatics;
		public stPneumatics _pneumatics
		{
			get
			{
				return __pneumatics;
			}
		}

		IstPneumatics IstComponents._pneumatics
		{
			get
			{
				return _pneumatics;
			}
		}

		IShadowstPneumatics IShadowstComponents._pneumatics
		{
			get
			{
				return _pneumatics;
			}
		}

		fbStepConveyor __inputConveyor;
		public fbStepConveyor _inputConveyor
		{
			get
			{
				return __inputConveyor;
			}
		}

		IfbStepConveyor IstComponents._inputConveyor
		{
			get
			{
				return _inputConveyor;
			}
		}

		IShadowfbStepConveyor IShadowstComponents._inputConveyor
		{
			get
			{
				return _inputConveyor;
			}
		}

		fbDigitalSensor __BrickInTakeOffPosition;
		public fbDigitalSensor _BrickInTakeOffPosition
		{
			get
			{
				return __BrickInTakeOffPosition;
			}
		}

		IfbDigitalSensor IstComponents._BrickInTakeOffPosition
		{
			get
			{
				return _BrickInTakeOffPosition;
			}
		}

		IShadowfbDigitalSensor IShadowstComponents._BrickInTakeOffPosition
		{
			get
			{
				return _BrickInTakeOffPosition;
			}
		}

		fbDigitalSensor __BrickInGripper;
		public fbDigitalSensor _BrickInGripper
		{
			get
			{
				return __BrickInGripper;
			}
		}

		IfbDigitalSensor IstComponents._BrickInGripper
		{
			get
			{
				return _BrickInGripper;
			}
		}

		IShadowfbDigitalSensor IShadowstComponents._BrickInGripper
		{
			get
			{
				return _BrickInGripper;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal __X_DimSensor;
		[Container(Layout.Stack, "Measurement sensors")]
		public Vortex.Connector.ValueTypes.OnlinerReal _X_DimSensor
		{
			get
			{
				return __X_DimSensor;
			}
		}

		[Container(Layout.Stack, "Measurement sensors")]
		Vortex.Connector.ValueTypes.Online.IOnlineReal IstComponents._X_DimSensor
		{
			get
			{
				return _X_DimSensor;
			}
		}

		[Container(Layout.Stack, "Measurement sensors")]
		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstComponents._X_DimSensor
		{
			get
			{
				return _X_DimSensor;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal __Y_DimSensor;
		public Vortex.Connector.ValueTypes.OnlinerReal _Y_DimSensor
		{
			get
			{
				return __Y_DimSensor;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstComponents._Y_DimSensor
		{
			get
			{
				return _Y_DimSensor;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstComponents._Y_DimSensor
		{
			get
			{
				return _Y_DimSensor;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal __Z_DimSensor;
		public Vortex.Connector.ValueTypes.OnlinerReal _Z_DimSensor
		{
			get
			{
				return __Z_DimSensor;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstComponents._Z_DimSensor
		{
			get
			{
				return _Z_DimSensor;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstComponents._Z_DimSensor
		{
			get
			{
				return _Z_DimSensor;
			}
		}

		public void LazyOnlineToShadow()
		{
			_pneumatics.LazyOnlineToShadow();
			_inputConveyor.LazyOnlineToShadow();
			_BrickInTakeOffPosition.LazyOnlineToShadow();
			_BrickInGripper.LazyOnlineToShadow();
			_X_DimSensor.Shadow = _X_DimSensor.LastValue;
			_Y_DimSensor.Shadow = _Y_DimSensor.LastValue;
			_Z_DimSensor.Shadow = _Z_DimSensor.LastValue;
		}

		public void LazyShadowToOnline()
		{
			_pneumatics.LazyShadowToOnline();
			_inputConveyor.LazyShadowToOnline();
			_BrickInTakeOffPosition.LazyShadowToOnline();
			_BrickInGripper.LazyShadowToOnline();
			_X_DimSensor.Cyclic = _X_DimSensor.Shadow;
			_Y_DimSensor.Cyclic = _Y_DimSensor.Shadow;
			_Z_DimSensor.Cyclic = _Z_DimSensor.Shadow;
		}

		public PlainstComponents CreatePlainerType()
		{
			var cloned = new PlainstComponents();
			cloned._pneumatics = _pneumatics.CreatePlainerType();
			cloned._inputConveyor = _inputConveyor.CreatePlainerType();
			cloned._BrickInTakeOffPosition = _BrickInTakeOffPosition.CreatePlainerType();
			cloned._BrickInGripper = _BrickInGripper.CreatePlainerType();
			return cloned;
		}

		protected PlainstComponents CreatePlainerType(PlainstComponents cloned)
		{
			cloned._pneumatics = _pneumatics.CreatePlainerType();
			cloned._inputConveyor = _inputConveyor.CreatePlainerType();
			cloned._BrickInTakeOffPosition = _BrickInTakeOffPosition.CreatePlainerType();
			cloned._BrickInGripper = _BrickInGripper.CreatePlainerType();
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
			__pneumatics = new stPneumatics(this, "", "_pneumatics");
			__inputConveyor = new fbStepConveyor(this, "<#Input step conveyor#> A4", "_inputConveyor");
			__inputConveyor.AttributeName = "<#Input step conveyor#> A4";
			__BrickInTakeOffPosition = new fbDigitalSensor(this, "<#Brick in the take-off position#>", "_BrickInTakeOffPosition");
			__BrickInTakeOffPosition.AttributeName = "<#Brick in the take-off position#>";
			__BrickInGripper = new fbDigitalSensor(this, "<#Brick in the gripper#>", "_BrickInGripper");
			__BrickInGripper.AttributeName = "<#Brick in the gripper#>";
			__X_DimSensor = @Connector.Online.Adapter.CreateREAL(this, "<#Sensor dim X#>", "_X_DimSensor");
			_X_DimSensor.AttributeName = "<#Sensor dim X#>";
			__Y_DimSensor = @Connector.Online.Adapter.CreateREAL(this, "<#Sensor dim Y#>", "_Y_DimSensor");
			_Y_DimSensor.AttributeName = "<#Sensor dim Y#>";
			__Z_DimSensor = @Connector.Online.Adapter.CreateREAL(this, "<#Sensor dim Z#>", "_Z_DimSensor");
			_Z_DimSensor.AttributeName = "<#Sensor dim Z#>";
			AttributeName = "<#Components#>";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stComponents()
		{
			PexPreConstructorParameterless();
			__pneumatics = new stPneumatics();
			__inputConveyor = new fbStepConveyor();
			__inputConveyor.AttributeName = "<#Input step conveyor#> A4";
			__BrickInTakeOffPosition = new fbDigitalSensor();
			__BrickInTakeOffPosition.AttributeName = "<#Brick in the take-off position#>";
			__BrickInGripper = new fbDigitalSensor();
			__BrickInGripper.AttributeName = "<#Brick in the gripper#>";
			__X_DimSensor = Vortex.Connector.IConnectorFactory.CreateREAL();
			_X_DimSensor.AttributeName = "<#Sensor dim X#>";
			__Y_DimSensor = Vortex.Connector.IConnectorFactory.CreateREAL();
			_Y_DimSensor.AttributeName = "<#Sensor dim Y#>";
			__Z_DimSensor = Vortex.Connector.IConnectorFactory.CreateREAL();
			_Z_DimSensor.AttributeName = "<#Sensor dim Z#>";
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
		IstPneumatics _pneumatics
		{
			get;
		}

		IfbStepConveyor _inputConveyor
		{
			get;
		}

		IfbDigitalSensor _BrickInTakeOffPosition
		{
			get;
		}

		IfbDigitalSensor _BrickInGripper
		{
			get;
		}

		[Container(Layout.Stack, "Measurement sensors")]
		Vortex.Connector.ValueTypes.Online.IOnlineReal _X_DimSensor
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal _Y_DimSensor
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal _Z_DimSensor
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
		IShadowstPneumatics _pneumatics
		{
			get;
		}

		IShadowfbStepConveyor _inputConveyor
		{
			get;
		}

		IShadowfbDigitalSensor _BrickInTakeOffPosition
		{
			get;
		}

		IShadowfbDigitalSensor _BrickInGripper
		{
			get;
		}

		[Container(Layout.Stack, "Measurement sensors")]
		Vortex.Connector.ValueTypes.Shadows.IShadowReal _X_DimSensor
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal _Y_DimSensor
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal _Z_DimSensor
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
		PlainstPneumatics __pneumatics;
		public PlainstPneumatics _pneumatics
		{
			get
			{
				return __pneumatics;
			}

			set
			{
				if (__pneumatics != value)
				{
					__pneumatics = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_pneumatics)));
				}
			}
		}

		PlainfbStepConveyor __inputConveyor;
		public PlainfbStepConveyor _inputConveyor
		{
			get
			{
				return __inputConveyor;
			}

			set
			{
				if (__inputConveyor != value)
				{
					__inputConveyor = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_inputConveyor)));
				}
			}
		}

		PlainfbDigitalSensor __BrickInTakeOffPosition;
		public PlainfbDigitalSensor _BrickInTakeOffPosition
		{
			get
			{
				return __BrickInTakeOffPosition;
			}

			set
			{
				if (__BrickInTakeOffPosition != value)
				{
					__BrickInTakeOffPosition = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_BrickInTakeOffPosition)));
				}
			}
		}

		PlainfbDigitalSensor __BrickInGripper;
		public PlainfbDigitalSensor _BrickInGripper
		{
			get
			{
				return __BrickInGripper;
			}

			set
			{
				if (__BrickInGripper != value)
				{
					__BrickInGripper = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_BrickInGripper)));
				}
			}
		}

		System.Single __X_DimSensor;
		[Container(Layout.Stack, "Measurement sensors")]
		public System.Single _X_DimSensor
		{
			get
			{
				return __X_DimSensor;
			}

			set
			{
				if (__X_DimSensor != value)
				{
					__X_DimSensor = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_X_DimSensor)));
				}
			}
		}

		System.Single __Y_DimSensor;
		public System.Single _Y_DimSensor
		{
			get
			{
				return __Y_DimSensor;
			}

			set
			{
				if (__Y_DimSensor != value)
				{
					__Y_DimSensor = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_Y_DimSensor)));
				}
			}
		}

		System.Single __Z_DimSensor;
		public System.Single _Z_DimSensor
		{
			get
			{
				return __Z_DimSensor;
			}

			set
			{
				if (__Z_DimSensor != value)
				{
					__Z_DimSensor = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_Z_DimSensor)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.stComponents target)
		{
			_pneumatics.CopyPlainToCyclic(target._pneumatics);
			_inputConveyor.CopyPlainToCyclic(target._inputConveyor);
			_BrickInTakeOffPosition.CopyPlainToCyclic(target._BrickInTakeOffPosition);
			_BrickInGripper.CopyPlainToCyclic(target._BrickInGripper);
			target._X_DimSensor.Cyclic = _X_DimSensor;
			target._Y_DimSensor.Cyclic = _Y_DimSensor;
			target._Z_DimSensor.Cyclic = _Z_DimSensor;
		}

		public void CopyPlainToCyclic(MainPlc.IstComponents target)
		{
			this.CopyPlainToCyclic((MainPlc.stComponents)target);
		}

		public void CopyPlainToShadow(MainPlc.stComponents target)
		{
			_pneumatics.CopyPlainToShadow(target._pneumatics);
			_inputConveyor.CopyPlainToShadow(target._inputConveyor);
			_BrickInTakeOffPosition.CopyPlainToShadow(target._BrickInTakeOffPosition);
			_BrickInGripper.CopyPlainToShadow(target._BrickInGripper);
			target._X_DimSensor.Shadow = _X_DimSensor;
			target._Y_DimSensor.Shadow = _Y_DimSensor;
			target._Z_DimSensor.Shadow = _Z_DimSensor;
		}

		public void CopyPlainToShadow(MainPlc.IShadowstComponents target)
		{
			this.CopyPlainToShadow((MainPlc.stComponents)target);
		}

		public void CopyCyclicToPlain(MainPlc.stComponents source)
		{
			_pneumatics.CopyCyclicToPlain(source._pneumatics);
			_inputConveyor.CopyCyclicToPlain(source._inputConveyor);
			_BrickInTakeOffPosition.CopyCyclicToPlain(source._BrickInTakeOffPosition);
			_BrickInGripper.CopyCyclicToPlain(source._BrickInGripper);
			_X_DimSensor = source._X_DimSensor.LastValue;
			_Y_DimSensor = source._Y_DimSensor.LastValue;
			_Z_DimSensor = source._Z_DimSensor.LastValue;
		}

		public void CopyCyclicToPlain(MainPlc.IstComponents source)
		{
			this.CopyCyclicToPlain((MainPlc.stComponents)source);
		}

		public void CopyShadowToPlain(MainPlc.stComponents source)
		{
			_pneumatics.CopyShadowToPlain(source._pneumatics);
			_inputConveyor.CopyShadowToPlain(source._inputConveyor);
			_BrickInTakeOffPosition.CopyShadowToPlain(source._BrickInTakeOffPosition);
			_BrickInGripper.CopyShadowToPlain(source._BrickInGripper);
			_X_DimSensor = source._X_DimSensor.Shadow;
			_Y_DimSensor = source._Y_DimSensor.Shadow;
			_Z_DimSensor = source._Z_DimSensor.Shadow;
		}

		public void CopyShadowToPlain(MainPlc.IShadowstComponents source)
		{
			this.CopyShadowToPlain((MainPlc.stComponents)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstComponents()
		{
			__pneumatics = new PlainstPneumatics();
			__inputConveyor = new PlainfbStepConveyor();
			__BrickInTakeOffPosition = new PlainfbDigitalSensor();
			__BrickInGripper = new PlainfbDigitalSensor();
		}
	}
}