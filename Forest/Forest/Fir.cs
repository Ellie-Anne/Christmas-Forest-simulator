using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Fir : Tree 
    {
        public Fir(int _Age, bool _Diseased, bool _Protection, bool _Dove) : base(_Age, _Diseased, _Protection, _Dove)
        { }
        public void CutDown()
        {

        }

        public void Replant()
        {

        }

        public string GetSpecies()
        {
            return ("Fir");
        }
    }
}
