using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CACHE_DESCRIPTOR")]
    public sealed class CacheDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(1UL)]
        public byte Associativity { get => ReadHere<byte>(nameof(Associativity)); set => WriteHere(nameof(Associativity), value); }

        [Offset(2UL)]
        public ushort LineSize { get => ReadHere<ushort>(nameof(LineSize)); set => WriteHere(nameof(LineSize), value); }

        [Offset(4UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        public CacheDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CacheDescriptor>();
        }
    }
}