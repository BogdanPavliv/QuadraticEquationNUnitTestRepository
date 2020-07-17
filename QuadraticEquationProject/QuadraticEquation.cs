using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationProject
{
    public class QuadraticEquation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public QuadraticEquation(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public string Discriminant()
        {
            double D = 0;
            string actualResult = string.Empty;

            if (A != 0)
            {
                D = Math.Pow(B, 2) - 4 * A * C;
                if (D < 0)
                {
                    actualResult += "Рівняння немає коренів";
                }
                else if (D == 0)
                {
                    if (-B / (2 * A) % 1 == 0)
                        actualResult += string.Format("x = {0}", -B / (2 * A));
                    else
                        actualResult += string.Format("x = {0}/{1}", -B, 2 * A);
                }
                else if (D > 0)
                {
                    if (((-B + Math.Sqrt(D)) / (2 * A)) % 1 == 0)
                        actualResult += string.Format("x1 = {0}, ", (-B + Math.Sqrt(D)) / (2 * A));
                    else
                        actualResult += string.Format("x1 = {0}/{1}, ", (-B + Math.Sqrt(D)), A * 2);
                    if (((-B - Math.Sqrt(D)) / (2 * A)) % 1 == 0)
                        actualResult += string.Format("x2 = {0}", (-B - Math.Sqrt(D)) / (2 * A));
                    else
                        actualResult += string.Format("x2 = {0}/{1}", (-B - Math.Sqrt(D)), A * 2);
                }
            }
            else
                actualResult += "Корені рівняння задані не вірно";

            return actualResult;
        }

    }
}
