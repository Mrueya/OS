using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.Food
{
    public class HotDog : FastFoodBase
    {
        public override void AddMeat()
        {
            Console.WriteLine("Добавлена сосиска");
        }

        public override void AddSalat()
        {
            Console.WriteLine("Добавлен жаренный лук");
        }

        public override void AddTopping()
        {
            Console.WriteLine("Добавлена горчица");
        }

        public override bool WantsTopping()
        {
            Console.WriteLine("Нужна горчица?");
            var readLine = Console.ReadLine();
            if (readLine != null || readLine.ToLower().Equals("да"))
            {
                return true;
            }
            return false;
        }
    }
}
