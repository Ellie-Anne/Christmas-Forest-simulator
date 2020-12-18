﻿using System;
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
        private Herd DeerHerd = new Herd();
        private Pack WolfPack = new Pack();
        List<Tree> AllHarvested = new List<Tree>();
        private bool rain;

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
                    RandomAge = randint.Next(5, 201);

                    RandomBool_asint = randint.Next(0, 10);

                    if (RandomBool_asint == 0)
                    {
                        Diseased = true;
                    }
                    else
                    {
                        Diseased = false;
                    }

                    RandomBool_asint = randint.Next(0, 2);

                    if (RandomBool_asint == 0)
                    {
                        Protection = true;
                    }
                    else
                    {
                        Protection = false;
                    }

                    RandomBool_asint = randint.Next(0, 50);

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
                    RandomAge = randint.Next(50, 301);

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

            AllHarvested.Add(Trees[0]);
        }

        public void HireForester(int ForesterNumber)
        {
            Foresters[ForesterNumber] = new Forester();
        }

        public void ForestFire()
        {
            Random ForestFire = new Random();
            int TreeToBurn;
            int NumberToBurn;
            int TotalBurnt = 0;

            if (ForestFire.Next(0,100)==0)
            {
                NumberToBurn = ForestFire.Next(0, 1001);
                for(int i =0; i<= NumberToBurn; i++)
                {
                    TreeToBurn = ForestFire.Next(0, 10000);

                    if (Trees[TreeToBurn].GetDead() == false)
                    {
                        Trees[TreeToBurn].Burn();
                        TotalBurnt += 1;
                    }
                }

                Console.WriteLine("Year " + Year);
                Console.WriteLine("Day " + Day);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("FOREST FIRE!!!!!! " + TotalBurnt + " trees were lost");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public void GrowDeerPopulation()
        {

        }

        public void GrowWolfPopulation()
        {

        }

        public void IncrementDay()
        //Other Stuff will go in here, things that happen regualarly, you know
        {
            Random RainChance = new Random();

            if(RainChance.Next(0,10) <3)
            {
                rain = true;
            }
            else
            {
                rain = false;
            }

            //if it is a new year, increase the year number, and reset the day number, and age up the trees
            if (Day == 366)
            {
                Console.WriteLine("End of Year " + Year);
                TapSyrup();
                OutputForest();
                

                Day = 1;
                Year += 1;

                for (int i = 0;i<10000;i++)
                {
                    Trees[i].AgeUp();
                }

                WolfPack.Hunt(DeerHerd);
                WolfPack.NewYear();
                DeerHerd.GrowHerd();
            }

            //Foresters are only hired for 30 days a year, might as well make it simple, the first 30 days
            if (Day <= 30)
            {
                Harvest();
            }
            else if (Day == 31)
            {
                TransportHarvest(AllHarvested);
                AllHarvested = null;
                AllHarvested = new List<Tree>();
                AllHarvested.Add(Trees[0]);
                Console.WriteLine();
            }
            
            if(((Day == 1)|(Day >= 46 & Day <= 50)|(Day>=88 & Day <= 99)|(Day>=151 & Day <=243)|(Day == 256)) & rain == true)
            {
                ForestFire();
            }


            DeerHerd.DeerAttacks(Trees);
            MoveDoves();
            Day += 1; //Increase the day
        }

        public void Harvest()
        {
            //What is the Date?
            Console.WriteLine("Year " + Year);
            Console.WriteLine("Day " + Day);

            List<Tree> ForesterHarvest;

            //We need yo hire 3 Foresters
            for (int i = 0; i < 3; i++)
            {
                HireForester(i);
                //Hello Mr.Forester, please go chop some trees
                Foresters[i].ChopTree(Trees);
                int ForesterNumber = i + 1;

                Console.WriteLine();

                if (Foresters[i].GetCountHarvested() == 0) //you didn't chop any
                {
                    //Tell the forest simulation managers how worthless you are
                    Console.WriteLine("Forester " + ForesterNumber + " couldn't find any trees");
                }
                else //you found some
                {
                    //you are a good forester, how many did you chop, and what species were they
                    Console.WriteLine("Forester " + ForesterNumber + " Harvested " + Foresters[i].GetCountHarvested() + " " + Foresters[i].GetTypeHarvested() + " Trees");
                }

                ForesterHarvest = Foresters[i].GetTreesSuccessfullyHarvested();
                foreach(Tree tree in ForesterHarvest)
                {
                    AllHarvested.Add(tree);
                }

            }

            Console.WriteLine();

        }

        public void TransportHarvest(List<Tree> Trees)
        {
            AllHarvested.RemoveAt(0);

            while(Trees.Count>0)
            {
                Trucks truck = new Trucks();
                truck.FillTruck(Trees);
            }
        }

        public void MoveDoves()
        {
            for (int i = 0; i<10000; i++)
            {
                Trees[i].SetDove();
            }
        }

        public void TapSyrup()
        {
            double litres = 0;

            for (int i =0; i<10000;i++)
            {
                if(Trees[i] is Maple & Trees[i].GetAge()>=4)
                {
                    litres += 1.5;
                }
            }

            Console.WriteLine(litres + " litres of Maple Syrup were harvested, this used " + litres * 3 + " containers for storage.");
        }

        public void OutputYear()
        {

        }

        public void OutputForest()
        {
            int spruce = 0;
            int fir = 0;
            int maple = 0;
            int bug_hotel = 0;
            int dead = 0;

            foreach(Tree tree in Trees)
            {
                string TreeType = Convert.ToString(tree.GetType());
                if (tree.GetDead() == true)
                {
                    dead += 1;
                }
                else if (tree is Spruce)
                {
                    spruce += 1;
                }
                else if (tree is Fir)
                {
                    fir += 1;
                }
                else if (tree is Maple)
                {
                    maple += 1;
                }
                else if (tree is BugHotel)
                {
                    bug_hotel += 1;
                }
            }

            Console.WriteLine("There are " + spruce + " Norway Spruce in the forest");
            Console.WriteLine("There are " + fir + " Nordmann Fir in the forest");
            Console.WriteLine("There are " + maple + " Maple Trees in the forest");
            Console.WriteLine("There are " + bug_hotel + " Bug Hotels in the forest");
            Console.WriteLine("There are " + dead + " dead trees in the forest");
            Console.WriteLine("There are " + WolfPack.GetCount() + " wolves in the forest");
            Console.WriteLine("There are " + DeerHerd.GetCount() + " deer in the forest");
            Console.WriteLine();

            int k = 0;

            for (int i = 0; i<100; i++)
            {
                for (int j = 0;j<100;j++)
                {
                    Trees[k].OutputTree();
                    k += 1;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public void OutputTree(int i)
        {
            Trees[i].OutputTree();
        }
    }
}
