using System;

namespace DesignPatterns
{
    class Shape : IComponent
    {
        public void render()
        {
            Console.WriteLine("Rendering shape");
        }
    }
}
