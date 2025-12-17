using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!LIST_ENTRY64")]
    public sealed class LIST_ENTRY64 : DynamicStructure
    {
        public ulong Flink { get; }
        public ulong Blink { get; }

        public LIST_ENTRY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static LIST_ENTRY64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(LIST_ENTRY64.Flink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(LIST_ENTRY64.Blink),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<LIST_ENTRY64>((mem, ptr) => new LIST_ENTRY64(mem, ptr), offsets);
        }
    }
}