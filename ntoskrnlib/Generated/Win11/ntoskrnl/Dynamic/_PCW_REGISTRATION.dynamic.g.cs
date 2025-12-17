using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_REGISTRATION")]
    public sealed class _PCW_REGISTRATION : DynamicStructure
    {
        public _PCW_REGISTRATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_REGISTRATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_PCW_REGISTRATION>((mem, ptr) => new _PCW_REGISTRATION(mem, ptr), offsets);
        }
    }
}