namespace Lab_2
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioCauchy = new System.Windows.Forms.RadioButton();
            this.radioLaplace = new System.Windows.Forms.RadioButton();
            this.radioUniform = new System.Windows.Forms.RadioButton();
            this.radioExponential = new System.Windows.Forms.RadioButton();
            this.numericUpDown_N = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label_par1 = new System.Windows.Forms.Label();
            this.numericUpDown_par1 = new System.Windows.Forms.NumericUpDown();
            this.label_par2 = new System.Windows.Forms.Label();
            this.numericUpDown_par2 = new System.Windows.Forms.NumericUpDown();
            this.chart_pdf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_cdf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_calculation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_bandwidth = new System.Windows.Forms.Label();
            this.numericUpDown_bandwidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_m = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_par1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_par2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bandwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_m)).BeginInit();
            this.SuspendLayout();
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioNormal.Location = new System.Drawing.Point(22, 115);
            this.radioNormal.Margin = new System.Windows.Forms.Padding(4);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(117, 22);
            this.radioNormal.TabIndex = 2;
            this.radioNormal.Text = "Нормальный";
            this.radioNormal.UseVisualStyleBackColor = true;
            this.radioNormal.CheckedChanged += new System.EventHandler(this.radioNormal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Законы распределения";
            // 
            // radioCauchy
            // 
            this.radioCauchy.AutoSize = true;
            this.radioCauchy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioCauchy.Location = new System.Drawing.Point(22, 232);
            this.radioCauchy.Margin = new System.Windows.Forms.Padding(4);
            this.radioCauchy.Name = "radioCauchy";
            this.radioCauchy.Size = new System.Drawing.Size(64, 22);
            this.radioCauchy.TabIndex = 5;
            this.radioCauchy.TabStop = true;
            this.radioCauchy.Text = "Коши";
            this.radioCauchy.UseVisualStyleBackColor = true;
            this.radioCauchy.CheckedChanged += new System.EventHandler(this.radioCauchy_CheckedChanged);
            // 
            // radioLaplace
            // 
            this.radioLaplace.AutoSize = true;
            this.radioLaplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioLaplace.Location = new System.Drawing.Point(22, 192);
            this.radioLaplace.Margin = new System.Windows.Forms.Padding(4);
            this.radioLaplace.Name = "radioLaplace";
            this.radioLaplace.Size = new System.Drawing.Size(86, 22);
            this.radioLaplace.TabIndex = 4;
            this.radioLaplace.TabStop = true;
            this.radioLaplace.Text = "Лапласа";
            this.radioLaplace.UseVisualStyleBackColor = true;
            this.radioLaplace.CheckedChanged += new System.EventHandler(this.radioLaplace_CheckedChanged);
            // 
            // radioUniform
            // 
            this.radioUniform.AutoSize = true;
            this.radioUniform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioUniform.Location = new System.Drawing.Point(22, 76);
            this.radioUniform.Margin = new System.Windows.Forms.Padding(4);
            this.radioUniform.Name = "radioUniform";
            this.radioUniform.Size = new System.Drawing.Size(123, 22);
            this.radioUniform.TabIndex = 1;
            this.radioUniform.Text = "Равномерный";
            this.radioUniform.UseVisualStyleBackColor = true;
            this.radioUniform.CheckedChanged += new System.EventHandler(this.radioUniform_CheckedChanged);
            // 
            // radioExponential
            // 
            this.radioExponential.AutoSize = true;
            this.radioExponential.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioExponential.Location = new System.Drawing.Point(22, 154);
            this.radioExponential.Margin = new System.Windows.Forms.Padding(4);
            this.radioExponential.Name = "radioExponential";
            this.radioExponential.Size = new System.Drawing.Size(162, 22);
            this.radioExponential.TabIndex = 3;
            this.radioExponential.TabStop = true;
            this.radioExponential.Text = "Экспоненциальный";
            this.radioExponential.UseVisualStyleBackColor = true;
            this.radioExponential.CheckedChanged += new System.EventHandler(this.radioExponential_CheckedChanged);
            // 
            // numericUpDown_N
            // 
            this.numericUpDown_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_N.Location = new System.Drawing.Point(431, 58);
            this.numericUpDown_N.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_N.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_N.Name = "numericUpDown_N";
            this.numericUpDown_N.Size = new System.Drawing.Size(112, 24);
            this.numericUpDown_N.TabIndex = 6;
            this.numericUpDown_N.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(426, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выборка";
            // 
            // label_par1
            // 
            this.label_par1.AutoSize = true;
            this.label_par1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_par1.Location = new System.Drawing.Point(426, 196);
            this.label_par1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_par1.Name = "label_par1";
            this.label_par1.Size = new System.Drawing.Size(55, 18);
            this.label_par1.TabIndex = 12;
            this.label_par1.Text = "Сдвиг";
            // 
            // numericUpDown_par1
            // 
            this.numericUpDown_par1.DecimalPlaces = 2;
            this.numericUpDown_par1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_par1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_par1.Location = new System.Drawing.Point(431, 225);
            this.numericUpDown_par1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_par1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_par1.Name = "numericUpDown_par1";
            this.numericUpDown_par1.Size = new System.Drawing.Size(112, 24);
            this.numericUpDown_par1.TabIndex = 7;
            this.numericUpDown_par1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label_par2
            // 
            this.label_par2.AutoSize = true;
            this.label_par2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_par2.Location = new System.Drawing.Point(426, 115);
            this.label_par2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_par2.Name = "label_par2";
            this.label_par2.Size = new System.Drawing.Size(79, 18);
            this.label_par2.TabIndex = 13;
            this.label_par2.Text = "Масштаб";
            // 
            // numericUpDown_par2
            // 
            this.numericUpDown_par2.DecimalPlaces = 2;
            this.numericUpDown_par2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_par2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_par2.Location = new System.Drawing.Point(431, 144);
            this.numericUpDown_par2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_par2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_par2.Name = "numericUpDown_par2";
            this.numericUpDown_par2.Size = new System.Drawing.Size(112, 24);
            this.numericUpDown_par2.TabIndex = 8;
            this.numericUpDown_par2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chart_pdf
            // 
            chartArea21.Name = "ChartArea1";
            this.chart_pdf.ChartAreas.Add(chartArea21);
            this.chart_pdf.Location = new System.Drawing.Point(13, 307);
            this.chart_pdf.Margin = new System.Windows.Forms.Padding(4);
            this.chart_pdf.Name = "chart_pdf";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.chart_pdf.Series.Add(series21);
            this.chart_pdf.Size = new System.Drawing.Size(458, 374);
            this.chart_pdf.TabIndex = 16;
            this.chart_pdf.TabStop = false;
            this.chart_pdf.Text = "chart_pdf";
            // 
            // chart_cdf
            // 
            chartArea22.Name = "ChartArea1";
            this.chart_cdf.ChartAreas.Add(chartArea22);
            this.chart_cdf.Location = new System.Drawing.Point(479, 307);
            this.chart_cdf.Margin = new System.Windows.Forms.Padding(4);
            this.chart_cdf.Name = "chart_cdf";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Name = "Series1";
            this.chart_cdf.Series.Add(series22);
            this.chart_cdf.Size = new System.Drawing.Size(466, 374);
            this.chart_cdf.TabIndex = 17;
            this.chart_cdf.TabStop = false;
            this.chart_cdf.Text = "chart_cdf";
            // 
            // button_calculation
            // 
            this.button_calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_calculation.Location = new System.Drawing.Point(680, 228);
            this.button_calculation.Margin = new System.Windows.Forms.Padding(4);
            this.button_calculation.Name = "button_calculation";
            this.button_calculation.Size = new System.Drawing.Size(122, 37);
            this.button_calculation.TabIndex = 9;
            this.button_calculation.Text = "Расчет";
            this.button_calculation.UseVisualStyleBackColor = true;
            this.button_calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(160, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Плотность вероятности";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(612, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Функция распределения";
            // 
            // label_bandwidth
            // 
            this.label_bandwidth.AutoSize = true;
            this.label_bandwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_bandwidth.Location = new System.Drawing.Point(588, 29);
            this.label_bandwidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_bandwidth.Name = "label_bandwidth";
            this.label_bandwidth.Size = new System.Drawing.Size(194, 18);
            this.label_bandwidth.TabIndex = 19;
            this.label_bandwidth.Text = "Параметра размытости";
            // 
            // numericUpDown_bandwidth
            // 
            this.numericUpDown_bandwidth.DecimalPlaces = 2;
            this.numericUpDown_bandwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_bandwidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_bandwidth.Location = new System.Drawing.Point(593, 58);
            this.numericUpDown_bandwidth.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_bandwidth.Name = "numericUpDown_bandwidth";
            this.numericUpDown_bandwidth.Size = new System.Drawing.Size(112, 24);
            this.numericUpDown_bandwidth.TabIndex = 18;
            this.numericUpDown_bandwidth.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(588, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Количество подинтервалов";
            // 
            // numericUpDown_m
            // 
            this.numericUpDown_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_m.Location = new System.Drawing.Point(593, 144);
            this.numericUpDown_m.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_m.Name = "numericUpDown_m";
            this.numericUpDown_m.Size = new System.Drawing.Size(112, 24);
            this.numericUpDown_m.TabIndex = 20;
            this.numericUpDown_m.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(958, 694);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_m);
            this.Controls.Add(this.label_bandwidth);
            this.Controls.Add(this.numericUpDown_bandwidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_calculation);
            this.Controls.Add(this.chart_cdf);
            this.Controls.Add(this.chart_pdf);
            this.Controls.Add(this.label_par2);
            this.Controls.Add(this.numericUpDown_par2);
            this.Controls.Add(this.label_par1);
            this.Controls.Add(this.numericUpDown_par1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_N);
            this.Controls.Add(this.radioExponential);
            this.Controls.Add(this.radioUniform);
            this.Controls.Add(this.radioLaplace);
            this.Controls.Add(this.radioCauchy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioNormal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Лабораторная 2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_par1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_par2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bandwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCauchy;
        private System.Windows.Forms.RadioButton radioLaplace;
        private System.Windows.Forms.RadioButton radioUniform;
        private System.Windows.Forms.RadioButton radioExponential;
        private System.Windows.Forms.NumericUpDown numericUpDown_N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_par1;
        private System.Windows.Forms.NumericUpDown numericUpDown_par1;
        private System.Windows.Forms.Label label_par2;
        private System.Windows.Forms.NumericUpDown numericUpDown_par2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pdf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cdf;
        private System.Windows.Forms.Button button_calculation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_bandwidth;
        private System.Windows.Forms.NumericUpDown numericUpDown_bandwidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_m;
    }
}

