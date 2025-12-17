using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_UNPACKED_ENTRY")]
    public sealed class _HEAP_UNPACKED_ENTRY : DynamicStructure
    {
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

        public _HEAP_UNPACKED_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_UNPACKED_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_UNPACKED_ENTRY.PreviousBlockPrivateData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.Flags),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.SmallTagIndex),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.SubSegmentCode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.PreviousSize),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.SegmentOffset),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.LFHFlags),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.UnusedBytes),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_HEAP_UNPACKED_ENTRY.CompactHeader),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_UNPACKED_ENTRY>((mem, ptr) => new _HEAP_UNPACKED_ENTRY(mem, ptr), offsets);
        }
    }
}