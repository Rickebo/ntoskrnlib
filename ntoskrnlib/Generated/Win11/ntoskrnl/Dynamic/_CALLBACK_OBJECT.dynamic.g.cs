using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CALLBACK_OBJECT")]
    public sealed class _CALLBACK_OBJECT : DynamicStructure
    {
        public _CALLBACK_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CALLBACK_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_CALLBACK_OBJECT>((mem, ptr) => new _CALLBACK_OBJECT(mem, ptr), offsets);
        }
    }
}