using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_POWER_SEQUENCE")]
    public sealed class PowerSequence : DynamicStructure
    {
        [Offset(0UL)]
        public uint SequenceD1 { get => ReadHere<uint>(nameof(SequenceD1)); set => WriteHere(nameof(SequenceD1), value); }

        [Offset(4UL)]
        public uint SequenceD2 { get => ReadHere<uint>(nameof(SequenceD2)); set => WriteHere(nameof(SequenceD2), value); }

        [Offset(8UL)]
        public uint SequenceD3 { get => ReadHere<uint>(nameof(SequenceD3)); set => WriteHere(nameof(SequenceD3), value); }

        public PowerSequence(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PowerSequence>();
        }
    }
}