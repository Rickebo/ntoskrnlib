using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_TICK_LOCK")]
    public sealed class RtlTickLock : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AsULong64 { get => ReadHere<ulong>(nameof(AsULong64)); set => WriteHere(nameof(AsULong64), value); }

        [Offset(0UL)]
        public ulong Busy { get => ReadHere<ulong>(nameof(Busy)); set => WriteHere(nameof(Busy), value); }

        [Offset(0UL)]
        public ulong Ticks { get => ReadHere<ulong>(nameof(Ticks)); set => WriteHere(nameof(Ticks), value); }

        public RtlTickLock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlTickLock>();
        }
    }
}