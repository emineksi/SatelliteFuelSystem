using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatelliteFuelSystem.Models
{
    public class RiseModel
    {
        [DisplayName("Yakıt Tüketim Değeri")]
        public decimal FuelConsumptionValue { get; set; }
        [DisplayName("Manevra Süresi")]
        public decimal ManeuverTime { get; set; }
        [DisplayName("Manevranın Başladığı İrtifa")]
        public decimal ManeuverAltitudeStart { get; set; }
        [DisplayName("Manevranın Bittiği İrtifa")]
        public decimal ManeuverAltitudeEnd { get; set; }
        [DisplayName("Manevra Hızı")]
        public decimal ManeuverSpeed { get; set; }
    }
}
