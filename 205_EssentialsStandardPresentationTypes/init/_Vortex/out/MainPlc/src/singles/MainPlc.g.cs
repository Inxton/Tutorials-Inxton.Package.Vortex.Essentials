using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;
using MainPlcConnector.Properties;

[assembly: Vortex.Connector.Attributes.AssemblyPlcCounterPart("{\r\n  \"Types\": [\r\n    {\r\n      \"TypeAttributes\": \"\",\r\n      \"TypeName\": \"enumMode\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 5\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbDigitalSensor\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbPneumaticActuator\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbStepConveyor\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"STATION 01\\\" }\",\r\n      \"TypeName\": \"fbStation\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbValueSimulation\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"<#Components#>\\\" }\",\r\n      \"TypeName\": \"stComponents\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"<#Pneumatics#>\\\" }\",\r\n      \"TypeName\": \"stPneumatics\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"stContinuosValueData\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"stData\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"IO\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 0\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MAIN\",\r\n      \"Namespace\": \"MainPlc\",\r\n      \"TypeMetaInfo\": 3\r\n    }\r\n  ],\r\n  \"Name\": \"MainPlc\",\r\n  \"Namespace\": \"MainPlc\"\r\n}")]
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
		IO _IO;
		public IO IO
		{
			get
			{
				return _IO;
			}
		}

		IIO IMainPlcTwinController.IO
		{
			get
			{
				return IO;
			}
		}

		IShadowIO IShadowMainPlcTwinController.IO
		{
			get
			{
				return IO;
			}
		}

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
			IO.LazyOnlineToShadow();
			MAIN.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			IO.LazyShadowToOnline();
			MAIN.LazyShadowToOnline();
		}

		public PlainMainPlcTwinController CreatePlainerType()
		{
			var cloned = new PlainMainPlcTwinController();
			cloned.IO = IO.CreatePlainerType();
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
		}

		protected PlainMainPlcTwinController CreatePlainerType(PlainMainPlcTwinController cloned)
		{
			cloned.IO = IO.CreatePlainerType();
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
			_IO = new IO(this.Connector, "", "IO");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public MainPlcTwinController(Vortex.Connector.ConnectorAdapter adapter, object[] parameters)
		{
			this.Connector = adapter.GetConnector(parameters);
			_IO = new IO(this.Connector, "", "IO");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public MainPlcTwinController(Vortex.Connector.ConnectorAdapter adapter)
		{
			this.Connector = adapter.GetConnector(adapter.Parameters);
			_IO = new IO(this.Connector, "", "IO");
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
		IIO IO
		{
			get;
		}

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
		IShadowIO IO
		{
			get;
		}

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
	public partial class PlainMainPlcTwinController : Vortex.Connector.IPlain
	{
		PlainIO _IO;
		public PlainIO IO
		{
			get
			{
				return _IO;
			}

			set
			{
				_IO = value;
			}
		}

		PlainMAIN _MAIN;
		public PlainMAIN MAIN
		{
			get
			{
				return _MAIN;
			}

			set
			{
				_MAIN = value;
			}
		}

		public void CopyPlainToCyclic(MainPlc.MainPlcTwinController target)
		{
			IO.CopyPlainToCyclic(target.IO);
			MAIN.CopyPlainToCyclic(target.MAIN);
		}

		public void CopyPlainToCyclic(MainPlc.IMainPlcTwinController target)
		{
			this.CopyPlainToCyclic((MainPlc.MainPlcTwinController)target);
		}

		public void CopyPlainToShadow(MainPlc.MainPlcTwinController target)
		{
			IO.CopyPlainToShadow(target.IO);
			MAIN.CopyPlainToShadow(target.MAIN);
		}

		public void CopyPlainToShadow(MainPlc.IShadowMainPlcTwinController target)
		{
			this.CopyPlainToShadow((MainPlc.MainPlcTwinController)target);
		}

		public void CopyCyclicToPlain(MainPlc.MainPlcTwinController source)
		{
			IO.CopyCyclicToPlain(source.IO);
			MAIN.CopyCyclicToPlain(source.MAIN);
		}

		public void CopyCyclicToPlain(MainPlc.IMainPlcTwinController source)
		{
			this.CopyCyclicToPlain((MainPlc.MainPlcTwinController)source);
		}

		public void CopyShadowToPlain(MainPlc.MainPlcTwinController source)
		{
			IO.CopyShadowToPlain(source.IO);
			MAIN.CopyShadowToPlain(source.MAIN);
		}

		public void CopyShadowToPlain(MainPlc.IShadowMainPlcTwinController source)
		{
			this.CopyShadowToPlain((MainPlc.MainPlcTwinController)source);
		}

		public PlainMainPlcTwinController()
		{
			_IO = new PlainIO();
			_MAIN = new PlainMAIN();
		}
	}
}