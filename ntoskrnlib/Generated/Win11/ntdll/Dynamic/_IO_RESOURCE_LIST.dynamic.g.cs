using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IO_RESOURCE_LIST")]
    public sealed class _IO_RESOURCE_LIST : DynamicStructure
    {
        public ushort Version { get; }
        public ushort Revision { get; }
        public uint Count { get; }
        public byte[] Descriptors { get; }

        public _IO_RESOURCE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_RESOURCE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_RESOURCE_LIST.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_LIST.Revision),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_LIST.Count),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_LIST.Descriptors),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IO_RESOURCE_LIST>((mem, ptr) => new _IO_RESOURCE_LIST(mem, ptr), offsets);
        }
    }
}