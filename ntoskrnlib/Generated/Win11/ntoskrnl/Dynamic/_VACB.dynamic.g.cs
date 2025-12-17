using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VACB")]
    public sealed class _VACB : DynamicStructure
    {
        public IntPtr BaseAddress { get; }
        public IntPtr SharedCacheMap { get; }
        public _unnamed_tag_ Overlay { get; }
        public IntPtr ArrayHead { get; }

        public _VACB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VACB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VACB.BaseAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VACB.SharedCacheMap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VACB.Overlay),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VACB.ArrayHead),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_VACB>((mem, ptr) => new _VACB(mem, ptr), offsets);
        }
    }
}