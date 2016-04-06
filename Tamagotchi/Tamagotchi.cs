using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi  // idea petting and feeding cause values to go up
    //trying to Kill!! Tamagotchi
{
    class Tamagotchi
    {
        private string Name = "N/A ";
        private string Gender = " N/A";
        private int Fullness = 0;
        private int Happiness = 0;

        public Tamagotchi(string name, string gender, int fullness, int happiness)
        {
            Name = name; //lowercase "name" could have been called anything like Bee, but string name above would be string bee.
            Gender = gender;
            Fullness = fullness;
            Happiness = happiness;
        }

        public string getName()
        {
            return Name;
        }

        public string getGender()
        {
            return Gender;
        }

        public int getFullness()
        {
            return Fullness;
        }
        public int getHappiness()
        {
            return Happiness;
        }
        public int pet()
        {
            Happiness = Happiness + 1;
            return Happiness;
        }
        public int feed()
        {
            Fullness = Fullness + 1;
            return Fullness;
        }
        public void dostuff()
        {
            Random rnd = new Random();
            Happiness = Happiness - rnd.Next(5); //rnd.Next will return a single integer by puttin
            // a "5" random numbers will be between 0 to 5  
            
            // Could also write rnd.Next(1,10); 1 starting value 10 ending value
            Fullness = Fullness - rnd.Next(10);
            Console.WriteLine(Happiness);
            Console.WriteLine(Fullness);
        }
    }
}