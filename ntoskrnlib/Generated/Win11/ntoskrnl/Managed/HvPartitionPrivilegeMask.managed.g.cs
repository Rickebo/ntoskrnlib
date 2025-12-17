using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HV_PARTITION_PRIVILEGE_MASK")]
    public sealed class HvPartitionPrivilegeMask : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AsUINT64 { get => ReadHere<ulong>(nameof(AsUINT64)); set => WriteHere(nameof(AsUINT64), value); }

        [Offset(0UL)]
        public ulong AccessVpRunTimeReg { get => ReadHere<ulong>(nameof(AccessVpRunTimeReg)); set => WriteHere(nameof(AccessVpRunTimeReg), value); }

        [Offset(0UL)]
        public ulong AccessPartitionReferenceCounter { get => ReadHere<ulong>(nameof(AccessPartitionReferenceCounter)); set => WriteHere(nameof(AccessPartitionReferenceCounter), value); }

        [Offset(0UL)]
        public ulong AccessSynicRegs { get => ReadHere<ulong>(nameof(AccessSynicRegs)); set => WriteHere(nameof(AccessSynicRegs), value); }

        [Offset(0UL)]
        public ulong AccessSyntheticTimerRegs { get => ReadHere<ulong>(nameof(AccessSyntheticTimerRegs)); set => WriteHere(nameof(AccessSyntheticTimerRegs), value); }

        [Offset(0UL)]
        public ulong AccessIntrCtrlRegs { get => ReadHere<ulong>(nameof(AccessIntrCtrlRegs)); set => WriteHere(nameof(AccessIntrCtrlRegs), value); }

        [Offset(0UL)]
        public ulong AccessHypercallMsrs { get => ReadHere<ulong>(nameof(AccessHypercallMsrs)); set => WriteHere(nameof(AccessHypercallMsrs), value); }

        [Offset(0UL)]
        public ulong AccessVpIndex { get => ReadHere<ulong>(nameof(AccessVpIndex)); set => WriteHere(nameof(AccessVpIndex), value); }

        [Offset(0UL)]
        public ulong AccessResetReg { get => ReadHere<ulong>(nameof(AccessResetReg)); set => WriteHere(nameof(AccessResetReg), value); }

        [Offset(0UL)]
        public ulong AccessStatsReg { get => ReadHere<ulong>(nameof(AccessStatsReg)); set => WriteHere(nameof(AccessStatsReg), value); }

        [Offset(0UL)]
        public ulong AccessPartitionReferenceTsc { get => ReadHere<ulong>(nameof(AccessPartitionReferenceTsc)); set => WriteHere(nameof(AccessPartitionReferenceTsc), value); }

        [Offset(0UL)]
        public ulong AccessGuestIdleReg { get => ReadHere<ulong>(nameof(AccessGuestIdleReg)); set => WriteHere(nameof(AccessGuestIdleReg), value); }

        [Offset(0UL)]
        public ulong AccessFrequencyRegs { get => ReadHere<ulong>(nameof(AccessFrequencyRegs)); set => WriteHere(nameof(AccessFrequencyRegs), value); }

        [Offset(0UL)]
        public ulong AccessDebugRegs { get => ReadHere<ulong>(nameof(AccessDebugRegs)); set => WriteHere(nameof(AccessDebugRegs), value); }

        [Offset(0UL)]
        public ulong AccessReenlightenmentControls { get => ReadHere<ulong>(nameof(AccessReenlightenmentControls)); set => WriteHere(nameof(AccessReenlightenmentControls), value); }

        [Offset(0UL)]
        public ulong AccessRootSchedulerReg { get => ReadHere<ulong>(nameof(AccessRootSchedulerReg)); set => WriteHere(nameof(AccessRootSchedulerReg), value); }

        [Offset(0UL)]
        public ulong AccessTscInvariantControls { get => ReadHere<ulong>(nameof(AccessTscInvariantControls)); set => WriteHere(nameof(AccessTscInvariantControls), value); }

        [Offset(0UL)]
        public ulong Reserved1 { get => ReadHere<ulong>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(0UL)]
        public ulong CreatePartitions { get => ReadHere<ulong>(nameof(CreatePartitions)); set => WriteHere(nameof(CreatePartitions), value); }

        [Offset(0UL)]
        public ulong AccessPartitionId { get => ReadHere<ulong>(nameof(AccessPartitionId)); set => WriteHere(nameof(AccessPartitionId), value); }

        [Offset(0UL)]
        public ulong AccessMemoryPool { get => ReadHere<ulong>(nameof(AccessMemoryPool)); set => WriteHere(nameof(AccessMemoryPool), value); }

        [Offset(0UL)]
        public ulong AdjustMessageBuffers { get => ReadHere<ulong>(nameof(AdjustMessageBuffers)); set => WriteHere(nameof(AdjustMessageBuffers), value); }

        [Offset(0UL)]
        public ulong PostMessages { get => ReadHere<ulong>(nameof(PostMessages)); set => WriteHere(nameof(PostMessages), value); }

        [Offset(0UL)]
        public ulong SignalEvents { get => ReadHere<ulong>(nameof(SignalEvents)); set => WriteHere(nameof(SignalEvents), value); }

        [Offset(0UL)]
        public ulong CreatePort { get => ReadHere<ulong>(nameof(CreatePort)); set => WriteHere(nameof(CreatePort), value); }

        [Offset(0UL)]
        public ulong ConnectPort { get => ReadHere<ulong>(nameof(ConnectPort)); set => WriteHere(nameof(ConnectPort), value); }

        [Offset(0UL)]
        public ulong AccessStats { get => ReadHere<ulong>(nameof(AccessStats)); set => WriteHere(nameof(AccessStats), value); }

        [Offset(0UL)]
        public ulong Reserved2 { get => ReadHere<ulong>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(0UL)]
        public ulong Debugging { get => ReadHere<ulong>(nameof(Debugging)); set => WriteHere(nameof(Debugging), value); }

        [Offset(0UL)]
        public ulong CpuManagement { get => ReadHere<ulong>(nameof(CpuManagement)); set => WriteHere(nameof(CpuManagement), value); }

        [Offset(0UL)]
        public ulong ConfigureProfiler { get => ReadHere<ulong>(nameof(ConfigureProfiler)); set => WriteHere(nameof(ConfigureProfiler), value); }

        [Offset(0UL)]
        public ulong AccessVpExitTracing { get => ReadHere<ulong>(nameof(AccessVpExitTracing)); set => WriteHere(nameof(AccessVpExitTracing), value); }

        [Offset(0UL)]
        public ulong EnableExtendedGvaRangesForFlushVirtualAddressList { get => ReadHere<ulong>(nameof(EnableExtendedGvaRangesForFlushVirtualAddressList)); set => WriteHere(nameof(EnableExtendedGvaRangesForFlushVirtualAddressList), value); }

        [Offset(0UL)]
        public ulong AccessVsm { get => ReadHere<ulong>(nameof(AccessVsm)); set => WriteHere(nameof(AccessVsm), value); }

        [Offset(0UL)]
        public ulong AccessVpRegisters { get => ReadHere<ulong>(nameof(AccessVpRegisters)); set => WriteHere(nameof(AccessVpRegisters), value); }

        [Offset(0UL)]
        public ulong UnusedBit { get => ReadHere<ulong>(nameof(UnusedBit)); set => WriteHere(nameof(UnusedBit), value); }

        [Offset(0UL)]
        public ulong FastHypercallOutput { get => ReadHere<ulong>(nameof(FastHypercallOutput)); set => WriteHere(nameof(FastHypercallOutput), value); }

        [Offset(0UL)]
        public ulong EnableExtendedHypercalls { get => ReadHere<ulong>(nameof(EnableExtendedHypercalls)); set => WriteHere(nameof(EnableExtendedHypercalls), value); }

        [Offset(0UL)]
        public ulong StartVirtualProcessor { get => ReadHere<ulong>(nameof(StartVirtualProcessor)); set => WriteHere(nameof(StartVirtualProcessor), value); }

        [Offset(0UL)]
        public ulong Isolation { get => ReadHere<ulong>(nameof(Isolation)); set => WriteHere(nameof(Isolation), value); }

        [Offset(0UL)]
        public ulong Reserved3 { get => ReadHere<ulong>(nameof(Reserved3)); set => WriteHere(nameof(Reserved3), value); }

        public HvPartitionPrivilegeMask(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HvPartitionPrivilegeMask>();
        }
    }
}