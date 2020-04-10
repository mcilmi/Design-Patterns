using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public interface IArtifact
    {
        string Render(string name);
    }
}
