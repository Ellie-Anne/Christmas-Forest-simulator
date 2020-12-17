using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Pack
    {
        private List<Wolf> Wolves = new List<Wolf>();

        public void Hunt(Herd DeerHerd)
        {
            foreach(Wolf wolf in Wolves)
            {
                if (wolf.Eat(DeerHerd) == false)
                {
                    Wolves.Remove(wolf);
                }
            }
        }

        public int GetCount()
        {
            return (Wolves.Count);
        }
    }
}
