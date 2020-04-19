using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
    public class SamsungTv : IDevice{
        public void TurnOn() { Console.WriteLine("SamsungTV: turn on"); }

        public void TurnOff() { Console.WriteLine("SamsungTV: turn off"); }

        public void SetChannel(int number) { Console.WriteLine($"SamsungTV: set channel to {number}"); }
    }
}
