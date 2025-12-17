using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KCPU_PARTITION")]
    public sealed class _KCPU_PARTITION : DynamicStructure
    {
        public _KCPU_PARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCPU_PARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KCPU_PARTITION>((mem, ptr) => new _KCPU_PARTITION(mem, ptr), offsets);
        }
    }
}