using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_THREAD_RNG_STATE")]
    public sealed class RtlThreadRngState : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray State64 { get => ReadStructure<DynamicArray>(nameof(State64)); set => WriteStructure(nameof(State64), value); }

        [Offset(0UL)]
        [Length(4)]
        public DynamicArray State32 { get => ReadStructure<DynamicArray>(nameof(State32)); set => WriteStructure(nameof(State32), value); }

        public RtlThreadRngState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlThreadRngState>();
        }
    }
}