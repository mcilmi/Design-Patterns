using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subteam1 = new Team();
            subteam1.add(new Truck());
            subteam1.add(new HumanResource());
            subteam1.add(new HumanResource());

            var subteam2 = new Team();
            subteam2.add(new Truck());
            subteam2.add(new HumanResource());
            subteam2.add(new HumanResource());

            var team = new Team();
            team.add(subteam1);
            team.add(subteam2);
            team.render();

        }
    }
}
