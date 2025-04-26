using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.Food
{
    public class Hamburger : FastFoodBase
    {
        public override void AddMeat()
        {
            Console.WriteLine("Добавлена котлета");
        }

        public override void AddSalat()
        {
            Console.WriteLine("Добавлены листья салата");
        }

        public override void AddTopping()
        {
            Console.WriteLine("Добавлен соус тысяча островов");
        }
    }
}
