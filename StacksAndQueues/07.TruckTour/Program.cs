using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<PetrolPump> pumps = new Queue<PetrolPump>();
            int[] pumpDetails = new int[2];
            bool pumpIsFound = false;
            int pumpCount = 0;
            int totalLitres = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {
                pumpDetails = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int pumpLitres = pumpDetails[0];
                int nextPumpDistance = pumpDetails[1];
                pumps.Enqueue(new PetrolPump(pumpLitres, nextPumpDistance));
            }

            while (!pumpIsFound)
            {
                for (int j = 0; j < numberOfPumps; j++)
                {
                    PetrolPump pum = pumps.Dequeue();
                    int litres = pum.litres;
                    int dist = pum.nextPumpDistance;
                    totalLitres += litres;
                    totalLitres -= dist;  
                    pumps.Enqueue(pum);

                    if (totalLitres < 0)
                    {
                        pumpCount++;
                        totalLitres = 0;
                    }
                    else if (totalLitres > 0)
                    {
                        pumpIsFound = true;
                        break;
                    }

                }

                pumps.Enqueue(pumps.Dequeue());
                
            }

            Console.WriteLine(pumpCount);

        }

    }

    public class PetrolPump
    {
        public int litres { get; set; }
        public int nextPumpDistance { get; set; }

        public PetrolPump(int Litres, int NextPumpDistance)
        {
            this.litres = Litres;
            this.nextPumpDistance = NextPumpDistance;
        }
    }
}
