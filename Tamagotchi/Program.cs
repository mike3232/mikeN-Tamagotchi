using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi t = new Tamagotchi("Mike ", "Male ",  15, 15);
            Console.WriteLine("Name: " + t.getName());
            Console.WriteLine("Gender: " + t.getGender());
            Console.WriteLine("Fullness: " + t.getFullness());
            Console.WriteLine("Happiness: " + t.getHappiness());

            while (t.getFullness() > 0 && t.getHappiness() >= 0)
            {
                Console.WriteLine("Would you like to feed or pet your Tamagotchi?");
                String action = Console.ReadLine();
                if (action == "pet") //Happiness++
                {
                    t.pet();
                }
                else if (action == "feed")
                {
                    t.feed(); //Fullness++
                }
                else
                {
                    Console.WriteLine("You Screwed Up!!!!");
                }
                t.dostuff(); //tried to move, didn't work, tried to do if (action == "dostuff") but other code didn't work
                Console.WriteLine("Your Tamagotchi's Fullness is {0} and Happiness is {1}", t.getFullness(), t.getHappiness());

                if (t.getFullness() <=0 || t.getHappiness() <=0)
                {
                  Console.WriteLine("Na na na na. Na na na na. Hey hey hey....Goodbye");
                }              
            }
        }
    }
}