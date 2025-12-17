#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1792)]
    public partial struct _KPRCB
    {
        [FieldOffset(0)]
        public uint MxCsr;
        [FieldOffset(4)]
        public byte LegacyNumber;
        [FieldOffset(5)]
        public byte ReservedMustBeZero;
        [FieldOffset(6)]
        public byte InterruptRequest;
        [FieldOffset(7)]
        public byte IdleHalt;
        [FieldOffset(8)]
        public IntPtr CurrentThread;
        [FieldOffset(16)]
        public IntPtr NextThread;
        [FieldOffset(24)]
        public IntPtr IdleThread;
        [FieldOffset(32)]
        public byte NestingLevel;
        [FieldOffset(33)]
        public byte ClockOwner;
        [FieldOffset(34)]
        public byte PendingTickFlags;
        [FieldOffset(34)]
        public byte PendingTick;
        [FieldOffset(34)]
        public byte PendingBackupTick;
        [FieldOffset(35)]
        public byte IdleState;
        [FieldOffset(36)]
        public uint Number;
        [FieldOffset(40)]
        public ulong RspBase;
        [FieldOffset(48)]
        public ulong PrcbLock;
        [FieldOffset(56)]
        public IntPtr PriorityState;
        [FieldOffset(64)]
        public sbyte CpuType;
        [FieldOffset(65)]
        public sbyte CpuID;
        [FieldOffset(66)]
        public ushort CpuStep;
        [FieldOffset(66)]
        public byte CpuStepping;
        [FieldOffset(67)]
        public byte CpuModel;
        [FieldOffset(68)]
        public uint MHz;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] HalReserved;
        [FieldOffset(136)]
        public ushort MinorVersion;
        [FieldOffset(138)]
        public ushort MajorVersion;
        [FieldOffset(140)]
        public byte BuildType;
        [FieldOffset(141)]
        public byte CpuVendor;
        [FieldOffset(142)]
        public byte LegacyCoresPerPhysicalProcessor;
        [FieldOffset(143)]
        public byte LegacyLogicalProcessorsPerCore;
        [FieldOffset(144)]
        public ulong TscFrequency;
        [FieldOffset(152)]
        public IntPtr TracepointLog;
        [FieldOffset(160)]
        public uint CoresPerPhysicalProcessor;
        [FieldOffset(164)]
        public uint LogicalProcessorsPerCore;
        [FieldOffset(168)]
        public uint SelfIpiRequestSummary;
        [FieldOffset(172)]
        public byte QpcToTscIncrementShift;
        [FieldOffset(173)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] PrcbPad03;
        [FieldOffset(176)]
        public ulong QpcToTscIncrement;
        [FieldOffset(184)]
        public ulong PrcbPad04;
        [FieldOffset(192)]
        public IntPtr SchedulerSubNode;
        [FieldOffset(200)]
        public ulong GroupSetMember;
        [FieldOffset(208)]
        public byte Group;
        [FieldOffset(209)]
        public byte GroupIndex;
        [FieldOffset(210)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PrcbPad05;
        [FieldOffset(212)]
        public uint InitialApicId;
        [FieldOffset(216)]
        public uint ScbOffset;
        [FieldOffset(220)]
        public uint ApicMask;
        [FieldOffset(224)]
        public IntPtr AcpiReserved;
        [FieldOffset(232)]
        public uint CFlushSize;
        [FieldOffset(236)]
        public uint PrcbFlagsReserved;
        [FieldOffset(240)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] PrcbPad11;
        [FieldOffset(256)]
        public _KPROCESSOR_STATE ProcessorState;
        [FieldOffset(1728)]
        public IntPtr ExtendedSupervisorState;
        [FieldOffset(1736)]
        public uint ProcessorSignature;
        [FieldOffset(1740)]
        public uint ProcessorFlags;
        [FieldOffset(1744)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] PrcbPad12a;
    }
}