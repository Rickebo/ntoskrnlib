using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_DEVICE")]
    public sealed class PopFxDevice : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(24UL)]
        public IntPtr IrpData { get => ReadHere<IntPtr>(nameof(IrpData)); set => WriteHere(nameof(IrpData), value); }

        [Offset(32UL)]
        public PopFxDeviceStatus Status { get => ReadStructure<PopFxDeviceStatus>(nameof(Status)); set => WriteStructure(nameof(Status), value); }

        [Offset(36UL)]
        public int PowerReqCall { get => ReadHere<int>(nameof(PowerReqCall)); set => WriteHere(nameof(PowerReqCall), value); }

        [Offset(40UL)]
        public int PowerNotReqCall { get => ReadHere<int>(nameof(PowerNotReqCall)); set => WriteHere(nameof(PowerNotReqCall), value); }

        [Offset(48UL)]
        public IntPtr DevNode { get => ReadHere<IntPtr>(nameof(DevNode)); set => WriteHere(nameof(DevNode), value); }

        [Offset(56UL)]
        public IntPtr DpmContext { get => ReadHere<IntPtr>(nameof(DpmContext)); set => WriteHere(nameof(DpmContext), value); }

        [Offset(64UL)]
        public IntPtr Plugin { get => ReadHere<IntPtr>(nameof(Plugin)); set => WriteHere(nameof(Plugin), value); }

        [Offset(72UL)]
        public IntPtr PluginHandle { get => ReadHere<IntPtr>(nameof(PluginHandle)); set => WriteHere(nameof(PluginHandle), value); }

        [Offset(80UL)]
        public IntPtr AcpiPlugin { get => ReadHere<IntPtr>(nameof(AcpiPlugin)); set => WriteHere(nameof(AcpiPlugin), value); }

        [Offset(88UL)]
        public IntPtr AcpiPluginHandle { get => ReadHere<IntPtr>(nameof(AcpiPluginHandle)); set => WriteHere(nameof(AcpiPluginHandle), value); }

        [Offset(96UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(104UL)]
        public IntPtr TargetDevice { get => ReadHere<IntPtr>(nameof(TargetDevice)); set => WriteHere(nameof(TargetDevice), value); }

        [Offset(112UL)]
        public PopFxDriverCallbacks Callbacks { get => ReadStructure<PopFxDriverCallbacks>(nameof(Callbacks)); set => WriteStructure(nameof(Callbacks), value); }

        [Offset(192UL)]
        public IntPtr DriverContext { get => ReadHere<IntPtr>(nameof(DriverContext)); set => WriteHere(nameof(DriverContext), value); }

        [Offset(200UL)]
        public ListEntry AcpiLink { get => ReadStructure<ListEntry>(nameof(AcpiLink)); set => WriteStructure(nameof(AcpiLink), value); }

        [Offset(216UL)]
        public UnicodeString DeviceId { get => ReadStructure<UnicodeString>(nameof(DeviceId)); set => WriteStructure(nameof(DeviceId), value); }

        [Offset(232UL)]
        public int CommonReferenceFlags { get => ReadHere<int>(nameof(CommonReferenceFlags)); set => WriteHere(nameof(CommonReferenceFlags), value); }

        [Offset(240UL)]
        public IoRemoveLock RemoveLock { get => ReadStructure<IoRemoveLock>(nameof(RemoveLock)); set => WriteStructure(nameof(RemoveLock), value); }

        [Offset(272UL)]
        [Length(10)]
        public DynamicArray RemoveLockReferenceCount { get => ReadStructure<DynamicArray>(nameof(RemoveLockReferenceCount)); set => WriteStructure(nameof(RemoveLockReferenceCount), value); }

        [Offset(312UL)]
        public IoRemoveLock AcpiRemoveLock { get => ReadStructure<IoRemoveLock>(nameof(AcpiRemoveLock)); set => WriteStructure(nameof(AcpiRemoveLock), value); }

        [Offset(344UL)]
        public PopFxWorkOrder WorkOrder { get => ReadStructure<PopFxWorkOrder>(nameof(WorkOrder)); set => WriteStructure(nameof(WorkOrder), value); }

        [Offset(400UL)]
        public ulong IdleLock { get => ReadHere<ulong>(nameof(IdleLock)); set => WriteHere(nameof(IdleLock), value); }

        [Offset(408UL)]
        public Ktimer IdleTimer { get => ReadStructure<Ktimer>(nameof(IdleTimer)); set => WriteStructure(nameof(IdleTimer), value); }

        [Offset(472UL)]
        public Kdpc IdleDpc { get => ReadStructure<Kdpc>(nameof(IdleDpc)); set => WriteStructure(nameof(IdleDpc), value); }

        [Offset(536UL)]
        public ulong IdleTimeout { get => ReadHere<ulong>(nameof(IdleTimeout)); set => WriteHere(nameof(IdleTimeout), value); }

        [Offset(544UL)]
        public ulong IdleStamp { get => ReadHere<ulong>(nameof(IdleStamp)); set => WriteHere(nameof(IdleStamp), value); }

        [Offset(552UL)]
        [Length(2)]
        public DynamicArray NextIrpDeviceObject { get => ReadStructure<DynamicArray>(nameof(NextIrpDeviceObject)); set => WriteStructure(nameof(NextIrpDeviceObject), value); }

        [Offset(568UL)]
        [Length(2)]
        public DynamicArray NextIrpPowerState { get => ReadStructure<DynamicArray>(nameof(NextIrpPowerState)); set => WriteStructure(nameof(NextIrpPowerState), value); }

        [Offset(576UL)]
        [Length(2)]
        public DynamicArray NextIrpCallerCompletion { get => ReadStructure<DynamicArray>(nameof(NextIrpCallerCompletion)); set => WriteStructure(nameof(NextIrpCallerCompletion), value); }

        [Offset(592UL)]
        [Length(2)]
        public DynamicArray NextIrpCallerContext { get => ReadStructure<DynamicArray>(nameof(NextIrpCallerContext)); set => WriteStructure(nameof(NextIrpCallerContext), value); }

        [Offset(608UL)]
        public Kevent IrpCompleteEvent { get => ReadStructure<Kevent>(nameof(IrpCompleteEvent)); set => WriteStructure(nameof(IrpCompleteEvent), value); }

        [Offset(632UL)]
        public IntPtr PowerOnDumpDeviceCallback { get => ReadHere<IntPtr>(nameof(PowerOnDumpDeviceCallback)); set => WriteHere(nameof(PowerOnDumpDeviceCallback), value); }

        [Offset(640UL)]
        public PopFxAccounting Accounting { get => ReadStructure<PopFxAccounting>(nameof(Accounting)); set => WriteStructure(nameof(Accounting), value); }

        [Offset(864UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(868UL)]
        public uint ComponentCount { get => ReadHere<uint>(nameof(ComponentCount)); set => WriteHere(nameof(ComponentCount), value); }

        [Offset(872UL)]
        public IntPtr Components { get => ReadHere<IntPtr>(nameof(Components)); set => WriteHere(nameof(Components), value); }

        [Offset(880UL)]
        public uint LogEntries { get => ReadHere<uint>(nameof(LogEntries)); set => WriteHere(nameof(LogEntries), value); }

        [Offset(888UL)]
        public IntPtr Log { get => ReadHere<IntPtr>(nameof(Log)); set => WriteHere(nameof(Log), value); }

        [Offset(896UL)]
        public int LogIndex { get => ReadHere<int>(nameof(LogIndex)); set => WriteHere(nameof(LogIndex), value); }

        [Offset(904UL)]
        public IntPtr DripsWatchdogDriverObject { get => ReadHere<IntPtr>(nameof(DripsWatchdogDriverObject)); set => WriteHere(nameof(DripsWatchdogDriverObject), value); }

        [Offset(912UL)]
        public PopFxDripsWatchdogContext DripsWatchdogContext { get => ReadStructure<PopFxDripsWatchdogContext>(nameof(DripsWatchdogContext)); set => WriteStructure(nameof(DripsWatchdogContext), value); }

        [Offset(952UL)]
        public uint ChildDeviceComponentIndex { get => ReadHere<uint>(nameof(ChildDeviceComponentIndex)); set => WriteHere(nameof(ChildDeviceComponentIndex), value); }

        [Offset(956UL)]
        public uint DirectedTimeout { get => ReadHere<uint>(nameof(DirectedTimeout)); set => WriteHere(nameof(DirectedTimeout), value); }

        [Offset(960UL)]
        public PopFxWorkOrder DirectedWorkOrder { get => ReadStructure<PopFxWorkOrder>(nameof(DirectedWorkOrder)); set => WriteStructure(nameof(DirectedWorkOrder), value); }

        [Offset(1016UL)]
        public PopFxWorkOrderWatchdogInfo DirectedWorkWatchdogInfo { get => ReadStructure<PopFxWorkOrderWatchdogInfo>(nameof(DirectedWorkWatchdogInfo)); set => WriteStructure(nameof(DirectedWorkWatchdogInfo), value); }

        [Offset(1192UL)]
        public ulong DirectedLock { get => ReadHere<ulong>(nameof(DirectedLock)); set => WriteHere(nameof(DirectedLock), value); }

        [Offset(1200UL)]
        public int DirectedTransitionCallCount { get => ReadHere<int>(nameof(DirectedTransitionCallCount)); set => WriteHere(nameof(DirectedTransitionCallCount), value); }

        [Offset(1208UL)]
        public PopFxDeviceDirectedTransitionState DirectedTransitionState { get => ReadStructure<PopFxDeviceDirectedTransitionState>(nameof(DirectedTransitionState)); set => WriteStructure(nameof(DirectedTransitionState), value); }

        [Offset(1224UL)]
        public IntPtr PowerProfile { get => ReadHere<IntPtr>(nameof(PowerProfile)); set => WriteHere(nameof(PowerProfile), value); }

        [Offset(1232UL)]
        public UnicodeString FriendlyName { get => ReadStructure<UnicodeString>(nameof(FriendlyName)); set => WriteStructure(nameof(FriendlyName), value); }

        [Offset(1248UL)]
        public WorkQueueItem ReportDevicePoweredOnPassiveWorkItem { get => ReadStructure<WorkQueueItem>(nameof(ReportDevicePoweredOnPassiveWorkItem)); set => WriteStructure(nameof(ReportDevicePoweredOnPassiveWorkItem), value); }

        [Offset(1280UL)]
        public ulong RelationsLock { get => ReadHere<ulong>(nameof(RelationsLock)); set => WriteHere(nameof(RelationsLock), value); }

        [Offset(1288UL)]
        public uint IdleProviderCount { get => ReadHere<uint>(nameof(IdleProviderCount)); set => WriteHere(nameof(IdleProviderCount), value); }

        [Offset(1296UL)]
        public IntPtr PendingDevicePowerIrp { get => ReadHere<IntPtr>(nameof(PendingDevicePowerIrp)); set => WriteHere(nameof(PendingDevicePowerIrp), value); }

        [Offset(1304UL)]
        public ListEntry ExternalDependencies { get => ReadStructure<ListEntry>(nameof(ExternalDependencies)); set => WriteStructure(nameof(ExternalDependencies), value); }

        public PopFxDevice(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxDevice>();
        }
    }
}