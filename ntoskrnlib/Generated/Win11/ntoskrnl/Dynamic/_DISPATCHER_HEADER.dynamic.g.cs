using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DISPATCHER_HEADER")]
    public sealed class _DISPATCHER_HEADER : DynamicStructure
    {
        public int Lock { get; }
        public int LockNV { get; }
        public byte Type { get; }
        public byte Signalling { get; }
        public byte Size { get; }
        public byte Reserved1 { get; }
        public byte TimerType { get; }
        public byte TimerControlFlags { get; }
        public byte Absolute { get; }
        public byte Wake { get; }
        public byte EncodedTolerableDelay { get; }
        public byte Hand { get; }
        public byte TimerMiscFlags { get; }
        public byte Index { get; }
        public byte Inserted { get; }
        public byte Expired { get; }
        public byte Timer2Type { get; }
        public byte Timer2Flags { get; }
        public byte Timer2Inserted { get; }
        public byte Timer2Expiring { get; }
        public byte Timer2CancelPending { get; }
        public byte Timer2SetPending { get; }
        public byte Timer2Running { get; }
        public byte Timer2Disabled { get; }
        public byte Timer2ReservedFlags { get; }
        public byte Timer2ComponentId { get; }
        public byte Timer2RelativeId { get; }
        public byte QueueType { get; }
        public byte QueueControlFlags { get; }
        public byte Abandoned { get; }
        public byte DisableIncrement { get; }
        public byte QueueReservedControlFlags { get; }
        public byte QueueSize { get; }
        public byte QueueReserved { get; }
        public byte ThreadType { get; }
        public byte ThreadReserved { get; }
        public byte ThreadControlFlags { get; }
        public byte CycleProfiling { get; }
        public byte CounterProfiling { get; }
        public byte GroupScheduling { get; }
        public byte AffinitySet { get; }
        public byte Tagged { get; }
        public byte EnergyProfiling { get; }
        public byte SchedulerAssist { get; }
        public byte ThreadReservedControlFlags { get; }
        public byte DebugActive { get; }
        public byte ActiveDR7 { get; }
        public byte Instrumented { get; }
        public byte Minimal { get; }
        public byte Reserved4 { get; }
        public byte AltSyscall { get; }
        public byte Emulation { get; }
        public byte Reserved5 { get; }
        public byte MutantType { get; }
        public byte MutantSize { get; }
        public byte DpcActive { get; }
        public byte MutantReserved { get; }
        public int SignalState { get; }
        public _LIST_ENTRY WaitListHead { get; }

        public _DISPATCHER_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DISPATCHER_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DISPATCHER_HEADER.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.LockNV),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Signalling),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Reserved1),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.TimerType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.TimerControlFlags),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Absolute),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Wake),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.EncodedTolerableDelay),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Hand),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.TimerMiscFlags),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Index),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Inserted),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Expired),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2Flags),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2Inserted),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2Expiring),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2CancelPending),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2SetPending),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2Running),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2Disabled),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2ReservedFlags),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2ComponentId),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Timer2RelativeId),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.QueueType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.QueueControlFlags),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Abandoned),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.DisableIncrement),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.QueueReservedControlFlags),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.QueueSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.QueueReserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.ThreadType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.ThreadReserved),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.ThreadControlFlags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.CycleProfiling),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.CounterProfiling),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.GroupScheduling),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.AffinitySet),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Tagged),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.EnergyProfiling),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.SchedulerAssist),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.ThreadReservedControlFlags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.DebugActive),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.ActiveDR7),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Instrumented),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Minimal),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Reserved4),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.AltSyscall),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Emulation),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.Reserved5),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.MutantType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.MutantSize),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.DpcActive),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.MutantReserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.SignalState),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DISPATCHER_HEADER.WaitListHead),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DISPATCHER_HEADER>((mem, ptr) => new _DISPATCHER_HEADER(mem, ptr), offsets);
        }
    }
}