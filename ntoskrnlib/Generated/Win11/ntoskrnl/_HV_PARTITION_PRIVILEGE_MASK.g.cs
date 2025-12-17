#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HV_PARTITION_PRIVILEGE_MASK
    {
        [FieldOffset(0)]
        public ulong AsUINT64;
        [FieldOffset(0)]
        public ulong AccessVpRunTimeReg;
        [FieldOffset(0)]
        public ulong AccessPartitionReferenceCounter;
        [FieldOffset(0)]
        public ulong AccessSynicRegs;
        [FieldOffset(0)]
        public ulong AccessSyntheticTimerRegs;
        [FieldOffset(0)]
        public ulong AccessIntrCtrlRegs;
        [FieldOffset(0)]
        public ulong AccessHypercallMsrs;
        [FieldOffset(0)]
        public ulong AccessVpIndex;
        [FieldOffset(0)]
        public ulong AccessResetReg;
        [FieldOffset(0)]
        public ulong AccessStatsReg;
        [FieldOffset(0)]
        public ulong AccessPartitionReferenceTsc;
        [FieldOffset(0)]
        public ulong AccessGuestIdleReg;
        [FieldOffset(0)]
        public ulong AccessFrequencyRegs;
        [FieldOffset(0)]
        public ulong AccessDebugRegs;
        [FieldOffset(0)]
        public ulong AccessReenlightenmentControls;
        [FieldOffset(0)]
        public ulong AccessRootSchedulerReg;
        [FieldOffset(0)]
        public ulong AccessTscInvariantControls;
        [FieldOffset(0)]
        public ulong Reserved1;
        [FieldOffset(0)]
        public ulong CreatePartitions;
        [FieldOffset(0)]
        public ulong AccessPartitionId;
        [FieldOffset(0)]
        public ulong AccessMemoryPool;
        [FieldOffset(0)]
        public ulong AdjustMessageBuffers;
        [FieldOffset(0)]
        public ulong PostMessages;
        [FieldOffset(0)]
        public ulong SignalEvents;
        [FieldOffset(0)]
        public ulong CreatePort;
        [FieldOffset(0)]
        public ulong ConnectPort;
        [FieldOffset(0)]
        public ulong AccessStats;
        [FieldOffset(0)]
        public ulong Reserved2;
        [FieldOffset(0)]
        public ulong Debugging;
        [FieldOffset(0)]
        public ulong CpuManagement;
        [FieldOffset(0)]
        public ulong ConfigureProfiler;
        [FieldOffset(0)]
        public ulong AccessVpExitTracing;
        [FieldOffset(0)]
        public ulong EnableExtendedGvaRangesForFlushVirtualAddressList;
        [FieldOffset(0)]
        public ulong AccessVsm;
        [FieldOffset(0)]
        public ulong AccessVpRegisters;
        [FieldOffset(0)]
        public ulong UnusedBit;
        [FieldOffset(0)]
        public ulong FastHypercallOutput;
        [FieldOffset(0)]
        public ulong EnableExtendedHypercalls;
        [FieldOffset(0)]
        public ulong StartVirtualProcessor;
        [FieldOffset(0)]
        public ulong Isolation;
        [FieldOffset(0)]
        public ulong Reserved3;
    }
}