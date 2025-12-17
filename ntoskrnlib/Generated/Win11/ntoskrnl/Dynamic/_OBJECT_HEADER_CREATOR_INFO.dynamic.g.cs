using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_CREATOR_INFO")]
    public sealed class _OBJECT_HEADER_CREATOR_INFO : DynamicStructure
    {
        public _LIST_ENTRY TypeList { get; }
        public IntPtr CreatorUniqueProcess { get; }
        public ushort CreatorBackTraceIndex { get; }
        public ushort Reserved1 { get; }
        public uint Reserved2 { get; }

        public _OBJECT_HEADER_CREATOR_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HEADER_CREATOR_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HEADER_CREATOR_INFO.TypeList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_CREATOR_INFO.CreatorUniqueProcess),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_CREATOR_INFO.CreatorBackTraceIndex),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_CREATOR_INFO.Reserved1),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_OBJECT_HEADER_CREATOR_INFO.Reserved2),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_OBJECT_HEADER_CREATOR_INFO>((mem, ptr) => new _OBJECT_HEADER_CREATOR_INFO(mem, ptr), offsets);
        }
    }
}