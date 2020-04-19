using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
    public class AdvancedRemoteControl : RemoteControl {
        public AdvancedRemoteControl(IDevice device) : base(device) {
        }

        public new void SetChannel(int number) {
            this.Device.SetChannel(number);
        }
    }
}
