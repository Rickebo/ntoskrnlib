using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SUBSEGMENT")]
    public sealed class _HEAP_LFH_SUBSEGMENT : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public _HEAP_LFH_SUBSEGMENT_STATE State { get; }
        public _SINGLE_LIST_ENTRY OwnerFreeListEntry { get; }
        public byte CommitStateOffset { get; }
        public byte Spare0 { get; }
        public ushort FreeCount { get; }
        public ushort BlockCount { get; }
        public byte FreeHint { get; }
        public byte WitheldBlockCount { get; }
        public byte CommitUnitShift { get; }
        public byte CommitUnitCount { get; }
        public _HEAP_LFH_COMMIT_UNIT_INFO CommitUnitInfo { get; }
        public _HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS BlockOffsets { get; }
        public ushort BucketRef { get; }
        public ushort PrivateSlotMapRef { get; }
        public ushort HighWatermarkBlockIndex { get; }
        public byte BitmapSearchWidth { get; }
        public byte PrivateFormat { get; }
        public byte Spare1 { get; }
        public _HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS UChar { get; }
        public uint Spare3 { get; }
        public ulong CommitLock { get; }
        public ulong[] BlockBitmap { get; }

        public _HEAP_LFH_SUBSEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_SUBSEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.State),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.OwnerFreeListEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.CommitStateOffset),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.Spare0),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.FreeCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.BlockCount),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.FreeHint),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.WitheldBlockCount),
                    new ulong[]
                    {
                        37UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.CommitUnitShift),
                    new ulong[]
                    {
                        38UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.CommitUnitCount),
                    new ulong[]
                    {
                        39UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.CommitUnitInfo),
                    new ulong[]
                    {
                        38UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.BlockOffsets),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.BucketRef),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.PrivateSlotMapRef),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.HighWatermarkBlockIndex),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.BitmapSearchWidth),
                    new ulong[]
                    {
                        50UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.PrivateFormat),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.Spare1),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.UChar),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.Spare3),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.CommitLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT.BlockBitmap),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_HEAP_LFH_SUBSEGMENT>((mem, ptr) => new _HEAP_LFH_SUBSEGMENT(mem, ptr), offsets);
        }
    }
}