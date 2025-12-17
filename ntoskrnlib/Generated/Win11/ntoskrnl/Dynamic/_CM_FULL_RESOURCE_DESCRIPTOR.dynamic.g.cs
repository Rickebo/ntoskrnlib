using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_FULL_RESOURCE_DESCRIPTOR")]
    public sealed class _CM_FULL_RESOURCE_DESCRIPTOR : DynamicStructure
    {
        public uint InterfaceType { get; }
        public uint BusNumber { get; }
        public _CM_PARTIAL_RESOURCE_LIST PartialResourceList { get; }

        public _CM_FULL_RESOURCE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_FULL_RESOURCE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_FULL_RESOURCE_DESCRIPTOR.InterfaceType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_FULL_RESOURCE_DESCRIPTOR.BusNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_FULL_RESOURCE_DESCRIPTOR.PartialResourceList),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CM_FULL_RESOURCE_DESCRIPTOR>((mem, ptr) => new _CM_FULL_RESOURCE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}