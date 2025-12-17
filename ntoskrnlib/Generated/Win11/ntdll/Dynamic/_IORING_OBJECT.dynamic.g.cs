using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IORING_OBJECT")]
    public sealed class _IORING_OBJECT : DynamicStructure
    {
        public _IORING_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IORING_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_IORING_OBJECT>((mem, ptr) => new _IORING_OBJECT(mem, ptr), offsets);
        }
    }
}