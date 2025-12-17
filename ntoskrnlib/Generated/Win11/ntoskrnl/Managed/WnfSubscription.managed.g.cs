using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_SUBSCRIPTION")]
    public sealed class WnfSubscription : DynamicStructure
    {
        [Offset(0UL)]
        public WnfNodeHeader Header { get => ReadStructure<WnfNodeHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public ExRundownRef RunRef { get => ReadStructure<ExRundownRef>(nameof(RunRef)); set => WriteStructure(nameof(RunRef), value); }

        [Offset(16UL)]
        public ulong SubscriptionId { get => ReadHere<ulong>(nameof(SubscriptionId)); set => WriteHere(nameof(SubscriptionId), value); }

        [Offset(24UL)]
        public ListEntry ProcessSubscriptionListEntry { get => ReadStructure<ListEntry>(nameof(ProcessSubscriptionListEntry)); set => WriteStructure(nameof(ProcessSubscriptionListEntry), value); }

        [Offset(40UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(48UL)]
        public IntPtr NameInstance { get => ReadHere<IntPtr>(nameof(NameInstance)); set => WriteHere(nameof(NameInstance), value); }

        [Offset(56UL)]
        public WnfStateNameStruct StateName { get => ReadStructure<WnfStateNameStruct>(nameof(StateName)); set => WriteStructure(nameof(StateName), value); }

        [Offset(64UL)]
        public ListEntry StateSubscriptionListEntry { get => ReadStructure<ListEntry>(nameof(StateSubscriptionListEntry)); set => WriteStructure(nameof(StateSubscriptionListEntry), value); }

        [Offset(80UL)]
        public ulong CallbackRoutine { get => ReadHere<ulong>(nameof(CallbackRoutine)); set => WriteHere(nameof(CallbackRoutine), value); }

        [Offset(88UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(96UL)]
        public uint CurrentChangeStamp { get => ReadHere<uint>(nameof(CurrentChangeStamp)); set => WriteHere(nameof(CurrentChangeStamp), value); }

        [Offset(100UL)]
        public uint SubscribedEventSet { get => ReadHere<uint>(nameof(SubscribedEventSet)); set => WriteHere(nameof(SubscribedEventSet), value); }

        [Offset(104UL)]
        public ListEntry PendingSubscriptionListEntry { get => ReadStructure<ListEntry>(nameof(PendingSubscriptionListEntry)); set => WriteStructure(nameof(PendingSubscriptionListEntry), value); }

        [Offset(120UL)]
        public uint SubscriptionState { get => ReadHere<uint>(nameof(SubscriptionState)); set => WriteHere(nameof(SubscriptionState), value); }

        [Offset(124UL)]
        public uint SignaledEventSet { get => ReadHere<uint>(nameof(SignaledEventSet)); set => WriteHere(nameof(SignaledEventSet), value); }

        [Offset(128UL)]
        public uint InDeliveryEventSet { get => ReadHere<uint>(nameof(InDeliveryEventSet)); set => WriteHere(nameof(InDeliveryEventSet), value); }

        public WnfSubscription(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfSubscription>();
        }
    }
}