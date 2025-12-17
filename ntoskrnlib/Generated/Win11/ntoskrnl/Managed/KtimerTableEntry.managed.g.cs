using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTIMER_TABLE_ENTRY")]
    public sealed class KtimerTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public ListEntry Entry { get => ReadStructure<ListEntry>(nameof(Entry)); set => WriteStructure(nameof(Entry), value); }

        [Offset(24UL)]
        public UlargeInteger Time { get => ReadStructure<UlargeInteger>(nameof(Time)); set => WriteStructure(nameof(Time), value); }

        public KtimerTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtimerTableEntry>();
        }
    }
}