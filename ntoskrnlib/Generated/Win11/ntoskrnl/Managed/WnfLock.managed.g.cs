using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_LOCK")]
    public sealed class WnfLock : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock PushLock { get => ReadStructure<ExPushLock>(nameof(PushLock)); set => WriteStructure(nameof(PushLock), value); }

        public WnfLock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfLock>();
        }
    }
}