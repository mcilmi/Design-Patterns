using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Truck : IComponent
    {
        public void render()
        {
            Console.WriteLine("Render a Truck");
        }
    }
}
