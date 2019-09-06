namespace Сортировки_пузырьком_и_выборкой
{
    partial class GraphView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphView));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rIncrease = new System.Windows.Forms.RadioButton();
            this.rDecrease = new System.Windows.Forms.RadioButton();
            this.rRandom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rChoice = new System.Windows.Forms.RadioButton();
            this.rBubble = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rMerge = new System.Windows.Forms.RadioButton();
            this.rQuick = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rIncrease);
            this.groupBox2.Controls.Add(this.rDecrease);
            this.groupBox2.Controls.Add(this.rRandom);
            this.groupBox2.Location = new System.Drawing.Point(12, 498);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 75);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор полседовательноси чисел для графика";
            // 
            // rIncrease
            // 
            this.rIncrease.AutoSize = true;
            this.rIncrease.Location = new System.Drawing.Point(229, 20);
            this.rIncrease.Name = "rIncrease";
            this.rIncrease.Size = new System.Drawing.Size(158, 19);
            this.rIncrease.TabIndex = 3;
            this.rIncrease.Text = "Возрастающая полед.";
            this.rIncrease.UseVisualStyleBackColor = true;
            // 
            // rDecrease
            // 
            this.rDecrease.AutoSize = true;
            this.rDecrease.Location = new System.Drawing.Point(6, 45);
            this.rDecrease.Name = "rDecrease";
            this.rDecrease.Size = new System.Drawing.Size(137, 19);
            this.rDecrease.TabIndex = 2;
            this.rDecrease.Text = "Убывающая полед.";
            this.rDecrease.UseVisualStyleBackColor = true;
            // 
            // rRandom
            // 
            this.rRandom.AutoSize = true;
            this.rRandom.Checked = true;
            this.rRandom.Location = new System.Drawing.Point(6, 20);
            this.rRandom.Name = "rRandom";
            this.rRandom.Size = new System.Drawing.Size(88, 19);
            this.rRandom.TabIndex = 1;
            this.rRandom.TabStop = true;
            this.rRandom.Text = "Случайные";
            this.rRandom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rMerge);
            this.groupBox1.Controls.Add(this.rQuick);
            this.groupBox1.Controls.Add(this.rChoice);
            this.groupBox1.Controls.Add(this.rBubble);
            this.groupBox1.Location = new System.Drawing.Point(12, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 79);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор алгоритма для графика";
            // 
            // rChoice
            // 
            this.rChoice.AutoSize = true;
            this.rChoice.Location = new System.Drawing.Point(127, 25);
            this.rChoice.Name = "rChoice";
            this.rChoice.Size = new System.Drawing.Size(81, 19);
            this.rChoice.TabIndex = 1;
            this.rChoice.Text = "Выборкой";
            this.rChoice.UseVisualStyleBackColor = true;
            // 
            // rBubble
            // 
            this.rBubble.AutoSize = true;
            this.rBubble.Checked = true;
            this.rBubble.Location = new System.Drawing.Point(6, 25);
            this.rBubble.Name = "rBubble";
            this.rBubble.Size = new System.Drawing.Size(88, 19);
            this.rBubble.TabIndex = 0;
            this.rBubble.TabStop = true;
            this.rBubble.Text = "Пузырьком";
            this.rBubble.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Изобразить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            chartArea1.AxisX.Minimum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(389, 395);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График";
            this.chart1.Titles.Add(title1);
            // 
            // rMerge
            // 
            this.rMerge.AutoSize = true;
            this.rMerge.Location = new System.Drawing.Point(127, 50);
            this.rMerge.Name = "rMerge";
            this.rMerge.Size = new System.Drawing.Size(74, 19);
            this.rMerge.TabIndex = 3;
            this.rMerge.Text = "Слияние";
            this.rMerge.UseVisualStyleBackColor = true;
            // 
            // rQuick
            // 
            this.rQuick.AutoSize = true;
            this.rQuick.Location = new System.Drawing.Point(6, 50);
            this.rQuick.Name = "rQuick";
            this.rQuick.Size = new System.Drawing.Size(74, 19);
            this.rQuick.TabIndex = 2;
            this.rQuick.Text = "Быстрая";
            this.rQuick.UseVisualStyleBackColor = true;
            // 
            // GraphView
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 585);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GraphView";
            this.Text = "График алгоритмов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphView_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rIncrease;
        private System.Windows.Forms.RadioButton rDecrease;
        private System.Windows.Forms.RadioButton rRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rChoice;
        private System.Windows.Forms.RadioButton rBubble;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rMerge;
        private System.Windows.Forms.RadioButton rQuick;
    }
}