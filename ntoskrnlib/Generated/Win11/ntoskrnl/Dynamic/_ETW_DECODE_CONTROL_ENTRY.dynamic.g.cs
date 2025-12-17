using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_DECODE_CONTROL_ENTRY")]
    public sealed class _ETW_DECODE_CONTROL_ENTRY : DynamicStructure
    {
        public IntPtr Next { get; }
        public _GUID Decode { get; }
        public _GUID Control { get; }
        public byte ConsumersNotified { get; }

        public _ETW_DECODE_CONTROL_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_DECODE_CONTROL_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_DECODE_CONTROL_ENTRY.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_DECODE_CONTROL_ENTRY.Decode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_DECODE_CONTROL_ENTRY.Control),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETW_DECODE_CONTROL_ENTRY.ConsumersNotified),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_ETW_DECODE_CONTROL_ENTRY>((mem, ptr) => new _ETW_DECODE_CONTROL_ENTRY(mem, ptr), offsets);
        }
    }
}