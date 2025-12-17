using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KTHREAD_COUNTERS")]
    public sealed class _KTHREAD_COUNTERS : DynamicStructure
    {
        public ulong WaitReasonBitMap { get; }
        public IntPtr UserData { get; }
        public uint Flags { get; }
        public uint ContextSwitches { get; }
        public ulong CycleTimeBias { get; }
        public ulong HardwareCounters { get; }
        public byte[] HwCounter { get; }

        public _KTHREAD_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTHREAD_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTHREAD_COUNTERS.WaitReasonBitMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTHREAD_COUNTERS.UserData),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KTHREAD_COUNTERS.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KTHREAD_COUNTERS.ContextSwitches),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_KTHREAD_COUNTERS.CycleTimeBias),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KTHREAD_COUNTERS.HardwareCounters),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KTHREAD_COUNTERS.HwCounter),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_KTHREAD_COUNTERS>((mem, ptr) => new _KTHREAD_COUNTERS(mem, ptr), offsets);
        }
    }
}