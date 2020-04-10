using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class Editor {
        public void OpenProject() {
            IArtifact[] artifacts = {
                new MainIcon(new Artifact("Program")), 
                new ErrorIcon(new Artifact("Editor")), 
                new Artifact("Artifact") 
            };

            // Render the artifacts
            foreach (var artifact in artifacts) {
                Console.WriteLine(artifact.Render(""));
            }
        }
    }
}
