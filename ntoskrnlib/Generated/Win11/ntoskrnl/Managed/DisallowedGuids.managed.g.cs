using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DISALLOWED_GUIDS")]
    public sealed class DisallowedGuids : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Count { get => ReadHere<ushort>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        public IntPtr Guids { get => ReadHere<IntPtr>(nameof(Guids)); set => WriteHere(nameof(Guids), value); }

        public DisallowedGuids(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DisallowedGuids>();
        }
    }
}