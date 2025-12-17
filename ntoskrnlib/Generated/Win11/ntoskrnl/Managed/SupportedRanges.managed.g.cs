using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SUPPORTED_RANGES")]
    public sealed class SupportedRanges : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(2UL)]
        public byte Sorted { get => ReadHere<byte>(nameof(Sorted)); set => WriteHere(nameof(Sorted), value); }

        [Offset(3UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint NoIO { get => ReadHere<uint>(nameof(NoIO)); set => WriteHere(nameof(NoIO), value); }

        [Offset(8UL)]
        public SupportedRange IO { get => ReadStructure<SupportedRange>(nameof(IO)); set => WriteStructure(nameof(IO), value); }

        [Offset(48UL)]
        public uint NoMemory { get => ReadHere<uint>(nameof(NoMemory)); set => WriteHere(nameof(NoMemory), value); }

        [Offset(56UL)]
        public SupportedRange Memory { get => ReadStructure<SupportedRange>(nameof(Memory)); set => WriteStructure(nameof(Memory), value); }

        [Offset(96UL)]
        public uint NoPrefetchMemory { get => ReadHere<uint>(nameof(NoPrefetchMemory)); set => WriteHere(nameof(NoPrefetchMemory), value); }

        [Offset(104UL)]
        public SupportedRange PrefetchMemory { get => ReadStructure<SupportedRange>(nameof(PrefetchMemory)); set => WriteStructure(nameof(PrefetchMemory), value); }

        [Offset(144UL)]
        public uint NoDma { get => ReadHere<uint>(nameof(NoDma)); set => WriteHere(nameof(NoDma), value); }

        [Offset(152UL)]
        public SupportedRange Dma { get => ReadStructure<SupportedRange>(nameof(Dma)); set => WriteStructure(nameof(Dma), value); }

        public SupportedRanges(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SupportedRanges>();
        }
    }
}