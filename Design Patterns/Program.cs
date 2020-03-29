using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group();
            group1.add(new Shape()); // image a squar
            group1.add(new Shape());

            var group2 = new Group();
            group2.add(new Shape());
            group2.add(new Shape());

            var group = new Group();
            group.add(group1);
            group.add(group2);

            group.render();

            Console.ReadKey();
        }
    }
}
