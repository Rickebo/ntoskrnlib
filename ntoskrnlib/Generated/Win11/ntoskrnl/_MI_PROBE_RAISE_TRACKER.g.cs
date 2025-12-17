#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_PROBE_RAISE_TRACKER
    {
        [FieldOffset(0)]
        public uint UserRangeInKernel;
        [FieldOffset(4)]
        public uint FaultFailed;
        [FieldOffset(8)]
        public uint WriteFaultFailed;
        [FieldOffset(12)]
        public uint LargePageFailed;
        [FieldOffset(16)]
        public uint UserAccessToKernelPte;
        [FieldOffset(20)]
        public uint BadPageLocation;
        [FieldOffset(24)]
        public uint InsufficientCharge;
        [FieldOffset(28)]
        public uint PageTableCharge;
        [FieldOffset(32)]
        public uint NoIoReference;
        [FieldOffset(36)]
        public uint ProbeFailed;
        [FieldOffset(40)]
        public uint PteIsZero;
        [FieldOffset(44)]
        public uint StrongCodeWrite;
        [FieldOffset(48)]
        public uint ReducedCloneCommitChargeFailed;
        [FieldOffset(52)]
        public uint CopyOnWriteAtDispatchNoPages;
        [FieldOffset(56)]
        public uint NoPageTablesAllowed;
        [FieldOffset(60)]
        public uint EnclavePageFailed;
    }
}