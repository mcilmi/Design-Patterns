using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
   public class MainIcon : IArtifact {
        private readonly IArtifact _artifact;

        public MainIcon(IArtifact artifact)
        {
            this._artifact = artifact;
        }
        public string Render(string name)
        {
            return _artifact.Render($"{name} [Main]");
        }
    }
}
