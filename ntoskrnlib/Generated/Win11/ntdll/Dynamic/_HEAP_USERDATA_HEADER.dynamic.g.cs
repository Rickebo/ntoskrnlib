using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_USERDATA_HEADER")]
    public sealed class _HEAP_USERDATA_HEADER : DynamicStructure
    {
        public _SINGLE_LIST_ENTRY SFreeListEntry { get; }
        public IntPtr SubSegment { get; }
        public IntPtr Reserved { get; }
        public uint SizeIndexAndPadding { get; }
        public byte SizeIndex { get; }
        public byte GuardPagePresent { get; }
        public ushort PaddingBytes { get; }
        public uint Signature { get; }
        public _HEAP_USERDATA_OFFSETS EncodedOffsets { get; }
        public _RTL_BITMAP_EX BusyBitmap { get; }
        public ulong[] BitmapData { get; }

        public _HEAP_USERDATA_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_USERDATA_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_USERDATA_HEADER.SFreeListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.SubSegment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.Reserved),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.SizeIndexAndPadding),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.SizeIndex),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.GuardPagePresent),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.PaddingBytes),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.Signature),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.EncodedOffsets),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.BusyBitmap),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_USERDATA_HEADER.BitmapData),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_HEAP_USERDATA_HEADER>((mem, ptr) => new _HEAP_USERDATA_HEADER(mem, ptr), offsets);
        }
    }
}