using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    
    public class Artifact : IArtifact
    {
        private readonly string _name;
        public Artifact(string name)
        {
            this._name = name;
        }
        public string Render(string icons) {
            return $"{this._name} {icons}";
        }

    }
}
