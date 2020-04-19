using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
   public class RemoteControl : IRemoteControl {
       protected readonly IDevice Device;

       public RemoteControl(IDevice device) {this.Device = device; }

        public void TurnOn() {
           this.Device.TurnOn();
       }

       public void TurnOff() {
           this.Device.TurnOff();
       }

       public void SetChannel(int channelNumber) {
           this.Device.SetChannel(channelNumber);
       }

   }
}
