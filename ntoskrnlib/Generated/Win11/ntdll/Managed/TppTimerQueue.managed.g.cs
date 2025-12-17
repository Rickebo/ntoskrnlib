using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_TIMER_QUEUE")]
    public sealed class TppTimerQueue : DynamicStructure
    {
        [Offset(0UL)]
        public RtlSrwlock Lock { get => ReadStructure<RtlSrwlock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(8UL)]
        public TppTimerSubqueue AbsoluteQueue { get => ReadStructure<TppTimerSubqueue>(nameof(AbsoluteQueue)); set => WriteStructure(nameof(AbsoluteQueue), value); }

        [Offset(128UL)]
        public TppTimerSubqueue RelativeQueue { get => ReadStructure<TppTimerSubqueue>(nameof(RelativeQueue)); set => WriteStructure(nameof(RelativeQueue), value); }

        [Offset(248UL)]
        public int AllocatedTimerCount { get => ReadHere<int>(nameof(AllocatedTimerCount)); set => WriteHere(nameof(AllocatedTimerCount), value); }

        public TppTimerQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppTimerQueue>();
        }
    }
}