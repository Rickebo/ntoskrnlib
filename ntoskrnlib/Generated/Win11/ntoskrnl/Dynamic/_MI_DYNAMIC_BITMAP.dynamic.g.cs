using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_DYNAMIC_BITMAP")]
    public sealed class _MI_DYNAMIC_BITMAP : DynamicStructure
    {
        public _RTL_BITMAP_EX Bitmap { get; }
        public ulong MaximumSize { get; }
        public ulong Hint { get; }
        public IntPtr BaseVa { get; }
        public ulong SizeTopDown { get; }
        public ulong HintTopDown { get; }
        public IntPtr BaseVaTopDown { get; }
        public int SpinLock { get; }

        public _MI_DYNAMIC_BITMAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_DYNAMIC_BITMAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_DYNAMIC_BITMAP.Bitmap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DYNAMIC_BITMAP.MaximumSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_DYNAMIC_BITMAP.Hint),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_DYNAMIC_BITMAP.BaseVa),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_DYNAMIC_BITMAP.SizeTopDown),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_DYNAMIC_BITMAP.HintTopDown),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_DYNAMIC_BITMAP.BaseVaTopDown),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_DYNAMIC_BITMAP.SpinLock),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MI_DYNAMIC_BITMAP>((mem, ptr) => new _MI_DYNAMIC_BITMAP(mem, ptr), offsets);
        }
    }
}