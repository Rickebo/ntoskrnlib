using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGEFILE_TRACES")]
    public sealed class MiPagefileTraces : DynamicStructure
    {
        [Offset(0UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(4UL)]
        public byte PagefileNumber { get => ReadHere<byte>(nameof(PagefileNumber)); set => WriteHere(nameof(PagefileNumber), value); }

        [Offset(5UL)]
        public byte Priority { get => ReadHere<byte>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(6UL)]
        public byte IrpPriority { get => ReadHere<byte>(nameof(IrpPriority)); set => WriteHere(nameof(IrpPriority), value); }

        [Offset(7UL)]
        public byte ReservationWrite { get => ReadHere<byte>(nameof(ReservationWrite)); set => WriteHere(nameof(ReservationWrite), value); }

        [Offset(8UL)]
        public ulong CurrentTime { get => ReadHere<ulong>(nameof(CurrentTime)); set => WriteHere(nameof(CurrentTime), value); }

        [Offset(16UL)]
        public ulong AvailablePages { get => ReadHere<ulong>(nameof(AvailablePages)); set => WriteHere(nameof(AvailablePages), value); }

        [Offset(24UL)]
        public ulong ModifiedPagesTotal { get => ReadHere<ulong>(nameof(ModifiedPagesTotal)); set => WriteHere(nameof(ModifiedPagesTotal), value); }

        [Offset(32UL)]
        public ulong ModifiedPagefilePages { get => ReadHere<ulong>(nameof(ModifiedPagefilePages)); set => WriteHere(nameof(ModifiedPagefilePages), value); }

        [Offset(40UL)]
        public ulong ModifiedNoWritePages { get => ReadHere<ulong>(nameof(ModifiedNoWritePages)); set => WriteHere(nameof(ModifiedNoWritePages), value); }

        [Offset(48UL)]
        public ulong ModifiedPagefileNoReservationPages { get => ReadHere<ulong>(nameof(ModifiedPagefileNoReservationPages)); set => WriteHere(nameof(ModifiedPagefileNoReservationPages), value); }

        [Offset(56UL)]
        public ulong ModifiedPageFileNoReservationCompressPages { get => ReadHere<ulong>(nameof(ModifiedPageFileNoReservationCompressPages)); set => WriteHere(nameof(ModifiedPageFileNoReservationCompressPages), value); }

        [Offset(64UL)]
        public ulong ModifiedPagefileReservationPages { get => ReadHere<ulong>(nameof(ModifiedPagefileReservationPages)); set => WriteHere(nameof(ModifiedPagefileReservationPages), value); }

        [Offset(72UL)]
        public UnnamedTag LocalMdl { get => ReadStructure<UnnamedTag>(nameof(LocalMdl)); set => WriteStructure(nameof(LocalMdl), value); }

        public MiPagefileTraces(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPagefileTraces>();
        }
    }
}