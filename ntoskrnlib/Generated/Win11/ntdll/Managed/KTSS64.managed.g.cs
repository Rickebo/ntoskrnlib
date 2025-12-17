using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KTSS64")]
    public sealed class KTSS64 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Reserved0 { get => ReadHere<uint>(nameof(Reserved0)); set => WriteHere(nameof(Reserved0), value); }

        [Offset(4UL)]
        public ulong Rsp0 { get => ReadHere<ulong>(nameof(Rsp0)); set => WriteHere(nameof(Rsp0), value); }

        [Offset(12UL)]
        public ulong Rsp1 { get => ReadHere<ulong>(nameof(Rsp1)); set => WriteHere(nameof(Rsp1), value); }

        [Offset(20UL)]
        public ulong Rsp2 { get => ReadHere<ulong>(nameof(Rsp2)); set => WriteHere(nameof(Rsp2), value); }

        [Offset(28UL)]
        [Length(8)]
        public DynamicArray Ist { get => ReadStructure<DynamicArray>(nameof(Ist)); set => WriteStructure(nameof(Ist), value); }

        [Offset(92UL)]
        public ulong Reserved1 { get => ReadHere<ulong>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(100UL)]
        public ushort Reserved2 { get => ReadHere<ushort>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(102UL)]
        public ushort IoMapBase { get => ReadHere<ushort>(nameof(IoMapBase)); set => WriteHere(nameof(IoMapBase), value); }

        public KTSS64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KTSS64>();
        }
    }
}