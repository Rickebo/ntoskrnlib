using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ACTIVATION_CONTEXT_DATA")]
    public sealed class _ACTIVATION_CONTEXT_DATA : DynamicStructure
    {
        public _ACTIVATION_CONTEXT_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACTIVATION_CONTEXT_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ACTIVATION_CONTEXT_DATA>((mem, ptr) => new _ACTIVATION_CONTEXT_DATA(mem, ptr), offsets);
        }
    }
}