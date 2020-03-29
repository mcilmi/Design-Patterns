using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Group : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void add(IComponent component)
        {
            components.Add(component);
        }
        public void render()
        {
            Console.WriteLine("Rendering Group: ");
            foreach(var component in components)
            {
                component.render();
            }
        }
    }
}
