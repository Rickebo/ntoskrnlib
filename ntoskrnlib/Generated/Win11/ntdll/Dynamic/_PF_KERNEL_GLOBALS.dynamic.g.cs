using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PF_KERNEL_GLOBALS")]
    public sealed class _PF_KERNEL_GLOBALS : DynamicStructure
    {
        public ulong AccessBufferAgeThreshold { get; }
        public int StreamSequenceNumber { get; }
        public uint Flags { get; }
        public int ScenarioPrefetchCount { get; }

        public _PF_KERNEL_GLOBALS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PF_KERNEL_GLOBALS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PF_KERNEL_GLOBALS.AccessBufferAgeThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PF_KERNEL_GLOBALS.StreamSequenceNumber),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PF_KERNEL_GLOBALS.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PF_KERNEL_GLOBALS.ScenarioPrefetchCount),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PF_KERNEL_GLOBALS>((mem, ptr) => new _PF_KERNEL_GLOBALS(mem, ptr), offsets);
        }
    }
}