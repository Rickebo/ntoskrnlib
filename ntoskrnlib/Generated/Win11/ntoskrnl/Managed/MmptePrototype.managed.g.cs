using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPTE_PROTOTYPE")]
    public sealed class MmptePrototype : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Valid { get => ReadHere<ulong>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        [Offset(0UL)]
        public ulong DemandFillProto { get => ReadHere<ulong>(nameof(DemandFillProto)); set => WriteHere(nameof(DemandFillProto), value); }

        [Offset(0UL)]
        public ulong HiberVerifyConverted { get => ReadHere<ulong>(nameof(HiberVerifyConverted)); set => WriteHere(nameof(HiberVerifyConverted), value); }

        [Offset(0UL)]
        public ulong ReadOnly { get => ReadHere<ulong>(nameof(ReadOnly)); set => WriteHere(nameof(ReadOnly), value); }

        [Offset(0UL)]
        public ulong SwizzleBit { get => ReadHere<ulong>(nameof(SwizzleBit)); set => WriteHere(nameof(SwizzleBit), value); }

        [Offset(0UL)]
        public ulong Protection { get => ReadHere<ulong>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public ulong Prototype { get => ReadHere<ulong>(nameof(Prototype)); set => WriteHere(nameof(Prototype), value); }

        [Offset(0UL)]
        public ulong Combined { get => ReadHere<ulong>(nameof(Combined)); set => WriteHere(nameof(Combined), value); }

        [Offset(0UL)]
        public ulong Unused1 { get => ReadHere<ulong>(nameof(Unused1)); set => WriteHere(nameof(Unused1), value); }

        [Offset(0UL)]
        public long ProtoAddress { get => ReadHere<long>(nameof(ProtoAddress)); set => WriteHere(nameof(ProtoAddress), value); }

        public MmptePrototype(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmptePrototype>();
        }
    }
}