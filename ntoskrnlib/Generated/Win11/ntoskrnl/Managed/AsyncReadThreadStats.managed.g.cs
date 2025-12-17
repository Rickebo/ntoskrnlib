using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ASYNC_READ_THREAD_STATS")]
    public sealed class AsyncReadThreadStats : DynamicStructure
    {
        [Offset(0UL)]
        [Length(101)]
        public DynamicArray CurrentLoad { get => ReadStructure<DynamicArray>(nameof(CurrentLoad)); set => WriteStructure(nameof(CurrentLoad), value); }

        public AsyncReadThreadStats(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AsyncReadThreadStats>();
        }
    }
}