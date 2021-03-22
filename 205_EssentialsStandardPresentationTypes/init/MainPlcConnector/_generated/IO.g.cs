using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "IO", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class IO : Vortex.Connector.IVortexObject, IIO, IShadowIO, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH1;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH1
		{
			get
			{
				return _i10A1_CH1;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH1
		{
			get
			{
				return i10A1_CH1;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH1
		{
			get
			{
				return i10A1_CH1;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH2;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH2
		{
			get
			{
				return _i10A1_CH2;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH2
		{
			get
			{
				return i10A1_CH2;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH2
		{
			get
			{
				return i10A1_CH2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH3;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH3
		{
			get
			{
				return _i10A1_CH3;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH3
		{
			get
			{
				return i10A1_CH3;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH3
		{
			get
			{
				return i10A1_CH3;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH4;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH4
		{
			get
			{
				return _i10A1_CH4;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH4
		{
			get
			{
				return i10A1_CH4;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH4
		{
			get
			{
				return i10A1_CH4;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH5;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH5
		{
			get
			{
				return _i10A1_CH5;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH5
		{
			get
			{
				return i10A1_CH5;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH5
		{
			get
			{
				return i10A1_CH5;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH6;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH6
		{
			get
			{
				return _i10A1_CH6;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH6
		{
			get
			{
				return i10A1_CH6;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH6
		{
			get
			{
				return i10A1_CH6;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH7;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH7
		{
			get
			{
				return _i10A1_CH7;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH7
		{
			get
			{
				return i10A1_CH7;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH7
		{
			get
			{
				return i10A1_CH7;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH8;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH8
		{
			get
			{
				return _i10A1_CH8;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH8
		{
			get
			{
				return i10A1_CH8;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH8
		{
			get
			{
				return i10A1_CH8;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH9;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH9
		{
			get
			{
				return _i10A1_CH9;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH9
		{
			get
			{
				return i10A1_CH9;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH9
		{
			get
			{
				return i10A1_CH9;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH10;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH10
		{
			get
			{
				return _i10A1_CH10;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH10
		{
			get
			{
				return i10A1_CH10;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH10
		{
			get
			{
				return i10A1_CH10;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH11;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH11
		{
			get
			{
				return _i10A1_CH11;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH11
		{
			get
			{
				return i10A1_CH11;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH11
		{
			get
			{
				return i10A1_CH11;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH12;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH12
		{
			get
			{
				return _i10A1_CH12;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH12
		{
			get
			{
				return i10A1_CH12;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH12
		{
			get
			{
				return i10A1_CH12;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH13;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH13
		{
			get
			{
				return _i10A1_CH13;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH13
		{
			get
			{
				return i10A1_CH13;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH13
		{
			get
			{
				return i10A1_CH13;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH14;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH14
		{
			get
			{
				return _i10A1_CH14;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH14
		{
			get
			{
				return i10A1_CH14;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH14
		{
			get
			{
				return i10A1_CH14;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH15;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH15
		{
			get
			{
				return _i10A1_CH15;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH15
		{
			get
			{
				return i10A1_CH15;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH15
		{
			get
			{
				return i10A1_CH15;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _i10A1_CH16;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool i10A1_CH16
		{
			get
			{
				return _i10A1_CH16;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.i10A1_CH16
		{
			get
			{
				return i10A1_CH16;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.i10A1_CH16
		{
			get
			{
				return i10A1_CH16;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH1;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH1
		{
			get
			{
				return _q10A2_CH1;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH1
		{
			get
			{
				return q10A2_CH1;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH1
		{
			get
			{
				return q10A2_CH1;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH2;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH2
		{
			get
			{
				return _q10A2_CH2;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH2
		{
			get
			{
				return q10A2_CH2;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH2
		{
			get
			{
				return q10A2_CH2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH3;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH3
		{
			get
			{
				return _q10A2_CH3;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH3
		{
			get
			{
				return q10A2_CH3;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH3
		{
			get
			{
				return q10A2_CH3;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH4;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH4
		{
			get
			{
				return _q10A2_CH4;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH4
		{
			get
			{
				return q10A2_CH4;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH4
		{
			get
			{
				return q10A2_CH4;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH5;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH5
		{
			get
			{
				return _q10A2_CH5;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH5
		{
			get
			{
				return q10A2_CH5;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH5
		{
			get
			{
				return q10A2_CH5;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH6;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH6
		{
			get
			{
				return _q10A2_CH6;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH6
		{
			get
			{
				return q10A2_CH6;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH6
		{
			get
			{
				return q10A2_CH6;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH7;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH7
		{
			get
			{
				return _q10A2_CH7;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH7
		{
			get
			{
				return q10A2_CH7;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH7
		{
			get
			{
				return q10A2_CH7;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH8;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH8
		{
			get
			{
				return _q10A2_CH8;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH8
		{
			get
			{
				return q10A2_CH8;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH8
		{
			get
			{
				return q10A2_CH8;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH9;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH9
		{
			get
			{
				return _q10A2_CH9;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH9
		{
			get
			{
				return q10A2_CH9;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH9
		{
			get
			{
				return q10A2_CH9;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH10;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH10
		{
			get
			{
				return _q10A2_CH10;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH10
		{
			get
			{
				return q10A2_CH10;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH10
		{
			get
			{
				return q10A2_CH10;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH11;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH11
		{
			get
			{
				return _q10A2_CH11;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH11
		{
			get
			{
				return q10A2_CH11;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH11
		{
			get
			{
				return q10A2_CH11;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH12;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH12
		{
			get
			{
				return _q10A2_CH12;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH12
		{
			get
			{
				return q10A2_CH12;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH12
		{
			get
			{
				return q10A2_CH12;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH13;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH13
		{
			get
			{
				return _q10A2_CH13;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH13
		{
			get
			{
				return q10A2_CH13;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH13
		{
			get
			{
				return q10A2_CH13;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH14;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH14
		{
			get
			{
				return _q10A2_CH14;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH14
		{
			get
			{
				return q10A2_CH14;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH14
		{
			get
			{
				return q10A2_CH14;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH15;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH15
		{
			get
			{
				return _q10A2_CH15;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH15
		{
			get
			{
				return q10A2_CH15;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH15
		{
			get
			{
				return q10A2_CH15;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _q10A2_CH16;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool q10A2_CH16
		{
			get
			{
				return _q10A2_CH16;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.q10A2_CH16
		{
			get
			{
				return q10A2_CH16;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.q10A2_CH16
		{
			get
			{
				return q10A2_CH16;
			}
		}

		public void LazyOnlineToShadow()
		{
			i10A1_CH1.Shadow = i10A1_CH1.LastValue;
			i10A1_CH2.Shadow = i10A1_CH2.LastValue;
			i10A1_CH3.Shadow = i10A1_CH3.LastValue;
			i10A1_CH4.Shadow = i10A1_CH4.LastValue;
			i10A1_CH5.Shadow = i10A1_CH5.LastValue;
			i10A1_CH6.Shadow = i10A1_CH6.LastValue;
			i10A1_CH7.Shadow = i10A1_CH7.LastValue;
			i10A1_CH8.Shadow = i10A1_CH8.LastValue;
			i10A1_CH9.Shadow = i10A1_CH9.LastValue;
			i10A1_CH10.Shadow = i10A1_CH10.LastValue;
			i10A1_CH11.Shadow = i10A1_CH11.LastValue;
			i10A1_CH12.Shadow = i10A1_CH12.LastValue;
			i10A1_CH13.Shadow = i10A1_CH13.LastValue;
			i10A1_CH14.Shadow = i10A1_CH14.LastValue;
			i10A1_CH15.Shadow = i10A1_CH15.LastValue;
			i10A1_CH16.Shadow = i10A1_CH16.LastValue;
			q10A2_CH1.Shadow = q10A2_CH1.LastValue;
			q10A2_CH2.Shadow = q10A2_CH2.LastValue;
			q10A2_CH3.Shadow = q10A2_CH3.LastValue;
			q10A2_CH4.Shadow = q10A2_CH4.LastValue;
			q10A2_CH5.Shadow = q10A2_CH5.LastValue;
			q10A2_CH6.Shadow = q10A2_CH6.LastValue;
			q10A2_CH7.Shadow = q10A2_CH7.LastValue;
			q10A2_CH8.Shadow = q10A2_CH8.LastValue;
			q10A2_CH9.Shadow = q10A2_CH9.LastValue;
			q10A2_CH10.Shadow = q10A2_CH10.LastValue;
			q10A2_CH11.Shadow = q10A2_CH11.LastValue;
			q10A2_CH12.Shadow = q10A2_CH12.LastValue;
			q10A2_CH13.Shadow = q10A2_CH13.LastValue;
			q10A2_CH14.Shadow = q10A2_CH14.LastValue;
			q10A2_CH15.Shadow = q10A2_CH15.LastValue;
			q10A2_CH16.Shadow = q10A2_CH16.LastValue;
		}

		public void LazyShadowToOnline()
		{
			i10A1_CH1.Cyclic = i10A1_CH1.Shadow;
			i10A1_CH2.Cyclic = i10A1_CH2.Shadow;
			i10A1_CH3.Cyclic = i10A1_CH3.Shadow;
			i10A1_CH4.Cyclic = i10A1_CH4.Shadow;
			i10A1_CH5.Cyclic = i10A1_CH5.Shadow;
			i10A1_CH6.Cyclic = i10A1_CH6.Shadow;
			i10A1_CH7.Cyclic = i10A1_CH7.Shadow;
			i10A1_CH8.Cyclic = i10A1_CH8.Shadow;
			i10A1_CH9.Cyclic = i10A1_CH9.Shadow;
			i10A1_CH10.Cyclic = i10A1_CH10.Shadow;
			i10A1_CH11.Cyclic = i10A1_CH11.Shadow;
			i10A1_CH12.Cyclic = i10A1_CH12.Shadow;
			i10A1_CH13.Cyclic = i10A1_CH13.Shadow;
			i10A1_CH14.Cyclic = i10A1_CH14.Shadow;
			i10A1_CH15.Cyclic = i10A1_CH15.Shadow;
			i10A1_CH16.Cyclic = i10A1_CH16.Shadow;
			q10A2_CH1.Cyclic = q10A2_CH1.Shadow;
			q10A2_CH2.Cyclic = q10A2_CH2.Shadow;
			q10A2_CH3.Cyclic = q10A2_CH3.Shadow;
			q10A2_CH4.Cyclic = q10A2_CH4.Shadow;
			q10A2_CH5.Cyclic = q10A2_CH5.Shadow;
			q10A2_CH6.Cyclic = q10A2_CH6.Shadow;
			q10A2_CH7.Cyclic = q10A2_CH7.Shadow;
			q10A2_CH8.Cyclic = q10A2_CH8.Shadow;
			q10A2_CH9.Cyclic = q10A2_CH9.Shadow;
			q10A2_CH10.Cyclic = q10A2_CH10.Shadow;
			q10A2_CH11.Cyclic = q10A2_CH11.Shadow;
			q10A2_CH12.Cyclic = q10A2_CH12.Shadow;
			q10A2_CH13.Cyclic = q10A2_CH13.Shadow;
			q10A2_CH14.Cyclic = q10A2_CH14.Shadow;
			q10A2_CH15.Cyclic = q10A2_CH15.Shadow;
			q10A2_CH16.Cyclic = q10A2_CH16.Shadow;
		}

		public PlainIO CreatePlainerType()
		{
			var cloned = new PlainIO();
			return cloned;
		}

		protected PlainIO CreatePlainerType(PlainIO cloned)
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

		public void FlushPlainToOnline(MainPlc.PlainIO source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainIO source)
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

		public void FlushOnlineToPlain(MainPlc.PlainIO source)
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

		public IO(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_i10A1_CH1 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH1");
			_i10A1_CH2 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH2");
			_i10A1_CH3 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH3");
			_i10A1_CH4 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH4");
			_i10A1_CH5 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH5");
			_i10A1_CH6 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH6");
			_i10A1_CH7 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH7");
			_i10A1_CH8 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH8");
			_i10A1_CH9 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH9");
			_i10A1_CH10 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH10");
			_i10A1_CH11 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH11");
			_i10A1_CH12 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH12");
			_i10A1_CH13 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH13");
			_i10A1_CH14 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH14");
			_i10A1_CH15 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH15");
			_i10A1_CH16 = @Connector.Online.Adapter.CreateBOOL(this, "", "i10A1_CH16");
			_q10A2_CH1 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH1");
			_q10A2_CH2 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH2");
			_q10A2_CH3 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH3");
			_q10A2_CH4 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH4");
			_q10A2_CH5 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH5");
			_q10A2_CH6 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH6");
			_q10A2_CH7 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH7");
			_q10A2_CH8 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH8");
			_q10A2_CH9 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH9");
			_q10A2_CH10 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH10");
			_q10A2_CH11 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH11");
			_q10A2_CH12 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH12");
			_q10A2_CH13 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH13");
			_q10A2_CH14 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH14");
			_q10A2_CH15 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH15");
			_q10A2_CH16 = @Connector.Online.Adapter.CreateBOOL(this, "", "q10A2_CH16");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public IO()
		{
			PexPreConstructorParameterless();
			_i10A1_CH1 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH2 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH3 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH4 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH5 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH6 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH7 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH8 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH9 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH10 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH11 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH12 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH13 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH14 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH15 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_i10A1_CH16 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH1 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH2 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH3 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH4 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH5 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH6 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH7 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH8 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH9 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH10 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH11 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH12 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH13 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH14 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH15 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_q10A2_CH16 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcIO
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcIO()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IIO : Vortex.Connector.IVortexOnlineObject
	{
		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH1
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH2
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH3
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH4
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH5
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH6
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH7
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH8
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH9
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH10
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH11
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH12
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH13
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH14
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH15
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool i10A1_CH16
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH1
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH2
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH3
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH4
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH5
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH6
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH7
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH8
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH9
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH10
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH11
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH12
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH13
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH14
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH15
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool q10A2_CH16
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainIO CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainIO source);
		void FlushOnlineToPlain(MainPlc.PlainIO source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowIO : Vortex.Connector.IVortexShadowObject
	{
		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH1
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH2
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH3
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH4
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH5
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH6
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH7
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH8
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH9
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH10
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH11
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH12
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH13
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH14
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH15
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool i10A1_CH16
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH1
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH2
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH3
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH4
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH5
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH6
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH7
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH8
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH9
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH10
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH11
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH12
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH13
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH14
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH15
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool q10A2_CH16
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainIO CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainIO source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainIO : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _i10A1_CH1;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH1
		{
			get
			{
				return _i10A1_CH1;
			}

			set
			{
				if (_i10A1_CH1 != value)
				{
					_i10A1_CH1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH1)));
				}
			}
		}

		System.Boolean _i10A1_CH2;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH2
		{
			get
			{
				return _i10A1_CH2;
			}

			set
			{
				if (_i10A1_CH2 != value)
				{
					_i10A1_CH2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH2)));
				}
			}
		}

		System.Boolean _i10A1_CH3;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH3
		{
			get
			{
				return _i10A1_CH3;
			}

			set
			{
				if (_i10A1_CH3 != value)
				{
					_i10A1_CH3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH3)));
				}
			}
		}

		System.Boolean _i10A1_CH4;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH4
		{
			get
			{
				return _i10A1_CH4;
			}

			set
			{
				if (_i10A1_CH4 != value)
				{
					_i10A1_CH4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH4)));
				}
			}
		}

		System.Boolean _i10A1_CH5;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH5
		{
			get
			{
				return _i10A1_CH5;
			}

			set
			{
				if (_i10A1_CH5 != value)
				{
					_i10A1_CH5 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH5)));
				}
			}
		}

		System.Boolean _i10A1_CH6;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH6
		{
			get
			{
				return _i10A1_CH6;
			}

			set
			{
				if (_i10A1_CH6 != value)
				{
					_i10A1_CH6 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH6)));
				}
			}
		}

		System.Boolean _i10A1_CH7;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH7
		{
			get
			{
				return _i10A1_CH7;
			}

			set
			{
				if (_i10A1_CH7 != value)
				{
					_i10A1_CH7 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH7)));
				}
			}
		}

		System.Boolean _i10A1_CH8;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH8
		{
			get
			{
				return _i10A1_CH8;
			}

			set
			{
				if (_i10A1_CH8 != value)
				{
					_i10A1_CH8 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH8)));
				}
			}
		}

		System.Boolean _i10A1_CH9;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH9
		{
			get
			{
				return _i10A1_CH9;
			}

			set
			{
				if (_i10A1_CH9 != value)
				{
					_i10A1_CH9 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH9)));
				}
			}
		}

		System.Boolean _i10A1_CH10;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH10
		{
			get
			{
				return _i10A1_CH10;
			}

			set
			{
				if (_i10A1_CH10 != value)
				{
					_i10A1_CH10 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH10)));
				}
			}
		}

		System.Boolean _i10A1_CH11;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH11
		{
			get
			{
				return _i10A1_CH11;
			}

			set
			{
				if (_i10A1_CH11 != value)
				{
					_i10A1_CH11 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH11)));
				}
			}
		}

		System.Boolean _i10A1_CH12;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH12
		{
			get
			{
				return _i10A1_CH12;
			}

			set
			{
				if (_i10A1_CH12 != value)
				{
					_i10A1_CH12 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH12)));
				}
			}
		}

		System.Boolean _i10A1_CH13;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH13
		{
			get
			{
				return _i10A1_CH13;
			}

			set
			{
				if (_i10A1_CH13 != value)
				{
					_i10A1_CH13 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH13)));
				}
			}
		}

		System.Boolean _i10A1_CH14;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH14
		{
			get
			{
				return _i10A1_CH14;
			}

			set
			{
				if (_i10A1_CH14 != value)
				{
					_i10A1_CH14 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH14)));
				}
			}
		}

		System.Boolean _i10A1_CH15;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH15
		{
			get
			{
				return _i10A1_CH15;
			}

			set
			{
				if (_i10A1_CH15 != value)
				{
					_i10A1_CH15 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH15)));
				}
			}
		}

		System.Boolean _i10A1_CH16;
		[IoLinkable("Inputs")]
		public System.Boolean i10A1_CH16
		{
			get
			{
				return _i10A1_CH16;
			}

			set
			{
				if (_i10A1_CH16 != value)
				{
					_i10A1_CH16 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(i10A1_CH16)));
				}
			}
		}

		System.Boolean _q10A2_CH1;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH1
		{
			get
			{
				return _q10A2_CH1;
			}

			set
			{
				if (_q10A2_CH1 != value)
				{
					_q10A2_CH1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH1)));
				}
			}
		}

		System.Boolean _q10A2_CH2;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH2
		{
			get
			{
				return _q10A2_CH2;
			}

			set
			{
				if (_q10A2_CH2 != value)
				{
					_q10A2_CH2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH2)));
				}
			}
		}

		System.Boolean _q10A2_CH3;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH3
		{
			get
			{
				return _q10A2_CH3;
			}

			set
			{
				if (_q10A2_CH3 != value)
				{
					_q10A2_CH3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH3)));
				}
			}
		}

		System.Boolean _q10A2_CH4;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH4
		{
			get
			{
				return _q10A2_CH4;
			}

			set
			{
				if (_q10A2_CH4 != value)
				{
					_q10A2_CH4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH4)));
				}
			}
		}

		System.Boolean _q10A2_CH5;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH5
		{
			get
			{
				return _q10A2_CH5;
			}

			set
			{
				if (_q10A2_CH5 != value)
				{
					_q10A2_CH5 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH5)));
				}
			}
		}

		System.Boolean _q10A2_CH6;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH6
		{
			get
			{
				return _q10A2_CH6;
			}

			set
			{
				if (_q10A2_CH6 != value)
				{
					_q10A2_CH6 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH6)));
				}
			}
		}

		System.Boolean _q10A2_CH7;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH7
		{
			get
			{
				return _q10A2_CH7;
			}

			set
			{
				if (_q10A2_CH7 != value)
				{
					_q10A2_CH7 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH7)));
				}
			}
		}

		System.Boolean _q10A2_CH8;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH8
		{
			get
			{
				return _q10A2_CH8;
			}

			set
			{
				if (_q10A2_CH8 != value)
				{
					_q10A2_CH8 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH8)));
				}
			}
		}

		System.Boolean _q10A2_CH9;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH9
		{
			get
			{
				return _q10A2_CH9;
			}

			set
			{
				if (_q10A2_CH9 != value)
				{
					_q10A2_CH9 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH9)));
				}
			}
		}

		System.Boolean _q10A2_CH10;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH10
		{
			get
			{
				return _q10A2_CH10;
			}

			set
			{
				if (_q10A2_CH10 != value)
				{
					_q10A2_CH10 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH10)));
				}
			}
		}

		System.Boolean _q10A2_CH11;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH11
		{
			get
			{
				return _q10A2_CH11;
			}

			set
			{
				if (_q10A2_CH11 != value)
				{
					_q10A2_CH11 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH11)));
				}
			}
		}

		System.Boolean _q10A2_CH12;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH12
		{
			get
			{
				return _q10A2_CH12;
			}

			set
			{
				if (_q10A2_CH12 != value)
				{
					_q10A2_CH12 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH12)));
				}
			}
		}

		System.Boolean _q10A2_CH13;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH13
		{
			get
			{
				return _q10A2_CH13;
			}

			set
			{
				if (_q10A2_CH13 != value)
				{
					_q10A2_CH13 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH13)));
				}
			}
		}

		System.Boolean _q10A2_CH14;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH14
		{
			get
			{
				return _q10A2_CH14;
			}

			set
			{
				if (_q10A2_CH14 != value)
				{
					_q10A2_CH14 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH14)));
				}
			}
		}

		System.Boolean _q10A2_CH15;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH15
		{
			get
			{
				return _q10A2_CH15;
			}

			set
			{
				if (_q10A2_CH15 != value)
				{
					_q10A2_CH15 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH15)));
				}
			}
		}

		System.Boolean _q10A2_CH16;
		[IoLinkable("Outputs")]
		public System.Boolean q10A2_CH16
		{
			get
			{
				return _q10A2_CH16;
			}

			set
			{
				if (_q10A2_CH16 != value)
				{
					_q10A2_CH16 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(q10A2_CH16)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.IO target)
		{
			target.i10A1_CH1.Cyclic = i10A1_CH1;
			target.i10A1_CH2.Cyclic = i10A1_CH2;
			target.i10A1_CH3.Cyclic = i10A1_CH3;
			target.i10A1_CH4.Cyclic = i10A1_CH4;
			target.i10A1_CH5.Cyclic = i10A1_CH5;
			target.i10A1_CH6.Cyclic = i10A1_CH6;
			target.i10A1_CH7.Cyclic = i10A1_CH7;
			target.i10A1_CH8.Cyclic = i10A1_CH8;
			target.i10A1_CH9.Cyclic = i10A1_CH9;
			target.i10A1_CH10.Cyclic = i10A1_CH10;
			target.i10A1_CH11.Cyclic = i10A1_CH11;
			target.i10A1_CH12.Cyclic = i10A1_CH12;
			target.i10A1_CH13.Cyclic = i10A1_CH13;
			target.i10A1_CH14.Cyclic = i10A1_CH14;
			target.i10A1_CH15.Cyclic = i10A1_CH15;
			target.i10A1_CH16.Cyclic = i10A1_CH16;
			target.q10A2_CH1.Cyclic = q10A2_CH1;
			target.q10A2_CH2.Cyclic = q10A2_CH2;
			target.q10A2_CH3.Cyclic = q10A2_CH3;
			target.q10A2_CH4.Cyclic = q10A2_CH4;
			target.q10A2_CH5.Cyclic = q10A2_CH5;
			target.q10A2_CH6.Cyclic = q10A2_CH6;
			target.q10A2_CH7.Cyclic = q10A2_CH7;
			target.q10A2_CH8.Cyclic = q10A2_CH8;
			target.q10A2_CH9.Cyclic = q10A2_CH9;
			target.q10A2_CH10.Cyclic = q10A2_CH10;
			target.q10A2_CH11.Cyclic = q10A2_CH11;
			target.q10A2_CH12.Cyclic = q10A2_CH12;
			target.q10A2_CH13.Cyclic = q10A2_CH13;
			target.q10A2_CH14.Cyclic = q10A2_CH14;
			target.q10A2_CH15.Cyclic = q10A2_CH15;
			target.q10A2_CH16.Cyclic = q10A2_CH16;
		}

		public void CopyPlainToCyclic(MainPlc.IIO target)
		{
			this.CopyPlainToCyclic((MainPlc.IO)target);
		}

		public void CopyPlainToShadow(MainPlc.IO target)
		{
			target.i10A1_CH1.Shadow = i10A1_CH1;
			target.i10A1_CH2.Shadow = i10A1_CH2;
			target.i10A1_CH3.Shadow = i10A1_CH3;
			target.i10A1_CH4.Shadow = i10A1_CH4;
			target.i10A1_CH5.Shadow = i10A1_CH5;
			target.i10A1_CH6.Shadow = i10A1_CH6;
			target.i10A1_CH7.Shadow = i10A1_CH7;
			target.i10A1_CH8.Shadow = i10A1_CH8;
			target.i10A1_CH9.Shadow = i10A1_CH9;
			target.i10A1_CH10.Shadow = i10A1_CH10;
			target.i10A1_CH11.Shadow = i10A1_CH11;
			target.i10A1_CH12.Shadow = i10A1_CH12;
			target.i10A1_CH13.Shadow = i10A1_CH13;
			target.i10A1_CH14.Shadow = i10A1_CH14;
			target.i10A1_CH15.Shadow = i10A1_CH15;
			target.i10A1_CH16.Shadow = i10A1_CH16;
			target.q10A2_CH1.Shadow = q10A2_CH1;
			target.q10A2_CH2.Shadow = q10A2_CH2;
			target.q10A2_CH3.Shadow = q10A2_CH3;
			target.q10A2_CH4.Shadow = q10A2_CH4;
			target.q10A2_CH5.Shadow = q10A2_CH5;
			target.q10A2_CH6.Shadow = q10A2_CH6;
			target.q10A2_CH7.Shadow = q10A2_CH7;
			target.q10A2_CH8.Shadow = q10A2_CH8;
			target.q10A2_CH9.Shadow = q10A2_CH9;
			target.q10A2_CH10.Shadow = q10A2_CH10;
			target.q10A2_CH11.Shadow = q10A2_CH11;
			target.q10A2_CH12.Shadow = q10A2_CH12;
			target.q10A2_CH13.Shadow = q10A2_CH13;
			target.q10A2_CH14.Shadow = q10A2_CH14;
			target.q10A2_CH15.Shadow = q10A2_CH15;
			target.q10A2_CH16.Shadow = q10A2_CH16;
		}

		public void CopyPlainToShadow(MainPlc.IShadowIO target)
		{
			this.CopyPlainToShadow((MainPlc.IO)target);
		}

		public void CopyCyclicToPlain(MainPlc.IO source)
		{
			i10A1_CH1 = source.i10A1_CH1.LastValue;
			i10A1_CH2 = source.i10A1_CH2.LastValue;
			i10A1_CH3 = source.i10A1_CH3.LastValue;
			i10A1_CH4 = source.i10A1_CH4.LastValue;
			i10A1_CH5 = source.i10A1_CH5.LastValue;
			i10A1_CH6 = source.i10A1_CH6.LastValue;
			i10A1_CH7 = source.i10A1_CH7.LastValue;
			i10A1_CH8 = source.i10A1_CH8.LastValue;
			i10A1_CH9 = source.i10A1_CH9.LastValue;
			i10A1_CH10 = source.i10A1_CH10.LastValue;
			i10A1_CH11 = source.i10A1_CH11.LastValue;
			i10A1_CH12 = source.i10A1_CH12.LastValue;
			i10A1_CH13 = source.i10A1_CH13.LastValue;
			i10A1_CH14 = source.i10A1_CH14.LastValue;
			i10A1_CH15 = source.i10A1_CH15.LastValue;
			i10A1_CH16 = source.i10A1_CH16.LastValue;
			q10A2_CH1 = source.q10A2_CH1.LastValue;
			q10A2_CH2 = source.q10A2_CH2.LastValue;
			q10A2_CH3 = source.q10A2_CH3.LastValue;
			q10A2_CH4 = source.q10A2_CH4.LastValue;
			q10A2_CH5 = source.q10A2_CH5.LastValue;
			q10A2_CH6 = source.q10A2_CH6.LastValue;
			q10A2_CH7 = source.q10A2_CH7.LastValue;
			q10A2_CH8 = source.q10A2_CH8.LastValue;
			q10A2_CH9 = source.q10A2_CH9.LastValue;
			q10A2_CH10 = source.q10A2_CH10.LastValue;
			q10A2_CH11 = source.q10A2_CH11.LastValue;
			q10A2_CH12 = source.q10A2_CH12.LastValue;
			q10A2_CH13 = source.q10A2_CH13.LastValue;
			q10A2_CH14 = source.q10A2_CH14.LastValue;
			q10A2_CH15 = source.q10A2_CH15.LastValue;
			q10A2_CH16 = source.q10A2_CH16.LastValue;
		}

		public void CopyCyclicToPlain(MainPlc.IIO source)
		{
			this.CopyCyclicToPlain((MainPlc.IO)source);
		}

		public void CopyShadowToPlain(MainPlc.IO source)
		{
			i10A1_CH1 = source.i10A1_CH1.Shadow;
			i10A1_CH2 = source.i10A1_CH2.Shadow;
			i10A1_CH3 = source.i10A1_CH3.Shadow;
			i10A1_CH4 = source.i10A1_CH4.Shadow;
			i10A1_CH5 = source.i10A1_CH5.Shadow;
			i10A1_CH6 = source.i10A1_CH6.Shadow;
			i10A1_CH7 = source.i10A1_CH7.Shadow;
			i10A1_CH8 = source.i10A1_CH8.Shadow;
			i10A1_CH9 = source.i10A1_CH9.Shadow;
			i10A1_CH10 = source.i10A1_CH10.Shadow;
			i10A1_CH11 = source.i10A1_CH11.Shadow;
			i10A1_CH12 = source.i10A1_CH12.Shadow;
			i10A1_CH13 = source.i10A1_CH13.Shadow;
			i10A1_CH14 = source.i10A1_CH14.Shadow;
			i10A1_CH15 = source.i10A1_CH15.Shadow;
			i10A1_CH16 = source.i10A1_CH16.Shadow;
			q10A2_CH1 = source.q10A2_CH1.Shadow;
			q10A2_CH2 = source.q10A2_CH2.Shadow;
			q10A2_CH3 = source.q10A2_CH3.Shadow;
			q10A2_CH4 = source.q10A2_CH4.Shadow;
			q10A2_CH5 = source.q10A2_CH5.Shadow;
			q10A2_CH6 = source.q10A2_CH6.Shadow;
			q10A2_CH7 = source.q10A2_CH7.Shadow;
			q10A2_CH8 = source.q10A2_CH8.Shadow;
			q10A2_CH9 = source.q10A2_CH9.Shadow;
			q10A2_CH10 = source.q10A2_CH10.Shadow;
			q10A2_CH11 = source.q10A2_CH11.Shadow;
			q10A2_CH12 = source.q10A2_CH12.Shadow;
			q10A2_CH13 = source.q10A2_CH13.Shadow;
			q10A2_CH14 = source.q10A2_CH14.Shadow;
			q10A2_CH15 = source.q10A2_CH15.Shadow;
			q10A2_CH16 = source.q10A2_CH16.Shadow;
		}

		public void CopyShadowToPlain(MainPlc.IShadowIO source)
		{
			this.CopyShadowToPlain((MainPlc.IO)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainIO()
		{
		}
	}
}