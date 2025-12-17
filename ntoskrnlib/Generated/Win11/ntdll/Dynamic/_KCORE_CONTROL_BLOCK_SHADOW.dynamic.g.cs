using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KCORE_CONTROL_BLOCK_SHADOW")]
    public sealed class _KCORE_CONTROL_BLOCK_SHADOW : DynamicStructure
    {
        public ulong Lock { get; }
        public ulong CurrentIsolationDomain { get; }
        public ulong NextIsolationDomain { get; }
        public byte TotalProcessors { get; }
        public byte IdleProcessors { get; }
        public byte NewDomainProcessors { get; }
        public byte Spare { get; }
        public byte[] ProcessorStates { get; }
        public ulong[] InterruptTargets { get; }

        public _KCORE_CONTROL_BLOCK_SHADOW(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCORE_CONTROL_BLOCK_SHADOW()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.CurrentIsolationDomain),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.NextIsolationDomain),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.TotalProcessors),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.IdleProcessors),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.NewDomainProcessors),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.Spare),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.ProcessorStates),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK_SHADOW.InterruptTargets),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_KCORE_CONTROL_BLOCK_SHADOW>((mem, ptr) => new _KCORE_CONTROL_BLOCK_SHADOW(mem, ptr), offsets);
        }
    }
}