using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            userInput.AddCarDistanceTime(200, 2);
            userInput.AddCarDistanceTime(400, 1.5);
            userInput.AddCarDistanceTime(300, 2);
            userInput.AddCarDistanceTime(600, 3);
            userInput.AddCarDistanceTime(700, 3.5);
            userInput.AddCarDistanceTime(350, 2);
            userInput.AddCarDistanceTime(450, 2);
            userInput.AddCarDistanceTime(500, 4);
            userInput.AddCarDistanceTime(800, 5);
            userInput.AddCarDistanceTime(1000, 4);
           
            int count = 0;
            foreach (var item in userInput.GetAttribute1())
            {
                count++;
                Console.WriteLine($"{count}. Distance {item.Distance} , Time -  {item.Time} , Speed - {item.Speed}");
            }
            Console.ReadLine();
        }
    }
}
