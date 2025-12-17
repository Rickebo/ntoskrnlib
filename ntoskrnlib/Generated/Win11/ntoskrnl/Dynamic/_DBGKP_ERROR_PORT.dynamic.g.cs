using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKP_ERROR_PORT")]
    public sealed class _DBGKP_ERROR_PORT : DynamicStructure
    {
        public _DBGKP_ERROR_PORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKP_ERROR_PORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_DBGKP_ERROR_PORT>((mem, ptr) => new _DBGKP_ERROR_PORT(mem, ptr), offsets);
        }
    }
}