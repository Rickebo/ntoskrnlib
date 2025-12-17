using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ECP_LIST")]
    public sealed class _ECP_LIST : DynamicStructure
    {
        public _ECP_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ECP_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_ECP_LIST>((mem, ptr) => new _ECP_LIST(mem, ptr), offsets);
        }
    }
}