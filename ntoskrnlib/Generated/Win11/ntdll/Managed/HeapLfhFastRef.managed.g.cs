using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_FAST_REF")]
    public sealed class HeapLfhFastRef : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Target { get => ReadHere<IntPtr>(nameof(Target)); set => WriteHere(nameof(Target), value); }

        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public ulong RefCount { get => ReadHere<ulong>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        public HeapLfhFastRef(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhFastRef>();
        }
    }
}