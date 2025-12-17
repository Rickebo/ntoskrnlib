using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PHYSICAL_VIEW")]
    public sealed class _MI_PHYSICAL_VIEW : DynamicStructure
    {
        public _RTL_BALANCED_NODE PhysicalNode { get; }
        public IntPtr Vad { get; }
        public IntPtr AweInfo { get; }
        public _unnamed_tag_ u1 { get; }
        public _RTL_BITMAP_EX BitMap { get; }
        public byte AgeStamp { get; }

        public _MI_PHYSICAL_VIEW(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PHYSICAL_VIEW()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PHYSICAL_VIEW.PhysicalNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PHYSICAL_VIEW.Vad),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PHYSICAL_VIEW.AweInfo),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PHYSICAL_VIEW.u1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PHYSICAL_VIEW.BitMap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_PHYSICAL_VIEW.AgeStamp),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MI_PHYSICAL_VIEW>((mem, ptr) => new _MI_PHYSICAL_VIEW(mem, ptr), offsets);
        }
    }
}