using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CI_NGEN_PATHS")]
    public sealed class CiNgenPaths : DynamicStructure
    {
        public CiNgenPaths(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CiNgenPaths>();
        }
    }
}