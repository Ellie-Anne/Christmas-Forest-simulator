using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Pack
    {
        private List<Wolf> Wolves = new List<Wolf>();

        public Pack()
        {
            Wolf wolf;
            wolf = new Wolf(0, true);
            Wolves.Add(wolf);

            for (int i = 0; i < 3; i++)
            {
                wolf = new Wolf(0, false);
                Wolves.Add(wolf);
            }
        }

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

        public void NewYear()
        {
            Random rnd = new Random();
            int random;
            bool gender;

            foreach (Wolf wolf in Wolves)
            {
                if (wolf.getGender() == false)
                {
                    random = rnd.Next(0, 2);

                    if(random == 0)
                    {
                        gender = true;
                    }
                    else
                    {
                        gender = false;
                    }

                    Wolves.Add(new Wolf(0, gender));
                }
                else if (wolf.getGender() == true & wolf.getAge() >= 3)
                {
                    Wolves.Remove(wolf);
                }
            }
        }
    }
}
