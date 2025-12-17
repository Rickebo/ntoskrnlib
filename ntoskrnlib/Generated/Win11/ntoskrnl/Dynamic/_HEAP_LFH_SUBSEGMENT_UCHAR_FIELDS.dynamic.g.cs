using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS")]
    public sealed class _HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS : DynamicStructure
    {
        public byte PrivateFormat { get; }
        public byte Spare1 { get; }
        public byte AllUCharBits { get; }

        public _HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS.PrivateFormat),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS.Spare1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS.AllUCharBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS>((mem, ptr) => new _HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS(mem, ptr), offsets);
        }
    }
}