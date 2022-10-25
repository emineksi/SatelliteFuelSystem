namespace SatelliteFuelSystem
{
    partial class ManeuverInsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManeuverTypeInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FuelConsumptionValueInput = new System.Windows.Forms.NumericUpDown();
            this.FuelConsumptionValueLabel = new System.Windows.Forms.Label();
            this.ManeuverTimeInputLabel = new System.Windows.Forms.Label();
            this.ManeuverAltitudeStartLabel = new System.Windows.Forms.Label();
            this.ManeuverAltitudeEndLabel = new System.Windows.Forms.Label();
            this.ManeuverSpeedLabel = new System.Windows.Forms.Label();
            this.ManeuverDistanceLabel = new System.Windows.Forms.Label();
            this.ManeuverTimeInput = new System.Windows.Forms.NumericUpDown();
            this.ManeuverAltitudeStartInput = new System.Windows.Forms.NumericUpDown();
            this.ManeuverAltitudeEndInput = new System.Windows.Forms.NumericUpDown();
            this.ManeuverSpeedInput = new System.Windows.Forms.NumericUpDown();
            this.ManeuverDistanceInput = new System.Windows.Forms.NumericUpDown();
            this.FuelConsumptionValuePanel = new System.Windows.Forms.Panel();
            this.ManeuverTimePanel = new System.Windows.Forms.Panel();
            this.ManeuverAltitudeStartPanel = new System.Windows.Forms.Panel();
            this.ManeuverAltitudeEndPanel = new System.Windows.Forms.Panel();
            this.ManeuverSpeedPanel = new System.Windows.Forms.Panel();
            this.ManeuverDistancePanel = new System.Windows.Forms.Panel();
            this.ManeuverTypePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FuelConsumptionValueInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverAltitudeStartInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverAltitudeEndInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverSpeedInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverDistanceInput)).BeginInit();
            this.FuelConsumptionValuePanel.SuspendLayout();
            this.ManeuverTimePanel.SuspendLayout();
            this.ManeuverAltitudeStartPanel.SuspendLayout();
            this.ManeuverAltitudeEndPanel.SuspendLayout();
            this.ManeuverSpeedPanel.SuspendLayout();
            this.ManeuverDistancePanel.SuspendLayout();
            this.ManeuverTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManeuverTypeInput
            // 
            this.ManeuverTypeInput.FormattingEnabled = true;
            this.ManeuverTypeInput.Location = new System.Drawing.Point(170, 7);
            this.ManeuverTypeInput.Name = "ManeuverTypeInput";
            this.ManeuverTypeInput.Size = new System.Drawing.Size(121, 23);
            this.ManeuverTypeInput.TabIndex = 0;
            this.ManeuverTypeInput.SelectedIndexChanged += new System.EventHandler(this.maneuverTypeInput_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manevra Tipi :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FuelConsumptionValueInput
            // 
            this.FuelConsumptionValueInput.Location = new System.Drawing.Point(170, 7);
            this.FuelConsumptionValueInput.Name = "FuelConsumptionValueInput";
            this.FuelConsumptionValueInput.Size = new System.Drawing.Size(121, 23);
            this.FuelConsumptionValueInput.TabIndex = 3;
            this.FuelConsumptionValueInput.ValueChanged += new System.EventHandler(this.FuelConsumptionValueInput_ValueChanged);
            // 
            // FuelConsumptionValueLabel
            // 
            this.FuelConsumptionValueLabel.AutoSize = true;
            this.FuelConsumptionValueLabel.Location = new System.Drawing.Point(3, 9);
            this.FuelConsumptionValueLabel.Name = "FuelConsumptionValueLabel";
            this.FuelConsumptionValueLabel.Size = new System.Drawing.Size(118, 15);
            this.FuelConsumptionValueLabel.TabIndex = 4;
            this.FuelConsumptionValueLabel.Text = "Yakıt tüketim değeri :";
            // 
            // ManeuverTimeInputLabel
            // 
            this.ManeuverTimeInputLabel.AutoSize = true;
            this.ManeuverTimeInputLabel.Location = new System.Drawing.Point(3, 9);
            this.ManeuverTimeInputLabel.Name = "ManeuverTimeInputLabel";
            this.ManeuverTimeInputLabel.Size = new System.Drawing.Size(95, 15);
            this.ManeuverTimeInputLabel.TabIndex = 5;
            this.ManeuverTimeInputLabel.Text = "Manevra süresi : ";
            // 
            // ManeuverAltitudeStartLabel
            // 
            this.ManeuverAltitudeStartLabel.AutoSize = true;
            this.ManeuverAltitudeStartLabel.Location = new System.Drawing.Point(3, 10);
            this.ManeuverAltitudeStartLabel.Name = "ManeuverAltitudeStartLabel";
            this.ManeuverAltitudeStartLabel.Size = new System.Drawing.Size(153, 15);
            this.ManeuverAltitudeStartLabel.TabIndex = 6;
            this.ManeuverAltitudeStartLabel.Text = "Manevranın başladığı irtifa :";
            // 
            // ManeuverAltitudeEndLabel
            // 
            this.ManeuverAltitudeEndLabel.AutoSize = true;
            this.ManeuverAltitudeEndLabel.Location = new System.Drawing.Point(3, 9);
            this.ManeuverAltitudeEndLabel.Name = "ManeuverAltitudeEndLabel";
            this.ManeuverAltitudeEndLabel.Size = new System.Drawing.Size(137, 15);
            this.ManeuverAltitudeEndLabel.TabIndex = 7;
            this.ManeuverAltitudeEndLabel.Text = "Manevranın bittiği irtifa :";
            // 
            // ManeuverSpeedLabel
            // 
            this.ManeuverSpeedLabel.AutoSize = true;
            this.ManeuverSpeedLabel.Location = new System.Drawing.Point(4, 10);
            this.ManeuverSpeedLabel.Name = "ManeuverSpeedLabel";
            this.ManeuverSpeedLabel.Size = new System.Drawing.Size(80, 15);
            this.ManeuverSpeedLabel.TabIndex = 8;
            this.ManeuverSpeedLabel.Text = "Manevra hızı :";
            // 
            // ManeuverDistanceLabel
            // 
            this.ManeuverDistanceLabel.AutoSize = true;
            this.ManeuverDistanceLabel.Location = new System.Drawing.Point(3, 9);
            this.ManeuverDistanceLabel.Name = "ManeuverDistanceLabel";
            this.ManeuverDistanceLabel.Size = new System.Drawing.Size(166, 15);
            this.ManeuverDistanceLabel.TabIndex = 9;
            this.ManeuverDistanceLabel.Text = "Manevranın kat ettiği mesafe :";
            // 
            // ManeuverTimeInput
            // 
            this.ManeuverTimeInput.Location = new System.Drawing.Point(171, 7);
            this.ManeuverTimeInput.Name = "ManeuverTimeInput";
            this.ManeuverTimeInput.Size = new System.Drawing.Size(120, 23);
            this.ManeuverTimeInput.TabIndex = 3;
            this.ManeuverTimeInput.ValueChanged += new System.EventHandler(this.ManeuverTimeInput_ValueChanged);
            // 
            // ManeuverAltitudeStartInput
            // 
            this.ManeuverAltitudeStartInput.Location = new System.Drawing.Point(171, 8);
            this.ManeuverAltitudeStartInput.Name = "ManeuverAltitudeStartInput";
            this.ManeuverAltitudeStartInput.Size = new System.Drawing.Size(120, 23);
            this.ManeuverAltitudeStartInput.TabIndex = 3;
            this.ManeuverAltitudeStartInput.ValueChanged += new System.EventHandler(this.ManeuverAltitudeStartInput_ValueChanged);
            // 
            // ManeuverAltitudeEndInput
            // 
            this.ManeuverAltitudeEndInput.Location = new System.Drawing.Point(170, 7);
            this.ManeuverAltitudeEndInput.Name = "ManeuverAltitudeEndInput";
            this.ManeuverAltitudeEndInput.Size = new System.Drawing.Size(120, 23);
            this.ManeuverAltitudeEndInput.TabIndex = 3;
            this.ManeuverAltitudeEndInput.ValueChanged += new System.EventHandler(this.ManeuverAltitudeEndInput_ValueChanged);
            // 
            // ManeuverSpeedInput
            // 
            this.ManeuverSpeedInput.Location = new System.Drawing.Point(170, 8);
            this.ManeuverSpeedInput.Name = "ManeuverSpeedInput";
            this.ManeuverSpeedInput.Size = new System.Drawing.Size(120, 23);
            this.ManeuverSpeedInput.TabIndex = 3;
            this.ManeuverSpeedInput.ValueChanged += new System.EventHandler(this.ManeuverSpeedInput_ValueChanged);
            // 
            // ManeuverDistanceInput
            // 
            this.ManeuverDistanceInput.Location = new System.Drawing.Point(170, 7);
            this.ManeuverDistanceInput.Name = "ManeuverDistanceInput";
            this.ManeuverDistanceInput.Size = new System.Drawing.Size(120, 23);
            this.ManeuverDistanceInput.TabIndex = 3;
            this.ManeuverDistanceInput.ValueChanged += new System.EventHandler(this.ManeuverDistanceInput_ValueChanged);
            // 
            // FuelConsumptionValuePanel
            // 
            this.FuelConsumptionValuePanel.Controls.Add(this.FuelConsumptionValueLabel);
            this.FuelConsumptionValuePanel.Controls.Add(this.FuelConsumptionValueInput);
            this.FuelConsumptionValuePanel.Location = new System.Drawing.Point(62, 80);
            this.FuelConsumptionValuePanel.Name = "FuelConsumptionValuePanel";
            this.FuelConsumptionValuePanel.Size = new System.Drawing.Size(306, 36);
            this.FuelConsumptionValuePanel.TabIndex = 10;
            // 
            // ManeuverTimePanel
            // 
            this.ManeuverTimePanel.Controls.Add(this.ManeuverTimeInputLabel);
            this.ManeuverTimePanel.Controls.Add(this.ManeuverTimeInput);
            this.ManeuverTimePanel.Location = new System.Drawing.Point(62, 122);
            this.ManeuverTimePanel.Name = "ManeuverTimePanel";
            this.ManeuverTimePanel.Size = new System.Drawing.Size(306, 36);
            this.ManeuverTimePanel.TabIndex = 5;
            // 
            // ManeuverAltitudeStartPanel
            // 
            this.ManeuverAltitudeStartPanel.Controls.Add(this.ManeuverAltitudeStartLabel);
            this.ManeuverAltitudeStartPanel.Controls.Add(this.ManeuverAltitudeStartInput);
            this.ManeuverAltitudeStartPanel.Location = new System.Drawing.Point(62, 207);
            this.ManeuverAltitudeStartPanel.Name = "ManeuverAltitudeStartPanel";
            this.ManeuverAltitudeStartPanel.Size = new System.Drawing.Size(306, 36);
            this.ManeuverAltitudeStartPanel.TabIndex = 5;
            // 
            // ManeuverAltitudeEndPanel
            // 
            this.ManeuverAltitudeEndPanel.Controls.Add(this.ManeuverAltitudeEndLabel);
            this.ManeuverAltitudeEndPanel.Controls.Add(this.ManeuverAltitudeEndInput);
            this.ManeuverAltitudeEndPanel.Location = new System.Drawing.Point(62, 248);
            this.ManeuverAltitudeEndPanel.Name = "ManeuverAltitudeEndPanel";
            this.ManeuverAltitudeEndPanel.Size = new System.Drawing.Size(306, 36);
            this.ManeuverAltitudeEndPanel.TabIndex = 5;
            // 
            // ManeuverSpeedPanel
            // 
            this.ManeuverSpeedPanel.Controls.Add(this.ManeuverSpeedLabel);
            this.ManeuverSpeedPanel.Controls.Add(this.ManeuverSpeedInput);
            this.ManeuverSpeedPanel.Location = new System.Drawing.Point(62, 164);
            this.ManeuverSpeedPanel.Name = "ManeuverSpeedPanel";
            this.ManeuverSpeedPanel.Size = new System.Drawing.Size(306, 36);
            this.ManeuverSpeedPanel.TabIndex = 5;
            // 
            // ManeuverDistancePanel
            // 
            this.ManeuverDistancePanel.Controls.Add(this.ManeuverDistanceLabel);
            this.ManeuverDistancePanel.Controls.Add(this.ManeuverDistanceInput);
            this.ManeuverDistancePanel.Location = new System.Drawing.Point(63, 206);
            this.ManeuverDistancePanel.Name = "ManeuverDistancePanel";
            this.ManeuverDistancePanel.Size = new System.Drawing.Size(306, 36);
            this.ManeuverDistancePanel.TabIndex = 5;
            // 
            // ManeuverTypePanel
            // 
            this.ManeuverTypePanel.Controls.Add(this.label1);
            this.ManeuverTypePanel.Controls.Add(this.ManeuverTypeInput);
            this.ManeuverTypePanel.Location = new System.Drawing.Point(62, 38);
            this.ManeuverTypePanel.Name = "ManeuverTypePanel";
            this.ManeuverTypePanel.Size = new System.Drawing.Size(306, 36);
            this.ManeuverTypePanel.TabIndex = 5;
            // 
            // ManeuverInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 424);
            this.Controls.Add(this.ManeuverTimePanel);
            this.Controls.Add(this.FuelConsumptionValuePanel);
            this.Controls.Add(this.ManeuverAltitudeStartPanel);
            this.Controls.Add(this.ManeuverAltitudeEndPanel);
            this.Controls.Add(this.ManeuverSpeedPanel);
            this.Controls.Add(this.ManeuverDistancePanel);
            this.Controls.Add(this.ManeuverTypePanel);
            this.Controls.Add(this.button1);
            this.Name = "ManeuverInsertForm";
            this.Text = "ManeuverInsertForm";
            ((System.ComponentModel.ISupportInitialize)(this.FuelConsumptionValueInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverAltitudeStartInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverAltitudeEndInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverSpeedInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManeuverDistanceInput)).EndInit();
            this.FuelConsumptionValuePanel.ResumeLayout(false);
            this.FuelConsumptionValuePanel.PerformLayout();
            this.ManeuverTimePanel.ResumeLayout(false);
            this.ManeuverTimePanel.PerformLayout();
            this.ManeuverAltitudeStartPanel.ResumeLayout(false);
            this.ManeuverAltitudeStartPanel.PerformLayout();
            this.ManeuverAltitudeEndPanel.ResumeLayout(false);
            this.ManeuverAltitudeEndPanel.PerformLayout();
            this.ManeuverSpeedPanel.ResumeLayout(false);
            this.ManeuverSpeedPanel.PerformLayout();
            this.ManeuverDistancePanel.ResumeLayout(false);
            this.ManeuverDistancePanel.PerformLayout();
            this.ManeuverTypePanel.ResumeLayout(false);
            this.ManeuverTypePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ManeuverTypeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown FuelConsumptionValueInput;
        private System.Windows.Forms.Label FuelConsumptionValueLabel;
        private System.Windows.Forms.Label ManeuverTimeInputLabel;
        private System.Windows.Forms.Label ManeuverAltitudeStartLabel;
        private System.Windows.Forms.Label ManeuverAltitudeEndLabel;
        private System.Windows.Forms.Label ManeuverSpeedLabel;
        private System.Windows.Forms.Label ManeuverDistanceLabel;
        private System.Windows.Forms.NumericUpDown ManeuverTimeInput;
        private System.Windows.Forms.NumericUpDown ManeuverAltitudeStartInput;
        private System.Windows.Forms.NumericUpDown ManeuverAltitudeEndInput;
        private System.Windows.Forms.NumericUpDown ManeuverSpeedInput;
        private System.Windows.Forms.NumericUpDown ManeuverDistanceInput;
        private System.Windows.Forms.Panel FuelConsumptionValuePanel;
        private System.Windows.Forms.Panel ManeuverTimePanel;
        private System.Windows.Forms.Panel ManeuverAltitudeStartPanel;
        private System.Windows.Forms.Panel ManeuverAltitudeEndPanel;
        private System.Windows.Forms.Panel ManeuverSpeedPanel;
        private System.Windows.Forms.Panel ManeuverDistancePanel;
        private System.Windows.Forms.Panel ManeuverTypePanel;
    }
}