using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_SWITCH_PARTITION")]
    public sealed class _DBGKD_SWITCH_PARTITION : DynamicStructure
    {
        public uint Partition { get; }

        public _DBGKD_SWITCH_PARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_SWITCH_PARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_SWITCH_PARTITION.Partition),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_SWITCH_PARTITION>((mem, ptr) => new _DBGKD_SWITCH_PARTITION(mem, ptr), offsets);
        }
    }
}