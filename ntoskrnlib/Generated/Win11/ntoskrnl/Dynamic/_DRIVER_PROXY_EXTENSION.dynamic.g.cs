using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DRIVER_PROXY_EXTENSION")]
    public sealed class _DRIVER_PROXY_EXTENSION : DynamicStructure
    {
        public _DRIVER_PROXY_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DRIVER_PROXY_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_DRIVER_PROXY_EXTENSION>((mem, ptr) => new _DRIVER_PROXY_EXTENSION(mem, ptr), offsets);
        }
    }
}