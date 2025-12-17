using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KLDTENTRY")]
    public sealed class _KLDTENTRY : DynamicStructure
    {
        public ushort LimitLow { get; }
        public ushort BaseLow { get; }
        public _unnamed_tag_ HighWord { get; }

        public _KLDTENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KLDTENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KLDTENTRY.LimitLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLDTENTRY.BaseLow),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KLDTENTRY.HighWord),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_KLDTENTRY>((mem, ptr) => new _KLDTENTRY(mem, ptr), offsets);
        }
    }
}