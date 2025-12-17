using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_DLL_OVERFLOW_AREA")]
    public sealed class _MI_DLL_OVERFLOW_AREA : DynamicStructure
    {
        public IntPtr RangeStart { get; }
        public IntPtr NextVa { get; }
        public IntPtr RangeStartAbove2gb { get; }
        public IntPtr NextVaAbove2gb { get; }

        public _MI_DLL_OVERFLOW_AREA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_DLL_OVERFLOW_AREA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_DLL_OVERFLOW_AREA.RangeStart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DLL_OVERFLOW_AREA.NextVa),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_DLL_OVERFLOW_AREA.RangeStartAbove2gb),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_DLL_OVERFLOW_AREA.NextVaAbove2gb),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_DLL_OVERFLOW_AREA>((mem, ptr) => new _MI_DLL_OVERFLOW_AREA(mem, ptr), offsets);
        }
    }
}