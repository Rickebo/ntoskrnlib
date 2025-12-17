using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_STACK_DATABASE_LOCK")]
    public sealed class RtlStackDatabaseLock : DynamicStructure
    {
        [Offset(0UL)]
        public RtlSrwlock Lock { get => ReadStructure<RtlSrwlock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        public RtlStackDatabaseLock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlStackDatabaseLock>();
        }
    }
}