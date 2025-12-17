using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTIMER_TABLE_STATE")]
    public sealed class KtimerTableState : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray LastTimerExpiration { get => ReadStructure<DynamicArray>(nameof(LastTimerExpiration)); set => WriteStructure(nameof(LastTimerExpiration), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray LastTimerHand { get => ReadStructure<DynamicArray>(nameof(LastTimerHand)); set => WriteStructure(nameof(LastTimerHand), value); }

        public KtimerTableState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtimerTableState>();
        }
    }
}