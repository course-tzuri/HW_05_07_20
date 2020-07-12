using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_7_20
{
    class Dog : Animal
    {
        
        public string _favoriteDogFood;
        

        public Dog(string _name, string _favorieDogFood) : base(_name)
        {
            this._favoriteDogFood = _favorieDogFood;


        }

        public override void MakeSound()
        {
            Bark();
        }
        public virtual void  Bark()
        {
           
            Console.WriteLine("hi, ho, ha");
        }
        public override string ToString()
        {
            return $"[{base.ToString()}] {_name} {_favoriteOfFood}";
        }

    }
    
}
