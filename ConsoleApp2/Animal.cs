using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public bool IsAlive { get; set; } = true;

        protected Action LifeAction;

        public Animal()
        {
            var timer = async () => {
                do {
                    await Task.Delay(1000);
                    LifeAction?.Invoke();
                }
                while (IsAlive);
            };
            timer();
        }


    }
}
