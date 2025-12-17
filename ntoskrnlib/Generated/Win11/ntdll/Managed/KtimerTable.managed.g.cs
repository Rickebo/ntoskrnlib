using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KTIMER_TABLE")]
    public sealed class KtimerTable : DynamicStructure
    {
        [Offset(0UL)]
        [Length(64)]
        public DynamicArray TimerExpiry { get => ReadStructure<DynamicArray>(nameof(TimerExpiry)); set => WriteStructure(nameof(TimerExpiry), value); }

        [Offset(512UL)]
        [Length(2)]
        public DynamicArray TimerEntries { get => ReadStructure<DynamicArray>(nameof(TimerEntries)); set => WriteStructure(nameof(TimerEntries), value); }

        [Offset(16896UL)]
        public KtimerTableState TableState { get => ReadStructure<KtimerTableState>(nameof(TableState)); set => WriteStructure(nameof(TableState), value); }

        public KtimerTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtimerTable>();
        }
    }
}