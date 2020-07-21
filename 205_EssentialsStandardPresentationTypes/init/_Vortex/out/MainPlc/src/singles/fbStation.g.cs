using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
	[Container(Layout.Tabs)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"STATION 01\" }", "fbStation", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class fbStation : Vortex.Connector.IVortexObject, IfbStation, IShadowfbStation, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerInt __modeSelector;
		[Container(Layout.Stack), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		public Vortex.Connector.ValueTypes.OnlinerInt _modeSelector
		{
			get
			{
				return __modeSelector;
			}
		}

		[Container(Layout.Stack), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbStation._modeSelector
		{
			get
			{
				return _modeSelector;
			}
		}

		[Container(Layout.Stack), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbStation._modeSelector
		{
			get
			{
				return _modeSelector;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt __modeCurrent;
		[ReadOnly(), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		public Vortex.Connector.ValueTypes.OnlinerInt _modeCurrent
		{
			get
			{
				return __modeCurrent;
			}
		}

		[ReadOnly(), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbStation._modeCurrent
		{
			get
			{
				return _modeCurrent;
			}
		}

		[ReadOnly(), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbStation._modeCurrent
		{
			get
			{
				return _modeCurrent;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString __stepInfo;
		public Vortex.Connector.ValueTypes.OnlinerString _stepInfo
		{
			get
			{
				return __stepInfo;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbStation._stepInfo
		{
			get
			{
				return _stepInfo;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbStation._stepInfo
		{
			get
			{
				return _stepInfo;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString __errorInfo;
		public Vortex.Connector.ValueTypes.OnlinerString _errorInfo
		{
			get
			{
				return __errorInfo;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbStation._errorInfo
		{
			get
			{
				return _errorInfo;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbStation._errorInfo
		{
			get
			{
				return _errorInfo;
			}
		}

		stComponents __components;
		public stComponents _components
		{
			get
			{
				return __components;
			}
		}

		IstComponents IfbStation._components
		{
			get
			{
				return _components;
			}
		}

		IShadowstComponents IShadowfbStation._components
		{
			get
			{
				return _components;
			}
		}

		stData __data;
		public stData _data
		{
			get
			{
				return __data;
			}
		}

		IstData IfbStation._data
		{
			get
			{
				return _data;
			}
		}

		IShadowstData IShadowfbStation._data
		{
			get
			{
				return _data;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt __step;
		public Vortex.Connector.ValueTypes.OnlinerInt _step
		{
			get
			{
				return __step;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IfbStation._step
		{
			get
			{
				return _step;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowfbStation._step
		{
			get
			{
				return _step;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool __ground_done;
		public Vortex.Connector.ValueTypes.OnlinerBool _ground_done
		{
			get
			{
				return __ground_done;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbStation._ground_done
		{
			get
			{
				return _ground_done;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbStation._ground_done
		{
			get
			{
				return _ground_done;
			}
		}

		public void LazyOnlineToShadow()
		{
			_modeSelector.Shadow = _modeSelector.LastValue;
			_modeCurrent.Shadow = _modeCurrent.LastValue;
			_stepInfo.Shadow = _stepInfo.LastValue;
			_errorInfo.Shadow = _errorInfo.LastValue;
			_components.LazyOnlineToShadow();
			_data.LazyOnlineToShadow();
			_step.Shadow = _step.LastValue;
			_ground_done.Shadow = _ground_done.LastValue;
		}

		public void LazyShadowToOnline()
		{
			_modeSelector.Cyclic = _modeSelector.Shadow;
			_modeCurrent.Cyclic = _modeCurrent.Shadow;
			_stepInfo.Cyclic = _stepInfo.Shadow;
			_errorInfo.Cyclic = _errorInfo.Shadow;
			_components.LazyShadowToOnline();
			_data.LazyShadowToOnline();
			_step.Cyclic = _step.Shadow;
			_ground_done.Cyclic = _ground_done.Shadow;
		}

		public PlainfbStation CreatePlainerType()
		{
			var cloned = new PlainfbStation();
			cloned._components = _components.CreatePlainerType();
			cloned._data = _data.CreatePlainerType();
			return cloned;
		}

		protected PlainfbStation CreatePlainerType(PlainfbStation cloned)
		{
			cloned._components = _components.CreatePlainerType();
			cloned._data = _data.CreatePlainerType();
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

		public void FlushPlainToOnline(MainPlc.PlainfbStation source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainfbStation source)
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

		public void FlushOnlineToPlain(MainPlc.PlainfbStation source)
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

		public fbStation(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__modeSelector = @Connector.Online.Adapter.CreateINT(this, "<#Select mode#>", "_modeSelector");
			_modeSelector.AttributeName = "<#Select mode#>";
			__modeCurrent = @Connector.Online.Adapter.CreateINT(this, "<#CurrentMode#>", "_modeCurrent");
			_modeCurrent.MakeReadOnly();
			_modeCurrent.AttributeName = "<#CurrentMode#>";
			__stepInfo = @Connector.Online.Adapter.CreateSTRING(this, "<#Step description#>", "_stepInfo");
			_stepInfo.AttributeName = "<#Step description#>";
			__errorInfo = @Connector.Online.Adapter.CreateSTRING(this, "<#Error description#>", "_errorInfo");
			_errorInfo.AttributeName = "<#Error description#>";
			__components = new stComponents(this, "<#Components#>", "_components");
			__components.AttributeName = "<#Components#>";
			__data = new stData(this, "<#Data#>", "_data");
			__data.AttributeName = "<#Data#>";
			__step = @Connector.Online.Adapter.CreateINT(this, "", "_step");
			__ground_done = @Connector.Online.Adapter.CreateBOOL(this, "", "_ground_done");
			AttributeName = "STATION 01";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public fbStation()
		{
			PexPreConstructorParameterless();
			__modeSelector = Vortex.Connector.IConnectorFactory.CreateINT();
			_modeSelector.AttributeName = "<#Select mode#>";
			__modeCurrent = Vortex.Connector.IConnectorFactory.CreateINT();
			_modeCurrent.AttributeName = "<#CurrentMode#>";
			__stepInfo = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_stepInfo.AttributeName = "<#Step description#>";
			__errorInfo = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_errorInfo.AttributeName = "<#Error description#>";
			__components = new stComponents();
			__components.AttributeName = "<#Components#>";
			__data = new stData();
			__data.AttributeName = "<#Data#>";
			__step = Vortex.Connector.IConnectorFactory.CreateINT();
			__ground_done = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "STATION 01";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbStation
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbStation()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbStation : Vortex.Connector.IVortexOnlineObject
	{
		[Container(Layout.Stack), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt _modeSelector
		{
			get;
		}

		[ReadOnly(), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt _modeCurrent
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString _stepInfo
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString _errorInfo
		{
			get;
		}

		IstComponents _components
		{
			get;
		}

		IstData _data
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt _step
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool _ground_done
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbStation CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainfbStation source);
		void FlushOnlineToPlain(MainPlc.PlainfbStation source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbStation : Vortex.Connector.IVortexShadowObject
	{
		[Container(Layout.Stack), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt _modeSelector
		{
			get;
		}

		[ReadOnly(), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt _modeCurrent
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString _stepInfo
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString _errorInfo
		{
			get;
		}

		IShadowstComponents _components
		{
			get;
		}

		IShadowstData _data
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt _step
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool _ground_done
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainfbStation CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainfbStation source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbStation : Vortex.Connector.IPlain
	{
		System.Int16 __modeSelector;
		[Container(Layout.Stack), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		public System.Int16 _modeSelector
		{
			get
			{
				return __modeSelector;
			}

			set
			{
				__modeSelector = value;
			}
		}

		System.Int16 __modeCurrent;
		[ReadOnly(), Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumMode))]
		public System.Int16 _modeCurrent
		{
			get
			{
				return __modeCurrent;
			}

			set
			{
				__modeCurrent = value;
			}
		}

		System.String __stepInfo;
		public System.String _stepInfo
		{
			get
			{
				return __stepInfo;
			}

			set
			{
				__stepInfo = value;
			}
		}

		System.String __errorInfo;
		public System.String _errorInfo
		{
			get
			{
				return __errorInfo;
			}

			set
			{
				__errorInfo = value;
			}
		}

		PlainstComponents __components;
		public PlainstComponents _components
		{
			get
			{
				return __components;
			}

			set
			{
				__components = value;
			}
		}

		PlainstData __data;
		public PlainstData _data
		{
			get
			{
				return __data;
			}

			set
			{
				__data = value;
			}
		}

		System.Int16 __step;
		public System.Int16 _step
		{
			get
			{
				return __step;
			}

			set
			{
				__step = value;
			}
		}

		System.Boolean __ground_done;
		public System.Boolean _ground_done
		{
			get
			{
				return __ground_done;
			}

			set
			{
				__ground_done = value;
			}
		}

		public void CopyPlainToCyclic(MainPlc.fbStation target)
		{
			target._modeSelector.Cyclic = _modeSelector;
			target._modeCurrent.Cyclic = _modeCurrent;
			target._stepInfo.Cyclic = _stepInfo;
			target._errorInfo.Cyclic = _errorInfo;
			_components.CopyPlainToCyclic(target._components);
			_data.CopyPlainToCyclic(target._data);
			target._step.Cyclic = _step;
			target._ground_done.Cyclic = _ground_done;
		}

		public void CopyPlainToCyclic(MainPlc.IfbStation target)
		{
			this.CopyPlainToCyclic((MainPlc.fbStation)target);
		}

		public void CopyPlainToShadow(MainPlc.fbStation target)
		{
			target._modeSelector.Shadow = _modeSelector;
			target._modeCurrent.Shadow = _modeCurrent;
			target._stepInfo.Shadow = _stepInfo;
			target._errorInfo.Shadow = _errorInfo;
			_components.CopyPlainToShadow(target._components);
			_data.CopyPlainToShadow(target._data);
			target._step.Shadow = _step;
			target._ground_done.Shadow = _ground_done;
		}

		public void CopyPlainToShadow(MainPlc.IShadowfbStation target)
		{
			this.CopyPlainToShadow((MainPlc.fbStation)target);
		}

		public void CopyCyclicToPlain(MainPlc.fbStation source)
		{
			_modeSelector = source._modeSelector.LastValue;
			_modeCurrent = source._modeCurrent.LastValue;
			_stepInfo = source._stepInfo.LastValue;
			_errorInfo = source._errorInfo.LastValue;
			_components.CopyCyclicToPlain(source._components);
			_data.CopyCyclicToPlain(source._data);
			_step = source._step.LastValue;
			_ground_done = source._ground_done.LastValue;
		}

		public void CopyCyclicToPlain(MainPlc.IfbStation source)
		{
			this.CopyCyclicToPlain((MainPlc.fbStation)source);
		}

		public void CopyShadowToPlain(MainPlc.fbStation source)
		{
			_modeSelector = source._modeSelector.Shadow;
			_modeCurrent = source._modeCurrent.Shadow;
			_stepInfo = source._stepInfo.Shadow;
			_errorInfo = source._errorInfo.Shadow;
			_components.CopyShadowToPlain(source._components);
			_data.CopyShadowToPlain(source._data);
			_step = source._step.Shadow;
			_ground_done = source._ground_done.Shadow;
		}

		public void CopyShadowToPlain(MainPlc.IShadowfbStation source)
		{
			this.CopyShadowToPlain((MainPlc.fbStation)source);
		}

		public PlainfbStation()
		{
			__components = new PlainstComponents();
			__data = new PlainstData();
		}
	}
}