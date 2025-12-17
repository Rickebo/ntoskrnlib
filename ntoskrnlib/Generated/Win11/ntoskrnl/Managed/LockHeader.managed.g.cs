using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOCK_HEADER")]
    public sealed class LockHeader : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTree LockTree { get => ReadStructure<RtlAvlTree>(nameof(LockTree)); set => WriteStructure(nameof(LockTree), value); }

        [Offset(8UL)]
        public RtlAvlTree LockMdlSwitchedTree { get => ReadStructure<RtlAvlTree>(nameof(LockMdlSwitchedTree)); set => WriteStructure(nameof(LockMdlSwitchedTree), value); }

        [Offset(16UL)]
        public ulong Count { get => ReadHere<ulong>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(24UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(28UL)]
        public uint Valid { get => ReadHere<uint>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        public LockHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LockHeader>();
        }
    }
}