using SatelliteFuelSystem.Helpers;
using SatelliteFuelSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatelliteFuelSystem
{
    public partial class Form1 : Form
    {
        List<HoverModel> hoverDatas = new List<HoverModel>();
        List<RiseModel> riseDatas = new List<RiseModel>();
        List<DescentModel> descentDatas = new List<DescentModel>();
        List<CruiseModel> cruiseDatas = new List<CruiseModel>();

        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManeuverInsertForm maneuverInsertForm = new ManeuverInsertForm();
            DialogResult dr = maneuverInsertForm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                maneuverInsertForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                if (maneuverInsertForm.ManeuverType == Enums.ManeuverTypes.Hover)
                {
                    hoverDatas.Add(new HoverModel
                    {
                        FuelConsumptionValue = maneuverInsertForm.FuelConsumptionValue,
                        ManeuverTime = maneuverInsertForm.ManeuverTime
                    });
                    var datas = new List<HoverModel>();
                    datas.AddRange(hoverDatas);
                    hoverGrid.DataSource = datas;
                }
                else if (maneuverInsertForm.ManeuverType == Enums.ManeuverTypes.Rise)
                {
                    riseDatas.Add(new RiseModel
                    {
                        FuelConsumptionValue = maneuverInsertForm.FuelConsumptionValue,
                        ManeuverTime = maneuverInsertForm.ManeuverTime,
                        ManeuverAltitudeStart = maneuverInsertForm.ManeuverAltitudeStart,
                        ManeuverAltitudeEnd = maneuverInsertForm.ManeuverAltitudeEnd,
                        ManeuverSpeed = maneuverInsertForm.ManeuverSpeed
                    });
                    var datas = new List<RiseModel>();
                    datas.AddRange(riseDatas);
                    riseGrid.DataSource = datas;
                }
                else if (maneuverInsertForm.ManeuverType == Enums.ManeuverTypes.Descent)
                {
                    descentDatas.Add(new DescentModel
                    {
                        FuelConsumptionValue = maneuverInsertForm.FuelConsumptionValue,
                        ManeuverTime = maneuverInsertForm.ManeuverTime,
                        ManeuverAltitudeStart = maneuverInsertForm.ManeuverAltitudeStart,
                        ManeuverAltitudeEnd = maneuverInsertForm.ManeuverAltitudeEnd,
                        ManeuverSpeed = maneuverInsertForm.ManeuverSpeed
                    });
                    var datas = new List<DescentModel>();
                    datas.AddRange(descentDatas);
                    descentGrid.DataSource = datas;
                }
                else if (maneuverInsertForm.ManeuverType == Enums.ManeuverTypes.Cruise)
                {
                    cruiseDatas.Add(new CruiseModel
                    {
                        FuelConsumptionValue = maneuverInsertForm.FuelConsumptionValue,
                        ManeuverTime = maneuverInsertForm.ManeuverTime,
                        ManeuverSpeed = maneuverInsertForm.ManeuverSpeed,
                        ManeuverDistance = maneuverInsertForm.ManeuverDistance
                    });
                    var datas = new List<CruiseModel>();
                    datas.AddRange(cruiseDatas);
                    cruiseGrid.DataSource = datas;
                }
                maneuverInsertForm.Close();
            }

            //maneuverInsertForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal totalFuelConsumption = 0;
            foreach (var item in hoverDatas)
            {
                var val = item.FuelConsumptionValue * item.ManeuverTime;
                totalFuelConsumption += val;
            }
            foreach (var item in riseDatas)
            {
                var maneuverTime = (Math.Abs(item.ManeuverAltitudeEnd - item.ManeuverAltitudeStart)) / item.ManeuverSpeed;
                totalFuelConsumption += maneuverTime * item.FuelConsumptionValue;
            }
            foreach (var item in descentDatas)
            {
                var maneuverTime = (Math.Abs(item.ManeuverAltitudeEnd - item.ManeuverAltitudeStart)) / item.ManeuverSpeed;
                totalFuelConsumption += maneuverTime * item.FuelConsumptionValue;
            }
            foreach (var item in cruiseDatas)
            {
                var maneuverTime = item.ManeuverDistance / item.ManeuverSpeed;
                totalFuelConsumption += maneuverTime * item.FuelConsumptionValue;
            }
            textBox1.Text = $"{totalFuelConsumption} Kg";
            panel1.Show();
        }
    }
}
