using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ASSEMBLY_STORAGE_MAP")]
    public sealed class _ASSEMBLY_STORAGE_MAP : DynamicStructure
    {
        public _ASSEMBLY_STORAGE_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ASSEMBLY_STORAGE_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ASSEMBLY_STORAGE_MAP>((mem, ptr) => new _ASSEMBLY_STORAGE_MAP(mem, ptr), offsets);
        }
    }
}