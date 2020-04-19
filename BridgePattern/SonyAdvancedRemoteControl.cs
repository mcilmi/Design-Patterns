using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
    public class SonyAdvancedRemoteControl : AdvancedRemoteControl {
        public override void TurnOn() { Console.WriteLine("Sony: turnOn"); }

        public override void TurnOff() { Console.WriteLine("Sony: turnOff"); }

        public override void SetChannel(int number) {  }
    }
}
