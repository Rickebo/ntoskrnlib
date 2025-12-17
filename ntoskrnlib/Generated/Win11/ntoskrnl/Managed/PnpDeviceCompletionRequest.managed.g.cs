using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_COMPLETION_REQUEST")]
    public sealed class PnpDeviceCompletionRequest : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr DeviceNode { get => ReadHere<IntPtr>(nameof(DeviceNode)); set => WriteHere(nameof(DeviceNode), value); }

        [Offset(24UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(32UL)]
        public uint CompletionState { get => ReadHere<uint>(nameof(CompletionState)); set => WriteHere(nameof(CompletionState), value); }

        [Offset(36UL)]
        public uint IrpPended { get => ReadHere<uint>(nameof(IrpPended)); set => WriteHere(nameof(IrpPended), value); }

        [Offset(40UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(48UL)]
        public IntPtr Information { get => ReadHere<IntPtr>(nameof(Information)); set => WriteHere(nameof(Information), value); }

        [Offset(56UL)]
        public int ReferenceCount { get => ReadHere<int>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(64UL)]
        public IntPtr Watchdog { get => ReadHere<IntPtr>(nameof(Watchdog)); set => WriteHere(nameof(Watchdog), value); }

        public PnpDeviceCompletionRequest(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpDeviceCompletionRequest>();
        }
    }
}