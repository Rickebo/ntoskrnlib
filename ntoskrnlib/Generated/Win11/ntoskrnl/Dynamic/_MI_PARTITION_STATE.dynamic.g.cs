using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_STATE")]
    public sealed class _MI_PARTITION_STATE : DynamicStructure
    {
        public int PartitionLock { get; }
        public _EX_PUSH_LOCK PartitionIdLock { get; }
        public ulong InitialPartitionIdBits { get; }
        public _LIST_ENTRY PartitionList { get; }
        public IntPtr PartitionIdBitmap { get; }
        public _RTL_BITMAP InitialPartitionIdBitmap { get; }
        public byte[] TempPartitionPointers { get; }
        public IntPtr Partition { get; }
        public uint CrossPartitionDenials { get; }
        public byte MultiplePartitionsExist { get; }
        public IntPtr ExtendedPartitionStart { get; }
        public ulong ExtendedPartitionBytes { get; }
        public ulong ChildPartitionBytes { get; }
        public _RTL_BITMAP_EX HugeIoPfnBitMap { get; }
        public IntPtr HugePfnDatabase { get; }
        public IntPtr HugePfnLockArray { get; }
        public int HugeRangesLock { get; }

        public _MI_PARTITION_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_STATE.PartitionLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.PartitionIdLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.InitialPartitionIdBits),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.PartitionList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.PartitionIdBitmap),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.InitialPartitionIdBitmap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.TempPartitionPointers),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.Partition),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.CrossPartitionDenials),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.MultiplePartitionsExist),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.ExtendedPartitionStart),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.ExtendedPartitionBytes),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.ChildPartitionBytes),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.HugeIoPfnBitMap),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.HugePfnDatabase),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.HugePfnLockArray),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STATE.HugeRangesLock),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_MI_PARTITION_STATE>((mem, ptr) => new _MI_PARTITION_STATE(mem, ptr), offsets);
        }
    }
}