using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Forest
    {
        private Tree[] Trees = new Tree[10000];
        private Forester[] Foresters = new Forester[3];
        private int Day = 1;
        private int Year = 1;
        private List<Deer> Deers = new List<Deer>();
        private List<Wolf> Wolves = new List<Wolf>();

        public Forest()
        {
            Random randint = new Random();
            int RandomTree;
            int RandomAge;
            int RandomBool_asint;
            bool Diseased;
            bool Protection;
            bool Dove;

            //makes 9999 trees
            for (int i = 0; i<=9999; i++)
            {
                RandomTree = randint.Next(1, 6);

                //makes spruce trees
                if (RandomTree == 1)
                {
                    RandomAge = randint.Next(0, 101);

                    RandomBool_asint = randint.Next(0, 2);

                    if (RandomBool_asint == 0)
                    {
                        Diseased = true;
                    }
                    else
                    {
                        Diseased = false;
                    }

                    if (RandomBool_asint == 0)
                    {
                        Protection = true;
                    }
                    else
                    {
                        Protection = false;
                    }

                    if (RandomBool_asint == 0)
                    {
                        Dove = true;
                    }
                    else
                    {
                        Dove = false;
                    }

                    Trees[i] = new Spruce(RandomAge, Diseased, Protection, Dove);

                }
                //makes fir trees
                else
                {
                    RandomAge = randint.Next(0, 201);

                    RandomAge = randint.Next(0, 101);

                    RandomBool_asint = randint.Next(0, 2);

                    if (RandomBool_asint == 0)
                    {
                        Diseased = true;
                    }
                    else
                    {
                        Diseased = false;
                    }

                    if (RandomBool_asint == 0)
                    {
                        Protection = true;
                    }
                    else
                    {
                        Protection = false;
                    }

                    if (RandomBool_asint == 0)
                    {
                        Dove = true;
                    }
                    else
                    {
                        Dove = false;
                    }

                    Trees[i] = new Fir(RandomAge, Diseased, Protection, Dove);
                }
            }
        }

        public void HireForester(int ForesterNumber)
        {
            Foresters[ForesterNumber] = new Forester();
        }

        public void ForestFire()
        {

        }

        public void GrowDeerPopulation()
        {

        }

        public void GrowWolfPopulation()
        {

        }

        public void IncrementDay()
        {
            
            if (Day == 366)
            {
                Day = 1;
                Year += 1;
                for (int i = 0;i<10000;i++)
                {
                    Trees[i].AgeUp();
                }
            }

            Console.WriteLine("Year " + Year);
            Console.WriteLine("Day " + Day);

            if (Day <= 30)
            {

                for (int i = 0; i < 3; i++)
                {
                    HireForester(i);
                    Foresters[i].ChopTree(Trees);
                    int ForesterNumber = i + 1;

                    Console.WriteLine();
                    
                    if (Foresters[i].GetCountHarvested() == 0)
                    {
                        Console.WriteLine("Forester " + ForesterNumber + " couldn't find any trees");
                    }
                    else
                    { 
                        Console.WriteLine("Forester " + ForesterNumber + " Harvested " + Foresters[i].GetCountHarvested() + " " + Foresters[i].GetTypeHarvested() + " Trees");
                    }

                }

            }

            Console.WriteLine();

            Day += 1;
        }

        public void OutputYear()
        {

        }

        public void OutputForest()
        {
            int spruce = 0;
            int fir = 0;

            foreach(Tree tree in Trees)
            {
                string TreeType = Convert.ToString(tree.GetType());
                if (tree is Spruce)
                {
                    spruce += 1;
                }
                else if (tree is Fir)
                {
                    fir += 1;
                }
            }

            Console.WriteLine("There are " + spruce + " Norway Spruce in the forest");
            Console.WriteLine("There are " + fir + " Nordmann Fir in the forest");
            Console.ReadLine();
        }

        public void OutputTree(int i)
        {
            Trees[i].OutputTree();
        }
    }
}
