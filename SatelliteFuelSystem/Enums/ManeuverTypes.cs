using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatelliteFuelSystem.Enums
{
    public enum ManeuverTypes
    {
        [Description("Askıda Uçuş Manevrası")]
        Hover = 1,
        [Description("Yükselme Manevrası")]
        Rise = 2,
        [Description("Alçalma Manevrası")]
        Descent = 3,
        [Description("Düz Uçuş Manevrası")]
        Cruise = 4
    }
}
