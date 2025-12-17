using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_REGION")]
    public sealed class _KALPC_REGION : DynamicStructure
    {
        public _LIST_ENTRY RegionListEntry { get; }
        public IntPtr Section { get; }
        public ulong Offset { get; }
        public ulong Size { get; }
        public ulong ViewSize { get; }
        public _unnamed_tag_ u1 { get; }
        public uint NumberOfViews { get; }
        public _LIST_ENTRY ViewListHead { get; }
        public IntPtr ReadOnlyView { get; }
        public IntPtr ReadWriteView { get; }

        public _KALPC_REGION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_REGION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_REGION.RegionListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_REGION.Section),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KALPC_REGION.Offset),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KALPC_REGION.Size),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KALPC_REGION.ViewSize),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KALPC_REGION.u1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KALPC_REGION.NumberOfViews),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_KALPC_REGION.ViewListHead),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KALPC_REGION.ReadOnlyView),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KALPC_REGION.ReadWriteView),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_KALPC_REGION>((mem, ptr) => new _KALPC_REGION(mem, ptr), offsets);
        }
    }
}