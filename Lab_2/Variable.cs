using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Variable
    {
        // интерфейс для любой случайной величины
        public interface RandomVariable
        {
            // плотность вероятности в точке x
            public double pdf(double x);

            // интегральная функция распределения в точке x
            public double cdf(double x);

            // квантиль уровня alpha
            public double quantile(double alpha);
        }

        // класс равномерной случайной величины
        public class UniformRandomVariable : RandomVariable
        {
            // левая и правая граница непрерывного равномерного распределения
            private double left, right;

            public UniformRandomVariable(double _left, double _right)
            {
                this.left = _left;
                this.right = _right;
            }

            public double pdf(double x)
            {
                if (x < this.left && x > this.right)
                    return 0.0;
                else
                    return 1.0 / (this.right - this.left);
            }

            public double cdf(double x)
            {
                if (x < this.left)
                    return 0.0;
                else if (x >= this.left && x < this.right)
                    return (x - this.left) / (this.right - this.left);
                else
                    return 1.0;
            }

            public double quantile(double alpha)
            {
                return alpha * (this.right - this.left) + this.left;
            }
        }

        // класс нормальной случайной величины
        public class NormalRandomVariable : RandomVariable
        {
            // параметры сдвига и масштаба нормального распределения
            private double location, scale;

            public NormalRandomVariable(double _location, double _scale)
            {
                this.location = _location;
                this.scale = _scale;
            }

            public double pdf(double x)
            {
                double z = (x - location) / scale;
                return Math.Exp(-0.5 * z * z) / (Math.Sqrt(2 * Math.PI) * scale);
            }

            public double cdf(double x)
            {
                double z = (x - location) / scale;
                if( z <= 0 )
                {
                    return 0.852 * Math.Exp(-Math.Pow((-z + 1.5774) / 2.0637, 2.34));
                }
                return 1 - 0.852 * Math.Exp(-Math.Pow((z + 1.5774) / 2.0637, 2.34));
            }

            public double quantile(double alpha)
            {
                return location + 4.91 * scale * (Math.Pow(alpha, 0.14) - Math.Pow(1 - alpha, 0.14));
            }
        }

        // класс экспоненциальной случайной величины
        public class ExponentialRandomVariable : RandomVariable
        {
            // параметр интенсивности (обратный коэффициент масштаба) экспоненциального распределения
            private double intensity;

            public ExponentialRandomVariable(double _intensity)
            {
                this.intensity = _intensity;
            }

            public double pdf(double x)
            {
                if (x >= 0)
                {
                    return intensity * Math.Exp(-intensity * x);
                }
                return 0;
            }

            public double cdf(double x)
            {
                if (x >= 0)
                {
                    return 1 - Math.Exp(-intensity * x);
                }
                return 0;
            }

            public double quantile(double alpha)
            {
                return - Math.Log(1 - alpha) / intensity;
            }
        }

        // класс двойной экспоненциальной случайной величины (распределение Лапласа)
        public class LaplaceRandomVariable : RandomVariable
        {
            // параметры сдвига и масштаба распределения Лапласа
            private double location, scale;

            public LaplaceRandomVariable(double _location, double _scale)
            {
                this.location = _location;
                this.scale = _scale;
            }

            public double pdf(double x)
            {
                return 0.5 * scale * Math.Exp(-scale * Math.Abs(x - location));
            }

            public double cdf(double x)
            {
                if (x <= location)
                {
                    return 0.5 * Math.Exp( scale * (x - location));
                }
                return 1 - 0.5 * Math.Exp( - scale * (x - location));
            }

            public double quantile(double alpha)
            {
                double x = location + Math.Log(alpha * 2) / scale;
                if (x <= location)
                {
                    return x;
                }
                return location - Math.Log(2 - alpha * 2) / scale;
            }
        }

        // класс случайной величины распределения Коши
        public class CauchyRandomVariable : RandomVariable
        {
            // параметры сдвига и масштаба распределения Лапласа
            private double location, scale;

            public CauchyRandomVariable(double _location, double _scale)
            {
                this.location = _location;
                this.scale = _scale;
            }

            public double pdf(double x)
            {
                return scale / (Math.PI * (Math.Pow(x - location, 2) + Math.Pow(scale, 2)));
            }

            public double cdf(double x)
            {
                return 0.5 + Math.Atan((x - location) / scale) / Math.PI;
            }

            public double quantile(double alpha)
            {
                return location + scale * Math.Tan(Math.PI * (alpha - 0.5));
            }
        }
    }
}
