using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMethod
{
    internal class Program
    {
        static void Main()
        {
            DrinkBehavior coffee = new Coffee(true);
            coffee.Create();
            
            DrinkBehavior tea = new Tea();
            tea.Create();
            
            DrinkBehavior coffeeWithSugarAndMilk = new Coffee(true);
            coffeeWithSugarAndMilk.Create();

            Console.ReadLine();
        }
    }
}
