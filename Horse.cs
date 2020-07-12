using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_7_20
{
    class Horse : Animal
    {
        
        public bool _racingHorse;

        
        public Horse(string _name,bool _racingHorse) : base (_name)
       {
           
           this._racingHorse = _racingHorse;

       }
        public override void MakeSound()
        {
            neigh();
        }

        public virtual void neigh()
        {
            Console.WriteLine("neigh");
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] {_name} {_racingHorse}";
        }
    }
}
