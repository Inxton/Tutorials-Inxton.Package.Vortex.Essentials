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
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stData", "MainPlc", TypeComplexityEnum.Complex)]
	public partial class stData : Vortex.Connector.IVortexObject, IstData, IShadowstData, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		stContinuosValueData _DimX;
		public stContinuosValueData DimX
		{
			get
			{
				return _DimX;
			}
		}

		IstContinuosValueData IstData.DimX
		{
			get
			{
				return DimX;
			}
		}

		IShadowstContinuosValueData IShadowstData.DimX
		{
			get
			{
				return DimX;
			}
		}

		stContinuosValueData _DimY;
		public stContinuosValueData DimY
		{
			get
			{
				return _DimY;
			}
		}

		IstContinuosValueData IstData.DimY
		{
			get
			{
				return DimY;
			}
		}

		IShadowstContinuosValueData IShadowstData.DimY
		{
			get
			{
				return DimY;
			}
		}

		stContinuosValueData _DimZ;
		public stContinuosValueData DimZ
		{
			get
			{
				return _DimZ;
			}
		}

		IstContinuosValueData IstData.DimZ
		{
			get
			{
				return DimZ;
			}
		}

		IShadowstContinuosValueData IShadowstData.DimZ
		{
			get
			{
				return DimZ;
			}
		}

		public void LazyOnlineToShadow()
		{
			DimX.LazyOnlineToShadow();
			DimY.LazyOnlineToShadow();
			DimZ.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			DimX.LazyShadowToOnline();
			DimY.LazyShadowToOnline();
			DimZ.LazyShadowToOnline();
		}

		public PlainstData CreatePlainerType()
		{
			var cloned = new PlainstData();
			cloned.DimX = DimX.CreatePlainerType();
			cloned.DimY = DimY.CreatePlainerType();
			cloned.DimZ = DimZ.CreatePlainerType();
			return cloned;
		}

		protected PlainstData CreatePlainerType(PlainstData cloned)
		{
			cloned.DimX = DimX.CreatePlainerType();
			cloned.DimY = DimY.CreatePlainerType();
			cloned.DimZ = DimZ.CreatePlainerType();
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

		public void FlushPlainToOnline(MainPlc.PlainstData source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(MainPlc.PlainstData source)
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

		public void FlushOnlineToPlain(MainPlc.PlainstData source)
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

		public stData(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_DimX = new stContinuosValueData(this, "<#DimensionX#> [mm]", "DimX");
			_DimX.AttributeName = "<#DimensionX#> [mm]";
			_DimY = new stContinuosValueData(this, "<#DimensionY#> [mm]", "DimY");
			_DimY.AttributeName = "<#DimensionY#> [mm]";
			_DimZ = new stContinuosValueData(this, "<#DimensionZ#> [mm]", "DimZ");
			_DimZ.AttributeName = "<#DimensionZ#> [mm]";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stData()
		{
			PexPreConstructorParameterless();
			_DimX = new stContinuosValueData();
			_DimX.AttributeName = "<#DimensionX#> [mm]";
			_DimY = new stContinuosValueData();
			_DimY.AttributeName = "<#DimensionY#> [mm]";
			_DimZ = new stContinuosValueData();
			_DimZ.AttributeName = "<#DimensionZ#> [mm]";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstData
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstData()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstData : Vortex.Connector.IVortexOnlineObject
	{
		IstContinuosValueData DimX
		{
			get;
		}

		IstContinuosValueData DimY
		{
			get;
		}

		IstContinuosValueData DimZ
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainstData CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(MainPlc.PlainstData source);
		void FlushOnlineToPlain(MainPlc.PlainstData source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstData : Vortex.Connector.IVortexShadowObject
	{
		IShadowstContinuosValueData DimX
		{
			get;
		}

		IShadowstContinuosValueData DimY
		{
			get;
		}

		IShadowstContinuosValueData DimZ
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		MainPlc.PlainstData CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(MainPlc.PlainstData source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstData : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainstContinuosValueData _DimX;
		public PlainstContinuosValueData DimX
		{
			get
			{
				return _DimX;
			}

			set
			{
				if (_DimX != value)
				{
					_DimX = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DimX)));
				}
			}
		}

		PlainstContinuosValueData _DimY;
		public PlainstContinuosValueData DimY
		{
			get
			{
				return _DimY;
			}

			set
			{
				if (_DimY != value)
				{
					_DimY = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DimY)));
				}
			}
		}

		PlainstContinuosValueData _DimZ;
		public PlainstContinuosValueData DimZ
		{
			get
			{
				return _DimZ;
			}

			set
			{
				if (_DimZ != value)
				{
					_DimZ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DimZ)));
				}
			}
		}

		public void CopyPlainToCyclic(MainPlc.stData target)
		{
			DimX.CopyPlainToCyclic(target.DimX);
			DimY.CopyPlainToCyclic(target.DimY);
			DimZ.CopyPlainToCyclic(target.DimZ);
		}

		public void CopyPlainToCyclic(MainPlc.IstData target)
		{
			this.CopyPlainToCyclic((MainPlc.stData)target);
		}

		public void CopyPlainToShadow(MainPlc.stData target)
		{
			DimX.CopyPlainToShadow(target.DimX);
			DimY.CopyPlainToShadow(target.DimY);
			DimZ.CopyPlainToShadow(target.DimZ);
		}

		public void CopyPlainToShadow(MainPlc.IShadowstData target)
		{
			this.CopyPlainToShadow((MainPlc.stData)target);
		}

		public void CopyCyclicToPlain(MainPlc.stData source)
		{
			DimX.CopyCyclicToPlain(source.DimX);
			DimY.CopyCyclicToPlain(source.DimY);
			DimZ.CopyCyclicToPlain(source.DimZ);
		}

		public void CopyCyclicToPlain(MainPlc.IstData source)
		{
			this.CopyCyclicToPlain((MainPlc.stData)source);
		}

		public void CopyShadowToPlain(MainPlc.stData source)
		{
			DimX.CopyShadowToPlain(source.DimX);
			DimY.CopyShadowToPlain(source.DimY);
			DimZ.CopyShadowToPlain(source.DimZ);
		}

		public void CopyShadowToPlain(MainPlc.IShadowstData source)
		{
			this.CopyShadowToPlain((MainPlc.stData)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstData()
		{
			_DimX = new PlainstContinuosValueData();
			_DimY = new PlainstContinuosValueData();
			_DimZ = new PlainstContinuosValueData();
		}
	}
}