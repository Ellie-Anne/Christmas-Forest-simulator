using System;
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
    }
}
