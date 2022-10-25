namespace SatelliteFuelSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hoverGrid = new System.Windows.Forms.DataGridView();
            this.riseGrid = new System.Windows.Forms.DataGridView();
            this.descentGrid = new System.Windows.Forms.DataGridView();
            this.cruiseGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hoverGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(743, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 109);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yeni Manevra Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(696, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uydu Görev Yakıt Tüketim Hesap Sistemi";
            // 
            // hoverGrid
            // 
            this.hoverGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hoverGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.hoverGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.hoverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoverGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.hoverGrid.Location = new System.Drawing.Point(112, 118);
            this.hoverGrid.Name = "hoverGrid";
            this.hoverGrid.RowHeadersVisible = false;
            this.hoverGrid.RowTemplate.Height = 25;
            this.hoverGrid.Size = new System.Drawing.Size(600, 150);
            this.hoverGrid.TabIndex = 0;
            // 
            // riseGrid
            // 
            this.riseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.riseGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.riseGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.riseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.riseGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.riseGrid.Location = new System.Drawing.Point(1030, 118);
            this.riseGrid.Name = "riseGrid";
            this.riseGrid.RowHeadersVisible = false;
            this.riseGrid.RowTemplate.Height = 25;
            this.riseGrid.Size = new System.Drawing.Size(600, 150);
            this.riseGrid.TabIndex = 0;
            // 
            // descentGrid
            // 
            this.descentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.descentGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.descentGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.descentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descentGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.descentGrid.Location = new System.Drawing.Point(112, 377);
            this.descentGrid.Name = "descentGrid";
            this.descentGrid.RowHeadersVisible = false;
            this.descentGrid.RowTemplate.Height = 25;
            this.descentGrid.Size = new System.Drawing.Size(600, 150);
            this.descentGrid.TabIndex = 0;
            // 
            // cruiseGrid
            // 
            this.cruiseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cruiseGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cruiseGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cruiseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cruiseGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cruiseGrid.Location = new System.Drawing.Point(1030, 377);
            this.cruiseGrid.Name = "cruiseGrid";
            this.cruiseGrid.RowHeadersVisible = false;
            this.cruiseGrid.RowTemplate.Height = 25;
            this.cruiseGrid.Size = new System.Drawing.Size(600, 150);
            this.cruiseGrid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(306, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Askıda Uçuş Manevra Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1236, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = " Yükselme Manevra Listesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(306, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alçalma Manevra Listesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1236, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Düz Uçuş Manevra Listesi";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(743, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 109);
            this.button2.TabIndex = 1;
            this.button2.Text = "Görevi Tamamla !";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Toplam Yakıt Tüketimi = ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(402, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 43);
            this.textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(551, 726);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 100);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 887);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cruiseGrid);
            this.Controls.Add(this.riseGrid);
            this.Controls.Add(this.descentGrid);
            this.Controls.Add(this.hoverGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.hoverGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView hoverGrid;
        private System.Windows.Forms.DataGridView riseGrid;
        private System.Windows.Forms.DataGridView descentGrid;
        private System.Windows.Forms.DataGridView cruiseGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
