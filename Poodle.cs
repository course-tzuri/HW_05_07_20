using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_7_20
{
    class Poodle : Dog
    {
       
       
        public int _numberOfPonyTails;

       

        public override void Bark()
        {
            Console.WriteLine("How, How");
        }

        public Poodle(string _name, string _favoriteDogFood, int _numberOfPonyTails) : base(_name, _favoriteDogFood) 
        {
            this._numberOfPonyTails = _numberOfPonyTails;
        }
    }
}
