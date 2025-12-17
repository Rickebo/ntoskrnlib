using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_WORKING_SET")]
    public sealed class _MI_PARTITION_WORKING_SET : DynamicStructure
    {
        public _MMSUPPORT_INSTANCE VmInstance { get; }
        public _MMWSL_INSTANCE VmWorkingSetList { get; }

        public _MI_PARTITION_WORKING_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_WORKING_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_WORKING_SET.VmInstance),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_WORKING_SET.VmWorkingSetList),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_MI_PARTITION_WORKING_SET>((mem, ptr) => new _MI_PARTITION_WORKING_SET(mem, ptr), offsets);
        }
    }
}