using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_LOG_ENTRY")]
    public sealed class _POP_FX_LOG_ENTRY : DynamicStructure
    {
        public ulong Timestamp { get; }
        public byte Operation { get; }
        public byte Component { get; }
        public ushort Processor { get; }
        public ushort Process { get; }
        public ushort Thread { get; }
        public ulong Information { get; }

        public _POP_FX_LOG_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_LOG_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_LOG_ENTRY.Timestamp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_LOG_ENTRY.Operation),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_LOG_ENTRY.Component),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_POP_FX_LOG_ENTRY.Processor),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_POP_FX_LOG_ENTRY.Process),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POP_FX_LOG_ENTRY.Thread),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_POP_FX_LOG_ENTRY.Information),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_POP_FX_LOG_ENTRY>((mem, ptr) => new _POP_FX_LOG_ENTRY(mem, ptr), offsets);
        }
    }
}