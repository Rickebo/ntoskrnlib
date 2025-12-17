using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DISALLOWED_GUIDS")]
    public sealed class _DISALLOWED_GUIDS : DynamicStructure
    {
        public ushort Count { get; }
        public IntPtr Guids { get; }

        public _DISALLOWED_GUIDS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DISALLOWED_GUIDS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DISALLOWED_GUIDS.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISALLOWED_GUIDS.Guids),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DISALLOWED_GUIDS>((mem, ptr) => new _DISALLOWED_GUIDS(mem, ptr), offsets);
        }
    }
}