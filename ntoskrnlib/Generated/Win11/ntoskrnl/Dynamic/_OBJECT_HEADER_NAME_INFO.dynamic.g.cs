using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_NAME_INFO")]
    public sealed class _OBJECT_HEADER_NAME_INFO : DynamicStructure
    {
        public IntPtr Directory { get; }
        public _UNICODE_STRING Name { get; }
        public int ReferenceCount { get; }
        public uint Reserved { get; }

        public _OBJECT_HEADER_NAME_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HEADER_NAME_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HEADER_NAME_INFO.Directory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_NAME_INFO.Name),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_NAME_INFO.ReferenceCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_NAME_INFO.Reserved),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_OBJECT_HEADER_NAME_INFO>((mem, ptr) => new _OBJECT_HEADER_NAME_INFO(mem, ptr), offsets);
        }
    }
}