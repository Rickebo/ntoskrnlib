using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PRIVATE_CACHE_MAP")]
    public sealed class _PRIVATE_CACHE_MAP : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public _PRIVATE_CACHE_MAP_FLAGS Flags { get; }
        public uint ReadAheadMask { get; }
        public IntPtr FileObject { get; }
        public _LARGE_INTEGER FileOffset1 { get; }
        public _LARGE_INTEGER BeyondLastByte1 { get; }
        public _LARGE_INTEGER FileOffset2 { get; }
        public _LARGE_INTEGER BeyondLastByte2 { get; }
        public uint SequentialReadCount { get; }
        public uint ReadAheadLength { get; }
        public _LARGE_INTEGER ReadAheadOffset { get; }
        public _LARGE_INTEGER ReadAheadBeyondLastByte { get; }
        public ulong PrevReadAheadBeyondLastByte { get; }
        public ulong ReadAheadSpinLock { get; }
        public uint PipelinedReadAheadRequestSize { get; }
        public uint ReadAheadGrowth { get; }
        public _LIST_ENTRY PrivateLinks { get; }
        public IntPtr ReadAheadWorkItem { get; }

        public _PRIVATE_CACHE_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PRIVATE_CACHE_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PRIVATE_CACHE_MAP.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.ReadAheadMask),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.FileObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.FileOffset1),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.BeyondLastByte1),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.FileOffset2),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.BeyondLastByte2),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.SequentialReadCount),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.ReadAheadLength),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.ReadAheadOffset),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.ReadAheadBeyondLastByte),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.PrevReadAheadBeyondLastByte),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.ReadAheadSpinLock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.PipelinedReadAheadRequestSize),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.ReadAheadGrowth),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.PrivateLinks),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PRIVATE_CACHE_MAP.ReadAheadWorkItem),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_PRIVATE_CACHE_MAP>((mem, ptr) => new _PRIVATE_CACHE_MAP(mem, ptr), offsets);
        }
    }
}