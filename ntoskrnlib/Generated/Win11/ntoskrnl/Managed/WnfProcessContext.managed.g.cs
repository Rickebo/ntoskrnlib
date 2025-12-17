using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_PROCESS_CONTEXT")]
    public sealed class WnfProcessContext : DynamicStructure
    {
        [Offset(0UL)]
        public WnfNodeHeader Header { get => ReadStructure<WnfNodeHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(16UL)]
        public ListEntry WnfProcessesListEntry { get => ReadStructure<ListEntry>(nameof(WnfProcessesListEntry)); set => WriteStructure(nameof(WnfProcessesListEntry), value); }

        [Offset(32UL)]
        [Length(3)]
        public DynamicArray ImplicitScopeInstances { get => ReadStructure<DynamicArray>(nameof(ImplicitScopeInstances)); set => WriteStructure(nameof(ImplicitScopeInstances), value); }

        [Offset(56UL)]
        public WnfLock TemporaryNamesListLock { get => ReadStructure<WnfLock>(nameof(TemporaryNamesListLock)); set => WriteStructure(nameof(TemporaryNamesListLock), value); }

        [Offset(64UL)]
        public ListEntry TemporaryNamesListHead { get => ReadStructure<ListEntry>(nameof(TemporaryNamesListHead)); set => WriteStructure(nameof(TemporaryNamesListHead), value); }

        [Offset(80UL)]
        public WnfLock ProcessSubscriptionListLock { get => ReadStructure<WnfLock>(nameof(ProcessSubscriptionListLock)); set => WriteStructure(nameof(ProcessSubscriptionListLock), value); }

        [Offset(88UL)]
        public ListEntry ProcessSubscriptionListHead { get => ReadStructure<ListEntry>(nameof(ProcessSubscriptionListHead)); set => WriteStructure(nameof(ProcessSubscriptionListHead), value); }

        [Offset(104UL)]
        public WnfLock DeliveryPendingListLock { get => ReadStructure<WnfLock>(nameof(DeliveryPendingListLock)); set => WriteStructure(nameof(DeliveryPendingListLock), value); }

        [Offset(112UL)]
        public ListEntry DeliveryPendingListHead { get => ReadStructure<ListEntry>(nameof(DeliveryPendingListHead)); set => WriteStructure(nameof(DeliveryPendingListHead), value); }

        [Offset(128UL)]
        public IntPtr NotificationEvent { get => ReadHere<IntPtr>(nameof(NotificationEvent)); set => WriteHere(nameof(NotificationEvent), value); }

        public WnfProcessContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfProcessContext>();
        }
    }
}