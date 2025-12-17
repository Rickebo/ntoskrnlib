using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FSRTL_ADVANCED_FCB_HEADER")]
    public sealed class _FSRTL_ADVANCED_FCB_HEADER : DynamicStructure
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
        public IntPtr FastMutex { get; }
        public _LIST_ENTRY FilterContexts { get; }
        public _EX_PUSH_LOCK PushLock { get; }
        public IntPtr FileContextSupportPointer { get; }
        public IntPtr Oplock { get; }
        public IntPtr ReservedForRemote { get; }
        public IntPtr AePushLock { get; }
        public uint BypassIoOpenCount { get; }
        public IntPtr ReservedContext { get; }

        public _FSRTL_ADVANCED_FCB_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FSRTL_ADVANCED_FCB_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.NodeByteSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.IsFastIoPossible),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.Flags2),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.Reserved),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.Version),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.Resource),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.PagingIoResource),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.AllocationSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.FileSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.ValidDataLength),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.FastMutex),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.FilterContexts),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.PushLock),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.FileContextSupportPointer),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.Oplock),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.ReservedForRemote),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.AePushLock),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.BypassIoOpenCount),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_FSRTL_ADVANCED_FCB_HEADER.ReservedContext),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_FSRTL_ADVANCED_FCB_HEADER>((mem, ptr) => new _FSRTL_ADVANCED_FCB_HEADER(mem, ptr), offsets);
        }
    }
}