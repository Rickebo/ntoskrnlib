using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CHPEV2_PROCESS_INFO")]
    public sealed class CHPEV2ProcessInfo : DynamicStructure
    {
        public CHPEV2ProcessInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CHPEV2ProcessInfo>();
        }
    }
}