using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NLS_STATE")]
    public sealed class _NLS_STATE : DynamicStructure
    {
        public _NLS_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NLS_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_NLS_STATE>((mem, ptr) => new _NLS_STATE(mem, ptr), offsets);
        }
    }
}