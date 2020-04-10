using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class ErrorIcon : IArtifact
    {
        private readonly IArtifact artifact;
        public ErrorIcon(IArtifact artifact)
        {
            this.artifact = artifact;

        }
        public string Render(string name)
        {
            return this.artifact.Render($"{name} [Error]");
        }
    }
}
