#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1320)]
    public partial struct _POP_FX_DEVICE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public IntPtr Irp;
        [FieldOffset(24)]
        public IntPtr IrpData;
        [FieldOffset(32)]
        public _POP_FX_DEVICE_STATUS Status;
        [FieldOffset(36)]
        public int PowerReqCall;
        [FieldOffset(40)]
        public int PowerNotReqCall;
        [FieldOffset(48)]
        public IntPtr DevNode;
        [FieldOffset(56)]
        public IntPtr DpmContext;
        [FieldOffset(64)]
        public IntPtr Plugin;
        [FieldOffset(72)]
        public IntPtr PluginHandle;
        [FieldOffset(80)]
        public IntPtr AcpiPlugin;
        [FieldOffset(88)]
        public IntPtr AcpiPluginHandle;
        [FieldOffset(96)]
        public IntPtr DeviceObject;
        [FieldOffset(104)]
        public IntPtr TargetDevice;
        [FieldOffset(112)]
        public _POP_FX_DRIVER_CALLBACKS Callbacks;
        [FieldOffset(192)]
        public IntPtr DriverContext;
        [FieldOffset(200)]
        public _LIST_ENTRY AcpiLink;
        [FieldOffset(216)]
        public _UNICODE_STRING DeviceId;
        [FieldOffset(232)]
        public int CommonReferenceFlags;
        [FieldOffset(240)]
        public _IO_REMOVE_LOCK RemoveLock;
        [FieldOffset(272)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public int[] RemoveLockReferenceCount;
        [FieldOffset(312)]
        public _IO_REMOVE_LOCK AcpiRemoveLock;
        [FieldOffset(344)]
        public _POP_FX_WORK_ORDER WorkOrder;
        [FieldOffset(400)]
        public ulong IdleLock;
        [FieldOffset(408)]
        public _KTIMER IdleTimer;
        [FieldOffset(472)]
        public _KDPC IdleDpc;
        [FieldOffset(536)]
        public ulong IdleTimeout;
        [FieldOffset(544)]
        public ulong IdleStamp;
        [FieldOffset(552)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] NextIrpDeviceObject;
        [FieldOffset(568)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _POWER_STATE[] NextIrpPowerState;
        [FieldOffset(576)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] NextIrpCallerCompletion;
        [FieldOffset(592)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] NextIrpCallerContext;
        [FieldOffset(608)]
        public _KEVENT IrpCompleteEvent;
        [FieldOffset(632)]
        public IntPtr PowerOnDumpDeviceCallback;
        [FieldOffset(640)]
        public _POP_FX_ACCOUNTING Accounting;
        [FieldOffset(864)]
        public uint Flags;
        [FieldOffset(868)]
        public uint ComponentCount;
        [FieldOffset(872)]
        public IntPtr Components;
        [FieldOffset(880)]
        public uint LogEntries;
        [FieldOffset(888)]
        public IntPtr Log;
        [FieldOffset(896)]
        public int LogIndex;
        [FieldOffset(904)]
        public IntPtr DripsWatchdogDriverObject;
        [FieldOffset(912)]
        public _POP_FX_DRIPS_WATCHDOG_CONTEXT DripsWatchdogContext;
        [FieldOffset(952)]
        public uint ChildDeviceComponentIndex;
        [FieldOffset(956)]
        public uint DirectedTimeout;
        [FieldOffset(960)]
        public _POP_FX_WORK_ORDER DirectedWorkOrder;
        [FieldOffset(1016)]
        public _POP_FX_WORK_ORDER_WATCHDOG_INFO DirectedWorkWatchdogInfo;
        [FieldOffset(1192)]
        public ulong DirectedLock;
        [FieldOffset(1200)]
        public int DirectedTransitionCallCount;
        [FieldOffset(1208)]
        public _POP_FX_DEVICE_DIRECTED_TRANSITION_STATE DirectedTransitionState;
        [FieldOffset(1224)]
        public IntPtr PowerProfile;
        [FieldOffset(1232)]
        public _UNICODE_STRING FriendlyName;
        [FieldOffset(1248)]
        public _WORK_QUEUE_ITEM ReportDevicePoweredOnPassiveWorkItem;
        [FieldOffset(1280)]
        public ulong RelationsLock;
        [FieldOffset(1288)]
        public uint IdleProviderCount;
        [FieldOffset(1296)]
        public IntPtr PendingDevicePowerIrp;
        [FieldOffset(1304)]
        public _LIST_ENTRY ExternalDependencies;
    }
}