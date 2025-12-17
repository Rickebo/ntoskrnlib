using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOSAPIC")]
    public sealed class Iosapic : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public byte IOSAPICID { get => ReadHere<byte>(nameof(IOSAPICID)); set => WriteHere(nameof(IOSAPICID), value); }

        [Offset(3UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint SystemVectorBase { get => ReadHere<uint>(nameof(SystemVectorBase)); set => WriteHere(nameof(SystemVectorBase), value); }

        [Offset(8UL)]
        public ulong IOSAPICAddress { get => ReadHere<ulong>(nameof(IOSAPICAddress)); set => WriteHere(nameof(IOSAPICAddress), value); }

        public Iosapic(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Iosapic>();
        }
    }
}