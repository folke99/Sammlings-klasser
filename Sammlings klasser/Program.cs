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
            //Övning 3
            /*
            List<string> kortlek = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (i == 0)
                    {
                        if (j == 11)
                        {
                            kortlek.Add("hKn");
                        }
                        else if (j == 12)
                        {
                            kortlek.Add("hD");
                        }
                        else if (j == 13)
                        {
                            kortlek.Add("hK");
                        }
                        else if (j == 0)
                        {
                            kortlek.Add("hE");
                        }
                        else
                        {
                            kortlek.Add("h" + j.ToString());
                        }
                    }
                    if (i == 1)
                    {
                        if (j == 11)
                        {
                            kortlek.Add("sKn");
                        }
                        else if (j == 12)
                        {
                            kortlek.Add("sD");
                        }
                        else if (j == 13)
                        {
                            kortlek.Add("sK");
                        }
                        else if (j == 0)
                        {
                            kortlek.Add("sE");
                        }
                        else
                        {
                            kortlek.Add("s" + j.ToString());
                        }
                    }
                    if (i == 2)
                    {
                        if (j == 11)
                        {
                            kortlek.Add("rKn");
                        }
                        else if (j == 12)
                        {
                            kortlek.Add("rD");
                        }
                        else if (j == 13)
                        {
                            kortlek.Add("rK");
                        }
                        else if (j == 0)
                        {
                            kortlek.Add("rE");
                        }
                        else
                        {
                            kortlek.Add("r" + j.ToString());
                        }
                    }
                    if (i == 3)
                    {
                        if (j == 11)
                        {
                            kortlek.Add("kKn");
                        }
                        else if (j == 12)
                        {
                            kortlek.Add("kD");
                        }
                        else if (j == 13)
                        {
                            kortlek.Add("kK");
                        }
                        else if (j == 0)
                        {
                            kortlek.Add("kE");
                        }
                        else
                        {
                            kortlek.Add("k" + j.ToString());
                        }
                    }
                }

            }
            for (int k = 51; k >= 0; k--)
            {
                Random rnd = new Random();
                int slumpKort = rnd.Next(0, k);
                Console.WriteLine(kortlek[slumpKort]);
                kortlek.RemoveAt(slumpKort);              
            }
            Console.ReadKey();
            */
            //Övning 4

        }

    }
}

