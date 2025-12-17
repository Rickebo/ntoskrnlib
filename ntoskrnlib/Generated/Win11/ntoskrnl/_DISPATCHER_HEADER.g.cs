#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _DISPATCHER_HEADER
    {
        [FieldOffset(0)]
        public int Lock;
        [FieldOffset(0)]
        public int LockNV;
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Signalling;
        [FieldOffset(2)]
        public byte Size;
        [FieldOffset(3)]
        public byte Reserved1;
        [FieldOffset(0)]
        public byte TimerType;
        [FieldOffset(1)]
        public byte TimerControlFlags;
        [FieldOffset(1)]
        public byte Absolute;
        [FieldOffset(1)]
        public byte Wake;
        [FieldOffset(1)]
        public byte EncodedTolerableDelay;
        [FieldOffset(2)]
        public byte Hand;
        [FieldOffset(3)]
        public byte TimerMiscFlags;
        [FieldOffset(3)]
        public byte Index;
        [FieldOffset(3)]
        public byte Inserted;
        [FieldOffset(3)]
        public byte Expired;
        [FieldOffset(0)]
        public byte Timer2Type;
        [FieldOffset(1)]
        public byte Timer2Flags;
        [FieldOffset(1)]
        public byte Timer2Inserted;
        [FieldOffset(1)]
        public byte Timer2Expiring;
        [FieldOffset(1)]
        public byte Timer2CancelPending;
        [FieldOffset(1)]
        public byte Timer2SetPending;
        [FieldOffset(1)]
        public byte Timer2Running;
        [FieldOffset(1)]
        public byte Timer2Disabled;
        [FieldOffset(1)]
        public byte Timer2ReservedFlags;
        [FieldOffset(2)]
        public byte Timer2ComponentId;
        [FieldOffset(3)]
        public byte Timer2RelativeId;
        [FieldOffset(0)]
        public byte QueueType;
        [FieldOffset(1)]
        public byte QueueControlFlags;
        [FieldOffset(1)]
        public byte Abandoned;
        [FieldOffset(1)]
        public byte DisableIncrement;
        [FieldOffset(1)]
        public byte QueueReservedControlFlags;
        [FieldOffset(2)]
        public byte QueueSize;
        [FieldOffset(3)]
        public byte QueueReserved;
        [FieldOffset(0)]
        public byte ThreadType;
        [FieldOffset(1)]
        public byte ThreadReserved;
        [FieldOffset(2)]
        public byte ThreadControlFlags;
        [FieldOffset(2)]
        public byte CycleProfiling;
        [FieldOffset(2)]
        public byte CounterProfiling;
        [FieldOffset(2)]
        public byte GroupScheduling;
        [FieldOffset(2)]
        public byte AffinitySet;
        [FieldOffset(2)]
        public byte Tagged;
        [FieldOffset(2)]
        public byte EnergyProfiling;
        [FieldOffset(2)]
        public byte SchedulerAssist;
        [FieldOffset(2)]
        public byte ThreadReservedControlFlags;
        [FieldOffset(3)]
        public byte DebugActive;
        [FieldOffset(3)]
        public byte ActiveDR7;
        [FieldOffset(3)]
        public byte Instrumented;
        [FieldOffset(3)]
        public byte Minimal;
        [FieldOffset(3)]
        public byte Reserved4;
        [FieldOffset(3)]
        public byte AltSyscall;
        [FieldOffset(3)]
        public byte Emulation;
        [FieldOffset(3)]
        public byte Reserved5;
        [FieldOffset(0)]
        public byte MutantType;
        [FieldOffset(1)]
        public byte MutantSize;
        [FieldOffset(2)]
        public byte DpcActive;
        [FieldOffset(3)]
        public byte MutantReserved;
        [FieldOffset(4)]
        public int SignalState;
        [FieldOffset(8)]
        public _LIST_ENTRY WaitListHead;
    }
}