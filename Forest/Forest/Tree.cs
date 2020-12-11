﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Tree
    {
        private int Age;
        private bool Diseased;
        private bool DeerProtection;
        private bool Dove;
        private string Location;

        public Tree(int _Age, bool _Diseased, bool _Protection, bool _Dove)
        {
            Age = _Age;
            Diseased = _Diseased;
            DeerProtection = _Protection;
            Dove = _Dove;
        }

        public int GetAge()
        {
            return (Age);
        }

        public void AgeUp()
        {
            Age += 1;
            //every year, a tree ages by 1 year
        }

        public void OutputTree()
        {
            if(this is Spruce)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("S");
            }
            else if (this is Fir)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("F");
            }
            else if (this is Maple)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("M");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public bool GetDiseased()
        {
            return (Diseased);
        }
    }
}
