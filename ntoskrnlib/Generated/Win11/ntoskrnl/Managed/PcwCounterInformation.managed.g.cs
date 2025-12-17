using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCW_COUNTER_INFORMATION")]
    public sealed class PcwCounterInformation : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CounterMask { get => ReadHere<ulong>(nameof(CounterMask)); set => WriteHere(nameof(CounterMask), value); }

        [Offset(8UL)]
        public IntPtr InstanceMask { get => ReadHere<IntPtr>(nameof(InstanceMask)); set => WriteHere(nameof(InstanceMask), value); }

        public PcwCounterInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PcwCounterInformation>();
        }
    }
}