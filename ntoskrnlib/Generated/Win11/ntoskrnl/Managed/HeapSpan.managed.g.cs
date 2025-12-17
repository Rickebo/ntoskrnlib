using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_SPAN")]
    public sealed class HeapSpan : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Address { get => ReadHere<IntPtr>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(8UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        public HeapSpan(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapSpan>();
        }
    }
}