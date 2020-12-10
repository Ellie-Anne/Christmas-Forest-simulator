using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Spruce : Tree
    {
        public Spruce(int _Age, bool _Diseased, bool _Protection, bool _Dove) : base(_Age, _Diseased, _Protection, _Dove)
        {}

        public string GetSpecies()
        {
            return ("Spruce");
        }
    }
}
