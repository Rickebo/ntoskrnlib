using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_PARTIAL_RESOURCE_DESCRIPTOR")]
    public sealed class _CM_PARTIAL_RESOURCE_DESCRIPTOR : DynamicStructure
    {
        public byte Type { get; }
        public byte ShareDisposition { get; }
        public ushort Flags { get; }
        public _unnamed_tag_ u { get; }

        public _CM_PARTIAL_RESOURCE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_PARTIAL_RESOURCE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_PARTIAL_RESOURCE_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_PARTIAL_RESOURCE_DESCRIPTOR.ShareDisposition),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_CM_PARTIAL_RESOURCE_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CM_PARTIAL_RESOURCE_DESCRIPTOR.u),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CM_PARTIAL_RESOURCE_DESCRIPTOR>((mem, ptr) => new _CM_PARTIAL_RESOURCE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}