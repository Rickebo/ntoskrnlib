using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SECONDARY_INTERRUPT_LINE_STATE")]
    public sealed class SecondaryInterruptLineState : DynamicStructure
    {
        [Offset(0UL)]
        public uint Polarity { get => ReadHere<uint>(nameof(Polarity)); set => WriteHere(nameof(Polarity), value); }

        [Offset(4UL)]
        public uint Mode { get => ReadHere<uint>(nameof(Mode)); set => WriteHere(nameof(Mode), value); }

        [Offset(8UL)]
        public uint Vector { get => ReadHere<uint>(nameof(Vector)); set => WriteHere(nameof(Vector), value); }

        [Offset(12UL)]
        public byte Unmasked { get => ReadHere<byte>(nameof(Unmasked)); set => WriteHere(nameof(Unmasked), value); }

        public SecondaryInterruptLineState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SecondaryInterruptLineState>();
        }
    }
}