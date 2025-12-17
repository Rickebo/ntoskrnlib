using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMAR_PAGE_TABLE_STATE")]
    public sealed class _DMAR_PAGE_TABLE_STATE : DynamicStructure
    {
        public _DMAR_PAGE_TABLE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMAR_PAGE_TABLE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_DMAR_PAGE_TABLE_STATE>((mem, ptr) => new _DMAR_PAGE_TABLE_STATE(mem, ptr), offsets);
        }
    }
}