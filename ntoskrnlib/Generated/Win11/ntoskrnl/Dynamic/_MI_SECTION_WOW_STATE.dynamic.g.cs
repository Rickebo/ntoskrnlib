using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SECTION_WOW_STATE")]
    public sealed class _MI_SECTION_WOW_STATE : DynamicStructure
    {
        public _RTL_BITMAP_EX ImageBitMap { get; }
        public _MI_DLL_OVERFLOW_AREA OverflowArea { get; }
        public IntPtr CfgBitMapSection { get; }
        public IntPtr CfgBitMapControlArea { get; }

        public _MI_SECTION_WOW_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SECTION_WOW_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SECTION_WOW_STATE.ImageBitMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SECTION_WOW_STATE.OverflowArea),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SECTION_WOW_STATE.CfgBitMapSection),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_SECTION_WOW_STATE.CfgBitMapControlArea),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_MI_SECTION_WOW_STATE>((mem, ptr) => new _MI_SECTION_WOW_STATE(mem, ptr), offsets);
        }
    }
}