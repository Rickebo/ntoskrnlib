using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INBV_OFFSET")]
    public sealed class _INBV_OFFSET : DynamicStructure
    {
        public uint X { get; }
        public uint Y { get; }

        public _INBV_OFFSET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INBV_OFFSET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INBV_OFFSET.X),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INBV_OFFSET.Y),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_INBV_OFFSET>((mem, ptr) => new _INBV_OFFSET(mem, ptr), offsets);
        }
    }
}