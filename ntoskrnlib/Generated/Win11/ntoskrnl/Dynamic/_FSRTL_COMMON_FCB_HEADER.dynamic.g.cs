using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FSRTL_COMMON_FCB_HEADER")]
    public sealed class _FSRTL_COMMON_FCB_HEADER : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public short NodeByteSize { get; }
        public byte Flags { get; }
        public byte IsFastIoPossible { get; }
        public byte Flags2 { get; }
        public byte Reserved { get; }
        public byte Version { get; }
        public IntPtr Resource { get; }
        public IntPtr PagingIoResource { get; }
        public _LARGE_INTEGER AllocationSize { get; }
        public _LARGE_INTEGER FileSize { get; }
        public _LARGE_INTEGER ValidDataLength { get; }

        public _FSRTL_COMMON_FCB_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FSRTL_COMMON_FCB_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.NodeByteSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.IsFastIoPossible),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.Flags2),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.Reserved),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.Version),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.Resource),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.PagingIoResource),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.AllocationSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.FileSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FSRTL_COMMON_FCB_HEADER.ValidDataLength),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_FSRTL_COMMON_FCB_HEADER>((mem, ptr) => new _FSRTL_COMMON_FCB_HEADER(mem, ptr), offsets);
        }
    }
}