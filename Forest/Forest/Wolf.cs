using System;
using System.Collections.Generic;
using System.Text;

namespace Forest
{
    class Wolf
    {
        private bool gender;
        private int age;

        public Wolf(int _age, bool _gender)
        {
            age = _age;
            gender = _gender;
        }

        public bool getGender()
        {
            return gender;
        }

        public int getAge()
        {
            return age;
        }

        public void incrementAge()
        {
            age = age + 1;
        }

        public bool Eat(Herd DeerHerd)
        {
            if (DeerHerd.GetCount() >=12)
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
