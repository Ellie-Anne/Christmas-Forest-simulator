using System;

namespace Forest
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();

            forest.OutputForest();


            for (int i = 0; i<9125; i++)
            {
                forest.IncrementDay();
            }

            Console.WriteLine("End of year 25");
            forest.OutputForest();
        }
    }
}
