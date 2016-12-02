using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammlings_klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            SortedList<int, int> resultat = new SortedList<int, int>();
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int tal = random.Next(1, 7);
                if (!resultat.ContainsKey(tal))
                    resultat.Add(tal, 0);
                    resultat[tal]++;
            }
            foreach (KeyValuePair<int, int> kvp in resultat)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
            //Sorted list tar längre tid efterom att den ska läsa in allt och sedan sortera.
            */
            //Övning 2
            /*
            bool stop = true;
            List<double> lista = new List<double>();
            int i = 0;
            double medel = 0;
            while(stop)
            {
                lista.Add(double.Parse(Console.ReadLine()));
                if (lista[i] == 0)
                    stop = false;
                else
                {
                    medel += lista[i];
                    Console.WriteLine(medel / lista.Count);
                    i++;
                }
            }
            */
            List<string> kortlek = new List<string>();
            string kort; ;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; i < 13; j++)
                {
                    if (i==0)
                        kortlek.Add("h" + i.ToString());
                    if (i==1)
                        kortlek.Add("k" + i.ToString());
                    if (i==2)
                        kortlek.Add("s" + i.ToString());
                    if(i==3)
                        kortlek.Add("r" + i.ToString());
                }

            }


        }

    }
}

