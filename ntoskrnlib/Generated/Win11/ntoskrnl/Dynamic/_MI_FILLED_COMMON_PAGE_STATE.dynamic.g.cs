using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_FILLED_COMMON_PAGE_STATE")]
    public sealed class _MI_FILLED_COMMON_PAGE_STATE : DynamicStructure
    {
        public ulong[] PageFrameIndex { get; }
        public IntPtr LeafMapping { get; }
        public ulong LeafCrc { get; }
        public _MMPTE PdeContents { get; }

        public _MI_FILLED_COMMON_PAGE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_FILLED_COMMON_PAGE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_FILLED_COMMON_PAGE_STATE.PageFrameIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FILLED_COMMON_PAGE_STATE.LeafMapping),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_FILLED_COMMON_PAGE_STATE.LeafCrc),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_FILLED_COMMON_PAGE_STATE.PdeContents),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_MI_FILLED_COMMON_PAGE_STATE>((mem, ptr) => new _MI_FILLED_COMMON_PAGE_STATE(mem, ptr), offsets);
        }
    }
}