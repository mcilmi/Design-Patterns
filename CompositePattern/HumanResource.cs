using System;

namespace CompositePattern
{
    class HumanResource : IComponent
    {
        public void render()
        {
            Console.WriteLine("Render Human Resource");
        }
    }
}
