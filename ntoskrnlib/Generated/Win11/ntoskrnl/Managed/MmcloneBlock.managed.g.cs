using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMCLONE_BLOCK")]
    public sealed class MmcloneBlock : DynamicStructure
    {
        [Offset(0UL)]
        public Mmpte ProtoPte { get => ReadStructure<Mmpte>(nameof(ProtoPte)); set => WriteStructure(nameof(ProtoPte), value); }

        [Offset(8UL)]
        public ulong CrossPartitionReferences { get => ReadHere<ulong>(nameof(CrossPartitionReferences)); set => WriteHere(nameof(CrossPartitionReferences), value); }

        [Offset(16UL)]
        public MiCloneBlockFlags u1 { get => ReadStructure<MiCloneBlockFlags>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(24UL)]
        public ulong UseCount { get => ReadHere<ulong>(nameof(UseCount)); set => WriteHere(nameof(UseCount), value); }

        public MmcloneBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmcloneBlock>();
        }
    }
}