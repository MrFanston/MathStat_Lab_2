using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            if (radioUniform.Checked == true)
            {
                chart_cdf.Series.Clear();
                chart_pdf.Series.Clear();

                int N = (int)numericUpDown_N.Value;
                int left = (int)numericUpDown_par2.Value;
                int right = (int)numericUpDown_par1.Value;
                List<double> array = new List<double>(N);

                Variable.UniformRandomVariable variable = new Variable.UniformRandomVariable(left, right);
                Generator.SimpleRandomNumberGenerator generator = new Generator.SimpleRandomNumberGenerator(variable);
                array = generator.get(N);

                // создаем сетку для графика
                array.Sort();
                int resolution = 2000;
                double grid = (double)(right - left) / (double)resolution; // по X
                List<double> X = new List<double>(N);
                
                // вычисляем значения функции распределения
                for (int i = 0; i < resolution; i++)
                {
                    X.Add(variable.cdf(left + grid * i));
                }

                // рисуем график функции распределения
                chart_cdf.Series.Add("cdf");
                chart_cdf.Series["cdf"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_cdf.Series["cdf"].Color = Color.Red;

                for (int i = 0; i < resolution; i++)
                {
                    chart_cdf.Series["cdf"].Points.AddXY(left + grid * i, X[i]);
                }

                // вычисляем значения эмпирической функции распределения
                Assessment.EDF edf = new Assessment.EDF(array);
                X.Clear();
                for (int i = 0; i < resolution; i++)
                {
                    X.Add(edf.value(left + grid * i));
                }

                // рисуем график эмпирической функции распределения
                chart_cdf.Series.Add("edf");
                chart_cdf.Series["edf"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_cdf.Series["edf"].Color = Color.Blue;

                for (int i = 0; i < resolution; i++)
                {
                    chart_cdf.Series["edf"].Points.AddXY(left + grid * i, X[i]);
                }

                // вычисляем значения сглаженной эмпирической функции распределения
                // параметр размытости
                double h = (double)(numericUpDown_bandwidth.Value) / 100.0;
                Assessment.SmoothedRandomVariable sdf = new Assessment.SmoothedRandomVariable(array, h);
                X.Clear();
                for (int i = 0; i < resolution; i++)
                {
                    X.Add(sdf.cdf(left + grid * i));
                }

                // рисуем график сглаженной эмпирической функции распределения
                chart_cdf.Series.Add("esdf");
                chart_cdf.Series["esdf"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_cdf.Series["esdf"].Color = Color.Green;

                for (int i = 0; i < resolution; i++)
                {
                    chart_cdf.Series["esdf"].Points.AddXY(left + grid * i, X[i]);
                }

                // вычисляем значения плотности распределения
                X.Clear();
                for (int i = 0; i < resolution; i++)
                {
                    X.Add(variable.pdf(left + grid * i));
                }

                // рисуем график функции распределения
                chart_pdf.Series.Add("pdf");
                chart_pdf.Series["pdf"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_pdf.Series["pdf"].Color = Color.Red;

                for (int i = 0; i < resolution; i++)
                {
                    chart_pdf.Series["pdf"].Points.AddXY(left + grid * i, X[i]);
                }

                // вычисляем значения гистограммы
                // количество подинтервалов
                int m = (int)numericUpDown_m.Value;
                Assessment.Histogram histogram = new Assessment.Histogram(array, m);
                X.Clear();
                for (int i = 0; i < resolution; i++)
                {
                    X.Add(histogram.Value(left + grid * i));
                }

                // рисуем график гистограммы
                chart_pdf.Series.Add("histogram");
                chart_pdf.Series["histogram"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_pdf.Series["histogram"].Color = Color.Blue;

                for (int i = 0; i < resolution; i++)
                {
                    chart_pdf.Series["histogram"].Points.AddXY(left + grid * i, X[i]);
                }

                // вычисляем значения оценки плотности Розенблатта-Парзена
                X.Clear();
                for (int i = 0; i < resolution; i++)
                {
                    X.Add(sdf.pdf(left + grid * i));
                }

                // рисуем график сглаженной эмпирической функции распределения
                chart_pdf.Series.Add("R_P");
                chart_pdf.Series["R_P"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_pdf.Series["R_P"].Color = Color.Green;

                for (int i = 0; i < resolution; i++)
                {
                    chart_pdf.Series["R_P"].Points.AddXY(left + grid * i, X[i]);
                }

                // настройка графиков
                chart_cdf.ChartAreas[0].AxisX.Interval = 1;
                chart_cdf.ChartAreas[0].AxisX.Minimum = left;
                chart_cdf.ChartAreas[0].AxisX.Maximum = right;
                chart_cdf.ChartAreas[0].AxisY.Minimum = 0;
                chart_cdf.ChartAreas[0].AxisY.Maximum = 1;

                chart_pdf.ChartAreas[0].AxisX.Interval = 1;
                chart_pdf.ChartAreas[0].AxisX.Minimum = left;
                chart_pdf.ChartAreas[0].AxisX.Maximum = right;
                chart_pdf.ChartAreas[0].AxisY.Minimum = 0;
                chart_pdf.ChartAreas[0].AxisY.Maximum = 1;
            }
            else if (radioNormal.Checked == true)
            {

            }
            else if (radioExponential.Checked == true)
            {

            }
            else if (radioLaplace.Checked == true)
            {

            }
            else if (radioCauchy.Checked == true)
            {

            }
        }

        private void radioUniform_CheckedChanged(object sender, EventArgs e)
        {
            label_par1.Text = "Правая граница";
            label_par2.Text = "Левая граница";
        }

        private void radioNormal_CheckedChanged(object sender, EventArgs e)
        {
            label_par1.Text = "Сдвиг";
            label_par2.Text = "Масштаб";
        }

    }
}
