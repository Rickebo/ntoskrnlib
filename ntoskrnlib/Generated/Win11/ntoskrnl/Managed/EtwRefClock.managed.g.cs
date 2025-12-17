using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_REF_CLOCK")]
    public sealed class EtwRefClock : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger StartTime { get => ReadStructure<LargeInteger>(nameof(StartTime)); set => WriteStructure(nameof(StartTime), value); }

        [Offset(8UL)]
        public LargeInteger StartPerfClock { get => ReadStructure<LargeInteger>(nameof(StartPerfClock)); set => WriteStructure(nameof(StartPerfClock), value); }

        public EtwRefClock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwRefClock>();
        }
    }
}