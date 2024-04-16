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
            private long left, right;

            public UniformRandomVariable(long _left, long _right)
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
    }
}
