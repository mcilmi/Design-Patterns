using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
    public class SonyRemoteControl : RemoteControl {
        public override void TurnOn() { Console.WriteLine("Sony: TurnOn");}

        public override void TurnOff() { Console.WriteLine("Sony: TurnOff");}
    }
}
