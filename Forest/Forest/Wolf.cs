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

        public void setAge(int _age)
        {
            age = _age;
        }

        public void Eat()
        {

        }

        public void Die()
        {

        }

        public void LeaveForest()
        {

        }

    }
}
