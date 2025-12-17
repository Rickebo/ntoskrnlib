using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_BITMAP")]
    public sealed class _RTL_BITMAP : DynamicStructure
    {
        public uint SizeOfBitMap { get; }
        public IntPtr Buffer { get; }

        public _RTL_BITMAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_BITMAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_BITMAP.SizeOfBitMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_BITMAP.Buffer),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTL_BITMAP>((mem, ptr) => new _RTL_BITMAP(mem, ptr), offsets);
        }
    }
}