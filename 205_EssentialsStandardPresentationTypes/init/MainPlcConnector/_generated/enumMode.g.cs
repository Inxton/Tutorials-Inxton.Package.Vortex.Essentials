using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace MainPlc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "enumMode", "MainPlc", TypeComplexityEnum.Enumerator)]
	public enum enumMode
	{
		None = 0,
		Ground = 10,
		Automat = 20,
		Manual = 30
	}
}