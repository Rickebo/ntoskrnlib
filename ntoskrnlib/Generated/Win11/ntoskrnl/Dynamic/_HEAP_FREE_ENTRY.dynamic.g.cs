using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_FREE_ENTRY")]
    public sealed class _HEAP_FREE_ENTRY : DynamicStructure
    {
        public _HEAP_ENTRY HeapEntry { get; }
        public _HEAP_UNPACKED_ENTRY UnpackedEntry { get; }
        public IntPtr PreviousBlockPrivateData { get; }
        public ushort Size { get; }
        public byte Flags { get; }
        public byte SmallTagIndex { get; }
        public uint SubSegmentCode { get; }
        public ushort PreviousSize { get; }
        public byte SegmentOffset { get; }
        public byte LFHFlags { get; }
        public byte UnusedBytes { get; }
        public ulong CompactHeader { get; }
        public _HEAP_EXTENDED_ENTRY ExtendedEntry { get; }
        public IntPtr Reserved { get; }
        public ushort FunctionIndex { get; }
        public ushort ContextValue { get; }
        public uint InterceptorValue { get; }
        public ushort UnusedBytesLength { get; }
        public byte EntryOffset { get; }
        public byte ExtendedBlockSignature { get; }
        public IntPtr ReservedForAlignment { get; }
        public uint Code1 { get; }
        public ushort Code2 { get; }
        public byte Code3 { get; }
        public byte Code4 { get; }
        public uint Code234 { get; }
        public ulong AgregateCode { get; }
        public _LIST_ENTRY FreeList { get; }

        public _HEAP_FREE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_FREE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_FREE_ENTRY.HeapEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.UnpackedEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.PreviousBlockPrivateData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.Flags),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.SmallTagIndex),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.SubSegmentCode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.PreviousSize),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.SegmentOffset),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.LFHFlags),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.UnusedBytes),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.CompactHeader),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.ExtendedEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.FunctionIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.ContextValue),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.InterceptorValue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.UnusedBytesLength),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.EntryOffset),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.ExtendedBlockSignature),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.ReservedForAlignment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.Code1),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.Code2),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.Code3),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.Code4),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.Code234),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.AgregateCode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_FREE_ENTRY.FreeList),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HEAP_FREE_ENTRY>((mem, ptr) => new _HEAP_FREE_ENTRY(mem, ptr), offsets);
        }
    }
}