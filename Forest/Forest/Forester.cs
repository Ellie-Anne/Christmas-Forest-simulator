using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Forester
    {
        private int TreesAttemptedHarvest = 0;
        private string TypeHarvested;
        private List<Tree> TreesSuccessfullyHarvested = new List<Tree>();
        private int MaxFir = 10;
        private int MaxSpruce = 4;
        static int ReplantCount = 0;
        private int i = 0;

        public void ChopTree(Tree[] Trees)
        {
            bool FirstFound = false;

            while(FirstFound == false & i<10000)
            {
                if (Trees[i] is Fir & Trees[i].GetAge() >= 25 & Trees[i].GetAge() <= 70)
                {
                    HarvestFir(Trees);
                    FirstFound = true;
                    TypeHarvested = "Fir";
                }
                else if (Trees[i] is Spruce & Trees[i].GetAge()>=90 & Trees[i].GetAge()<=150 )
                {
                    HarvestSpruce(Trees);
                    FirstFound = true;
                    TypeHarvested = "Spruce";
                }
                i += 1;
            }
        }

        public void HarvestFir(Tree[] Trees)
        {
            while (TreesAttemptedHarvest < MaxFir & i<10000)
            {
                if (Trees[i] is Fir & Trees[i].GetAge() >= 25 & Trees[i].GetAge() <= 70)
                {
                    TreesSuccessfullyHarvested.Add(Trees[i]);
                    TreesAttemptedHarvest += 1;
                    Trees[i] = null;
                    ReplantFir(Trees);
                }

                i += 1;
            }
        }

        public void HarvestSpruce(Tree[] Trees)
        {
            while (TreesAttemptedHarvest < MaxSpruce & i<10000)
            {
                if (Trees[i] is Spruce & Trees[i].GetAge() >= 90 & Trees[i].GetAge() <= 150)
                {
                    TreesSuccessfullyHarvested.Add(Trees[i]);
                    TreesAttemptedHarvest += 1;
                    Trees[i] = null;
                    ReplantSpruce(Trees);
                }

                i += 1;
            }

        }

        public void ReplantFir(Tree[] trees)
        {
            Random random = new Random();
            bool Diseased;
            bool Protected;
            bool Dove;

            if (random.Next(0,2) == 0)
            {
                Diseased = true;
            }
            else
            {
                Diseased = false;
            }

            if (random.Next(0, 2) == 0)
            {
                Protected = true;
            }
            else
            {
                Protected = false;
            }

            if (random.Next(0, 50) == 0)
            {
                Dove = true;
            }
            else
            {
                Dove = false;
            }


            if (ReplantCount % 3 == 0)
            {
                trees[i] = new Fir(0, Diseased, Protected, Dove);
            }
            else
            {
                trees[i] = new Maple(0, Diseased, Protected, Dove);
            }

            ReplantCount += 1;

        }

        public void ReplantSpruce(Tree[] trees)
        {
            Random random = new Random();
            bool Diseased;
            bool Protected;
            bool Dove;

            if (random.Next(0, 2) == 0)
            {
                Diseased = true;
            }
            else
            {
                Diseased = false;
            }

            if (random.Next(0, 2) == 0)
            {
                Protected = true;
            }
            else
            {
                Protected = false;
            }

            if (random.Next(0, 50) == 0)
            {
                Dove = true;
            }
            else
            {
                Dove = false;
            }


            if (ReplantCount % 3 == 0)
            {
                trees[i] = new Spruce(0, Diseased, Protected, Dove);
            }
            else
            {
                trees[i] = new Maple(0, Diseased, Protected, Dove);
            }

            ReplantCount += 1;
        }

        public int GetCountHarvested()
        {
            return (TreesSuccessfullyHarvested.Count);
        }

        public string GetTypeHarvested()
        {
            return (TypeHarvested);
        }
    }
}
