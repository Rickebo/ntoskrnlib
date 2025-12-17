#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 472)]
    public partial struct _POP_FX_COMPONENT
    {
        [FieldOffset(0)]
        public _GUID Id;
        [FieldOffset(16)]
        public uint Index;
        [FieldOffset(24)]
        public _POP_FX_WORK_ORDER WorkOrder;
        [FieldOffset(80)]
        public IntPtr Device;
        [FieldOffset(88)]
        public _POP_FX_COMPONENT_FLAGS Flags;
        [FieldOffset(96)]
        public int Resident;
        [FieldOffset(104)]
        public _KEVENT ActiveEvent;
        [FieldOffset(128)]
        public ulong IdleLock;
        [FieldOffset(136)]
        public int IdleConditionComplete;
        [FieldOffset(140)]
        public int IdleStateComplete;
        [FieldOffset(144)]
        public ulong IdleStamp;
        [FieldOffset(152)]
        public uint CurrentIdleState;
        [FieldOffset(156)]
        public uint IdleStateCount;
        [FieldOffset(160)]
        public IntPtr IdleStates;
        [FieldOffset(168)]
        public uint DeepestWakeableIdleState;
        [FieldOffset(172)]
        public uint ProviderCount;
        [FieldOffset(176)]
        public IntPtr Providers;
        [FieldOffset(184)]
        public uint IdleProviderCount;
        [FieldOffset(188)]
        public uint DependentCount;
        [FieldOffset(192)]
        public IntPtr Dependents;
        [FieldOffset(200)]
        public _POP_FX_ACCOUNTING Accounting;
        [FieldOffset(424)]
        public IntPtr Performance;
        [FieldOffset(432)]
        public IntPtr PowerProfile;
        [FieldOffset(440)]
        public _LIST_ENTRY ExternalDependents;
        [FieldOffset(456)]
        public _LIST_ENTRY ExternalDependencies;
    }
}