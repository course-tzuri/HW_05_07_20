using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_7_20
{
    class Wolf :Dog
    {
       
       
        public static string _nameOfPack;
       public static string _favorieDogFood;

        public Wolf(string _name) :base (_name, _favorieDogFood)
        {
            this._name = _name;
            
        }

        public override void MakeSound()
        {

        }

        public Wolf(string _name, string _favoriteOfFood, string _nameOfPack) :base(_name, _favoriteOfFood)
        {
          
          
         
        }

        
    }
}
