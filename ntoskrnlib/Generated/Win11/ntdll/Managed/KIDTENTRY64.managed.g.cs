using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KIDTENTRY64")]
    public sealed class KIDTENTRY64 : DynamicStructure
    {
        [Offset(0UL)]
        public ushort OffsetLow { get => ReadHere<ushort>(nameof(OffsetLow)); set => WriteHere(nameof(OffsetLow), value); }

        [Offset(2UL)]
        public ushort Selector { get => ReadHere<ushort>(nameof(Selector)); set => WriteHere(nameof(Selector), value); }

        [Offset(4UL)]
        public ushort IstIndex { get => ReadHere<ushort>(nameof(IstIndex)); set => WriteHere(nameof(IstIndex), value); }

        [Offset(4UL)]
        public ushort Reserved0 { get => ReadHere<ushort>(nameof(Reserved0)); set => WriteHere(nameof(Reserved0), value); }

        [Offset(4UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public ushort Dpl { get => ReadHere<ushort>(nameof(Dpl)); set => WriteHere(nameof(Dpl), value); }

        [Offset(4UL)]
        public ushort Present { get => ReadHere<ushort>(nameof(Present)); set => WriteHere(nameof(Present), value); }

        [Offset(6UL)]
        public ushort OffsetMiddle { get => ReadHere<ushort>(nameof(OffsetMiddle)); set => WriteHere(nameof(OffsetMiddle), value); }

        [Offset(8UL)]
        public uint OffsetHigh { get => ReadHere<uint>(nameof(OffsetHigh)); set => WriteHere(nameof(OffsetHigh), value); }

        [Offset(12UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(0UL)]
        public ulong Alignment { get => ReadHere<ulong>(nameof(Alignment)); set => WriteHere(nameof(Alignment), value); }

        public KIDTENTRY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KIDTENTRY64>();
        }
    }
}