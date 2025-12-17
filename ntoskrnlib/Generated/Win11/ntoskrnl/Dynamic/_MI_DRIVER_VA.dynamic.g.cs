using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_DRIVER_VA")]
    public sealed class _MI_DRIVER_VA : DynamicStructure
    {
        public IntPtr Next { get; }
        public IntPtr PointerPte { get; }
        public _RTL_BITMAP BitMap { get; }
        public uint Hint { get; }
        public uint Flags { get; }
        public _RTL_BITMAP PageTableCommitmentBitMap { get; }

        public _MI_DRIVER_VA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_DRIVER_VA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_DRIVER_VA.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DRIVER_VA.PointerPte),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_DRIVER_VA.BitMap),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_DRIVER_VA.Hint),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_DRIVER_VA.Flags),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MI_DRIVER_VA.PageTableCommitmentBitMap),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_MI_DRIVER_VA>((mem, ptr) => new _MI_DRIVER_VA(mem, ptr), offsets);
        }
    }
}