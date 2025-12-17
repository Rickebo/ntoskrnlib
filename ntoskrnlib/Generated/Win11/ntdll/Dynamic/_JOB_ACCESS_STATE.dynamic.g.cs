using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_JOB_ACCESS_STATE")]
    public sealed class _JOB_ACCESS_STATE : DynamicStructure
    {
        public _JOB_ACCESS_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _JOB_ACCESS_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_JOB_ACCESS_STATE>((mem, ptr) => new _JOB_ACCESS_STATE(mem, ptr), offsets);
        }
    }
}