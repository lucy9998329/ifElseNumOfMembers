using System;

namespace ifElseNumOfMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            /*{
            int i = 0;
            Console.WriteLine("Enter a number please.");
            int num = int.Parse(Console.ReadLine());
            for (i = 0; i <= 12; i++)
            Console.WriteLine($"{num} x {i} = {num * i}");
            }*/
                                                         
            Console.WriteLine("What is the name of the band? ");
            string name = Console.ReadLine();
            Console.WriteLine("How many people are in the band? ");            
            int numberOfMembers = int.Parse(Console.ReadLine());
            
            /*
            int numberOfMembers = 0;
            if(!int.TryParse(Console.ReadLine(), out numberOfMembers))
            {
             Console.WriteLine("input was not valid");
             Environment.Exit(0);   
            }*/

            if(numberOfMembers < 1)
            {
            Console.WriteLine("You must have at least 1 member");  
            }
            else if(numberOfMembers == 1)
            {
            Console.WriteLine(name + " is a solo");
            }
            else if(numberOfMembers == 2)
            {
            Console.WriteLine(name + " is a duo");
            }
            else
            {
            Console.WriteLine(name + " has " + numberOfMembers + " members");   
            }

            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();

        }
    }
}
