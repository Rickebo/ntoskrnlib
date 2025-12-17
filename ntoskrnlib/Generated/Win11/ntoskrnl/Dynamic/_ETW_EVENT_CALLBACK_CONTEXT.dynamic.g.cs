using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_EVENT_CALLBACK_CONTEXT")]
    public sealed class _ETW_EVENT_CALLBACK_CONTEXT : DynamicStructure
    {
        public _ETW_EVENT_CALLBACK_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_EVENT_CALLBACK_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ETW_EVENT_CALLBACK_CONTEXT>((mem, ptr) => new _ETW_EVENT_CALLBACK_CONTEXT(mem, ptr), offsets);
        }
    }
}