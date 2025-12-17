using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_POOL_ENTRY_INUSE")]
    public sealed class ViPoolEntryInuse : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr VirtualAddress { get => ReadHere<IntPtr>(nameof(VirtualAddress)); set => WriteHere(nameof(VirtualAddress), value); }

        [Offset(8UL)]
        public IntPtr CallingAddress { get => ReadHere<IntPtr>(nameof(CallingAddress)); set => WriteHere(nameof(CallingAddress), value); }

        [Offset(16UL)]
        public ulong NumberOfBytes { get => ReadHere<ulong>(nameof(NumberOfBytes)); set => WriteHere(nameof(NumberOfBytes), value); }

        [Offset(24UL)]
        public ulong Tag { get => ReadHere<ulong>(nameof(Tag)); set => WriteHere(nameof(Tag), value); }

        public ViPoolEntryInuse(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViPoolEntryInuse>();
        }
    }
}