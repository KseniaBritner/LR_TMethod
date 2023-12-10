using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMethod
{
    public abstract class DrinkBehavior
    {
        public void Create()
        {
            BoilerWater();
            PourIntoGlass();
            Brew();
            AddСomponents();
        }
        public void BoilerWater()
        {
            Console.WriteLine("Вода вскипятилась");
        }
        public void PourIntoGlass()
        {
            Console.WriteLine("Вода налита в стакан");
        }
        protected abstract void Brew();
        protected abstract void AddСomponents();
        protected abstract bool IsAddish();
    }
}
