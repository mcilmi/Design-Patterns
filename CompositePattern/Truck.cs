using System;

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
