using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KWAIT_BLOCK")]
    public sealed class _KWAIT_BLOCK : DynamicStructure
    {
        public _LIST_ENTRY WaitListEntry { get; }
        public byte WaitType { get; }
        public byte BlockState { get; }
        public ushort WaitKey { get; }
        public int SpareLong { get; }
        public IntPtr Thread { get; }
        public IntPtr NotificationQueue { get; }
        public IntPtr Dpc { get; }
        public IntPtr Object { get; }
        public IntPtr SparePtr { get; }

        public _KWAIT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KWAIT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KWAIT_BLOCK.WaitListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.WaitType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.BlockState),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.WaitKey),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.SpareLong),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.Thread),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.NotificationQueue),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.Dpc),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.Object),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KWAIT_BLOCK.SparePtr),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_KWAIT_BLOCK>((mem, ptr) => new _KWAIT_BLOCK(mem, ptr), offsets);
        }
    }
}