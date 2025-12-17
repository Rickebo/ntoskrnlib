using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPTE_TIMESTAMP")]
    public sealed class MmpteTimestamp : DynamicStructure
    {
        [Offset(0UL)]
        public ulong MustBeZero { get => ReadHere<ulong>(nameof(MustBeZero)); set => WriteHere(nameof(MustBeZero), value); }

        [Offset(0UL)]
        public ulong Unused { get => ReadHere<ulong>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        [Offset(0UL)]
        public ulong SwizzleBit { get => ReadHere<ulong>(nameof(SwizzleBit)); set => WriteHere(nameof(SwizzleBit), value); }

        [Offset(0UL)]
        public ulong Protection { get => ReadHere<ulong>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public ulong Prototype { get => ReadHere<ulong>(nameof(Prototype)); set => WriteHere(nameof(Prototype), value); }

        [Offset(0UL)]
        public ulong Transition { get => ReadHere<ulong>(nameof(Transition)); set => WriteHere(nameof(Transition), value); }

        [Offset(0UL)]
        public ulong PageFileLow { get => ReadHere<ulong>(nameof(PageFileLow)); set => WriteHere(nameof(PageFileLow), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong GlobalTimeStamp { get => ReadHere<ulong>(nameof(GlobalTimeStamp)); set => WriteHere(nameof(GlobalTimeStamp), value); }

        public MmpteTimestamp(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpteTimestamp>();
        }
    }
}