#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _EXT_IOMMU_CAPABILITIES
    {
        [FieldOffset(0)]
        public ulong AsUINT64;
        [FieldOffset(0)]
        public ulong GeneratesMsiInterrupts;
        [FieldOffset(0)]
        public ulong CoherentTableWalks;
        [FieldOffset(0)]
        public ulong InterruptsNotSubjectToRemapping;
        [FieldOffset(0)]
        public ulong InterruptRemapping;
        [FieldOffset(0)]
        public ulong Stage2DmaRemapping;
        [FieldOffset(0)]
        public ulong Svm;
        [FieldOffset(0)]
        public ulong PcieFunctionBased;
    }
}