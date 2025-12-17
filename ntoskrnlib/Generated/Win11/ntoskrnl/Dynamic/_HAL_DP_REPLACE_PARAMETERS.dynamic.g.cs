using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_DP_REPLACE_PARAMETERS")]
    public sealed class _HAL_DP_REPLACE_PARAMETERS : DynamicStructure
    {
        public uint Flags { get; }
        public IntPtr TargetProcessors { get; }
        public IntPtr SpareProcessors { get; }

        public _HAL_DP_REPLACE_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_DP_REPLACE_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_DP_REPLACE_PARAMETERS.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_DP_REPLACE_PARAMETERS.TargetProcessors),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_DP_REPLACE_PARAMETERS.SpareProcessors),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HAL_DP_REPLACE_PARAMETERS>((mem, ptr) => new _HAL_DP_REPLACE_PARAMETERS(mem, ptr), offsets);
        }
    }
}