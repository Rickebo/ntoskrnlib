using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSR_FLAGS")]
    public sealed class KsrFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint MpwrResume { get => ReadHere<uint>(nameof(MpwrResume)); set => WriteHere(nameof(MpwrResume), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AsULong { get => ReadHere<uint>(nameof(AsULong)); set => WriteHere(nameof(AsULong), value); }

        public KsrFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsrFlags>();
        }
    }
}