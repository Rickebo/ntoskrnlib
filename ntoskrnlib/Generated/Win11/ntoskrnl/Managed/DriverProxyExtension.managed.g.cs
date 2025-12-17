using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DRIVER_PROXY_EXTENSION")]
    public sealed class DriverProxyExtension : DynamicStructure
    {
        public DriverProxyExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DriverProxyExtension>();
        }
    }
}