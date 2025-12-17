using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HVP_VIEW_MAP")]
    public sealed class _HVP_VIEW_MAP : DynamicStructure
    {
        public IntPtr SectionReference { get; }
        public long StorageEndFileOffset { get; }
        public long SectionEndFileOffset { get; }
        public IntPtr ProcessTuple { get; }
        public uint Flags { get; }
        public _RTL_RB_TREE ViewTree { get; }

        public _HVP_VIEW_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HVP_VIEW_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HVP_VIEW_MAP.SectionReference),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HVP_VIEW_MAP.StorageEndFileOffset),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HVP_VIEW_MAP.SectionEndFileOffset),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HVP_VIEW_MAP.ProcessTuple),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HVP_VIEW_MAP.Flags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HVP_VIEW_MAP.ViewTree),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_HVP_VIEW_MAP>((mem, ptr) => new _HVP_VIEW_MAP(mem, ptr), offsets);
        }
    }
}