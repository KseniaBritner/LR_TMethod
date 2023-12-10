using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMethod
{
    public class Tea : DrinkBehavior
    {
        protected override void Brew()
        {
            Console.WriteLine("Чай заварен");
        }
        protected override void AddСomponents()
        {
            if (IsAddish())
            {
                Console.WriteLine("В чай добавлен лимон");
            }
        }
        protected override bool IsAddish()
        {
            return true;
        }
    }
}
