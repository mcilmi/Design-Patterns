using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
   public class RemoteControl : IRemoteControl {
       private readonly IDevice _device;
       public RemoteControl(IDevice device) { this._device = device; }

       public void TurnOn() {
           this._device.TurnOn();
       }

       public void TurnOff() {
           this._device.TurnOff();
       }

       public void SetChannel(int channelNumber) {
           this._device.SetChannel(channelNumber);
       }

   }
}
