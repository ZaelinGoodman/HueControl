using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HueControl
{
    public partial class NAT_UPnP_Configuration_Browser : Form
    {
        public NAT_UPnP_Configuration_Browser()
        {
            InitializeComponent();
            foreach (NATUPNPLib.IStaticPortMapping p in NAT_UPnP_Helper.Portmappings)
            {
                lbPortMappings.Items.Add(new NAT_UPnP_Helper.NATUPnPListBoxItem(p));
            }
        }
    }
}
