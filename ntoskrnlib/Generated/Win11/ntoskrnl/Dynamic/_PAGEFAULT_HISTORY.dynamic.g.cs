using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PAGEFAULT_HISTORY")]
    public sealed class _PAGEFAULT_HISTORY : DynamicStructure
    {
        public _PAGEFAULT_HISTORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PAGEFAULT_HISTORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_PAGEFAULT_HISTORY>((mem, ptr) => new _PAGEFAULT_HISTORY(mem, ptr), offsets);
        }
    }
}