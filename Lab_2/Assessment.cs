using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Assessment
    {
        // класс для всех оценок
        public abstract class Estimation
        {
            protected List<double> array;
            public Estimation(List<double> array)
            {
                this.array = array;
            }
        }

        // эмпирическая функция распределения
        public class EDF : Estimation
        {
            new List<double> array;
            public EDF(List<double> array)
                : base(array)
            {
                this.array = array;
            }

            public int heaviside_function(double x)
            {
                if (x > 0)
                    return 1;
                else
                    return 0;
            }
            public double value(double x) 
            {
                double summ = 0;
                for(int i=0; i < array.Count(); i++)
                {
                    summ += heaviside_function(x - array[i]);
                }
                return summ/ array.Count();
            }
        }

        // непараметрическая случайная величина
        public class SmoothedRandomVariable : Assessment.Estimation, Variable.RandomVariable
        {
            double k(double x)
            {
                if (Math.Abs(x) >= 1)
                {
                    return 0;
                }
                else
                {
                    return 0.5;
                }
            }

            double K(double x)
            {
                if (x < -1)
                {
                    return 0;
                }
                else if (-1 <= x && x < 1)
                {
                    return (x+1) / 2;
                }
                else
                {
                    return 1;
                }
            }

            // значение параметра размытости
            double h;

            public SmoothedRandomVariable(List<double> array, double h)
                : base(array)
            {
                this.h = h;
            }

            public double pdf(double x)
            {
                double mean = 0;
                for (int i = 0; i < array.Count(); i++)
                {
                    mean += k((x - array[i]) / h);
                }
                return mean / (array.Count() * h);
            }

            public double cdf(double x)
            {
                double mean = 0;
                for (int i = 0; i < array.Count(); i++)
                {
                    mean += K((x - array[i]) / h);
                }
                return mean / array.Count();
            }

            public double quantile(double alpha)
            {
                return 0.0;
            }
        }

        // гистограмма
        public class Histogram : Estimation
        {
            protected class Interval
            {
                double a;
                double b;
                public Interval(double a, double b)
                {
                    this.a = a;
                    this.b = b;
                }

                public bool is_in(double x)
                {
                    return x >= this.a && x <= this.b;
                }
            }

            // количество подинтервалов
            int m;
            public Histogram(List<double> array, int m)
                : base(array)
            {
                this.m = m;
                construct_intervals();
            }

            double left_boundary_of_intervals;
            double right_boundary_of_intervals;

            // массив с границами каждого из интервалов
            List<(double, double, double)> intervals;

            private void construct_intervals()
            {
                left_boundary_of_intervals = array[0];
                right_boundary_of_intervals = array[array.Count() - 1];

                // вычисляем размах значений выборки
                double range = right_boundary_of_intervals - left_boundary_of_intervals;

                // длина каждого из интервалов
                double length_interval = range / m;

                // массив с подинтервалами (левая граница, правая граница и количество элементов внутри подинтервала)
                intervals = new List<(double, double, double)>(m);

                // задаем правые и левые границы подинтервалов
                for (int i = 0; i < m; i++)
                {
                    intervals.Add((left_boundary_of_intervals + i * length_interval, left_boundary_of_intervals + (i + 1) * length_interval, 0));
                }

                // формируем высоты интервалов
                // перебор подинтервалов
                int j = 0;
                for (int i = 0; i < m; i++)
                {
                    int count = 0;
                    Interval interval = new Interval(intervals[i].Item1, intervals[i].Item2);
                    // поиск количества элементов входящих в подинтервал
                    for (; j < array.Count(); j++)
                    {
                        if (interval.is_in(array[j]))
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    intervals[i] = (intervals[i].Item1, intervals[i].Item2, (double)count / (((double)array.Count()) * length_interval));
                }
            }


            public double Value(double x)
            {
                for (int i = 0; i < m; ++i)
                {
                    Interval interval = new Interval(intervals[i].Item1, intervals[i].Item2);
                    if (interval.is_in(x))
                    {
                        return intervals[i].Item3;
                    }
                }
                return 0;
            }
        }

    }
}
