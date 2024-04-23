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
            chart_cdf.Series.Clear();
            chart_pdf.Series.Clear();

            // размер выборки
            int N = (int)numericUpDown_N.Value;

            // параметры
            double par1 = (double)numericUpDown_par1.Value;
            double par2 = (double)numericUpDown_par2.Value;

            // объект класса случайной величины
            Variable.RandomVariable obj;

            if (radioUniform.Checked == true)
            { 
                obj = new Variable.UniformRandomVariable(par2, par1);
                calculation(obj, N);
            }
            else if (radioNormal.Checked == true)
            {
                obj = new Variable.NormalRandomVariable(par1, par2);
                calculation(obj, N);
            }
            else if (radioExponential.Checked == true)
            {
                obj = new Variable.ExponentialRandomVariable(par2);
                calculation(obj, N);
            }
            else if (radioLaplace.Checked == true)
            {
                obj = new Variable.LaplaceRandomVariable(par1, par2);
                calculation(obj, N);
            }
            else if (radioCauchy.Checked == true)
            {
                obj = new Variable.CauchyRandomVariable(par1, par2);
                calculation(obj, N);
            }
        }

        private void radioUniform_CheckedChanged(object sender, EventArgs e)
        {
            chart_cdf.Series.Clear();
            chart_pdf.Series.Clear();
            label_par1.Text = "Правая граница";
            label_par2.Text = "Левая граница";
            numericUpDown_par1.Visible = true;
        }

        private void radioNormal_CheckedChanged(object sender, EventArgs e)
        {
            chart_cdf.Series.Clear();
            chart_pdf.Series.Clear();
            label_par1.Text = "Сдвиг";
            label_par2.Text = "Масштаб";
            numericUpDown_par1.Visible = true;
        }

        private void radioExponential_CheckedChanged(object sender, EventArgs e)
        {
            chart_cdf.Series.Clear();
            chart_pdf.Series.Clear();
            label_par2.Text = "Интенсивность";
            label_par1.Text = "";
            numericUpDown_par1.Visible = false;
        }

        private void radioLaplace_CheckedChanged(object sender, EventArgs e)
        {
            chart_cdf.Series.Clear();
            chart_pdf.Series.Clear();
            label_par1.Text = "Сдвиг";
            label_par2.Text = "Масштаб";
            numericUpDown_par1.Visible = true;
        }

        private void radioCauchy_CheckedChanged(object sender, EventArgs e)
        {
            chart_cdf.Series.Clear();
            chart_pdf.Series.Clear();
            label_par1.Text = "Сдвиг";
            label_par2.Text = "Масштаб";
            numericUpDown_par1.Visible = true;
        }

        private void calculation(Variable.RandomVariable variable, int N )
        {
            // выборка значений
            List<double> array;

            Generator.SimpleRandomNumberGenerator generator = new Generator.SimpleRandomNumberGenerator(variable);
            array = generator.get(N);

            // создаем сетку для графика
            array.Sort();
            int resolution = 2000;
            double grid = (double)(array.Max() - array.Min()) / (double)resolution; // по X
            List<double> X = new List<double>(N);

            // вычисляем значения функции распределения
            for (int i = 0; i < resolution; i++)
            {
                X.Add(variable.cdf(array.Min() + grid * i));
            }

            // рисуем график функции распределения
            chart_cdf.Series.Add("cdf");
            chart_cdf.Series["cdf"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_cdf.Series["cdf"].Color = Color.Red;

            for (int i = 0; i < resolution; i++)
            {
                chart_cdf.Series["cdf"].Points.AddXY(array.Min() + grid * i, X[i]);
            }

            // вычисляем значения эмпирической функции распределения
            Assessment.EDF edf = new Assessment.EDF(array);
            X.Clear();
            for (int i = 0; i < resolution; i++)
            {
                X.Add(edf.value(array.Min() + grid * i));
            }

            // рисуем график эмпирической функции распределения
            chart_cdf.Series.Add("edf");
            chart_cdf.Series["edf"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_cdf.Series["edf"].Color = Color.Blue;

            for (int i = 0; i < resolution; i++)
            {
                chart_cdf.Series["edf"].Points.AddXY(array.Min() + grid * i, X[i]);
            }

            // вычисляем значения сглаженной эмпирической функции распределения
            // параметр размытости
            double h = (double)(numericUpDown_bandwidth.Value);
            Assessment.SmoothedRandomVariable sdf = new Assessment.SmoothedRandomVariable(array, h);
            X.Clear();
            for (int i = 0; i < resolution; i++)
            {
                X.Add(sdf.cdf(array.Min() + grid * i));
            }

            // рисуем график сглаженной эмпирической функции распределения
            chart_cdf.Series.Add("esdf");
            chart_cdf.Series["esdf"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_cdf.Series["esdf"].Color = Color.Green;

            for (int i = 0; i < resolution; i++)
            {
                chart_cdf.Series["esdf"].Points.AddXY(array.Min() + grid * i, X[i]);
            }

            // вычисляем значения плотности распределения
            X.Clear();
            for (int i = 0; i < resolution; i++)
            {
                X.Add(variable.pdf(array.Min() + grid * i));
            }

            // рисуем график функции распределения
            chart_pdf.Series.Add("pdf");
            chart_pdf.Series["pdf"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_pdf.Series["pdf"].Color = Color.Red;

            for (int i = 0; i < resolution; i++)
            {
                chart_pdf.Series["pdf"].Points.AddXY(array.Min() + grid * i, X[i]);
            }

            // вычисляем значения гистограммы
            // количество подинтервалов
            int m = (int)numericUpDown_m.Value;
            Assessment.Histogram histogram = new Assessment.Histogram(array, m);
            X.Clear();
            for (int i = 0; i < resolution; i++)
            {
                X.Add(histogram.Value(array.Min() + grid * i));
            }

            // рисуем график гистограммы
            chart_pdf.Series.Add("histogram");
            chart_pdf.Series["histogram"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_pdf.Series["histogram"].Color = Color.Blue;

            for (int i = 0; i < resolution; i++)
            {
                chart_pdf.Series["histogram"].Points.AddXY(array.Min() + grid * i, X[i]);
            }

            // вычисляем значения оценки плотности Розенблатта-Парзена
            X.Clear();
            for (int i = 0; i < resolution; i++)
            {
                X.Add(sdf.pdf(array.Min() + grid * i));
            }

            // рисуем график сглаженной эмпирической функции распределения
            chart_pdf.Series.Add("R_P");
            chart_pdf.Series["R_P"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_pdf.Series["R_P"].Color = Color.Green;

            for (int i = 0; i < resolution; i++)
            {
                chart_pdf.Series["R_P"].Points.AddXY(array.Min() + grid * i, X[i]);
            }

            // настройка графиков
            chart_cdf.ChartAreas[0].AxisX.Interval = 1;
            chart_cdf.ChartAreas[0].AxisX.Minimum = Math.Floor(array.Min());
            chart_cdf.ChartAreas[0].AxisX.Maximum = Math.Ceiling(array.Max());
            chart_cdf.ChartAreas[0].AxisY.Minimum = 0;
            chart_cdf.ChartAreas[0].AxisY.Maximum = 1;

            chart_pdf.ChartAreas[0].AxisX.Interval = 1;
            chart_pdf.ChartAreas[0].AxisX.Minimum = Math.Floor(array.Min());
            chart_pdf.ChartAreas[0].AxisX.Maximum = Math.Ceiling(array.Max());
        }
    }
}
