using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;
using MainPlcConnector.Properties;

[assembly: Vortex.Connector.Attributes.AssemblyPlcCounterPart("{\r\n  \"Types\": [\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbPneumaticActuator\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MAIN\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 3\r\n    }\r\n  ],\r\n  \"Name\": \"MainPlc\",\r\n  \"Namespace\": \"MainPlc\"\r\n}")]
#pragma warning disable SA1402, CS1591, CS0108, CS0067
namespace MainPlc
{
	public partial class MainPlcTwinController : Vortex.Connector.ITwinController, IMainPlcTwinController, IShadowMainPlcTwinController
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
		MAIN _MAIN;
		public MAIN MAIN
		{
			get
			{
				return _MAIN;
			}
		}

		IMAIN IMainPlcTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		IShadowMAIN IShadowMainPlcTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		public void LazyOnlineToShadow()
		{
			MAIN.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			MAIN.LazyShadowToOnline();
		}

		public PlainMainPlcTwinController CreatePlainerType()
		{
			var cloned = new PlainMainPlcTwinController();
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
		}

		protected PlainMainPlcTwinController CreatePlainerType(PlainMainPlcTwinController cloned)
		{
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
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

		public IMainPlcTwinController Online
		{
			get
			{
				return (IMainPlcTwinController)this;
			}
		}

		public IShadowMainPlcTwinController Shadow
		{
			get
			{
				return (IShadowMainPlcTwinController)this;
			}
		}

		public Vortex.Connector.IConnector Connector
		{
			get;
			set;
		}

		public MainPlcTwinController()
		{
			var adapter = new Vortex.Connector.ConnectorAdapter(typeof (DummyConnectorFactory));
			this.Connector = adapter.GetConnector(new object[]{});
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public MainPlcTwinController(Vortex.Connector.ConnectorAdapter adapter, object[] parameters)
		{
			this.Connector = adapter.GetConnector(parameters);
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public MainPlcTwinController(Vortex.Connector.ConnectorAdapter adapter)
		{
			this.Connector = adapter.GetConnector(adapter.Parameters);
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public static string LocalizationDirectory
		{
			get;
			set;
		}

		private static Vortex.Localizations.Abstractions.ITranslator _translator
		{
			get;
			set;
		}

		internal static Vortex.Localizations.Abstractions.ITranslator Translator
		{
			get
			{
				if (_translator == null)
				{
					_translator = Vortex.Localizations.Abstractions.ITranslator.Get(typeof (Localizations));
				} return  _translator ; 

			}
		}
	}

	public partial interface IMainPlcTwinController
	{
		IMAIN MAIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainMainPlcTwinController CreatePlainerType();
	}

	public partial interface IShadowMainPlcTwinController
	{
		IShadowMAIN MAIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainMainPlcTwinController CreatePlainerType();
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMainPlcTwinController : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainMAIN _MAIN;
		public PlainMAIN MAIN
		{
			get
			{
				return _MAIN;
			}

			set
			{
				if (_MAIN != value)
				{
					_MAIN = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MAIN)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.MainPlcTwinController target)
		{
			MAIN.CopyPlainToCyclic(target.MAIN);
		}

		public void CopyPlainToCyclic(MainPlc.IMainPlcTwinController target)
		{
			this.CopyPlainToCyclic((MainPlc.MainPlcTwinController)target);
		}

		public void CopyPlainToShadow(MainPlc.MainPlcTwinController target)
		{
			MAIN.CopyPlainToShadow(target.MAIN);
		}

		public void CopyPlainToShadow(MainPlc.IShadowMainPlcTwinController target)
		{
			this.CopyPlainToShadow((MainPlc.MainPlcTwinController)target);
		}

		public void CopyCyclicToPlain(MainPlc.MainPlcTwinController source)
		{
			MAIN.CopyCyclicToPlain(source.MAIN);
		}

		public void CopyCyclicToPlain(MainPlc.IMainPlcTwinController source)
		{
			this.CopyCyclicToPlain((MainPlc.MainPlcTwinController)source);
		}

		public void CopyShadowToPlain(MainPlc.MainPlcTwinController source)
		{
			MAIN.CopyShadowToPlain(source.MAIN);
		}

		public void CopyShadowToPlain(MainPlc.IShadowMainPlcTwinController source)
		{
			this.CopyShadowToPlain((MainPlc.MainPlcTwinController)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMainPlcTwinController()
		{
			_MAIN = new PlainMAIN();
		}
	}
}