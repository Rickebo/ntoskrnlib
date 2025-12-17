using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KALPC_SECTION")]
    public sealed class _KALPC_SECTION : DynamicStructure
    {
        public IntPtr SectionObject { get; }
        public ulong Size { get; }
        public IntPtr HandleTable { get; }
        public IntPtr SectionHandle { get; }
        public IntPtr OwnerProcess { get; }
        public IntPtr OwnerPort { get; }
        public _unnamed_tag_ u1 { get; }
        public uint NumberOfRegions { get; }
        public _LIST_ENTRY RegionListHead { get; }

        public _KALPC_SECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KALPC_SECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KALPC_SECTION.SectionObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KALPC_SECTION.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KALPC_SECTION.HandleTable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KALPC_SECTION.SectionHandle),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KALPC_SECTION.OwnerProcess),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KALPC_SECTION.OwnerPort),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KALPC_SECTION.u1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KALPC_SECTION.NumberOfRegions),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_KALPC_SECTION.RegionListHead),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_KALPC_SECTION>((mem, ptr) => new _KALPC_SECTION(mem, ptr), offsets);
        }
    }
}