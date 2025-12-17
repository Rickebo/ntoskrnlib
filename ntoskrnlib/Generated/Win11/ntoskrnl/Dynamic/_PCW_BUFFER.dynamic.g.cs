using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_BUFFER")]
    public sealed class _PCW_BUFFER : DynamicStructure
    {
        public _PCW_BUFFER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_BUFFER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_PCW_BUFFER>((mem, ptr) => new _PCW_BUFFER(mem, ptr), offsets);
        }
    }
}