using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatelliteFuelSystem.Models
{
    public class CruiseModel
    {
        [DisplayName("Yakıt Tüketim Değeri")]
        public decimal FuelConsumptionValue { get; set; }
        [DisplayName("Manevra Süresi")]
        public decimal ManeuverTime { get; set; }
        [DisplayName("Manevranın Kat Ettiği Mesafe")]
        public decimal ManeuverDistance { get; set; }
        [DisplayName("Manevra Hızı")]
        public decimal ManeuverSpeed { get; set; }

    }
}
