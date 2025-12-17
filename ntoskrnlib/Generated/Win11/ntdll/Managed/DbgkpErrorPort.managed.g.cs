using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DBGKP_ERROR_PORT")]
    public sealed class DbgkpErrorPort : DynamicStructure
    {
        public DbgkpErrorPort(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkpErrorPort>();
        }
    }
}