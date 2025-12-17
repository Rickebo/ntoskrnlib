using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_TRANS")]
    public sealed class CmTrans : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry TransactionListEntry { get => ReadStructure<ListEntry>(nameof(TransactionListEntry)); set => WriteStructure(nameof(TransactionListEntry), value); }

        [Offset(16UL)]
        public ListEntry KCBUoWListHead { get => ReadStructure<ListEntry>(nameof(KCBUoWListHead)); set => WriteStructure(nameof(KCBUoWListHead), value); }

        [Offset(32UL)]
        public ListEntry LazyCommitListEntry { get => ReadStructure<ListEntry>(nameof(LazyCommitListEntry)); set => WriteStructure(nameof(LazyCommitListEntry), value); }

        [Offset(48UL)]
        public uint Prepared { get => ReadHere<uint>(nameof(Prepared)); set => WriteHere(nameof(Prepared), value); }

        [Offset(48UL)]
        public uint Aborted { get => ReadHere<uint>(nameof(Aborted)); set => WriteHere(nameof(Aborted), value); }

        [Offset(48UL)]
        public uint Committed { get => ReadHere<uint>(nameof(Committed)); set => WriteHere(nameof(Committed), value); }

        [Offset(48UL)]
        public uint Initializing { get => ReadHere<uint>(nameof(Initializing)); set => WriteHere(nameof(Initializing), value); }

        [Offset(48UL)]
        public uint Invalid { get => ReadHere<uint>(nameof(Invalid)); set => WriteHere(nameof(Invalid), value); }

        [Offset(48UL)]
        public uint UseReservation { get => ReadHere<uint>(nameof(UseReservation)); set => WriteHere(nameof(UseReservation), value); }

        [Offset(48UL)]
        public uint TmCallbacksActive { get => ReadHere<uint>(nameof(TmCallbacksActive)); set => WriteHere(nameof(TmCallbacksActive), value); }

        [Offset(48UL)]
        public uint LightWeight { get => ReadHere<uint>(nameof(LightWeight)); set => WriteHere(nameof(LightWeight), value); }

        [Offset(48UL)]
        public uint Freed1 { get => ReadHere<uint>(nameof(Freed1)); set => WriteHere(nameof(Freed1), value); }

        [Offset(48UL)]
        public uint Freed2 { get => ReadHere<uint>(nameof(Freed2)); set => WriteHere(nameof(Freed2), value); }

        [Offset(48UL)]
        public uint Spare1 { get => ReadHere<uint>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(48UL)]
        public uint Freed { get => ReadHere<uint>(nameof(Freed)); set => WriteHere(nameof(Freed), value); }

        [Offset(48UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(48UL)]
        public uint TransState { get => ReadHere<uint>(nameof(TransState)); set => WriteHere(nameof(TransState), value); }

        [Offset(56UL)]
        public CmTransPtr Trans { get => ReadStructure<CmTransPtr>(nameof(Trans)); set => WriteStructure(nameof(Trans), value); }

        [Offset(64UL)]
        public IntPtr CmRm { get => ReadHere<IntPtr>(nameof(CmRm)); set => WriteHere(nameof(CmRm), value); }

        [Offset(72UL)]
        public IntPtr KtmEnlistmentObject { get => ReadHere<IntPtr>(nameof(KtmEnlistmentObject)); set => WriteHere(nameof(KtmEnlistmentObject), value); }

        [Offset(80UL)]
        public IntPtr KtmEnlistmentHandle { get => ReadHere<IntPtr>(nameof(KtmEnlistmentHandle)); set => WriteHere(nameof(KtmEnlistmentHandle), value); }

        [Offset(88UL)]
        public Guid KtmUow { get => ReadStructure<Guid>(nameof(KtmUow)); set => WriteStructure(nameof(KtmUow), value); }

        [Offset(104UL)]
        public ulong StartLsn { get => ReadHere<ulong>(nameof(StartLsn)); set => WriteHere(nameof(StartLsn), value); }

        [Offset(112UL)]
        public uint HiveCount { get => ReadHere<uint>(nameof(HiveCount)); set => WriteHere(nameof(HiveCount), value); }

        [Offset(120UL)]
        [Length(8)]
        public DynamicArray HiveArray { get => ReadStructure<DynamicArray>(nameof(HiveArray)); set => WriteStructure(nameof(HiveArray), value); }

        public CmTrans(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmTrans>();
        }
    }
}