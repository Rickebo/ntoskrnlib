#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 904)]
    public partial struct _DEVICE_NODE
    {
        [FieldOffset(0)]
        public IntPtr Sibling;
        [FieldOffset(8)]
        public IntPtr Child;
        [FieldOffset(16)]
        public IntPtr Parent;
        [FieldOffset(24)]
        public IntPtr LastChild;
        [FieldOffset(32)]
        public IntPtr PhysicalDeviceObject;
        [FieldOffset(40)]
        public _UNICODE_STRING InstancePath;
        [FieldOffset(56)]
        public _UNICODE_STRING ServiceName;
        [FieldOffset(72)]
        public IntPtr PendingIrp;
        [FieldOffset(80)]
        public IntPtr FxDevice;
        [FieldOffset(88)]
        public int FxDeviceLock;
        [FieldOffset(96)]
        public _KEVENT FxRemoveEvent;
        [FieldOffset(120)]
        public int FxActivationCount;
        [FieldOffset(124)]
        public int FxSleepCount;
        [FieldOffset(128)]
        public _UNICODE_STRING UniqueId;
        [FieldOffset(144)]
        public IntPtr Plugin;
        [FieldOffset(152)]
        public uint Level;
        [FieldOffset(156)]
        public _POWER_STATE CurrentPowerState;
        [FieldOffset(160)]
        public _PO_DEVICE_NOTIFY Notify;
        [FieldOffset(264)]
        public _PO_IRP_MANAGER PoIrpManager;
        [FieldOffset(296)]
        public int PowerFlags;
        [FieldOffset(300)]
        public uint State;
        [FieldOffset(304)]
        public uint PreviousState;
        [FieldOffset(308)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public uint[] StateHistory;
        [FieldOffset(388)]
        public uint StateHistoryEntry;
        [FieldOffset(392)]
        public int CompletionStatus;
        [FieldOffset(396)]
        public uint Flags;
        [FieldOffset(400)]
        public uint UserFlags;
        [FieldOffset(404)]
        public uint Problem;
        [FieldOffset(408)]
        public int ProblemStatus;
        [FieldOffset(416)]
        public IntPtr ResourceList;
        [FieldOffset(424)]
        public IntPtr ResourceListTranslated;
        [FieldOffset(432)]
        public IntPtr DuplicatePDO;
        [FieldOffset(440)]
        public IntPtr ResourceRequirements;
        [FieldOffset(448)]
        public uint InterfaceType;
        [FieldOffset(452)]
        public uint BusNumber;
        [FieldOffset(456)]
        public uint ChildInterfaceType;
        [FieldOffset(460)]
        public uint ChildBusNumber;
        [FieldOffset(464)]
        public ushort ChildBusTypeIndex;
        [FieldOffset(466)]
        public byte RemovalPolicy;
        [FieldOffset(467)]
        public byte HardwareRemovalPolicy;
        [FieldOffset(472)]
        public _LIST_ENTRY TargetDeviceNotify;
        [FieldOffset(488)]
        public _LIST_ENTRY DeviceArbiterList;
        [FieldOffset(504)]
        public _LIST_ENTRY DeviceTranslatorList;
        [FieldOffset(520)]
        public ushort NoTranslatorMask;
        [FieldOffset(522)]
        public ushort QueryTranslatorMask;
        [FieldOffset(524)]
        public ushort NoArbiterMask;
        [FieldOffset(526)]
        public ushort QueryArbiterMask;
        [FieldOffset(528)]
        public _unnamed_tag_ OverUsed1;
        [FieldOffset(536)]
        public _unnamed_tag_ OverUsed2;
        [FieldOffset(544)]
        public IntPtr BootResources;
        [FieldOffset(552)]
        public IntPtr BootResourcesTranslated;
        [FieldOffset(560)]
        public uint CapabilityFlags;
        [FieldOffset(568)]
        public _unnamed_tag_ DockInfo;
        [FieldOffset(600)]
        public uint DisableableDepends;
        [FieldOffset(608)]
        public _LIST_ENTRY PendedSetInterfaceState;
        [FieldOffset(624)]
        public _LIST_ENTRY LegacyBusListEntry;
        [FieldOffset(640)]
        public uint DriverUnloadRetryCount;
        [FieldOffset(648)]
        public IntPtr PreviousParent;
        [FieldOffset(656)]
        public int DeletedChildren;
        [FieldOffset(660)]
        public uint NumaNodeIndex;
        [FieldOffset(664)]
        public _GUID ContainerID;
        [FieldOffset(680)]
        public byte OverrideFlags;
        [FieldOffset(684)]
        public uint DeviceIdsHash;
        [FieldOffset(688)]
        public byte RequiresUnloadedDriver;
        [FieldOffset(696)]
        public IntPtr PendingEjectRelations;
        [FieldOffset(704)]
        public uint StateFlags;
        [FieldOffset(712)]
        public IntPtr RebalanceContext;
        [FieldOffset(720)]
        public IntPtr IommuExtension;
        [FieldOffset(728)]
        public _PO_DIRECTED_DRIPS_STATE DirectedDripsState;
        [FieldOffset(784)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _PNP_PROBLEM_CODE_LOG_ENTRY[] ProblemCodeLog;
        [FieldOffset(880)]
        public uint ProblemCodeLogNextIndex;
        [FieldOffset(888)]
        public _LARGE_INTEGER StateTimestamp;
        [FieldOffset(896)]
        public _LARGE_INTEGER PreviousStateTimestamp;
    }
}