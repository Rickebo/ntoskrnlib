using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!IORING_REGISTERED_BUFFER")]
    public sealed class IORING_REGISTERED_BUFFER : DynamicStructure
    {
        public uint BufferIndex { get; }
        public uint Offset { get; }

        public IORING_REGISTERED_BUFFER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static IORING_REGISTERED_BUFFER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(IORING_REGISTERED_BUFFER.BufferIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(IORING_REGISTERED_BUFFER.Offset),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<IORING_REGISTERED_BUFFER>((mem, ptr) => new IORING_REGISTERED_BUFFER(mem, ptr), offsets);
        }
    }
}