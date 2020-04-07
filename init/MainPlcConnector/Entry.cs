#define LOCAL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace MainPlc
{
    public static class Entry
    {

#if LOCAL
        const string AmsId = null; // your ams id or set to 'null' if local
        const int Port = 851;
#else
        const string AmsId = "172.20.10.2.1.1"; // set your target ams id
        const int Port = 851;
#endif

        public static MainPlcTwinController MainPlc { get; } = new MainPlcTwinController(Tc3ConnectorAdapter.Create(AmsId, 851));
    }
}
