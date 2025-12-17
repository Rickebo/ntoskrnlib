using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SID_AND_ATTRIBUTES")]
    public sealed class SidAndAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Sid { get => ReadHere<IntPtr>(nameof(Sid)); set => WriteHere(nameof(Sid), value); }

        [Offset(8UL)]
        public uint Attributes { get => ReadHere<uint>(nameof(Attributes)); set => WriteHere(nameof(Attributes), value); }

        public SidAndAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SidAndAttributes>();
        }
    }
}