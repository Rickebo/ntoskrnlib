#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _KI_RESCHEDULE_CONTEXT_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Prcb;
        [FieldOffset(8)]
        public IntPtr SharedReadyQueue;
        [FieldOffset(16)]
        public IntPtr CompareThread;
        [FieldOffset(24)]
        public IntPtr NewThread;
        [FieldOffset(32)]
        public byte Idle;
        [FieldOffset(32)]
        public byte IsolationWidth;
        [FieldOffset(32)]
        public byte CanCheckDeferredPreemption;
        [FieldOffset(32)]
        public byte PartialYield;
        [FieldOffset(32)]
        public byte FullYield;
        [FieldOffset(32)]
        public byte IsolationPlaceholder;
        [FieldOffset(32)]
        public byte SpareCompateThreadStateFlags;
        [FieldOffset(32)]
        public byte AllCompareThreadStateFlags;
        [FieldOffset(33)]
        public byte ReadyTransition;
        [FieldOffset(33)]
        public byte SpareNewThreadStateFlags;
        [FieldOffset(33)]
        public byte AllNewThreadStateFlags;
        [FieldOffset(34)]
        public byte SkipStandbyReschedule;
        [FieldOffset(34)]
        public byte DoNotSetPreemptionBit;
        [FieldOffset(34)]
        public byte SpareCommitFlags;
        [FieldOffset(34)]
        public byte AllCommitFlags;
        [FieldOffset(35)]
        public byte NewThreadReferenced;
        [FieldOffset(35)]
        public byte LogEtw;
        [FieldOffset(35)]
        public byte IssuePriorityKick;
        [FieldOffset(35)]
        public byte DispatchInterruptIfHalted;
        [FieldOffset(35)]
        public byte DispatchInterruptAlways;
        [FieldOffset(35)]
        public byte SpareCompletionFlags;
        [FieldOffset(35)]
        public byte AllCompletionFlags;
        [FieldOffset(36)]
        public sbyte KickPriority;
        [FieldOffset(37)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Spare;
    }
}