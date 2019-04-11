namespace TA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSmallRoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataDriver = new System.Windows.Forms.DataGridView();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBoxMap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(298, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 583);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Map";
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMap.Location = new System.Drawing.Point(24, 59);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(996, 512);
            this.pictureBoxMap.TabIndex = 4;
            this.pictureBoxMap.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSmallRoad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 239);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonSmallRoad
            // 
            this.buttonSmallRoad.Location = new System.Drawing.Point(218, 23);
            this.buttonSmallRoad.Name = "buttonSmallRoad";
            this.buttonSmallRoad.Size = new System.Drawing.Size(75, 23);
            this.buttonSmallRoad.TabIndex = 0;
            this.buttonSmallRoad.Text = "ok";
            this.buttonSmallRoad.UseVisualStyleBackColor = true;
            this.buttonSmallRoad.Click += new System.EventHandler(this.buttonSmallRoad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataDriver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 344);
            this.panel1.TabIndex = 4;
            // 
            // dataDriver
            // 
            this.dataDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDriver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverName,
            this.StationA,
            this.StationB,
            this.Speed,
            this.Fuel});
            this.dataDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDriver.Location = new System.Drawing.Point(0, 20);
            this.dataDriver.Name = "dataDriver";
            this.dataDriver.Size = new System.Drawing.Size(298, 324);
            this.dataDriver.TabIndex = 13;
            // 
            // DriverName
            // 
            this.DriverName.HeaderText = "Name";
            this.DriverName.Name = "DriverName";
            // 
            // StationA
            // 
            this.StationA.HeaderText = "A";
            this.StationA.Name = "StationA";
            this.StationA.Width = 30;
            // 
            // StationB
            // 
            this.StationB.HeaderText = "B";
            this.StationB.Name = "StationB";
            this.StationB.Width = 30;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            this.Speed.Width = 50;
            // 
            // Fuel
            // 
            this.Fuel.HeaderText = "Fuel";
            this.Fuel.Name = "Fuel";
            this.Fuel.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Driver list";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationA;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSmallRoad;
    }
}

