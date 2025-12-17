using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_GEN_ADDR")]
    public sealed class GenAddr : DynamicStructure
    {
        [Offset(0UL)]
        public byte AddressSpaceID { get => ReadHere<byte>(nameof(AddressSpaceID)); set => WriteHere(nameof(AddressSpaceID), value); }

        [Offset(1UL)]
        public byte BitWidth { get => ReadHere<byte>(nameof(BitWidth)); set => WriteHere(nameof(BitWidth), value); }

        [Offset(2UL)]
        public byte BitOffset { get => ReadHere<byte>(nameof(BitOffset)); set => WriteHere(nameof(BitOffset), value); }

        [Offset(3UL)]
        public byte AccessSize { get => ReadHere<byte>(nameof(AccessSize)); set => WriteHere(nameof(AccessSize), value); }

        [Offset(4UL)]
        public LargeInteger Address { get => ReadStructure<LargeInteger>(nameof(Address)); set => WriteStructure(nameof(Address), value); }

        public GenAddr(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<GenAddr>();
        }
    }
}