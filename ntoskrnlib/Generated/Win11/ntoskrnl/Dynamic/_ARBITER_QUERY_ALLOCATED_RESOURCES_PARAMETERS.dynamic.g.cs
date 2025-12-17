using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_QUERY_ALLOCATED_RESOURCES_PARAMETERS")]
    public sealed class _ARBITER_QUERY_ALLOCATED_RESOURCES_PARAMETERS : DynamicStructure
    {
        public IntPtr AllocatedResources { get; }

        public _ARBITER_QUERY_ALLOCATED_RESOURCES_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_QUERY_ALLOCATED_RESOURCES_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_QUERY_ALLOCATED_RESOURCES_PARAMETERS.AllocatedResources),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARBITER_QUERY_ALLOCATED_RESOURCES_PARAMETERS>((mem, ptr) => new _ARBITER_QUERY_ALLOCATED_RESOURCES_PARAMETERS(mem, ptr), offsets);
        }
    }
}