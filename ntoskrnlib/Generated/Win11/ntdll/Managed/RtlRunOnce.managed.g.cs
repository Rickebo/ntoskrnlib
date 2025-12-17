using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_RUN_ONCE")]
    public sealed class RtlRunOnce : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Ptr { get => ReadHere<IntPtr>(nameof(Ptr)); set => WriteHere(nameof(Ptr), value); }

        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public ulong State { get => ReadHere<ulong>(nameof(State)); set => WriteHere(nameof(State), value); }

        public RtlRunOnce(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlRunOnce>();
        }
    }
}