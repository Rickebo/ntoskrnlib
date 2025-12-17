using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_CONDITION_VARIABLE")]
    public sealed class RtlConditionVariable : DynamicStructure
    {
        [Offset(0UL)]
        public ulong WakeCount { get => ReadHere<ulong>(nameof(WakeCount)); set => WriteHere(nameof(WakeCount), value); }

        [Offset(0UL)]
        public ulong Waking { get => ReadHere<ulong>(nameof(Waking)); set => WriteHere(nameof(Waking), value); }

        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public IntPtr Ptr { get => ReadHere<IntPtr>(nameof(Ptr)); set => WriteHere(nameof(Ptr), value); }

        public RtlConditionVariable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlConditionVariable>();
        }
    }
}