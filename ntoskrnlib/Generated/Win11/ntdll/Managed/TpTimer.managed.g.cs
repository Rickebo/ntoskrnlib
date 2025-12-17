using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_TIMER")]
    public sealed class TpTimer : DynamicStructure
    {
        [Offset(0UL)]
        public TpWork Work { get => ReadStructure<TpWork>(nameof(Work)); set => WriteStructure(nameof(Work), value); }

        [Offset(240UL)]
        public RtlSrwlock Lock { get => ReadStructure<RtlSrwlock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(248UL)]
        public TppPhLinks WindowEndLinks { get => ReadStructure<TppPhLinks>(nameof(WindowEndLinks)); set => WriteStructure(nameof(WindowEndLinks), value); }

        [Offset(248UL)]
        public ListEntry ExpirationLinks { get => ReadStructure<ListEntry>(nameof(ExpirationLinks)); set => WriteStructure(nameof(ExpirationLinks), value); }

        [Offset(288UL)]
        public TppPhLinks WindowStartLinks { get => ReadStructure<TppPhLinks>(nameof(WindowStartLinks)); set => WriteStructure(nameof(WindowStartLinks), value); }

        [Offset(328UL)]
        public long DueTime { get => ReadHere<long>(nameof(DueTime)); set => WriteHere(nameof(DueTime), value); }

        [Offset(336UL)]
        public TppIte CancelIte { get => ReadStructure<TppIte>(nameof(CancelIte)); set => WriteStructure(nameof(CancelIte), value); }

        [Offset(344UL)]
        public uint Window { get => ReadHere<uint>(nameof(Window)); set => WriteHere(nameof(Window), value); }

        [Offset(348UL)]
        public uint Period { get => ReadHere<uint>(nameof(Period)); set => WriteHere(nameof(Period), value); }

        [Offset(352UL)]
        public byte Inserted { get => ReadHere<byte>(nameof(Inserted)); set => WriteHere(nameof(Inserted), value); }

        [Offset(353UL)]
        public byte WaitTimer { get => ReadHere<byte>(nameof(WaitTimer)); set => WriteHere(nameof(WaitTimer), value); }

        [Offset(354UL)]
        public byte TimerStatus { get => ReadHere<byte>(nameof(TimerStatus)); set => WriteHere(nameof(TimerStatus), value); }

        [Offset(354UL)]
        public byte InQueue { get => ReadHere<byte>(nameof(InQueue)); set => WriteHere(nameof(InQueue), value); }

        [Offset(354UL)]
        public byte Absolute { get => ReadHere<byte>(nameof(Absolute)); set => WriteHere(nameof(Absolute), value); }

        [Offset(354UL)]
        public byte Cancelled { get => ReadHere<byte>(nameof(Cancelled)); set => WriteHere(nameof(Cancelled), value); }

        [Offset(355UL)]
        public byte BlockInsert { get => ReadHere<byte>(nameof(BlockInsert)); set => WriteHere(nameof(BlockInsert), value); }

        public TpTimer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpTimer>();
        }
    }
}