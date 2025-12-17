using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!CMP_OFFSET_ARRAY")]
    public sealed class CMP_OFFSET_ARRAY : DynamicStructure
    {
        public uint FileOffset { get; }
        public IntPtr DataBuffer { get; }
        public uint DataLength { get; }

        public CMP_OFFSET_ARRAY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static CMP_OFFSET_ARRAY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(CMP_OFFSET_ARRAY.FileOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(CMP_OFFSET_ARRAY.DataBuffer),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(CMP_OFFSET_ARRAY.DataLength),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<CMP_OFFSET_ARRAY>((mem, ptr) => new CMP_OFFSET_ARRAY(mem, ptr), offsets);
        }
    }
}