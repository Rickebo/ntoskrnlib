using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MMWSL_INSTANCE")]
    public sealed class _MMWSL_INSTANCE : DynamicStructure
    {
        public _MMWSL_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMWSL_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_MMWSL_INSTANCE>((mem, ptr) => new _MMWSL_INSTANCE(mem, ptr), offsets);
        }
    }
}