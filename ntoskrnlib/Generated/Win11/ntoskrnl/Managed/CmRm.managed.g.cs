using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_RM")]
    public sealed class CmRm : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry RmListEntry { get => ReadStructure<ListEntry>(nameof(RmListEntry)); set => WriteStructure(nameof(RmListEntry), value); }

        [Offset(16UL)]
        public ListEntry TransactionListHead { get => ReadStructure<ListEntry>(nameof(TransactionListHead)); set => WriteStructure(nameof(TransactionListHead), value); }

        [Offset(32UL)]
        public IntPtr TmHandle { get => ReadHere<IntPtr>(nameof(TmHandle)); set => WriteHere(nameof(TmHandle), value); }

        [Offset(40UL)]
        public IntPtr Tm { get => ReadHere<IntPtr>(nameof(Tm)); set => WriteHere(nameof(Tm), value); }

        [Offset(48UL)]
        public IntPtr RmHandle { get => ReadHere<IntPtr>(nameof(RmHandle)); set => WriteHere(nameof(RmHandle), value); }

        [Offset(56UL)]
        public IntPtr KtmRm { get => ReadHere<IntPtr>(nameof(KtmRm)); set => WriteHere(nameof(KtmRm), value); }

        [Offset(64UL)]
        public uint RefCount { get => ReadHere<uint>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(68UL)]
        public uint ContainerNum { get => ReadHere<uint>(nameof(ContainerNum)); set => WriteHere(nameof(ContainerNum), value); }

        [Offset(72UL)]
        public ulong ContainerSize { get => ReadHere<ulong>(nameof(ContainerSize)); set => WriteHere(nameof(ContainerSize), value); }

        [Offset(80UL)]
        public IntPtr CmHive { get => ReadHere<IntPtr>(nameof(CmHive)); set => WriteHere(nameof(CmHive), value); }

        [Offset(88UL)]
        public IntPtr LogFileObject { get => ReadHere<IntPtr>(nameof(LogFileObject)); set => WriteHere(nameof(LogFileObject), value); }

        [Offset(96UL)]
        public IntPtr MarshallingContext { get => ReadHere<IntPtr>(nameof(MarshallingContext)); set => WriteHere(nameof(MarshallingContext), value); }

        [Offset(104UL)]
        public uint RmFlags { get => ReadHere<uint>(nameof(RmFlags)); set => WriteHere(nameof(RmFlags), value); }

        [Offset(108UL)]
        public int LogStartStatus1 { get => ReadHere<int>(nameof(LogStartStatus1)); set => WriteHere(nameof(LogStartStatus1), value); }

        [Offset(112UL)]
        public int LogStartStatus2 { get => ReadHere<int>(nameof(LogStartStatus2)); set => WriteHere(nameof(LogStartStatus2), value); }

        [Offset(120UL)]
        public ulong BaseLsn { get => ReadHere<ulong>(nameof(BaseLsn)); set => WriteHere(nameof(BaseLsn), value); }

        [Offset(128UL)]
        public IntPtr RmLock { get => ReadHere<IntPtr>(nameof(RmLock)); set => WriteHere(nameof(RmLock), value); }

        public CmRm(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmRm>();
        }
    }
}