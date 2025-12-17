using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ASSEMBLY_STORAGE_MAP")]
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