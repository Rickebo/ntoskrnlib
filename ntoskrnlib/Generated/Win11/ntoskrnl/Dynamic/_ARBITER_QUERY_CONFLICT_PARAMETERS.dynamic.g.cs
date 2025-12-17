using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_QUERY_CONFLICT_PARAMETERS")]
    public sealed class _ARBITER_QUERY_CONFLICT_PARAMETERS : DynamicStructure
    {
        public IntPtr PhysicalDeviceObject { get; }
        public IntPtr ConflictingResource { get; }
        public IntPtr ConflictCount { get; }
        public IntPtr Conflicts { get; }

        public _ARBITER_QUERY_CONFLICT_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_QUERY_CONFLICT_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_QUERY_CONFLICT_PARAMETERS.PhysicalDeviceObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_QUERY_CONFLICT_PARAMETERS.ConflictingResource),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ARBITER_QUERY_CONFLICT_PARAMETERS.ConflictCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ARBITER_QUERY_CONFLICT_PARAMETERS.Conflicts),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_ARBITER_QUERY_CONFLICT_PARAMETERS>((mem, ptr) => new _ARBITER_QUERY_CONFLICT_PARAMETERS(mem, ptr), offsets);
        }
    }
}