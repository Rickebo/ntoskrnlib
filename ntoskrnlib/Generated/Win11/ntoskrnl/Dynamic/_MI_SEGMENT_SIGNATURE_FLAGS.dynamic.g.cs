using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SEGMENT_SIGNATURE_FLAGS")]
    public sealed class _MI_SEGMENT_SIGNATURE_FLAGS : DynamicStructure
    {
        public byte ImageSigningLevel { get; }
        public byte ImageSigningType { get; }
        public byte Spare { get; }
        public byte EntireField { get; }

        public _MI_SEGMENT_SIGNATURE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SEGMENT_SIGNATURE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SEGMENT_SIGNATURE_FLAGS.ImageSigningLevel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SEGMENT_SIGNATURE_FLAGS.ImageSigningType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SEGMENT_SIGNATURE_FLAGS.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SEGMENT_SIGNATURE_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_SEGMENT_SIGNATURE_FLAGS>((mem, ptr) => new _MI_SEGMENT_SIGNATURE_FLAGS(mem, ptr), offsets);
        }
    }
}