using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_COMPLETION_QUEUE")]
    public sealed class PnpDeviceCompletionQueue : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry DispatchedList { get => ReadStructure<ListEntry>(nameof(DispatchedList)); set => WriteStructure(nameof(DispatchedList), value); }

        [Offset(16UL)]
        public uint DispatchedCount { get => ReadHere<uint>(nameof(DispatchedCount)); set => WriteHere(nameof(DispatchedCount), value); }

        [Offset(24UL)]
        public ListEntry CompletedList { get => ReadStructure<ListEntry>(nameof(CompletedList)); set => WriteStructure(nameof(CompletedList), value); }

        [Offset(40UL)]
        public Ksemaphore CompletedSemaphore { get => ReadStructure<Ksemaphore>(nameof(CompletedSemaphore)); set => WriteStructure(nameof(CompletedSemaphore), value); }

        [Offset(72UL)]
        public ulong SpinLock { get => ReadHere<ulong>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        public PnpDeviceCompletionQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpDeviceCompletionQueue>();
        }
    }
}