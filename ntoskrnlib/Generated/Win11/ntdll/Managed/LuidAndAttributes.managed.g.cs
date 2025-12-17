using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_LUID_AND_ATTRIBUTES")]
    public sealed class LuidAndAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public Luid Luid { get => ReadStructure<Luid>(nameof(Luid)); set => WriteStructure(nameof(Luid), value); }

        [Offset(8UL)]
        public uint Attributes { get => ReadHere<uint>(nameof(Attributes)); set => WriteHere(nameof(Attributes), value); }

        public LuidAndAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LuidAndAttributes>();
        }
    }
}