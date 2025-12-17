using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTLP_HP_ALLOC_TRACKER")]
    public sealed class _RTLP_HP_ALLOC_TRACKER : DynamicStructure
    {
        public ulong BaseAddress { get; }
        public _RTL_CSPARSE_BITMAP AllocTrackerBitmap { get; }
        public byte[] AllocTrackerBitmapBuffer { get; }

        public _RTLP_HP_ALLOC_TRACKER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_HP_ALLOC_TRACKER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_HP_ALLOC_TRACKER.BaseAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_HP_ALLOC_TRACKER.AllocTrackerBitmap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTLP_HP_ALLOC_TRACKER.AllocTrackerBitmapBuffer),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTLP_HP_ALLOC_TRACKER>((mem, ptr) => new _RTLP_HP_ALLOC_TRACKER(mem, ptr), offsets);
        }
    }
}