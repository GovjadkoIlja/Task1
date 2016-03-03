using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class Program
    {
        public static int make(int[,] mass, int s, int n, double d, int best)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                if ((mass[i, 1] == 1) && (mass[i, 0] + s < d + best))
                {
                    mass[i, 1] = 0;
                    s += mass[i, 0];
                    if (Math.Abs(s - d) < Math.Abs(best - d))
                        best = s;
                    best = make(mass, s, n, d, best);
                }

            }
            return best;
        }
        static void Main(string[] args)
        {
            int n;
            int i;
            int best = 0;
            int s = 0;
            double d;
            n = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[n, 2];
            for (i = 0; i < n; i++)
            {
                mass[i, 0] = Convert.ToInt32(Console.ReadLine());
                mass[i, 1] = 1;
                s += mass[i, 0];
            }
            s /= 2;
            best = make(mass, 0, n, s / 2, best);
            d = ((best - s/2)*2);
        Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
