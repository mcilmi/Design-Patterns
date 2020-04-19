using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
    public interface IRemoteControl {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int channelNumber);
    }
}
