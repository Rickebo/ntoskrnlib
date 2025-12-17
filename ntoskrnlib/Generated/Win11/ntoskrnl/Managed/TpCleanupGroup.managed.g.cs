using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TP_CLEANUP_GROUP")]
    public sealed class TpCleanupGroup : DynamicStructure
    {
        public TpCleanupGroup(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpCleanupGroup>();
        }
    }
}