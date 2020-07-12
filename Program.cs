using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_7_20
{
    class Program
    {


        public static void AnimalSing(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].MakeSound();
            }
        }
        static void Main(string[] args)
        {

            Horse a = new Horse("dany", true)
            {

            };
            Dog b = new Dog("How", "meat")
            {

            };

            Poodle c = new Poodle("Tolip", "Bonzo", 1)
            {

            };

            Wolf d = new Wolf("Rexi", "meat", "Pack 1")
            {

            };

            PetWolf e = new PetWolf("Koti", "Bonzo", "yala")
            {

            };

            



        }
    }
}
