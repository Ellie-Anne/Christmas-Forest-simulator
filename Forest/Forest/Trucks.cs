using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Trucks
    {
        private int NumberOfTrees;
        private string TypeTransporting;

        public void FillTruck(List<Tree> Trees)
        {
            if(Trees[0] is Fir)
            {
                FillWithFir(Trees);
            }
            else if (Trees[0] is Spruce)
            {
                FillWithSpruce(Trees);
            }

            Console.WriteLine("Truck was used to transport " + NumberOfTrees + " " + TypeTransporting + " harvested this year.");
        }

        public void FillWithFir(List<Tree> Trees)
        {
            TypeTransporting = "Nordmann Fir";

            for (int i = 0; i<Trees.Count; i++)
            {
                if(Trees[i] is Fir & NumberOfTrees <35)
                {
                    NumberOfTrees += 1;
                    Trees.RemoveAt(i);
                    i -= 1;
                }
            }
        }
        public void FillWithSpruce(List<Tree> Trees)
        {
            TypeTransporting = "Norway Spruce";

            for (int i = 0; i < Trees.Count; i++)
            {
                if (Trees[i] is Spruce & NumberOfTrees < 15)
                {
                    NumberOfTrees += 1;
                    Trees.RemoveAt(i);
                    i -= 1;
                }
            }
        }
    }
}
