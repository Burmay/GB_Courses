using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Class1
    {
        int neutrons;
        double kernel;
        double kernelDynamics;
        double k;
        double extinguishing;
        double newneutrons;
        public Class1()
        {
            neutrons = 1;
            kernel = 0;
            newneutrons = 0;
            kernelDynamics = 0;
            k = 0.18;
            extinguishing = 0;
        }
        public int Neutrons()
        {
            return neutrons;
        }
        public double Kernel()
        {
            return kernel;
        }
        public void Uranus()
        {
            if (kernelDynamics > 0)
                kernelDynamics = kernelDynamics - 0.05;
            if (kernelDynamics < 0)
                kernelDynamics = kernelDynamics + 0.05;
            kernel = kernel + kernelDynamics;
            if (kernel >= 5)
            {
                kernel = 5;
                kernelDynamics = 0;
            }
            if (kernel <= 0)
            {
                kernel = 0;
                kernelDynamics = 0;
            }
            extinguishing = 1 - kernel * k;
            Random random = new Random();
            for (int i = 0; i != neutrons; i++)
            {
                newneutrons = random.Next(1, 8) * extinguishing + newneutrons;
            }
            neutrons = Convert.ToInt32(newneutrons);
            newneutrons = 0;
        }
        public void PutForward()
        {
            kernelDynamics = kernelDynamics - 0.25;
        }
        public void PushIn()
        {
            kernelDynamics = kernelDynamics + 0.25;
        }
        public void Nothing()
        {
            
        }
    }
}
