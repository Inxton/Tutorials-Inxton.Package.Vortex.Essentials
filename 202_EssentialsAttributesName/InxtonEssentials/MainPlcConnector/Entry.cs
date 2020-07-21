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
        public const string AmsId = null; // your ams id or set to 'null' if local
        public const int Port = 851;
#else

        public const string AmsId = "172.20.10.104.1.1"; // set your target ams id
        public const int Port = 851;
#endif
        public static MainPlcTwinController MainPlc = new MainPlcTwinController(Tc3ConnectorAdapter.Create(AmsId, Port));
    }
}