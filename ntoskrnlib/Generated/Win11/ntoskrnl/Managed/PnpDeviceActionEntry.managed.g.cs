using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_ACTION_ENTRY")]
    public sealed class PnpDeviceActionEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(24UL)]
        public uint RequestType { get => ReadHere<uint>(nameof(RequestType)); set => WriteHere(nameof(RequestType), value); }

        [Offset(28UL)]
        public byte ReorderingBarrier { get => ReadHere<byte>(nameof(ReorderingBarrier)); set => WriteHere(nameof(ReorderingBarrier), value); }

        [Offset(32UL)]
        public PnpDeviceActionRequestArgument RequestArgument { get => ReadStructure<PnpDeviceActionRequestArgument>(nameof(RequestArgument)); set => WriteStructure(nameof(RequestArgument), value); }

        [Offset(48UL)]
        public IntPtr CompletionEvent { get => ReadHere<IntPtr>(nameof(CompletionEvent)); set => WriteHere(nameof(CompletionEvent), value); }

        [Offset(56UL)]
        public IntPtr CompletionStatus { get => ReadHere<IntPtr>(nameof(CompletionStatus)); set => WriteHere(nameof(CompletionStatus), value); }

        [Offset(64UL)]
        public Guid ActivityId { get => ReadStructure<Guid>(nameof(ActivityId)); set => WriteStructure(nameof(ActivityId), value); }

        [Offset(80UL)]
        public int RefCount { get => ReadHere<int>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(84UL)]
        public byte Dequeued { get => ReadHere<byte>(nameof(Dequeued)); set => WriteHere(nameof(Dequeued), value); }

        [Offset(88UL)]
        public ExPushLock CancelLock { get => ReadStructure<ExPushLock>(nameof(CancelLock)); set => WriteStructure(nameof(CancelLock), value); }

        [Offset(96UL)]
        public byte CancelRequested { get => ReadHere<byte>(nameof(CancelRequested)); set => WriteHere(nameof(CancelRequested), value); }

        public PnpDeviceActionEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpDeviceActionEntry>();
        }
    }
}