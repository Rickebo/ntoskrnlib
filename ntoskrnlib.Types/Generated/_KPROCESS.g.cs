using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=456)]
public struct _KPROCESS
{
    [FieldOffset(0)]
    public _DISPATCHER_HEADER Header;
    [FieldOffset(24)]
    public _LIST_ENTRY ProfileListHead;
    [FieldOffset(40)]
    public ulong DirectoryTableBase;
    [FieldOffset(48)]
    public _LIST_ENTRY ThreadListHead;
    [FieldOffset(64)]
    public uint ProcessLock;
    [FieldOffset(68)]
    public uint ProcessTimerDelay;
    [FieldOffset(72)]
    public ulong DeepFreezeStartTime;
    [FieldOffset(80)]
    public IntPtr Affinity;
    [FieldOffset(88)]
    public _KAB_UM_PROCESS_CONTEXT AutoBoostState;
    [FieldOffset(104)]
    public _LIST_ENTRY ReadyListHead;
    [FieldOffset(120)]
    public _SINGLE_LIST_ENTRY SwapListEntry;
    [FieldOffset(128)]
    public IntPtr ActiveProcessors;
    [FieldOffset(136)]
    public int ProcessFlags;
    [FieldOffset(140)]
    public uint Spare0c;
    [FieldOffset(144)]
    public sbyte BasePriority;
    [FieldOffset(145)]
    public sbyte QuantumReset;
    [FieldOffset(146)]
    public sbyte Visited;
    [FieldOffset(147)]
    public _KEXECUTE_OPTIONS Flags;
    [FieldOffset(152)]
    public _KGROUP_MASK ActiveGroupsMask;
    [FieldOffset(168)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public ulong[] ActiveGroupPadding;
    [FieldOffset(184)]
    public IntPtr IdealProcessorAssignmentBlock;
    [FieldOffset(192)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
    public ulong[] Padding;
    [FieldOffset(240)]
    public uint Padding2;
    [FieldOffset(244)]
    public uint SchedulerAssistYieldBoostCount;
    [FieldOffset(248)]
    public long SchedulerAssistYieldBoostAllowedTime;
    [FieldOffset(256)]
    public uint Spare0d;
    [FieldOffset(260)]
    public ushort IdealGlobalNode;
    [FieldOffset(262)]
    public ushort Spare1;
    [FieldOffset(264)]
    public _KSTACK_COUNT StackCount;
    [FieldOffset(272)]
    public _LIST_ENTRY ProcessListEntry;
    [FieldOffset(288)]
    public ulong CycleTime;
    [FieldOffset(296)]
    public ulong ContextSwitches;
    [FieldOffset(304)]
    public IntPtr SchedulingGroup;
    [FieldOffset(312)]
    public ulong KernelTime;
    [FieldOffset(320)]
    public ulong UserTime;
    [FieldOffset(328)]
    public ulong ReadyTime;
    [FieldOffset(336)]
    public uint FreezeCount;
    [FieldOffset(340)]
    public uint Spare4;
    [FieldOffset(344)]
    public ulong UserDirectoryTableBase;
    [FieldOffset(352)]
    public byte AddressPolicy;
    [FieldOffset(353)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public byte[] Spare2;
    [FieldOffset(360)]
    public IntPtr InstrumentationCallback;
    [FieldOffset(368)]
    public _unnamed_tag_ SecureState;
    [FieldOffset(376)]
    public ulong KernelWaitTime;
    [FieldOffset(384)]
    public ulong UserWaitTime;
    [FieldOffset(392)]
    public ulong LastRebalanceQpc;
    [FieldOffset(400)]
    public IntPtr PerProcessorCycleTimes;
    [FieldOffset(408)]
    public ulong ExtendedFeatureDisableMask;
    [FieldOffset(416)]
    public ushort PrimaryGroup;
    [FieldOffset(418)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public ushort[] Spare3;
    [FieldOffset(424)]
    public IntPtr UserCetLogging;
    [FieldOffset(432)]
    public _LIST_ENTRY CpuPartitionList;
    [FieldOffset(448)]
    public IntPtr AvailableCpuState;
}
