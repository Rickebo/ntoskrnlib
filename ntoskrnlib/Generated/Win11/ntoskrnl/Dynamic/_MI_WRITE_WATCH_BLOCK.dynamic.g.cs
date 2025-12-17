using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_WRITE_WATCH_BLOCK")]
    public sealed class _MI_WRITE_WATCH_BLOCK : DynamicStructure
    {
        public int Lock { get; }
        public _RTL_BITMAP_EX BitMap { get; }

        public _MI_WRITE_WATCH_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_WRITE_WATCH_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_WRITE_WATCH_BLOCK.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_WRITE_WATCH_BLOCK.BitMap),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MI_WRITE_WATCH_BLOCK>((mem, ptr) => new _MI_WRITE_WATCH_BLOCK(mem, ptr), offsets);
        }
    }
}