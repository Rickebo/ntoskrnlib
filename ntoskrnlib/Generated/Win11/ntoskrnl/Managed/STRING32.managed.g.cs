using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_STRING32")]
    public sealed class STRING32 : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Length { get => ReadHere<ushort>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort MaximumLength { get => ReadHere<ushort>(nameof(MaximumLength)); set => WriteHere(nameof(MaximumLength), value); }

        [Offset(4UL)]
        public uint Buffer { get => ReadHere<uint>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        public STRING32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<STRING32>();
        }
    }
}