﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_July_2017_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokePower = int.Parse(Console.ReadLine());
            var distanceBetweenTargets = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());
            var CheckForCountOftargets = pokePower / distanceBetweenTargets;
            var CheckForRemainingPower = pokePower % distanceBetweenTargets;

            if (CheckForCountOftargets % 2 == 0 && CheckForRemainingPower == 0 && exhaustionFactor > 0)
            {
                pokePower = pokePower / 2 + ((pokePower / 2) / exhaustionFactor);
            }

            var countOftargets = pokePower / distanceBetweenTargets;
            var remainingPower = pokePower % distanceBetweenTargets;

            Console.WriteLine("{0}\n{1}", remainingPower, countOftargets);
        }
    }
}
