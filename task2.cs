using System;

namespace project
{
    internal class task2
    {
        static void Main(string[] args)
        {
            var grade = 84;
            if (grade < 65)
            {
                Console.WriteLine("Kəsildin");  
            }
            else if (grade <85 && grade>=65)
            {
                Console.WriteLine("Adi Diplom");
            }      
            
           else  if (grade <95 && grade>=85)
            {
                Console.WriteLine("Honour");
            }

            else
            {
                Console.WriteLine("High Honour");
            }



        }








    }
}
