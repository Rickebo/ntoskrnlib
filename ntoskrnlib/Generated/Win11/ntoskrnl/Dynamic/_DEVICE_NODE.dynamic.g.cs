using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_NODE")]
    public sealed class _DEVICE_NODE : DynamicStructure
    {
        public IntPtr Sibling { get; }
        public IntPtr Child { get; }
        public IntPtr Parent { get; }
        public IntPtr LastChild { get; }
        public IntPtr PhysicalDeviceObject { get; }
        public _UNICODE_STRING InstancePath { get; }
        public _UNICODE_STRING ServiceName { get; }
        public IntPtr PendingIrp { get; }
        public IntPtr FxDevice { get; }
        public int FxDeviceLock { get; }
        public _KEVENT FxRemoveEvent { get; }
        public int FxActivationCount { get; }
        public int FxSleepCount { get; }
        public _UNICODE_STRING UniqueId { get; }
        public IntPtr Plugin { get; }
        public uint Level { get; }
        public _POWER_STATE CurrentPowerState { get; }
        public _PO_DEVICE_NOTIFY Notify { get; }
        public _PO_IRP_MANAGER PoIrpManager { get; }
        public int PowerFlags { get; }
        public uint State { get; }
        public uint PreviousState { get; }
        public uint[] StateHistory { get; }
        public uint StateHistoryEntry { get; }
        public int CompletionStatus { get; }
        public uint Flags { get; }
        public uint UserFlags { get; }
        public uint Problem { get; }
        public int ProblemStatus { get; }
        public IntPtr ResourceList { get; }
        public IntPtr ResourceListTranslated { get; }
        public IntPtr DuplicatePDO { get; }
        public IntPtr ResourceRequirements { get; }
        public uint InterfaceType { get; }
        public uint BusNumber { get; }
        public uint ChildInterfaceType { get; }
        public uint ChildBusNumber { get; }
        public ushort ChildBusTypeIndex { get; }
        public byte RemovalPolicy { get; }
        public byte HardwareRemovalPolicy { get; }
        public _LIST_ENTRY TargetDeviceNotify { get; }
        public _LIST_ENTRY DeviceArbiterList { get; }
        public _LIST_ENTRY DeviceTranslatorList { get; }
        public ushort NoTranslatorMask { get; }
        public ushort QueryTranslatorMask { get; }
        public ushort NoArbiterMask { get; }
        public ushort QueryArbiterMask { get; }
        public _unnamed_tag_ OverUsed1 { get; }
        public _unnamed_tag_ OverUsed2 { get; }
        public IntPtr BootResources { get; }
        public IntPtr BootResourcesTranslated { get; }
        public uint CapabilityFlags { get; }
        public _unnamed_tag_ DockInfo { get; }
        public uint DisableableDepends { get; }
        public _LIST_ENTRY PendedSetInterfaceState { get; }
        public _LIST_ENTRY LegacyBusListEntry { get; }
        public uint DriverUnloadRetryCount { get; }
        public IntPtr PreviousParent { get; }
        public int DeletedChildren { get; }
        public uint NumaNodeIndex { get; }
        public _GUID ContainerID { get; }
        public byte OverrideFlags { get; }
        public uint DeviceIdsHash { get; }
        public byte RequiresUnloadedDriver { get; }
        public IntPtr PendingEjectRelations { get; }
        public uint StateFlags { get; }
        public IntPtr RebalanceContext { get; }
        public IntPtr IommuExtension { get; }
        public _PO_DIRECTED_DRIPS_STATE DirectedDripsState { get; }
        public byte[] ProblemCodeLog { get; }
        public uint ProblemCodeLogNextIndex { get; }
        public _LARGE_INTEGER StateTimestamp { get; }
        public _LARGE_INTEGER PreviousStateTimestamp { get; }

        public _DEVICE_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_NODE.Sibling),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.Child),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.Parent),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.LastChild),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PhysicalDeviceObject),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.InstancePath),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ServiceName),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PendingIrp),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.FxDevice),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.FxDeviceLock),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.FxRemoveEvent),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.FxActivationCount),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.FxSleepCount),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.UniqueId),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.Plugin),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.Level),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.CurrentPowerState),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.Notify),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PoIrpManager),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PowerFlags),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.State),
                    new ulong[]
                    {
                        300UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PreviousState),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.StateHistory),
                    new ulong[]
                    {
                        308UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.StateHistoryEntry),
                    new ulong[]
                    {
                        388UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.CompletionStatus),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.Flags),
                    new ulong[]
                    {
                        396UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.UserFlags),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.Problem),
                    new ulong[]
                    {
                        404UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ProblemStatus),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ResourceList),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ResourceListTranslated),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DuplicatePDO),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ResourceRequirements),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.InterfaceType),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.BusNumber),
                    new ulong[]
                    {
                        452UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ChildInterfaceType),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ChildBusNumber),
                    new ulong[]
                    {
                        460UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ChildBusTypeIndex),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.RemovalPolicy),
                    new ulong[]
                    {
                        466UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.HardwareRemovalPolicy),
                    new ulong[]
                    {
                        467UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.TargetDeviceNotify),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DeviceArbiterList),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DeviceTranslatorList),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.NoTranslatorMask),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.QueryTranslatorMask),
                    new ulong[]
                    {
                        522UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.NoArbiterMask),
                    new ulong[]
                    {
                        524UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.QueryArbiterMask),
                    new ulong[]
                    {
                        526UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.OverUsed1),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.OverUsed2),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.BootResources),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.BootResourcesTranslated),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.CapabilityFlags),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DockInfo),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DisableableDepends),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PendedSetInterfaceState),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.LegacyBusListEntry),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DriverUnloadRetryCount),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PreviousParent),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DeletedChildren),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.NumaNodeIndex),
                    new ulong[]
                    {
                        660UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ContainerID),
                    new ulong[]
                    {
                        664UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.OverrideFlags),
                    new ulong[]
                    {
                        680UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DeviceIdsHash),
                    new ulong[]
                    {
                        684UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.RequiresUnloadedDriver),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PendingEjectRelations),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.StateFlags),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.RebalanceContext),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.IommuExtension),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.DirectedDripsState),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ProblemCodeLog),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.ProblemCodeLogNextIndex),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.StateTimestamp),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_DEVICE_NODE.PreviousStateTimestamp),
                    new ulong[]
                    {
                        896UL
                    }
                }
            };
            Register<_DEVICE_NODE>((mem, ptr) => new _DEVICE_NODE(mem, ptr), offsets);
        }
    }
}