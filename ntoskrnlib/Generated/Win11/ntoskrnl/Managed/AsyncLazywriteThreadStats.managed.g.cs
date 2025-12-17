using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ASYNC_LAZYWRITE_THREAD_STATS")]
    public sealed class AsyncLazywriteThreadStats : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CurrentLoad { get => ReadHere<IntPtr>(nameof(CurrentLoad)); set => WriteHere(nameof(CurrentLoad), value); }

        public AsyncLazywriteThreadStats(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AsyncLazywriteThreadStats>();
        }
    }
}