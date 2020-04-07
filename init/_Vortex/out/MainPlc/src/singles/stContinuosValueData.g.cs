using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
	[Container(Layout.Wrap), Group(Layout.GroupBox)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stContinuosValueData", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class stContinuosValueData : Vortex.Connector.IVortexObject, IstContinuosValueData, IShadowstContinuosValueData, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerReal _Mininum;
		public Vortex.Connector.ValueTypes.OnlinerReal Mininum
		{
			get
			{
				return _Mininum;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstContinuosValueData.Mininum
		{
			get
			{
				return Mininum;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstContinuosValueData.Mininum
		{
			get
			{
				return Mininum;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Measured;
		[RenderIgnore("Control", "ShadowControl")]
		public Vortex.Connector.ValueTypes.OnlinerReal Measured
		{
			get
			{
				return _Measured;
			}
		}

		[RenderIgnore("Control", "ShadowControl")]
		Vortex.Connector.ValueTypes.Online.IOnlineReal IstContinuosValueData.Measured
		{
			get
			{
				return Measured;
			}
		}

		[RenderIgnore("Control", "ShadowControl")]
		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstContinuosValueData.Measured
		{
			get
			{
				return Measured;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Maximum;
		public Vortex.Connector.ValueTypes.OnlinerReal Maximum
		{
			get
			{
				return _Maximum;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstContinuosValueData.Maximum
		{
			get
			{
				return Maximum;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstContinuosValueData.Maximum
		{
			get
			{
				return Maximum;
			}
		}

		public void LazyOnlineToShadow()
		{
			Mininum.Shadow = Mininum.LastValue;
			Measured.Shadow = Measured.LastValue;
			Maximum.Shadow = Maximum.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Mininum.Cyclic = Mininum.Shadow;
			Measured.Cyclic = Measured.Shadow;
			Maximum.Cyclic = Maximum.Shadow;
		}

		public PlainstContinuosValueData CreatePlainerType()
		{
			var cloned = new PlainstContinuosValueData();
			return cloned;
		}

		protected PlainstContinuosValueData CreatePlainerType(PlainstContinuosValueData cloned)
		{
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

		public void FlushPlainToOnline(MainPlc.PlainstContinuosValueData source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainstContinuosValueData source)
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

		public void FlushOnlineToPlain(MainPlc.PlainstContinuosValueData source)
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

		public stContinuosValueData(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Mininum = @Connector.Online.Adapter.CreateREAL(this, "<#Min#>", "Mininum");
			Mininum.AttributeName = "<#Min#>";
			_Measured = @Connector.Online.Adapter.CreateREAL(this, "<#Aquired#>", "Measured");
			Measured.AttributeName = "<#Aquired#>";
			_Maximum = @Connector.Online.Adapter.CreateREAL(this, "<#Max#>", "Maximum");
			Maximum.AttributeName = "<#Max#>";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public stContinuosValueData()
		{
			PexPreConstructorParameterless();
			_Mininum = Vortex.Connector.IConnectorFactory.CreateREAL();
			Mininum.AttributeName = "<#Min#>";
			_Measured = Vortex.Connector.IConnectorFactory.CreateREAL();
			Measured.AttributeName = "<#Aquired#>";
			_Maximum = Vortex.Connector.IConnectorFactory.CreateREAL();
			Maximum.AttributeName = "<#Max#>";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstContinuosValueData
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstContinuosValueData()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstContinuosValueData : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineReal Mininum
		{
			get;
		}

		[RenderIgnore("Control", "ShadowControl")]
		Vortex.Connector.ValueTypes.Online.IOnlineReal Measured
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Maximum
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainstContinuosValueData CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainstContinuosValueData source);
		void FlushOnlineToPlain(MainPlc.PlainstContinuosValueData source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstContinuosValueData : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowReal Mininum
		{
			get;
		}

		[RenderIgnore("Control", "ShadowControl")]
		Vortex.Connector.ValueTypes.Shadows.IShadowReal Measured
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Maximum
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainstContinuosValueData CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainstContinuosValueData source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstContinuosValueData : Vortex.Connector.IPlain
	{
		System.Single _Mininum;
		public System.Single Mininum
		{
			get
			{
				return _Mininum;
			}

			set
			{
				_Mininum = value;
			}
		}

		System.Single _Measured;
		[RenderIgnore("Control", "ShadowControl")]
		public System.Single Measured
		{
			get
			{
				return _Measured;
			}

			set
			{
				_Measured = value;
			}
		}

		System.Single _Maximum;
		public System.Single Maximum
		{
			get
			{
				return _Maximum;
			}

			set
			{
				_Maximum = value;
			}
		}

		public void CopyPlainToCyclic(MainPlc.stContinuosValueData target)
		{
			target.Mininum.Cyclic = Mininum;
			target.Measured.Cyclic = Measured;
			target.Maximum.Cyclic = Maximum;
		}

		public void CopyPlainToCyclic(MainPlc.IstContinuosValueData target)
		{
			this.CopyPlainToCyclic((MainPlc.stContinuosValueData)target);
		}

		public void CopyPlainToShadow(MainPlc.stContinuosValueData target)
		{
			target.Mininum.Shadow = Mininum;
			target.Measured.Shadow = Measured;
			target.Maximum.Shadow = Maximum;
		}

		public void CopyPlainToShadow(MainPlc.IShadowstContinuosValueData target)
		{
			this.CopyPlainToShadow((MainPlc.stContinuosValueData)target);
		}

		public void CopyCyclicToPlain(MainPlc.stContinuosValueData source)
		{
			Mininum = source.Mininum.LastValue;
			Measured = source.Measured.LastValue;
			Maximum = source.Maximum.LastValue;
		}

		public void CopyCyclicToPlain(MainPlc.IstContinuosValueData source)
		{
			this.CopyCyclicToPlain((MainPlc.stContinuosValueData)source);
		}

		public void CopyShadowToPlain(MainPlc.stContinuosValueData source)
		{
			Mininum = source.Mininum.Shadow;
			Measured = source.Measured.Shadow;
			Maximum = source.Maximum.Shadow;
		}

		public void CopyShadowToPlain(MainPlc.IShadowstContinuosValueData source)
		{
			this.CopyShadowToPlain((MainPlc.stContinuosValueData)source);
		}

		public PlainstContinuosValueData()
		{
		}
	}
}