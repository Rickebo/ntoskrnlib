using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PLATFORM_IDLE_ACCOUNTING")]
    public sealed class _PLATFORM_IDLE_ACCOUNTING : DynamicStructure
    {
        public uint ResetCount { get; }
        public uint StateCount { get; }
        public uint DeepSleepCount { get; }
        public ulong DripsWakeSkipCount { get; }
        public uint TimeUnit { get; }
        public ulong StartTime { get; }
        public byte[] State { get; }

        public _PLATFORM_IDLE_ACCOUNTING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PLATFORM_IDLE_ACCOUNTING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PLATFORM_IDLE_ACCOUNTING.ResetCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_ACCOUNTING.StateCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_ACCOUNTING.DeepSleepCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_ACCOUNTING.DripsWakeSkipCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_ACCOUNTING.TimeUnit),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_ACCOUNTING.StartTime),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_ACCOUNTING.State),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_PLATFORM_IDLE_ACCOUNTING>((mem, ptr) => new _PLATFORM_IDLE_ACCOUNTING(mem, ptr), offsets);
        }
    }
}