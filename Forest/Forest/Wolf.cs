using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Wolf
    {
        public bool Eat(Herd DeerHerd)
        {
            if (DeerHerd.GetCount >=12)
            {
                DeerHerd.Kill(0);
                return (true);
            }

            else
            {
                return (false);
            }
        }

        public void Die()
        {

        }

        public void LeaveForest()
        {

        }
    }
}
