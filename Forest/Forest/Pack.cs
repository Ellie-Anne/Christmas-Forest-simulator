﻿using System;
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
    }
}
