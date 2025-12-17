using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_MESSAGE")]
    public sealed class KalpcMessage : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Entry { get => ReadStructure<ListEntry>(nameof(Entry)); set => WriteStructure(nameof(Entry), value); }

        [Offset(16UL)]
        public IntPtr PortQueue { get => ReadHere<IntPtr>(nameof(PortQueue)); set => WriteHere(nameof(PortQueue), value); }

        [Offset(24UL)]
        public IntPtr OwnerPort { get => ReadHere<IntPtr>(nameof(OwnerPort)); set => WriteHere(nameof(OwnerPort), value); }

        [Offset(32UL)]
        public IntPtr WaitingThread { get => ReadHere<IntPtr>(nameof(WaitingThread)); set => WriteHere(nameof(WaitingThread), value); }

        [Offset(40UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(44UL)]
        public int SequenceNo { get => ReadHere<int>(nameof(SequenceNo)); set => WriteHere(nameof(SequenceNo), value); }

        [Offset(48UL)]
        public IntPtr QuotaProcess { get => ReadHere<IntPtr>(nameof(QuotaProcess)); set => WriteHere(nameof(QuotaProcess), value); }

        [Offset(48UL)]
        public IntPtr QuotaBlock { get => ReadHere<IntPtr>(nameof(QuotaBlock)); set => WriteHere(nameof(QuotaBlock), value); }

        [Offset(56UL)]
        public IntPtr CancelSequencePort { get => ReadHere<IntPtr>(nameof(CancelSequencePort)); set => WriteHere(nameof(CancelSequencePort), value); }

        [Offset(64UL)]
        public IntPtr CancelQueuePort { get => ReadHere<IntPtr>(nameof(CancelQueuePort)); set => WriteHere(nameof(CancelQueuePort), value); }

        [Offset(72UL)]
        public int CancelSequenceNo { get => ReadHere<int>(nameof(CancelSequenceNo)); set => WriteHere(nameof(CancelSequenceNo), value); }

        [Offset(80UL)]
        public ListEntry CancelListEntry { get => ReadStructure<ListEntry>(nameof(CancelListEntry)); set => WriteStructure(nameof(CancelListEntry), value); }

        [Offset(96UL)]
        public IntPtr Reserve { get => ReadHere<IntPtr>(nameof(Reserve)); set => WriteHere(nameof(Reserve), value); }

        [Offset(104UL)]
        public KalpcMessageAttributes MessageAttributes { get => ReadStructure<KalpcMessageAttributes>(nameof(MessageAttributes)); set => WriteStructure(nameof(MessageAttributes), value); }

        [Offset(176UL)]
        public IntPtr DataUserVa { get => ReadHere<IntPtr>(nameof(DataUserVa)); set => WriteHere(nameof(DataUserVa), value); }

        [Offset(184UL)]
        public IntPtr CommunicationInfo { get => ReadHere<IntPtr>(nameof(CommunicationInfo)); set => WriteHere(nameof(CommunicationInfo), value); }

        [Offset(192UL)]
        public IntPtr ConnectionPort { get => ReadHere<IntPtr>(nameof(ConnectionPort)); set => WriteHere(nameof(ConnectionPort), value); }

        [Offset(200UL)]
        public IntPtr ServerThread { get => ReadHere<IntPtr>(nameof(ServerThread)); set => WriteHere(nameof(ServerThread), value); }

        [Offset(208UL)]
        public IntPtr WakeReference { get => ReadHere<IntPtr>(nameof(WakeReference)); set => WriteHere(nameof(WakeReference), value); }

        [Offset(216UL)]
        public IntPtr WakeReference2 { get => ReadHere<IntPtr>(nameof(WakeReference2)); set => WriteHere(nameof(WakeReference2), value); }

        [Offset(224UL)]
        public IntPtr ExtensionBuffer { get => ReadHere<IntPtr>(nameof(ExtensionBuffer)); set => WriteHere(nameof(ExtensionBuffer), value); }

        [Offset(232UL)]
        public ulong ExtensionBufferSize { get => ReadHere<ulong>(nameof(ExtensionBufferSize)); set => WriteHere(nameof(ExtensionBufferSize), value); }

        [Offset(240UL)]
        public PortMessage PortMessage { get => ReadStructure<PortMessage>(nameof(PortMessage)); set => WriteStructure(nameof(PortMessage), value); }

        public KalpcMessage(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcMessage>();
        }
    }
}