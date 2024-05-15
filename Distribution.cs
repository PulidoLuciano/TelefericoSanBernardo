using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefericoSanBernardo
{
    internal class Distribution
    {

        # region CONTINUOUS Distributions.
        static public void Uniform(double a, double b, ref double x)
        {
            double aux = a;
            a = Math.Min(aux, b);
            b = Math.Max(aux, b);

            List<double> ld = GeneradorNumerosAleatorios.ParteCentralCuadrado(3, Seeder.seed(), 1);
            double u = ld[0];

            x = a + (b - a) * u;
        }

        static public void Exponential(double ex, ref double x)
        {
            List<double> ld = GeneradorNumerosAleatorios.ParteCentralCuadrado(3, Seeder.seed(), 1);
            double u = ld[0];

            x = -ex * Math.Log(u);
        }

        static public void Normal(double m, double d, ref double x)
        {
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                List<double> ld = GeneradorNumerosAleatorios.ParteCentralCuadrado(3, Seeder.seed(), 1);
                double u = ld[0];

                sum += u;
            }

            x = d * (sum - 6) + m;
        }
        #endregion

        #region DISCRETE Distributions
        static public void Binomial(double n, double p, ref double x)
        {
            x = 0;
            for (int i = 0; i < n; i++)
            {
                List<double> ld = GeneradorNumerosAleatorios.ParteCentralCuadrado(3, Seeder.seed(), 1);
                double u = ld[0];

                if (u <= p) x += 1;
            }

        }

        static public void Poisson(double a, ref double x)
        {
            double b = Math.Exp(-a);
            x = 0;
            double p = 1;
            while (p > b)
            {
                List<double> ld = GeneradorNumerosAleatorios.ParteCentralCuadrado(3, Seeder.seed(), 1);
                double u = ld[0];

                p *= u;
                x += 1;
            }
        }
        #endregion
    }
}
