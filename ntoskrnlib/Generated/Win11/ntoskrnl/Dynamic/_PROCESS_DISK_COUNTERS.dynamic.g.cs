using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCESS_DISK_COUNTERS")]
    public sealed class _PROCESS_DISK_COUNTERS : DynamicStructure
    {
        public ulong BytesRead { get; }
        public ulong BytesWritten { get; }
        public ulong ReadOperationCount { get; }
        public ulong WriteOperationCount { get; }
        public ulong FlushOperationCount { get; }

        public _PROCESS_DISK_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESS_DISK_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESS_DISK_COUNTERS.BytesRead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_DISK_COUNTERS.BytesWritten),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROCESS_DISK_COUNTERS.ReadOperationCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROCESS_DISK_COUNTERS.WriteOperationCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROCESS_DISK_COUNTERS.FlushOperationCount),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_PROCESS_DISK_COUNTERS>((mem, ptr) => new _PROCESS_DISK_COUNTERS(mem, ptr), offsets);
        }
    }
}