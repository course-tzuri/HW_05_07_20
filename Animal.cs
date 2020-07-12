using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_7_20
{
    abstract class Animal
    {
        public string _name;
       

       
        public Animal(string _name)
        {
            this._name = _name;
        }

        public Animal(string _name, string _favoriteDogFood) : this(_name)
        {
            this._favoriteDogFood = _favoriteDogFood;
        }

        public abstract  void MakeSound();
        

        
        
        public override string ToString()
        {
            return $"[{base.ToString()}] {_name}";
        }
    }
}
