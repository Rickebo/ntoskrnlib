using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_TIMER")]
    public sealed class _TP_TIMER : DynamicStructure
    {
        public _TP_WORK Work { get; }
        public _RTL_SRWLOCK Lock { get; }
        public _TPP_PH_LINKS WindowEndLinks { get; }
        public _LIST_ENTRY ExpirationLinks { get; }
        public _TPP_PH_LINKS WindowStartLinks { get; }
        public long DueTime { get; }
        public _TPP_ITE CancelIte { get; }
        public uint Window { get; }
        public uint Period { get; }
        public byte Inserted { get; }
        public byte WaitTimer { get; }
        public byte TimerStatus { get; }
        public byte InQueue { get; }
        public byte Absolute { get; }
        public byte Cancelled { get; }
        public byte BlockInsert { get; }

        public _TP_TIMER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_TIMER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_TIMER.Work),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_TIMER.Lock),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_TP_TIMER.WindowEndLinks),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_TP_TIMER.ExpirationLinks),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_TP_TIMER.WindowStartLinks),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_TP_TIMER.DueTime),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_TP_TIMER.CancelIte),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_TP_TIMER.Window),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_TP_TIMER.Period),
                    new ulong[]
                    {
                        348UL
                    }
                },
                {
                    nameof(_TP_TIMER.Inserted),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_TP_TIMER.WaitTimer),
                    new ulong[]
                    {
                        353UL
                    }
                },
                {
                    nameof(_TP_TIMER.TimerStatus),
                    new ulong[]
                    {
                        354UL
                    }
                },
                {
                    nameof(_TP_TIMER.InQueue),
                    new ulong[]
                    {
                        354UL
                    }
                },
                {
                    nameof(_TP_TIMER.Absolute),
                    new ulong[]
                    {
                        354UL
                    }
                },
                {
                    nameof(_TP_TIMER.Cancelled),
                    new ulong[]
                    {
                        354UL
                    }
                },
                {
                    nameof(_TP_TIMER.BlockInsert),
                    new ulong[]
                    {
                        355UL
                    }
                }
            };
            Register<_TP_TIMER>((mem, ptr) => new _TP_TIMER(mem, ptr), offsets);
        }
    }
}