using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMCLONE_HEADER")]
    public sealed class MmcloneHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ulong NumberOfPtes { get => ReadHere<ulong>(nameof(NumberOfPtes)); set => WriteHere(nameof(NumberOfPtes), value); }

        [Offset(8UL)]
        public ulong NumberOfProcessReferences { get => ReadHere<ulong>(nameof(NumberOfProcessReferences)); set => WriteHere(nameof(NumberOfProcessReferences), value); }

        [Offset(16UL)]
        public IntPtr ClonePtes { get => ReadHere<IntPtr>(nameof(ClonePtes)); set => WriteHere(nameof(ClonePtes), value); }

        [Offset(24UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        public MmcloneHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmcloneHeader>();
        }
    }
}