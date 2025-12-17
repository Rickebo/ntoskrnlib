using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETIMER")]
    public sealed class Etimer : DynamicStructure
    {
        [Offset(0UL)]
        public Ktimer KeTimer { get => ReadStructure<Ktimer>(nameof(KeTimer)); set => WriteStructure(nameof(KeTimer), value); }

        [Offset(64UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(72UL)]
        public Kapc TimerApc { get => ReadStructure<Kapc>(nameof(TimerApc)); set => WriteStructure(nameof(TimerApc), value); }

        [Offset(160UL)]
        public Kdpc TimerDpc { get => ReadStructure<Kdpc>(nameof(TimerDpc)); set => WriteStructure(nameof(TimerDpc), value); }

        [Offset(224UL)]
        public ListEntry ActiveTimerListEntry { get => ReadStructure<ListEntry>(nameof(ActiveTimerListEntry)); set => WriteStructure(nameof(ActiveTimerListEntry), value); }

        [Offset(240UL)]
        public uint Period { get => ReadHere<uint>(nameof(Period)); set => WriteHere(nameof(Period), value); }

        [Offset(244UL)]
        public sbyte TimerFlags { get => ReadHere<sbyte>(nameof(TimerFlags)); set => WriteHere(nameof(TimerFlags), value); }

        [Offset(244UL)]
        public byte ApcAssociated { get => ReadHere<byte>(nameof(ApcAssociated)); set => WriteHere(nameof(ApcAssociated), value); }

        [Offset(244UL)]
        public byte FlushDpcs { get => ReadHere<byte>(nameof(FlushDpcs)); set => WriteHere(nameof(FlushDpcs), value); }

        [Offset(244UL)]
        public byte Paused { get => ReadHere<byte>(nameof(Paused)); set => WriteHere(nameof(Paused), value); }

        [Offset(244UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(245UL)]
        public byte DueTimeType { get => ReadHere<byte>(nameof(DueTimeType)); set => WriteHere(nameof(DueTimeType), value); }

        [Offset(246UL)]
        public ushort Spare2 { get => ReadHere<ushort>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        [Offset(248UL)]
        public IntPtr WakeReason { get => ReadHere<IntPtr>(nameof(WakeReason)); set => WriteHere(nameof(WakeReason), value); }

        [Offset(256UL)]
        public ListEntry WakeTimerListEntry { get => ReadStructure<ListEntry>(nameof(WakeTimerListEntry)); set => WriteStructure(nameof(WakeTimerListEntry), value); }

        [Offset(272UL)]
        public IntPtr VirtualizedTimerCookie { get => ReadHere<IntPtr>(nameof(VirtualizedTimerCookie)); set => WriteHere(nameof(VirtualizedTimerCookie), value); }

        [Offset(280UL)]
        public ListEntry VirtualizedTimerLinks { get => ReadStructure<ListEntry>(nameof(VirtualizedTimerLinks)); set => WriteStructure(nameof(VirtualizedTimerLinks), value); }

        [Offset(296UL)]
        public ulong DueTime { get => ReadHere<ulong>(nameof(DueTime)); set => WriteHere(nameof(DueTime), value); }

        [Offset(304UL)]
        public uint CoalescingWindow { get => ReadHere<uint>(nameof(CoalescingWindow)); set => WriteHere(nameof(CoalescingWindow), value); }

        public Etimer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Etimer>();
        }
    }
}