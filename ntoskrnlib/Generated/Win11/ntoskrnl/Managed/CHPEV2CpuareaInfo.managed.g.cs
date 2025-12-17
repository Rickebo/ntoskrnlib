using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CHPEV2_CPUAREA_INFO")]
    public sealed class CHPEV2CpuareaInfo : DynamicStructure
    {
        public CHPEV2CpuareaInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CHPEV2CpuareaInfo>();
        }
    }
}