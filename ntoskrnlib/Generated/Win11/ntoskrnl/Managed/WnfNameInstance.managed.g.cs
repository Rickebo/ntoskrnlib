using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_NAME_INSTANCE")]
    public sealed class WnfNameInstance : DynamicStructure
    {
        [Offset(0UL)]
        public WnfNodeHeader Header { get => ReadStructure<WnfNodeHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public ExRundownRef RunRef { get => ReadStructure<ExRundownRef>(nameof(RunRef)); set => WriteStructure(nameof(RunRef), value); }

        [Offset(16UL)]
        public RtlBalancedNode TreeLinks { get => ReadStructure<RtlBalancedNode>(nameof(TreeLinks)); set => WriteStructure(nameof(TreeLinks), value); }

        [Offset(40UL)]
        public WnfStateNameStruct StateName { get => ReadStructure<WnfStateNameStruct>(nameof(StateName)); set => WriteStructure(nameof(StateName), value); }

        [Offset(48UL)]
        public IntPtr ScopeInstance { get => ReadHere<IntPtr>(nameof(ScopeInstance)); set => WriteHere(nameof(ScopeInstance), value); }

        [Offset(56UL)]
        public WnfStateNameRegistration StateNameInfo { get => ReadStructure<WnfStateNameRegistration>(nameof(StateNameInfo)); set => WriteStructure(nameof(StateNameInfo), value); }

        [Offset(80UL)]
        public WnfLock StateDataLock { get => ReadStructure<WnfLock>(nameof(StateDataLock)); set => WriteStructure(nameof(StateDataLock), value); }

        [Offset(88UL)]
        public IntPtr StateData { get => ReadHere<IntPtr>(nameof(StateData)); set => WriteHere(nameof(StateData), value); }

        [Offset(96UL)]
        public uint CurrentChangeStamp { get => ReadHere<uint>(nameof(CurrentChangeStamp)); set => WriteHere(nameof(CurrentChangeStamp), value); }

        [Offset(104UL)]
        public IntPtr PermanentDataStore { get => ReadHere<IntPtr>(nameof(PermanentDataStore)); set => WriteHere(nameof(PermanentDataStore), value); }

        [Offset(112UL)]
        public WnfLock StateSubscriptionListLock { get => ReadStructure<WnfLock>(nameof(StateSubscriptionListLock)); set => WriteStructure(nameof(StateSubscriptionListLock), value); }

        [Offset(120UL)]
        public ListEntry StateSubscriptionListHead { get => ReadStructure<ListEntry>(nameof(StateSubscriptionListHead)); set => WriteStructure(nameof(StateSubscriptionListHead), value); }

        [Offset(136UL)]
        public ListEntry TemporaryNameListEntry { get => ReadStructure<ListEntry>(nameof(TemporaryNameListEntry)); set => WriteStructure(nameof(TemporaryNameListEntry), value); }

        [Offset(152UL)]
        public IntPtr CreatorProcess { get => ReadHere<IntPtr>(nameof(CreatorProcess)); set => WriteHere(nameof(CreatorProcess), value); }

        [Offset(160UL)]
        public int DataSubscribersCount { get => ReadHere<int>(nameof(DataSubscribersCount)); set => WriteHere(nameof(DataSubscribersCount), value); }

        [Offset(164UL)]
        public int CurrentDeliveryCount { get => ReadHere<int>(nameof(CurrentDeliveryCount)); set => WriteHere(nameof(CurrentDeliveryCount), value); }

        public WnfNameInstance(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfNameInstance>();
        }
    }
}