using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson5
{
    class Class4
    {

        public string[] EGE(string metka)
        {
            string[,] Lowdown = new string[100, 3];
            string a;
            string [] b = new string[5];
            double q;
            StreamReader sr = new StreamReader(metka);
            for (int i =0; sr.EndOfStream == false; i++)
            {
                a = sr.ReadLine();
                b = a.Split(' ');
                for (int j = 0; j != 3; j++)
                {
                    if(j < 2)
                        Lowdown[i, j] = b[j];
                    else
                    {
                        q = Convert.ToInt32(b[2]) + Convert.ToInt32(b[3]) + Convert.ToInt32(b[4]);
                        q = q / 3;

                        Lowdown[i, 2] = q.ToString();
                    }
                }
            }
            string[] final = Sentence(Lowdown);
            return final;
        }
        public string[] Sentence (string[,] Lowdown)
        {
            double[] min = new double[3];
            min[0] = 5;
            min[1] = 5;
            min[2] = 5;
            string[] sentence = new string[3];
            for (int i = 0; i != 100; i++)
            {
                if(Convert.ToDouble(Lowdown[i, 2]) < min[0] || Convert.ToDouble(Lowdown[i, 2]) < min[1] || Convert.ToDouble(Lowdown[i, 2]) < min[2])
                {
                    if (min[0] < min[1] || min[0] < min[2])
                    {
                        min[0] = Convert.ToDouble(Lowdown[i, 2]);
                        sentence[0] = Lowdown[i,2];
                    }
                    if (min[1] < min[0] || min[1] < min[2])
                    {
                        min[1] = Convert.ToDouble(Lowdown[i, 2]);
                        sentence[1] = Lowdown[i, 2];
                    }
                    if (min[2] < min[1] || min[2] < min[0])
                    {
                        min[2] = Convert.ToDouble(Lowdown[i, 2]);
                        sentence[2] = Lowdown[i, 2];
                    }
                    else
                    {
                        min[0] = Convert.ToDouble(Lowdown[i, 2]);
                        sentence[0] = Lowdown[i, 2];
                    }

                }
            }
            return sentence;
        }
    }
}
