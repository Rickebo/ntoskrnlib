using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS")]
    public sealed class _HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS : DynamicStructure
    {
        public ushort BlockSize { get; }
        public ushort FirstBlockOffset { get; }
        public uint EncodedData { get; }

        public _HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS.BlockSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS.FirstBlockOffset),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS.EncodedData),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS>((mem, ptr) => new _HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS(mem, ptr), offsets);
        }
    }
}