using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ASSEMBLY_STORAGE_MAP")]
    public sealed class AssemblyStorageMap : DynamicStructure
    {
        public AssemblyStorageMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AssemblyStorageMap>();
        }
    }
}