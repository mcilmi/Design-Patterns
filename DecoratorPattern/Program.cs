using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class Program {
        public static void Main(string[] args) {
            var editor = new Editor();
            editor.OpenProjects();
        }
    }
}
