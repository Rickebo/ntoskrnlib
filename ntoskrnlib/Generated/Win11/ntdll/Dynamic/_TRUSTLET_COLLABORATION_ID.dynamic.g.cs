using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TRUSTLET_COLLABORATION_ID")]
    public sealed class _TRUSTLET_COLLABORATION_ID : DynamicStructure
    {
        public ulong[] Value { get; }

        public _TRUSTLET_COLLABORATION_ID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRUSTLET_COLLABORATION_ID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRUSTLET_COLLABORATION_ID.Value),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TRUSTLET_COLLABORATION_ID>((mem, ptr) => new _TRUSTLET_COLLABORATION_ID(mem, ptr), offsets);
        }
    }
}