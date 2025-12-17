using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_CLONE_BLOCK_FLAGS")]
    public sealed class MiCloneBlockFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CloneProtection { get => ReadHere<ulong>(nameof(CloneProtection)); set => WriteHere(nameof(CloneProtection), value); }

        [Offset(0UL)]
        public ulong ReducedCommitReferences { get => ReadHere<ulong>(nameof(ReducedCommitReferences)); set => WriteHere(nameof(ReducedCommitReferences), value); }

        [Offset(0UL)]
        public ulong ScpPage { get => ReadHere<ulong>(nameof(ScpPage)); set => WriteHere(nameof(ScpPage), value); }

        [Offset(0UL)]
        public ulong Spare { get => ReadHere<ulong>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public ulong LockBit { get => ReadHere<ulong>(nameof(LockBit)); set => WriteHere(nameof(LockBit), value); }

        [Offset(0UL)]
        public long EntireField { get => ReadHere<long>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MiCloneBlockFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCloneBlockFlags>();
        }
    }
}