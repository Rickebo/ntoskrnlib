using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!LIST_ENTRY32")]
    public sealed class LIST_ENTRY32 : DynamicStructure
    {
        public uint Flink { get; }
        public uint Blink { get; }

        public LIST_ENTRY32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static LIST_ENTRY32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(LIST_ENTRY32.Flink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(LIST_ENTRY32.Blink),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<LIST_ENTRY32>((mem, ptr) => new LIST_ENTRY32(mem, ptr), offsets);
        }
    }
}