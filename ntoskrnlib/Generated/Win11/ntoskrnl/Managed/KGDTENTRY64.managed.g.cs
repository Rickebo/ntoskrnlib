using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KGDTENTRY64")]
    public sealed class KGDTENTRY64 : DynamicStructure
    {
        [Offset(0UL)]
        public ushort LimitLow { get => ReadHere<ushort>(nameof(LimitLow)); set => WriteHere(nameof(LimitLow), value); }

        [Offset(2UL)]
        public ushort BaseLow { get => ReadHere<ushort>(nameof(BaseLow)); set => WriteHere(nameof(BaseLow), value); }

        [Offset(4UL)]
        public UnnamedTag Bytes { get => ReadStructure<UnnamedTag>(nameof(Bytes)); set => WriteStructure(nameof(Bytes), value); }

        [Offset(4UL)]
        public UnnamedTag Bits { get => ReadStructure<UnnamedTag>(nameof(Bits)); set => WriteStructure(nameof(Bits), value); }

        [Offset(8UL)]
        public uint BaseUpper { get => ReadHere<uint>(nameof(BaseUpper)); set => WriteHere(nameof(BaseUpper), value); }

        [Offset(12UL)]
        public uint MustBeZero { get => ReadHere<uint>(nameof(MustBeZero)); set => WriteHere(nameof(MustBeZero), value); }

        [Offset(0UL)]
        public long DataLow { get => ReadHere<long>(nameof(DataLow)); set => WriteHere(nameof(DataLow), value); }

        [Offset(8UL)]
        public long DataHigh { get => ReadHere<long>(nameof(DataHigh)); set => WriteHere(nameof(DataHigh), value); }

        public KGDTENTRY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KGDTENTRY64>();
        }
    }
}