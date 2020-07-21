using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
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
		fbPneumaticActuator __horizontalPiston;
		public fbPneumaticActuator _horizontalPiston
		{
			get
			{
				return __horizontalPiston;
			}
		}

		IfbPneumaticActuator IMAIN._horizontalPiston
		{
			get
			{
				return _horizontalPiston;
			}
		}

		IShadowfbPneumaticActuator IShadowMAIN._horizontalPiston
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

		IfbPneumaticActuator IMAIN._verticalPiston
		{
			get
			{
				return _verticalPiston;
			}
		}

		IShadowfbPneumaticActuator IShadowMAIN._verticalPiston
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

		IfbPneumaticActuator IMAIN._gripper
		{
			get
			{
				return _gripper;
			}
		}

		IShadowfbPneumaticActuator IShadowMAIN._gripper
		{
			get
			{
				return _gripper;
			}
		}

		public void LazyOnlineToShadow()
		{
			_horizontalPiston.LazyOnlineToShadow();
			_verticalPiston.LazyOnlineToShadow();
			_gripper.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			_horizontalPiston.LazyShadowToOnline();
			_verticalPiston.LazyShadowToOnline();
			_gripper.LazyShadowToOnline();
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned._horizontalPiston = _horizontalPiston.CreatePlainerType();
			cloned._verticalPiston = _verticalPiston.CreatePlainerType();
			cloned._gripper = _gripper.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned._horizontalPiston = _horizontalPiston.CreatePlainerType();
			cloned._verticalPiston = _verticalPiston.CreatePlainerType();
			cloned._gripper = _gripper.CreatePlainerType();
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
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__horizontalPiston = new fbPneumaticActuator(this, "Horizontal piston A1", "_horizontalPiston");
			__horizontalPiston.AttributeName = "Horizontal piston A1";
			__verticalPiston = new fbPneumaticActuator(this, "Vertical piston A2", "_verticalPiston");
			__verticalPiston.AttributeName = "Vertical piston A2";
			__gripper = new fbPneumaticActuator(this, "Gripper A3", "_gripper");
			__gripper.AttributeName = "Gripper A3";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			__horizontalPiston = new fbPneumaticActuator();
			__horizontalPiston.AttributeName = "Horizontal piston A1";
			__verticalPiston = new fbPneumaticActuator();
			__verticalPiston.AttributeName = "Vertical piston A2";
			__gripper = new fbPneumaticActuator();
			__gripper.AttributeName = "Gripper A3";
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
	public partial class PlainMAIN : Vortex.Connector.IPlain
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
				__horizontalPiston = value;
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
				__verticalPiston = value;
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
				__gripper = value;
			}
		}

		public void CopyPlainToCyclic(MainPlc.MAIN target)
		{
			_horizontalPiston.CopyPlainToCyclic(target._horizontalPiston);
			_verticalPiston.CopyPlainToCyclic(target._verticalPiston);
			_gripper.CopyPlainToCyclic(target._gripper);
		}

		public void CopyPlainToCyclic(MainPlc.IMAIN target)
		{
			this.CopyPlainToCyclic((MainPlc.MAIN)target);
		}

		public void CopyPlainToShadow(MainPlc.MAIN target)
		{
			_horizontalPiston.CopyPlainToShadow(target._horizontalPiston);
			_verticalPiston.CopyPlainToShadow(target._verticalPiston);
			_gripper.CopyPlainToShadow(target._gripper);
		}

		public void CopyPlainToShadow(MainPlc.IShadowMAIN target)
		{
			this.CopyPlainToShadow((MainPlc.MAIN)target);
		}

		public void CopyCyclicToPlain(MainPlc.MAIN source)
		{
			_horizontalPiston.CopyCyclicToPlain(source._horizontalPiston);
			_verticalPiston.CopyCyclicToPlain(source._verticalPiston);
			_gripper.CopyCyclicToPlain(source._gripper);
		}

		public void CopyCyclicToPlain(MainPlc.IMAIN source)
		{
			this.CopyCyclicToPlain((MainPlc.MAIN)source);
		}

		public void CopyShadowToPlain(MainPlc.MAIN source)
		{
			_horizontalPiston.CopyShadowToPlain(source._horizontalPiston);
			_verticalPiston.CopyShadowToPlain(source._verticalPiston);
			_gripper.CopyShadowToPlain(source._gripper);
		}

		public void CopyShadowToPlain(MainPlc.IShadowMAIN source)
		{
			this.CopyShadowToPlain((MainPlc.MAIN)source);
		}

		public PlainMAIN()
		{
			__horizontalPiston = new PlainfbPneumaticActuator();
			__verticalPiston = new PlainfbPneumaticActuator();
			__gripper = new PlainfbPneumaticActuator();
		}
	}
}