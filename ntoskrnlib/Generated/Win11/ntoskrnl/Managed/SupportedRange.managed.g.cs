using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SUPPORTED_RANGE")]
    public sealed class SupportedRange : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public uint SystemAddressSpace { get => ReadHere<uint>(nameof(SystemAddressSpace)); set => WriteHere(nameof(SystemAddressSpace), value); }

        [Offset(16UL)]
        public long SystemBase { get => ReadHere<long>(nameof(SystemBase)); set => WriteHere(nameof(SystemBase), value); }

        [Offset(24UL)]
        public long Base { get => ReadHere<long>(nameof(Base)); set => WriteHere(nameof(Base), value); }

        [Offset(32UL)]
        public long Limit { get => ReadHere<long>(nameof(Limit)); set => WriteHere(nameof(Limit), value); }

        public SupportedRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SupportedRange>();
        }
    }
}