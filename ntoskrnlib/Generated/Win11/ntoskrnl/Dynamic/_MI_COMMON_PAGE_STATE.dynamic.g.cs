using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_COMMON_PAGE_STATE")]
    public sealed class _MI_COMMON_PAGE_STATE : DynamicStructure
    {
        public IntPtr DummyPagePfn { get; }
        public ulong DummyPage { get; }
        public byte[] GapFrames { get; }

        public _MI_COMMON_PAGE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_COMMON_PAGE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_COMMON_PAGE_STATE.DummyPagePfn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COMMON_PAGE_STATE.DummyPage),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_COMMON_PAGE_STATE.GapFrames),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MI_COMMON_PAGE_STATE>((mem, ptr) => new _MI_COMMON_PAGE_STATE(mem, ptr), offsets);
        }
    }
}