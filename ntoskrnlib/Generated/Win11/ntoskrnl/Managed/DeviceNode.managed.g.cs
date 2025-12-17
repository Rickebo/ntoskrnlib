using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_NODE")]
    public sealed class DeviceNode : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Sibling { get => ReadHere<IntPtr>(nameof(Sibling)); set => WriteHere(nameof(Sibling), value); }

        [Offset(8UL)]
        public IntPtr Child { get => ReadHere<IntPtr>(nameof(Child)); set => WriteHere(nameof(Child), value); }

        [Offset(16UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(24UL)]
        public IntPtr LastChild { get => ReadHere<IntPtr>(nameof(LastChild)); set => WriteHere(nameof(LastChild), value); }

        [Offset(32UL)]
        public IntPtr PhysicalDeviceObject { get => ReadHere<IntPtr>(nameof(PhysicalDeviceObject)); set => WriteHere(nameof(PhysicalDeviceObject), value); }

        [Offset(40UL)]
        public UnicodeString InstancePath { get => ReadStructure<UnicodeString>(nameof(InstancePath)); set => WriteStructure(nameof(InstancePath), value); }

        [Offset(56UL)]
        public UnicodeString ServiceName { get => ReadStructure<UnicodeString>(nameof(ServiceName)); set => WriteStructure(nameof(ServiceName), value); }

        [Offset(72UL)]
        public IntPtr PendingIrp { get => ReadHere<IntPtr>(nameof(PendingIrp)); set => WriteHere(nameof(PendingIrp), value); }

        [Offset(80UL)]
        public IntPtr FxDevice { get => ReadHere<IntPtr>(nameof(FxDevice)); set => WriteHere(nameof(FxDevice), value); }

        [Offset(88UL)]
        public int FxDeviceLock { get => ReadHere<int>(nameof(FxDeviceLock)); set => WriteHere(nameof(FxDeviceLock), value); }

        [Offset(96UL)]
        public Kevent FxRemoveEvent { get => ReadStructure<Kevent>(nameof(FxRemoveEvent)); set => WriteStructure(nameof(FxRemoveEvent), value); }

        [Offset(120UL)]
        public int FxActivationCount { get => ReadHere<int>(nameof(FxActivationCount)); set => WriteHere(nameof(FxActivationCount), value); }

        [Offset(124UL)]
        public int FxSleepCount { get => ReadHere<int>(nameof(FxSleepCount)); set => WriteHere(nameof(FxSleepCount), value); }

        [Offset(128UL)]
        public UnicodeString UniqueId { get => ReadStructure<UnicodeString>(nameof(UniqueId)); set => WriteStructure(nameof(UniqueId), value); }

        [Offset(144UL)]
        public IntPtr Plugin { get => ReadHere<IntPtr>(nameof(Plugin)); set => WriteHere(nameof(Plugin), value); }

        [Offset(152UL)]
        public uint Level { get => ReadHere<uint>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(156UL)]
        public PowerState CurrentPowerState { get => ReadStructure<PowerState>(nameof(CurrentPowerState)); set => WriteStructure(nameof(CurrentPowerState), value); }

        [Offset(160UL)]
        public PoDeviceNotify Notify { get => ReadStructure<PoDeviceNotify>(nameof(Notify)); set => WriteStructure(nameof(Notify), value); }

        [Offset(264UL)]
        public PoIrpManager PoIrpManager { get => ReadStructure<PoIrpManager>(nameof(PoIrpManager)); set => WriteStructure(nameof(PoIrpManager), value); }

        [Offset(296UL)]
        public int PowerFlags { get => ReadHere<int>(nameof(PowerFlags)); set => WriteHere(nameof(PowerFlags), value); }

        [Offset(300UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(304UL)]
        public uint PreviousState { get => ReadHere<uint>(nameof(PreviousState)); set => WriteHere(nameof(PreviousState), value); }

        [Offset(308UL)]
        [Length(20)]
        public DynamicArray StateHistory { get => ReadStructure<DynamicArray>(nameof(StateHistory)); set => WriteStructure(nameof(StateHistory), value); }

        [Offset(388UL)]
        public uint StateHistoryEntry { get => ReadHere<uint>(nameof(StateHistoryEntry)); set => WriteHere(nameof(StateHistoryEntry), value); }

        [Offset(392UL)]
        public int CompletionStatus { get => ReadHere<int>(nameof(CompletionStatus)); set => WriteHere(nameof(CompletionStatus), value); }

        [Offset(396UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(400UL)]
        public uint UserFlags { get => ReadHere<uint>(nameof(UserFlags)); set => WriteHere(nameof(UserFlags), value); }

        [Offset(404UL)]
        public uint Problem { get => ReadHere<uint>(nameof(Problem)); set => WriteHere(nameof(Problem), value); }

        [Offset(408UL)]
        public int ProblemStatus { get => ReadHere<int>(nameof(ProblemStatus)); set => WriteHere(nameof(ProblemStatus), value); }

        [Offset(416UL)]
        public IntPtr ResourceList { get => ReadHere<IntPtr>(nameof(ResourceList)); set => WriteHere(nameof(ResourceList), value); }

        [Offset(424UL)]
        public IntPtr ResourceListTranslated { get => ReadHere<IntPtr>(nameof(ResourceListTranslated)); set => WriteHere(nameof(ResourceListTranslated), value); }

        [Offset(432UL)]
        public IntPtr DuplicatePDO { get => ReadHere<IntPtr>(nameof(DuplicatePDO)); set => WriteHere(nameof(DuplicatePDO), value); }

        [Offset(440UL)]
        public IntPtr ResourceRequirements { get => ReadHere<IntPtr>(nameof(ResourceRequirements)); set => WriteHere(nameof(ResourceRequirements), value); }

        [Offset(448UL)]
        public uint InterfaceType { get => ReadHere<uint>(nameof(InterfaceType)); set => WriteHere(nameof(InterfaceType), value); }

        [Offset(452UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(456UL)]
        public uint ChildInterfaceType { get => ReadHere<uint>(nameof(ChildInterfaceType)); set => WriteHere(nameof(ChildInterfaceType), value); }

        [Offset(460UL)]
        public uint ChildBusNumber { get => ReadHere<uint>(nameof(ChildBusNumber)); set => WriteHere(nameof(ChildBusNumber), value); }

        [Offset(464UL)]
        public ushort ChildBusTypeIndex { get => ReadHere<ushort>(nameof(ChildBusTypeIndex)); set => WriteHere(nameof(ChildBusTypeIndex), value); }

        [Offset(466UL)]
        public byte RemovalPolicy { get => ReadHere<byte>(nameof(RemovalPolicy)); set => WriteHere(nameof(RemovalPolicy), value); }

        [Offset(467UL)]
        public byte HardwareRemovalPolicy { get => ReadHere<byte>(nameof(HardwareRemovalPolicy)); set => WriteHere(nameof(HardwareRemovalPolicy), value); }

        [Offset(472UL)]
        public ListEntry TargetDeviceNotify { get => ReadStructure<ListEntry>(nameof(TargetDeviceNotify)); set => WriteStructure(nameof(TargetDeviceNotify), value); }

        [Offset(488UL)]
        public ListEntry DeviceArbiterList { get => ReadStructure<ListEntry>(nameof(DeviceArbiterList)); set => WriteStructure(nameof(DeviceArbiterList), value); }

        [Offset(504UL)]
        public ListEntry DeviceTranslatorList { get => ReadStructure<ListEntry>(nameof(DeviceTranslatorList)); set => WriteStructure(nameof(DeviceTranslatorList), value); }

        [Offset(520UL)]
        public ushort NoTranslatorMask { get => ReadHere<ushort>(nameof(NoTranslatorMask)); set => WriteHere(nameof(NoTranslatorMask), value); }

        [Offset(522UL)]
        public ushort QueryTranslatorMask { get => ReadHere<ushort>(nameof(QueryTranslatorMask)); set => WriteHere(nameof(QueryTranslatorMask), value); }

        [Offset(524UL)]
        public ushort NoArbiterMask { get => ReadHere<ushort>(nameof(NoArbiterMask)); set => WriteHere(nameof(NoArbiterMask), value); }

        [Offset(526UL)]
        public ushort QueryArbiterMask { get => ReadHere<ushort>(nameof(QueryArbiterMask)); set => WriteHere(nameof(QueryArbiterMask), value); }

        [Offset(528UL)]
        public UnnamedTag OverUsed1 { get => ReadStructure<UnnamedTag>(nameof(OverUsed1)); set => WriteStructure(nameof(OverUsed1), value); }

        [Offset(536UL)]
        public UnnamedTag OverUsed2 { get => ReadStructure<UnnamedTag>(nameof(OverUsed2)); set => WriteStructure(nameof(OverUsed2), value); }

        [Offset(544UL)]
        public IntPtr BootResources { get => ReadHere<IntPtr>(nameof(BootResources)); set => WriteHere(nameof(BootResources), value); }

        [Offset(552UL)]
        public IntPtr BootResourcesTranslated { get => ReadHere<IntPtr>(nameof(BootResourcesTranslated)); set => WriteHere(nameof(BootResourcesTranslated), value); }

        [Offset(560UL)]
        public uint CapabilityFlags { get => ReadHere<uint>(nameof(CapabilityFlags)); set => WriteHere(nameof(CapabilityFlags), value); }

        [Offset(568UL)]
        public UnnamedTag DockInfo { get => ReadStructure<UnnamedTag>(nameof(DockInfo)); set => WriteStructure(nameof(DockInfo), value); }

        [Offset(600UL)]
        public uint DisableableDepends { get => ReadHere<uint>(nameof(DisableableDepends)); set => WriteHere(nameof(DisableableDepends), value); }

        [Offset(608UL)]
        public ListEntry PendedSetInterfaceState { get => ReadStructure<ListEntry>(nameof(PendedSetInterfaceState)); set => WriteStructure(nameof(PendedSetInterfaceState), value); }

        [Offset(624UL)]
        public ListEntry LegacyBusListEntry { get => ReadStructure<ListEntry>(nameof(LegacyBusListEntry)); set => WriteStructure(nameof(LegacyBusListEntry), value); }

        [Offset(640UL)]
        public uint DriverUnloadRetryCount { get => ReadHere<uint>(nameof(DriverUnloadRetryCount)); set => WriteHere(nameof(DriverUnloadRetryCount), value); }

        [Offset(648UL)]
        public IntPtr PreviousParent { get => ReadHere<IntPtr>(nameof(PreviousParent)); set => WriteHere(nameof(PreviousParent), value); }

        [Offset(656UL)]
        public int DeletedChildren { get => ReadHere<int>(nameof(DeletedChildren)); set => WriteHere(nameof(DeletedChildren), value); }

        [Offset(660UL)]
        public uint NumaNodeIndex { get => ReadHere<uint>(nameof(NumaNodeIndex)); set => WriteHere(nameof(NumaNodeIndex), value); }

        [Offset(664UL)]
        public Guid ContainerID { get => ReadStructure<Guid>(nameof(ContainerID)); set => WriteStructure(nameof(ContainerID), value); }

        [Offset(680UL)]
        public byte OverrideFlags { get => ReadHere<byte>(nameof(OverrideFlags)); set => WriteHere(nameof(OverrideFlags), value); }

        [Offset(684UL)]
        public uint DeviceIdsHash { get => ReadHere<uint>(nameof(DeviceIdsHash)); set => WriteHere(nameof(DeviceIdsHash), value); }

        [Offset(688UL)]
        public byte RequiresUnloadedDriver { get => ReadHere<byte>(nameof(RequiresUnloadedDriver)); set => WriteHere(nameof(RequiresUnloadedDriver), value); }

        [Offset(696UL)]
        public IntPtr PendingEjectRelations { get => ReadHere<IntPtr>(nameof(PendingEjectRelations)); set => WriteHere(nameof(PendingEjectRelations), value); }

        [Offset(704UL)]
        public uint StateFlags { get => ReadHere<uint>(nameof(StateFlags)); set => WriteHere(nameof(StateFlags), value); }

        [Offset(712UL)]
        public IntPtr RebalanceContext { get => ReadHere<IntPtr>(nameof(RebalanceContext)); set => WriteHere(nameof(RebalanceContext), value); }

        [Offset(720UL)]
        public IntPtr IommuExtension { get => ReadHere<IntPtr>(nameof(IommuExtension)); set => WriteHere(nameof(IommuExtension), value); }

        [Offset(728UL)]
        public PoDirectedDripsState DirectedDripsState { get => ReadStructure<PoDirectedDripsState>(nameof(DirectedDripsState)); set => WriteStructure(nameof(DirectedDripsState), value); }

        [Offset(784UL)]
        [Length(4)]
        public DynamicArray ProblemCodeLog { get => ReadStructure<DynamicArray>(nameof(ProblemCodeLog)); set => WriteStructure(nameof(ProblemCodeLog), value); }

        [Offset(880UL)]
        public uint ProblemCodeLogNextIndex { get => ReadHere<uint>(nameof(ProblemCodeLogNextIndex)); set => WriteHere(nameof(ProblemCodeLogNextIndex), value); }

        [Offset(888UL)]
        public LargeInteger StateTimestamp { get => ReadStructure<LargeInteger>(nameof(StateTimestamp)); set => WriteStructure(nameof(StateTimestamp), value); }

        [Offset(896UL)]
        public LargeInteger PreviousStateTimestamp { get => ReadStructure<LargeInteger>(nameof(PreviousStateTimestamp)); set => WriteStructure(nameof(PreviousStateTimestamp), value); }

        public DeviceNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceNode>();
        }
    }
}