using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ETW_BUFFER_CONTEXT")]
    public sealed class _ETW_BUFFER_CONTEXT : DynamicStructure
    {
        public byte ProcessorNumber { get; }
        public byte Alignment { get; }
        public ushort ProcessorIndex { get; }
        public ushort LoggerId { get; }

        public _ETW_BUFFER_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_BUFFER_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_BUFFER_CONTEXT.ProcessorNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_BUFFER_CONTEXT.Alignment),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_ETW_BUFFER_CONTEXT.ProcessorIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_BUFFER_CONTEXT.LoggerId),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_ETW_BUFFER_CONTEXT>((mem, ptr) => new _ETW_BUFFER_CONTEXT(mem, ptr), offsets);
        }
    }
}