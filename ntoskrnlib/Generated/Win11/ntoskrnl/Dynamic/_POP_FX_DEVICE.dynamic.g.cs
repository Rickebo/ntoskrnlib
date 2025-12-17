using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_DEVICE")]
    public sealed class _POP_FX_DEVICE : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public IntPtr Irp { get; }
        public IntPtr IrpData { get; }
        public _POP_FX_DEVICE_STATUS Status { get; }
        public int PowerReqCall { get; }
        public int PowerNotReqCall { get; }
        public IntPtr DevNode { get; }
        public IntPtr DpmContext { get; }
        public IntPtr Plugin { get; }
        public IntPtr PluginHandle { get; }
        public IntPtr AcpiPlugin { get; }
        public IntPtr AcpiPluginHandle { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr TargetDevice { get; }
        public _POP_FX_DRIVER_CALLBACKS Callbacks { get; }
        public IntPtr DriverContext { get; }
        public _LIST_ENTRY AcpiLink { get; }
        public _UNICODE_STRING DeviceId { get; }
        public int CommonReferenceFlags { get; }
        public _IO_REMOVE_LOCK RemoveLock { get; }
        public int[] RemoveLockReferenceCount { get; }
        public _IO_REMOVE_LOCK AcpiRemoveLock { get; }
        public _POP_FX_WORK_ORDER WorkOrder { get; }
        public ulong IdleLock { get; }
        public _KTIMER IdleTimer { get; }
        public _KDPC IdleDpc { get; }
        public ulong IdleTimeout { get; }
        public ulong IdleStamp { get; }
        public byte[] NextIrpDeviceObject { get; }
        public byte[] NextIrpPowerState { get; }
        public byte[] NextIrpCallerCompletion { get; }
        public byte[] NextIrpCallerContext { get; }
        public _KEVENT IrpCompleteEvent { get; }
        public IntPtr PowerOnDumpDeviceCallback { get; }
        public _POP_FX_ACCOUNTING Accounting { get; }
        public uint Flags { get; }
        public uint ComponentCount { get; }
        public IntPtr Components { get; }
        public uint LogEntries { get; }
        public IntPtr Log { get; }
        public int LogIndex { get; }
        public IntPtr DripsWatchdogDriverObject { get; }
        public _POP_FX_DRIPS_WATCHDOG_CONTEXT DripsWatchdogContext { get; }
        public uint ChildDeviceComponentIndex { get; }
        public uint DirectedTimeout { get; }
        public _POP_FX_WORK_ORDER DirectedWorkOrder { get; }
        public _POP_FX_WORK_ORDER_WATCHDOG_INFO DirectedWorkWatchdogInfo { get; }
        public ulong DirectedLock { get; }
        public int DirectedTransitionCallCount { get; }
        public _POP_FX_DEVICE_DIRECTED_TRANSITION_STATE DirectedTransitionState { get; }
        public IntPtr PowerProfile { get; }
        public _UNICODE_STRING FriendlyName { get; }
        public _WORK_QUEUE_ITEM ReportDevicePoweredOnPassiveWorkItem { get; }
        public ulong RelationsLock { get; }
        public uint IdleProviderCount { get; }
        public IntPtr PendingDevicePowerIrp { get; }
        public _LIST_ENTRY ExternalDependencies { get; }

        public _POP_FX_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_DEVICE.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.Irp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.IrpData),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.Status),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.PowerReqCall),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.PowerNotReqCall),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DevNode),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DpmContext),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.Plugin),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.PluginHandle),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.AcpiPlugin),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.AcpiPluginHandle),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DeviceObject),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.TargetDevice),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.Callbacks),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DriverContext),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.AcpiLink),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DeviceId),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.CommonReferenceFlags),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.RemoveLock),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.RemoveLockReferenceCount),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.AcpiRemoveLock),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.WorkOrder),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.IdleLock),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.IdleTimer),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.IdleDpc),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.IdleTimeout),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.IdleStamp),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.NextIrpDeviceObject),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.NextIrpPowerState),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.NextIrpCallerCompletion),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.NextIrpCallerContext),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.IrpCompleteEvent),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.PowerOnDumpDeviceCallback),
                    new ulong[]
                    {
                        632UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.Accounting),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.Flags),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.ComponentCount),
                    new ulong[]
                    {
                        868UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.Components),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.LogEntries),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.Log),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.LogIndex),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DripsWatchdogDriverObject),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DripsWatchdogContext),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.ChildDeviceComponentIndex),
                    new ulong[]
                    {
                        952UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DirectedTimeout),
                    new ulong[]
                    {
                        956UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DirectedWorkOrder),
                    new ulong[]
                    {
                        960UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DirectedWorkWatchdogInfo),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DirectedLock),
                    new ulong[]
                    {
                        1192UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DirectedTransitionCallCount),
                    new ulong[]
                    {
                        1200UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.DirectedTransitionState),
                    new ulong[]
                    {
                        1208UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.PowerProfile),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.FriendlyName),
                    new ulong[]
                    {
                        1232UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.ReportDevicePoweredOnPassiveWorkItem),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.RelationsLock),
                    new ulong[]
                    {
                        1280UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.IdleProviderCount),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.PendingDevicePowerIrp),
                    new ulong[]
                    {
                        1296UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE.ExternalDependencies),
                    new ulong[]
                    {
                        1304UL
                    }
                }
            };
            Register<_POP_FX_DEVICE>((mem, ptr) => new _POP_FX_DEVICE(mem, ptr), offsets);
        }
    }
}