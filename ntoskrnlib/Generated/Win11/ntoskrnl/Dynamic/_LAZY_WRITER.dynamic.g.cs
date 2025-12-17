using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LAZY_WRITER")]
    public sealed class _LAZY_WRITER : DynamicStructure
    {
        public _KTIMER ScanTimer { get; }
        public byte TimerInitialized { get; }
        public byte ScanActive { get; }
        public byte OtherWork { get; }
        public byte PendingTeardownScan { get; }
        public byte PendingPeriodicScan { get; }
        public byte PendingLowMemoryScan { get; }
        public byte PendingPowerScan { get; }
        public byte PendingCoalescingFlushScan { get; }

        public _LAZY_WRITER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LAZY_WRITER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LAZY_WRITER.ScanTimer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LAZY_WRITER.TimerInitialized),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LAZY_WRITER.ScanActive),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_LAZY_WRITER.OtherWork),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_LAZY_WRITER.PendingTeardownScan),
                    new ulong[]
                    {
                        67UL
                    }
                },
                {
                    nameof(_LAZY_WRITER.PendingPeriodicScan),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_LAZY_WRITER.PendingLowMemoryScan),
                    new ulong[]
                    {
                        69UL
                    }
                },
                {
                    nameof(_LAZY_WRITER.PendingPowerScan),
                    new ulong[]
                    {
                        70UL
                    }
                },
                {
                    nameof(_LAZY_WRITER.PendingCoalescingFlushScan),
                    new ulong[]
                    {
                        71UL
                    }
                }
            };
            Register<_LAZY_WRITER>((mem, ptr) => new _LAZY_WRITER(mem, ptr), offsets);
        }
    }
}