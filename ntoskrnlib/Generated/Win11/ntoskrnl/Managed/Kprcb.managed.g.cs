using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPRCB")]
    public sealed class Kprcb : DynamicStructure
    {
        [Offset(0UL)]
        public uint MxCsr { get => ReadHere<uint>(nameof(MxCsr)); set => WriteHere(nameof(MxCsr), value); }

        [Offset(4UL)]
        public byte LegacyNumber { get => ReadHere<byte>(nameof(LegacyNumber)); set => WriteHere(nameof(LegacyNumber), value); }

        [Offset(5UL)]
        public byte ReservedMustBeZero { get => ReadHere<byte>(nameof(ReservedMustBeZero)); set => WriteHere(nameof(ReservedMustBeZero), value); }

        [Offset(6UL)]
        public byte InterruptRequest { get => ReadHere<byte>(nameof(InterruptRequest)); set => WriteHere(nameof(InterruptRequest), value); }

        [Offset(7UL)]
        public byte IdleHalt { get => ReadHere<byte>(nameof(IdleHalt)); set => WriteHere(nameof(IdleHalt), value); }

        [Offset(8UL)]
        public IntPtr CurrentThread { get => ReadHere<IntPtr>(nameof(CurrentThread)); set => WriteHere(nameof(CurrentThread), value); }

        [Offset(16UL)]
        public IntPtr NextThread { get => ReadHere<IntPtr>(nameof(NextThread)); set => WriteHere(nameof(NextThread), value); }

        [Offset(24UL)]
        public IntPtr IdleThread { get => ReadHere<IntPtr>(nameof(IdleThread)); set => WriteHere(nameof(IdleThread), value); }

        [Offset(32UL)]
        public byte NestingLevel { get => ReadHere<byte>(nameof(NestingLevel)); set => WriteHere(nameof(NestingLevel), value); }

        [Offset(33UL)]
        public byte ClockOwner { get => ReadHere<byte>(nameof(ClockOwner)); set => WriteHere(nameof(ClockOwner), value); }

        [Offset(34UL)]
        public byte PendingTickFlags { get => ReadHere<byte>(nameof(PendingTickFlags)); set => WriteHere(nameof(PendingTickFlags), value); }

        [Offset(34UL)]
        public byte PendingTick { get => ReadHere<byte>(nameof(PendingTick)); set => WriteHere(nameof(PendingTick), value); }

        [Offset(34UL)]
        public byte PendingBackupTick { get => ReadHere<byte>(nameof(PendingBackupTick)); set => WriteHere(nameof(PendingBackupTick), value); }

        [Offset(35UL)]
        public byte IdleState { get => ReadHere<byte>(nameof(IdleState)); set => WriteHere(nameof(IdleState), value); }

        [Offset(36UL)]
        public uint Number { get => ReadHere<uint>(nameof(Number)); set => WriteHere(nameof(Number), value); }

        [Offset(40UL)]
        public ulong RspBase { get => ReadHere<ulong>(nameof(RspBase)); set => WriteHere(nameof(RspBase), value); }

        [Offset(48UL)]
        public ulong PrcbLock { get => ReadHere<ulong>(nameof(PrcbLock)); set => WriteHere(nameof(PrcbLock), value); }

        [Offset(56UL)]
        public IntPtr PriorityState { get => ReadHere<IntPtr>(nameof(PriorityState)); set => WriteHere(nameof(PriorityState), value); }

        [Offset(64UL)]
        public sbyte CpuType { get => ReadHere<sbyte>(nameof(CpuType)); set => WriteHere(nameof(CpuType), value); }

        [Offset(65UL)]
        public sbyte CpuID { get => ReadHere<sbyte>(nameof(CpuID)); set => WriteHere(nameof(CpuID), value); }

        [Offset(66UL)]
        public ushort CpuStep { get => ReadHere<ushort>(nameof(CpuStep)); set => WriteHere(nameof(CpuStep), value); }

        [Offset(66UL)]
        public byte CpuStepping { get => ReadHere<byte>(nameof(CpuStepping)); set => WriteHere(nameof(CpuStepping), value); }

        [Offset(67UL)]
        public byte CpuModel { get => ReadHere<byte>(nameof(CpuModel)); set => WriteHere(nameof(CpuModel), value); }

        [Offset(68UL)]
        public uint MHz { get => ReadHere<uint>(nameof(MHz)); set => WriteHere(nameof(MHz), value); }

        [Offset(72UL)]
        [Length(8)]
        public DynamicArray HalReserved { get => ReadStructure<DynamicArray>(nameof(HalReserved)); set => WriteStructure(nameof(HalReserved), value); }

        [Offset(136UL)]
        public ushort MinorVersion { get => ReadHere<ushort>(nameof(MinorVersion)); set => WriteHere(nameof(MinorVersion), value); }

        [Offset(138UL)]
        public ushort MajorVersion { get => ReadHere<ushort>(nameof(MajorVersion)); set => WriteHere(nameof(MajorVersion), value); }

        [Offset(140UL)]
        public byte BuildType { get => ReadHere<byte>(nameof(BuildType)); set => WriteHere(nameof(BuildType), value); }

        [Offset(141UL)]
        public byte CpuVendor { get => ReadHere<byte>(nameof(CpuVendor)); set => WriteHere(nameof(CpuVendor), value); }

        [Offset(142UL)]
        public byte LegacyCoresPerPhysicalProcessor { get => ReadHere<byte>(nameof(LegacyCoresPerPhysicalProcessor)); set => WriteHere(nameof(LegacyCoresPerPhysicalProcessor), value); }

        [Offset(143UL)]
        public byte LegacyLogicalProcessorsPerCore { get => ReadHere<byte>(nameof(LegacyLogicalProcessorsPerCore)); set => WriteHere(nameof(LegacyLogicalProcessorsPerCore), value); }

        [Offset(144UL)]
        public ulong TscFrequency { get => ReadHere<ulong>(nameof(TscFrequency)); set => WriteHere(nameof(TscFrequency), value); }

        [Offset(152UL)]
        public IntPtr TracepointLog { get => ReadHere<IntPtr>(nameof(TracepointLog)); set => WriteHere(nameof(TracepointLog), value); }

        [Offset(160UL)]
        public uint CoresPerPhysicalProcessor { get => ReadHere<uint>(nameof(CoresPerPhysicalProcessor)); set => WriteHere(nameof(CoresPerPhysicalProcessor), value); }

        [Offset(164UL)]
        public uint LogicalProcessorsPerCore { get => ReadHere<uint>(nameof(LogicalProcessorsPerCore)); set => WriteHere(nameof(LogicalProcessorsPerCore), value); }

        [Offset(168UL)]
        public uint SelfIpiRequestSummary { get => ReadHere<uint>(nameof(SelfIpiRequestSummary)); set => WriteHere(nameof(SelfIpiRequestSummary), value); }

        [Offset(172UL)]
        public byte QpcToTscIncrementShift { get => ReadHere<byte>(nameof(QpcToTscIncrementShift)); set => WriteHere(nameof(QpcToTscIncrementShift), value); }

        [Offset(173UL)]
        [Length(3)]
        public DynamicArray PrcbPad03 { get => ReadStructure<DynamicArray>(nameof(PrcbPad03)); set => WriteStructure(nameof(PrcbPad03), value); }

        [Offset(176UL)]
        public ulong QpcToTscIncrement { get => ReadHere<ulong>(nameof(QpcToTscIncrement)); set => WriteHere(nameof(QpcToTscIncrement), value); }

        [Offset(184UL)]
        public ulong PrcbPad04 { get => ReadHere<ulong>(nameof(PrcbPad04)); set => WriteHere(nameof(PrcbPad04), value); }

        [Offset(192UL)]
        public IntPtr SchedulerSubNode { get => ReadHere<IntPtr>(nameof(SchedulerSubNode)); set => WriteHere(nameof(SchedulerSubNode), value); }

        [Offset(200UL)]
        public ulong GroupSetMember { get => ReadHere<ulong>(nameof(GroupSetMember)); set => WriteHere(nameof(GroupSetMember), value); }

        [Offset(208UL)]
        public byte Group { get => ReadHere<byte>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(209UL)]
        public byte GroupIndex { get => ReadHere<byte>(nameof(GroupIndex)); set => WriteHere(nameof(GroupIndex), value); }

        [Offset(210UL)]
        [Length(2)]
        public DynamicArray PrcbPad05 { get => ReadStructure<DynamicArray>(nameof(PrcbPad05)); set => WriteStructure(nameof(PrcbPad05), value); }

        [Offset(212UL)]
        public uint InitialApicId { get => ReadHere<uint>(nameof(InitialApicId)); set => WriteHere(nameof(InitialApicId), value); }

        [Offset(216UL)]
        public uint ScbOffset { get => ReadHere<uint>(nameof(ScbOffset)); set => WriteHere(nameof(ScbOffset), value); }

        [Offset(220UL)]
        public uint ApicMask { get => ReadHere<uint>(nameof(ApicMask)); set => WriteHere(nameof(ApicMask), value); }

        [Offset(224UL)]
        public IntPtr AcpiReserved { get => ReadHere<IntPtr>(nameof(AcpiReserved)); set => WriteHere(nameof(AcpiReserved), value); }

        [Offset(232UL)]
        public uint CFlushSize { get => ReadHere<uint>(nameof(CFlushSize)); set => WriteHere(nameof(CFlushSize), value); }

        [Offset(236UL)]
        public uint PrcbFlagsReserved { get => ReadHere<uint>(nameof(PrcbFlagsReserved)); set => WriteHere(nameof(PrcbFlagsReserved), value); }

        [Offset(240UL)]
        [Length(2)]
        public DynamicArray PrcbPad11 { get => ReadStructure<DynamicArray>(nameof(PrcbPad11)); set => WriteStructure(nameof(PrcbPad11), value); }

        [Offset(256UL)]
        public KprocessorState ProcessorState { get => ReadStructure<KprocessorState>(nameof(ProcessorState)); set => WriteStructure(nameof(ProcessorState), value); }

        [Offset(1728UL)]
        public IntPtr ExtendedSupervisorState { get => ReadHere<IntPtr>(nameof(ExtendedSupervisorState)); set => WriteHere(nameof(ExtendedSupervisorState), value); }

        [Offset(1736UL)]
        public uint ProcessorSignature { get => ReadHere<uint>(nameof(ProcessorSignature)); set => WriteHere(nameof(ProcessorSignature), value); }

        [Offset(1740UL)]
        public uint ProcessorFlags { get => ReadHere<uint>(nameof(ProcessorFlags)); set => WriteHere(nameof(ProcessorFlags), value); }

        [Offset(1744UL)]
        [Length(4)]
        public DynamicArray PrcbPad12a { get => ReadStructure<DynamicArray>(nameof(PrcbPad12a)); set => WriteStructure(nameof(PrcbPad12a), value); }

        public Kprcb(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kprcb>();
        }
    }
}