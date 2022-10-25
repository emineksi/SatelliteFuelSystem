using SatelliteFuelSystem.Enums;
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
    public partial class ManeuverInsertForm : Form
    {
        public ManeuverTypes ManeuverType { get; set; }
        public decimal FuelConsumptionValue { get; set; }
        public decimal ManeuverTime { get; set; }
        public decimal ManeuverAltitudeStart { get; set; }
        public decimal ManeuverAltitudeEnd { get; set; }
        public decimal ManeuverSpeed { get; set; }
        public decimal ManeuverDistance { get; set; }

        public ManeuverInsertForm()
        {
            InitializeComponent();
            FuelConsumptionValuePanel.Hide();
            ManeuverTimePanel.Hide();
            ManeuverAltitudeStartPanel.Hide();
            ManeuverAltitudeEndPanel.Hide();
            ManeuverDistancePanel.Hide();
            ManeuverSpeedPanel.Hide();

            var maneuverTypes = EnumHelpers.GetDescriptions(typeof(ManeuverTypes)).ToArray();
            ManeuverTypeInput.Items.AddRange(maneuverTypes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                (ManeuverType == ManeuverTypes.Hover && (FuelConsumptionValue <= 0 || ManeuverTime <= 0)) ||
                (ManeuverType == ManeuverTypes.Rise && (FuelConsumptionValue <= 0 || ManeuverTime <= 0 || ManeuverAltitudeStart <= 0 || ManeuverAltitudeEnd <= 0 || ManeuverSpeed <= 0)) ||
                (ManeuverType == ManeuverTypes.Descent && (FuelConsumptionValue <= 0 || ManeuverTime <= 0 || ManeuverAltitudeStart <= 0 || ManeuverAltitudeEnd <= 0 || ManeuverSpeed <= 0)) ||
                (ManeuverType == ManeuverTypes.Cruise && (FuelConsumptionValue <= 0 || ManeuverTime <= 0 || ManeuverDistance <= 0 || ManeuverSpeed <= 0))
                )
            {
                MessageBox.Show("Manevra kaydedilemedi, Lütfen ilgili alanları eksiksiz doldurunuz!!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FuelConsumptionValueInput_ValueChanged(object sender, EventArgs e)
        {
            FuelConsumptionValue = FuelConsumptionValueInput.Value;
        }

        private void ManeuverTimeInput_ValueChanged(object sender, EventArgs e)
        {
            ManeuverTime = ManeuverTimeInput.Value;
        }

        private void ManeuverAltitudeStartInput_ValueChanged(object sender, EventArgs e)
        {
            ManeuverAltitudeStart = ManeuverAltitudeStartInput.Value;
        }

        private void ManeuverAltitudeEndInput_ValueChanged(object sender, EventArgs e)
        {
            ManeuverAltitudeEnd = ManeuverAltitudeEndInput.Value;
        }

        private void ManeuverSpeedInput_ValueChanged(object sender, EventArgs e)
        {
            ManeuverSpeed = ManeuverSpeedInput.Value;
        }

        private void ManeuverDistanceInput_ValueChanged(object sender, EventArgs e)
        {
            ManeuverDistance = ManeuverDistanceInput.Value;
        }

        private void maneuverTypeInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuelConsumptionValuePanel.Hide();
            ManeuverTimePanel.Hide();
            ManeuverAltitudeStartPanel.Hide();
            ManeuverAltitudeEndPanel.Hide();
            ManeuverDistancePanel.Hide();
            ManeuverSpeedPanel.Hide();

            var selectedIndex = ManeuverTypeInput.SelectedIndex;
            var enumValue = selectedIndex + 1;
            ManeuverType = (ManeuverTypes)enumValue;
            switch (ManeuverType)
            {
                case ManeuverTypes.Hover:
                    FuelConsumptionValuePanel.Show();
                    ManeuverTimePanel.Show();
                    break;
                case ManeuverTypes.Rise:
                    FuelConsumptionValuePanel.Show();
                    ManeuverTimePanel.Show();
                    ManeuverAltitudeStartPanel.Show();
                    ManeuverAltitudeEndPanel.Show();
                    ManeuverSpeedPanel.Show();
                    break;
                case ManeuverTypes.Descent:
                    FuelConsumptionValuePanel.Show();
                    ManeuverTimePanel.Show();
                    ManeuverAltitudeStartPanel.Show();
                    ManeuverAltitudeEndPanel.Show();
                    ManeuverSpeedPanel.Show();
                    break;
                case ManeuverTypes.Cruise:
                    FuelConsumptionValuePanel.Show();
                    ManeuverTimePanel.Show();
                    ManeuverDistancePanel.Show();
                    ManeuverSpeedPanel.Show();


                    break;
                default:
                    break;
            }
        }
    }
}
