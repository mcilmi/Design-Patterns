using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
    public abstract class  AdvancedRemoteControl : RemoteControl {
        public abstract void SetChannel(int number);
    }
}
