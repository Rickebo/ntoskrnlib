using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KLDTENTRY")]
    public sealed class Kldtentry : DynamicStructure
    {
        [Offset(0UL)]
        public ushort LimitLow { get => ReadHere<ushort>(nameof(LimitLow)); set => WriteHere(nameof(LimitLow), value); }

        [Offset(2UL)]
        public ushort BaseLow { get => ReadHere<ushort>(nameof(BaseLow)); set => WriteHere(nameof(BaseLow), value); }

        [Offset(4UL)]
        public UnnamedTag HighWord { get => ReadStructure<UnnamedTag>(nameof(HighWord)); set => WriteStructure(nameof(HighWord), value); }

        public Kldtentry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kldtentry>();
        }
    }
}