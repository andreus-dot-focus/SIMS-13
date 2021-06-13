using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_13
{
    class Generator
    {
        double[] stat = new double[4];
        public double[] freq = new double[4];
        Random rnd = new Random();
        double alpha;

        public double average = 0;
        public double variance = 0;

        public double error_ave;
        public double error_var;

        public double chi_square = 0;
        public double chi_square_norm = 9.488;

        int generateEvent(double p)
        {
            alpha = rnd.NextDouble();
            double x = Math.Log(alpha) / Math.Log(1 - p);
            return (int)x;
        }

        public void createExperiments(double p1, int N)
        {
            double p2 = p1 * (1 - p1);
            double p3 = p2 * (1 - p1);
            double p4 = p3 * (1 - p1);
            double[] prob = new double[4] { p1, p2, p3, p4 };
            for (int i = 1; i <= (int)N; i++)
            {
                double value = generateEvent(p1);
                if (value == 0)
                {
                    stat[0]++;
                }
                if (value == 1)
                {
                    stat[1]++;
                }
                if (value == 2)
                {
                    stat[2]++;
                }
                if (value > 2)
                {
                    stat[3]++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                freq[i] = stat[i] / N;
            }

            
            double math_ave = 0;

            double[] events = new double[4] { 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                math_ave += (double)prob[i] * events[i];
                average += (double)freq[i] * events[i];
            }

            double math_var = 0;
            for (int i = 0; i < 4; i++)
            {
                math_var += (double)prob[i] * Math.Pow((events[i] - math_ave), 2);
                variance += (double)freq[i] * Math.Pow((events[i] - average), 2);
            }

            error_ave = Math.Abs(((math_ave - average) / math_ave) * 100);
            error_var = Math.Abs(((math_var - variance) / math_var) * 100);
          
            for (int i = 0; i < 3; i++)
            {
                chi_square += Math.Pow(stat[i] - N * prob[i], 2) / (N * prob[i]);
            }            
        }
    }
}
