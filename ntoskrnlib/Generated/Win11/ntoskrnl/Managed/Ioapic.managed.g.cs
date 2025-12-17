using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOAPIC")]
    public sealed class Ioapic : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public byte IOAPICID { get => ReadHere<byte>(nameof(IOAPICID)); set => WriteHere(nameof(IOAPICID), value); }

        [Offset(3UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint IOAPICAddress { get => ReadHere<uint>(nameof(IOAPICAddress)); set => WriteHere(nameof(IOAPICAddress), value); }

        [Offset(8UL)]
        public uint SystemVectorBase { get => ReadHere<uint>(nameof(SystemVectorBase)); set => WriteHere(nameof(SystemVectorBase), value); }

        public Ioapic(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Ioapic>();
        }
    }
}