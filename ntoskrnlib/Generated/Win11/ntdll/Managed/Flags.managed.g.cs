using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_flags")]
    public sealed class Flags : DynamicStructure
    {
        [Offset(0UL)]
        public byte SmtSetsPresent { get => ReadHere<byte>(nameof(SmtSetsPresent)); set => WriteHere(nameof(SmtSetsPresent), value); }

        [Offset(0UL)]
        public byte Fill { get => ReadHere<byte>(nameof(Fill)); set => WriteHere(nameof(Fill), value); }

        public Flags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Flags>();
        }
    }
}