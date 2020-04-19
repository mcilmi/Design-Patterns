using System;
using System.Collections.Generic;
using System.Text;

// RemoteControl
//  SonyRemoteControl
//  AdvancedRemoteControl
//      SonyAdvancedRemoteControl    

namespace BridgePattern {
   public abstract class RemoteControl {
       public abstract void TurnOn();

       public abstract void TurnOff();
   }
}
