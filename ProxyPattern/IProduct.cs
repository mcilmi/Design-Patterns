using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern {
    public interface IProduct {
         int GetId();
         string GetName();

         void SetName(string name);
    }
}
