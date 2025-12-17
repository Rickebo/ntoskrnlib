using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_STD_LIST_HEAD")]
    public sealed class RtlStdListHead : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public RtlStackDatabaseLock Lock { get => ReadStructure<RtlStackDatabaseLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        public RtlStdListHead(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlStdListHead>();
        }
    }
}