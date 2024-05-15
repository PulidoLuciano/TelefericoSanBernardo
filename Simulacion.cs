using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefericoSanBernardo.assets
{
    public class Simulacion
    {
        public Simulacion()
        {
            simular();
        }
        
        public int totalPersonas { get; set; }
        public int menores { get; set; }
        public int jovenes { get; set; }
        public int adultos { get; set; }
        public int provinciales { get; set; }
        public int nacionales { get; set; }
        public int internacionales { get; set; }
        public double ingresoTeleferico { get; set; }
        public double ingresoMascotas { get; set; }
        public double ingresoRegalos { get; set; }
        public double ingresoPicnic { get; set; }

        

        public void simular()
        {
            int A = 0;
            int J = 0;
            int M = 0;
            int E = 0;
            int I = 0;
            int N = 0;
            int PP = 0;
            int H = 0;
            int TP = 0;

            double IE = 0;
            double IM = 0;
            double IGS = 0;
            double IR = 0;
            
            // HORAS
            while (H < 9)
            {
                H++;
               
                double P = 0;
                Distribution.Poisson(85, ref P);

                // PERSONA
                while (P > 0)
                {
                    P--;

                    precioEntrada();

                    List<double> ld = GeneradorNumerosAleatorios.CongruencialMultiplicativo(3, 1, 547, 5631, Seeder.seed());
                    double u = ld[0];

                    if (u < 0.02)
                    {
                        IM += 2500;
                        IE += 2500;
                    }

                    ld = GeneradorNumerosAleatorios.Lehmer(Seeder.seed(), 73, 1);
                    u = ld[0];

                    if (u < 0.3)
                    {
                        ld = GeneradorNumerosAleatorios.Lehmer(Seeder.seed(), 73, 1);
                        u = ld[0];

                        double X = 1000 + 6000 * u;

                        IGS += X;
                    }

                    double Y = 0;
                    Distribution.Normal(4300, 500, ref Y);

                    IR += Y;
                }


            }

            TP = A + J + M;

            totalPersonas = TP;
            adultos = A;
            jovenes = J;
            menores = M;
            internacionales = I;
            nacionales = N;
            provinciales = PP;
            ingresoMascotas = IM;
            ingresoTeleferico = IE;
            ingresoRegalos = IGS;
            ingresoPicnic = IR;

            void precioEntrada()
            {
                int CJ = 0;
                int CA = 0;

                List<double> ld = GeneradorNumerosAleatorios.Lehmer(Seeder.seed(), 73, 1);
                double u = ld[0];

                if (u < 0.6)
                {
                    A++;
                    CA = 1;
                }
                else if (u < 0.9)
                {
                    J++;
                    CJ = 1;
                    
                }
                else
                {
                    M++;
                }

                nacionalidad(CJ, CA);
            }

            void nacionalidad(int CJ, int CA)
            {
                List<double> ld = GeneradorNumerosAleatorios.Lehmer(Seeder.seed(), 73, 1);
                double u = ld[0];

                if (u < 0.15)
                {
                    I++;
                    IE += 10000 * CA + 7000 * CJ;
                }
                else if (u < 0.75)
                {
                    N++;
                    IE += 7000 * CA + 5000 * CJ;
                }
                else
                {
                    PP++;
                    IE += 4000 * CA + 2000 * CJ;
                }
            }
        }
    }
}
