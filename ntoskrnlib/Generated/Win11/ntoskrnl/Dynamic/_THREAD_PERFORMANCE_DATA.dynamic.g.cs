using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_THREAD_PERFORMANCE_DATA")]
    public sealed class _THREAD_PERFORMANCE_DATA : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public _PROCESSOR_NUMBER ProcessorNumber { get; }
        public uint ContextSwitches { get; }
        public uint HwCountersCount { get; }
        public ulong UpdateCount { get; }
        public ulong WaitReasonBitMap { get; }
        public ulong HardwareCounters { get; }
        public _COUNTER_READING CycleTime { get; }
        public byte[] HwCounters { get; }

        public _THREAD_PERFORMANCE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _THREAD_PERFORMANCE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_THREAD_PERFORMANCE_DATA.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.ProcessorNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.ContextSwitches),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.HwCountersCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.UpdateCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.WaitReasonBitMap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.HardwareCounters),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.CycleTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_THREAD_PERFORMANCE_DATA.HwCounters),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_THREAD_PERFORMANCE_DATA>((mem, ptr) => new _THREAD_PERFORMANCE_DATA(mem, ptr), offsets);
        }
    }
}