#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public partial struct _TPP_CLEANUP_GROUP_MEMBER
    {
        [FieldOffset(0)]
        public _TPP_REFCOUNT Refcount;
        [FieldOffset(8)]
        public IntPtr VFuncs;
        [FieldOffset(16)]
        public IntPtr CleanupGroup;
        [FieldOffset(24)]
        public IntPtr CleanupGroupCancelCallback;
        [FieldOffset(32)]
        public IntPtr FinalizationCallback;
        [FieldOffset(40)]
        public _LIST_ENTRY CleanupGroupMemberLinks;
        [FieldOffset(56)]
        public _TPP_BARRIER CallbackBarrier;
        [FieldOffset(80)]
        public IntPtr Callback;
        [FieldOffset(80)]
        public IntPtr WorkCallback;
        [FieldOffset(80)]
        public IntPtr SimpleCallback;
        [FieldOffset(80)]
        public IntPtr TimerCallback;
        [FieldOffset(80)]
        public IntPtr WaitCallback;
        [FieldOffset(80)]
        public IntPtr IoCallback;
        [FieldOffset(80)]
        public IntPtr AlpcCallback;
        [FieldOffset(80)]
        public IntPtr AlpcCallbackEx;
        [FieldOffset(80)]
        public IntPtr JobCallback;
        [FieldOffset(88)]
        public IntPtr Context;
        [FieldOffset(96)]
        public IntPtr ActivationContext;
        [FieldOffset(104)]
        public IntPtr SubProcessTag;
        [FieldOffset(112)]
        public _GUID ActivityId;
        [FieldOffset(128)]
        public _ALPC_WORK_ON_BEHALF_TICKET WorkOnBehalfTicket;
        [FieldOffset(136)]
        public IntPtr RaceDll;
        [FieldOffset(144)]
        public IntPtr Pool;
        [FieldOffset(152)]
        public _LIST_ENTRY PoolObjectLinks;
        [FieldOffset(168)]
        public int Flags;
        [FieldOffset(168)]
        public uint LongFunction;
        [FieldOffset(168)]
        public uint Persistent;
        [FieldOffset(168)]
        public uint UnusedPublic;
        [FieldOffset(168)]
        public uint Released;
        [FieldOffset(168)]
        public uint CleanupGroupReleased;
        [FieldOffset(168)]
        public uint InCleanupGroupCleanupList;
        [FieldOffset(168)]
        public uint UnusedPrivate;
        [FieldOffset(176)]
        public _TPP_CALLER AllocCaller;
        [FieldOffset(184)]
        public _TPP_CALLER ReleaseCaller;
        [FieldOffset(192)]
        public uint CallbackPriority;
    }
}