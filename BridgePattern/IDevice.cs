using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
    public interface IDevice {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}
