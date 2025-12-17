using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETIMER")]
    public sealed class _ETIMER : DynamicStructure
    {
        public _KTIMER KeTimer { get; }
        public ulong Lock { get; }
        public _KAPC TimerApc { get; }
        public _KDPC TimerDpc { get; }
        public _LIST_ENTRY ActiveTimerListEntry { get; }
        public uint Period { get; }
        public sbyte TimerFlags { get; }
        public byte ApcAssociated { get; }
        public byte FlushDpcs { get; }
        public byte Paused { get; }
        public byte Spare1 { get; }
        public byte DueTimeType { get; }
        public ushort Spare2 { get; }
        public IntPtr WakeReason { get; }
        public _LIST_ENTRY WakeTimerListEntry { get; }
        public IntPtr VirtualizedTimerCookie { get; }
        public _LIST_ENTRY VirtualizedTimerLinks { get; }
        public ulong DueTime { get; }
        public uint CoalescingWindow { get; }

        public _ETIMER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETIMER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETIMER.KeTimer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETIMER.Lock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ETIMER.TimerApc),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ETIMER.TimerDpc),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_ETIMER.ActiveTimerListEntry),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_ETIMER.Period),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_ETIMER.TimerFlags),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_ETIMER.ApcAssociated),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_ETIMER.FlushDpcs),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_ETIMER.Paused),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_ETIMER.Spare1),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_ETIMER.DueTimeType),
                    new ulong[]
                    {
                        245UL
                    }
                },
                {
                    nameof(_ETIMER.Spare2),
                    new ulong[]
                    {
                        246UL
                    }
                },
                {
                    nameof(_ETIMER.WakeReason),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_ETIMER.WakeTimerListEntry),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_ETIMER.VirtualizedTimerCookie),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_ETIMER.VirtualizedTimerLinks),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_ETIMER.DueTime),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_ETIMER.CoalescingWindow),
                    new ulong[]
                    {
                        304UL
                    }
                }
            };
            Register<_ETIMER>((mem, ptr) => new _ETIMER(mem, ptr), offsets);
        }
    }
}