using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_JOBOBJECT_WAKE_FILTER")]
    public sealed class _JOBOBJECT_WAKE_FILTER : DynamicStructure
    {
        public uint HighEdgeFilter { get; }
        public uint LowEdgeFilter { get; }

        public _JOBOBJECT_WAKE_FILTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _JOBOBJECT_WAKE_FILTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_JOBOBJECT_WAKE_FILTER.HighEdgeFilter),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_JOBOBJECT_WAKE_FILTER.LowEdgeFilter),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_JOBOBJECT_WAKE_FILTER>((mem, ptr) => new _JOBOBJECT_WAKE_FILTER(mem, ptr), offsets);
        }
    }
}