﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactory = int.Parse(Console.ReadLine());

            int targetsPoked = 0;

            double originalValue = pokemonPower * 0.50;

            while (pokemonPower >= distance)
            {
                if (pokemonPower == originalValue)
                {
                    if (exhaustionFactory > 0)
                    {
                        pokemonPower = pokemonPower / exhaustionFactory;
                        if (pokemonPower < distance)
                        {
                            break;
                        }
                    }
                }

                pokemonPower -= distance;
                targetsPoked++;
            }

            Console.WriteLine(pokemonPower);
            Console.WriteLine(targetsPoked);
        }
    }
}