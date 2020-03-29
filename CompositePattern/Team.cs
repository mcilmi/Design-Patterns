using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Team : IComponent
    {
        private IList<IComponent> teams = new List<IComponent>();

        public void add(IComponent member)
        {
            teams.Add(member);
        }
        public void render()
        {
            foreach(var member in teams)
            {
                member.render();
            }
        }
    }
}
