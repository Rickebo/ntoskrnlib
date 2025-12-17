using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_INSTANCE")]
    public sealed class _PCW_INSTANCE : DynamicStructure
    {
        public _PCW_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_PCW_INSTANCE>((mem, ptr) => new _PCW_INSTANCE(mem, ptr), offsets);
        }
    }
}