using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_CM_PARTIAL_RESOURCE_LIST")]
    public sealed class _CM_PARTIAL_RESOURCE_LIST : DynamicStructure
    {
        public ushort Version { get; }
        public ushort Revision { get; }
        public uint Count { get; }
        public byte[] PartialDescriptors { get; }

        public _CM_PARTIAL_RESOURCE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_PARTIAL_RESOURCE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_PARTIAL_RESOURCE_LIST.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_PARTIAL_RESOURCE_LIST.Revision),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CM_PARTIAL_RESOURCE_LIST.Count),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_PARTIAL_RESOURCE_LIST.PartialDescriptors),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CM_PARTIAL_RESOURCE_LIST>((mem, ptr) => new _CM_PARTIAL_RESOURCE_LIST(mem, ptr), offsets);
        }
    }
}