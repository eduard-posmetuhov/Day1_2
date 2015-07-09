using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootN
{
    public class Root
    {
        public static double FindRoot(double N, int n, int e)
        {
            double x = 1;
            double eps = Math.Pow(10,-e);
            for (;;)
            {
                double nx = ((n-1)*x+N/Math.Pow(x,n-1))/n;
                if (Math.Abs(x-nx)<eps)
                    break;
                x = nx;
            }
            return x;            
        }
    }
}
