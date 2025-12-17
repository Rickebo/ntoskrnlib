using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ETW_SILODRIVERSTATE")]
    public sealed class _ETW_SILODRIVERSTATE : DynamicStructure
    {
        public _ETW_SILODRIVERSTATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_SILODRIVERSTATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ETW_SILODRIVERSTATE>((mem, ptr) => new _ETW_SILODRIVERSTATE(mem, ptr), offsets);
        }
    }
}