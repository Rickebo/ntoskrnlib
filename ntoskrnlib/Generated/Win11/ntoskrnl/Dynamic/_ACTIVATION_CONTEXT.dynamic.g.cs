using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ACTIVATION_CONTEXT")]
    public sealed class _ACTIVATION_CONTEXT : DynamicStructure
    {
        public _ACTIVATION_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACTIVATION_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ACTIVATION_CONTEXT>((mem, ptr) => new _ACTIVATION_CONTEXT(mem, ptr), offsets);
        }
    }
}