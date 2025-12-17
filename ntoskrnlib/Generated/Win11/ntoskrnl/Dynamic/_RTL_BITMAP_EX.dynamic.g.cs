using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_BITMAP_EX")]
    public sealed class _RTL_BITMAP_EX : DynamicStructure
    {
        public ulong SizeOfBitMap { get; }
        public IntPtr Buffer { get; }

        public _RTL_BITMAP_EX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_BITMAP_EX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_BITMAP_EX.SizeOfBitMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_BITMAP_EX.Buffer),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTL_BITMAP_EX>((mem, ptr) => new _RTL_BITMAP_EX(mem, ptr), offsets);
        }
    }
}