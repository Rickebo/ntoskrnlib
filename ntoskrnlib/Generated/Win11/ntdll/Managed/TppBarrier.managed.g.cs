using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_BARRIER")]
    public sealed class TppBarrier : DynamicStructure
    {
        [Offset(0UL)]
        public TppFlagsCount Ptr { get => ReadStructure<TppFlagsCount>(nameof(Ptr)); set => WriteStructure(nameof(Ptr), value); }

        [Offset(8UL)]
        public RtlSrwlock WaitLock { get => ReadStructure<RtlSrwlock>(nameof(WaitLock)); set => WriteStructure(nameof(WaitLock), value); }

        [Offset(16UL)]
        public TppIte WaitList { get => ReadStructure<TppIte>(nameof(WaitList)); set => WriteStructure(nameof(WaitList), value); }

        public TppBarrier(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppBarrier>();
        }
    }
}