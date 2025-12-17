using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_PTE_TYPE")]
    public sealed class _MI_SYSTEM_PTE_TYPE : DynamicStructure
    {
        public _RTL_BITMAP_EX Bitmap { get; }
        public _RTL_BITMAP_EX TrackingBitmap { get; }
        public IntPtr BasePte { get; }
        public uint Flags { get; }
        public uint VaType { get; }
        public uint PteFailures { get; }
        public int SpinLock { get; }
        public ulong TotalSystemPtes { get; }
        public ulong Hint { get; }
        public ulong LowestBitEverAllocated { get; }
        public IntPtr CachedPtes { get; }
        public ulong TotalFreeSystemPtes { get; }

        public _MI_SYSTEM_PTE_TYPE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_PTE_TYPE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.Bitmap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.TrackingBitmap),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.BasePte),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.Flags),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.VaType),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.PteFailures),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.SpinLock),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.TotalSystemPtes),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.Hint),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.LowestBitEverAllocated),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.CachedPtes),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_TYPE.TotalFreeSystemPtes),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_MI_SYSTEM_PTE_TYPE>((mem, ptr) => new _MI_SYSTEM_PTE_TYPE(mem, ptr), offsets);
        }
    }
}