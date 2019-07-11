using System;
using System.Collections;
namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont == true)
            {
                Console.WriteLine("Welcome to your room caluculator");

                Console.WriteLine("Please enter the Length of your room");
                string length = Console.ReadLine();
                double length1 = double.Parse(length);

                Console.WriteLine("Please enter the Width of your room");
                string width = Console.ReadLine();
                double width1 = double.Parse(width);

                double area = (length1 * width1);
                double parimiter = ( 2 * (length1 + width1));
                Console.WriteLine("The area of your ropom is " + (area));
                Console.WriteLine("The parimiter of your room is " + (parimiter));

                Console.WriteLine("Would You like to calulate the volume of the room y/n");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    Console.WriteLine("Please enter the height of your room");
                    string height = Console.ReadLine();
                    double height1 = double.Parse(height);

                    Console.WriteLine("The Volume of your room is " + (length1 * width1 * height1));
                }
                else if (answer == "n" || answer == "N")
                {
                    Console.WriteLine("Okay");
                }

                Console.WriteLine("Would you like to calculate another room y/n");
                string answer1 = Console.ReadLine();

                if (answer1 == "y" || answer1 == "Y")
                {
                    cont = true;
                }
                else if (answer1 == "n" || answer1 == "N")
                {
                    cont = false;
                }
            }
        }
    }
}
