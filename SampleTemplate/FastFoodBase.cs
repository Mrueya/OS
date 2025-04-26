using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.Food
{
    public abstract class FastFoodBase
    {
        public void PrepareFood()
        {
            Console.WriteLine("Готовим еду:");
            AddBread();
            AddSalat();
            AddMeat();
            if(WantsTopping())
            {
                AddTopping();
            }
        }
        private void AddBread()
        {
            Console.WriteLine("Добавлен хлеб");
        }
        public abstract void AddSalat();
        public abstract void AddMeat();
        public abstract void AddTopping();
        public virtual bool WantsTopping()
        {
            return true;
        }

    }
}
