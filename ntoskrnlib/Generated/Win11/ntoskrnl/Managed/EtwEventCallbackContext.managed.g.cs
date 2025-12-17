using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_EVENT_CALLBACK_CONTEXT")]
    public sealed class EtwEventCallbackContext : DynamicStructure
    {
        public EtwEventCallbackContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwEventCallbackContext>();
        }
    }
}