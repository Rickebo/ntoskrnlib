using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_RESCHEDULE_CONTEXT")]
    public sealed class _KI_RESCHEDULE_CONTEXT : DynamicStructure
    {
        public byte ProcessorCount { get; }
        public byte ScanStart { get; }
        public uint MaximumThreadIsolationWidth { get; }
        public uint IsolationWidth { get; }
        public byte[] ProcessorEntries { get; }
        public byte[] SharedReadyLockQueues { get; }

        public _KI_RESCHEDULE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_RESCHEDULE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_RESCHEDULE_CONTEXT.ProcessorCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT.ScanStart),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT.MaximumThreadIsolationWidth),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT.IsolationWidth),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT.ProcessorEntries),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KI_RESCHEDULE_CONTEXT.SharedReadyLockQueues),
                    new ulong[]
                    {
                        176UL
                    }
                }
            };
            Register<_KI_RESCHEDULE_CONTEXT>((mem, ptr) => new _KI_RESCHEDULE_CONTEXT(mem, ptr), offsets);
        }
    }
}