using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NATUPNPLib;

namespace HueControl
{
    static class NAT_UPnP_Helper
    {
        private static UPnPNATClass upnpnat = null;
        public static UPnPNATClass UPnPNat {
            get {
                return upnpnat ?? new NATUPNPLib.UPnPNATClass();}
        }
        public static IStaticPortMappingCollection Portmappings {
            get {
                return UPnPNat.StaticPortMappingCollection;}
        }
        public static IStaticPortMapping AddMapping(
                int portExternal, string internalClient, int portInternal,
                string protocol = "TCP", string description = "HueControl Portmapping", bool enabled = true) {
            return UPnPNat.StaticPortMappingCollection.Add(portExternal, protocol, portInternal, internalClient, enabled, description);
        }
        public static void Remove(int portExternal, string protocol = "TCP") {
            UPnPNat.StaticPortMappingCollection.Remove(portExternal, protocol);
        }
        public class NATUPnPListBoxItem
        {
            public NATUPnPListBoxItem(NATUPNPLib.IStaticPortMapping mapping)
            {
                this.Mapping = mapping;
            }

            public NATUPNPLib.IStaticPortMapping Mapping { get; set; }

            public override string ToString()
            {
                return this.Mapping.Description;
            }
        }
    }
}
