using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Herd
    {
        private List<Deer> Deers = new List<Deer>();

        public Herd()
        {
            Deer deer;
            for (int i =0; i<58;i++)
            {
                deer = new Deer();
                Deers.Add(deer);
            }
        }

        public void DeerAttacks(Tree[] Trees)
        {
            Random rnd = new Random();
            foreach (Deer deer in Deers)
            {
                Trees[rnd.Next(0, 10000)].IncreaseDamage();
            }
        }

        public void GrowHerd()
        {
            Deer deer;
            for (int i = 0; i<28; i++)
            {
                deer = new Deer();
                Deers.Add(deer);
            }
        }
    }
}
