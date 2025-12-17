using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KSHARED_READY_QUEUE")]
    public sealed class _KSHARED_READY_QUEUE : DynamicStructure
    {
        public _KSHARED_READY_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSHARED_READY_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KSHARED_READY_QUEUE>((mem, ptr) => new _KSHARED_READY_QUEUE(mem, ptr), offsets);
        }
    }
}