using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_EXP_LICENSE_STATE")]
    public sealed class _EXP_LICENSE_STATE : DynamicStructure
    {
        public _EXP_LICENSE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXP_LICENSE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_EXP_LICENSE_STATE>((mem, ptr) => new _EXP_LICENSE_STATE(mem, ptr), offsets);
        }
    }
}