using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_LIST_ENTRY")]
    public sealed class HeapLfhListEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Next { get => ReadHere<ushort>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(0UL)]
        public ulong Preserve { get => ReadHere<ulong>(nameof(Preserve)); set => WriteHere(nameof(Preserve), value); }

        [Offset(8UL)]
        public uint Check { get => ReadHere<uint>(nameof(Check)); set => WriteHere(nameof(Check), value); }

        public HeapLfhListEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhListEntry>();
        }
    }
}