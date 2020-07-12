using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_7_20
{
    class PetWolf: Wolf


         
    {

        
        public PetWolf(string _name, string __favorieDogFood, string _nameOfPack) : base ("Pet Wolaf", "Bonzo", "Yala")
        {
            
     
          
        }
        public override void MakeSound()
        {
            Console.WriteLine("he,ha,hi");
        }
        
    }
}
