using System;

namespace BridgePattern {
    public class Program {
        public static void Main(string[] args) {
            var remoteControl = new RemoteControl(new SamsungTv());
            remoteControl.TurnOn();
            remoteControl.SetChannel(34);
            remoteControl.SetChannel(27);
            remoteControl.TurnOff();
        }
    }
}
