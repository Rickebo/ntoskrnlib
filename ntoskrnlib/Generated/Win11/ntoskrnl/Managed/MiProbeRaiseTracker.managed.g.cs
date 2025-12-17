using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PROBE_RAISE_TRACKER")]
    public sealed class MiProbeRaiseTracker : DynamicStructure
    {
        [Offset(0UL)]
        public uint UserRangeInKernel { get => ReadHere<uint>(nameof(UserRangeInKernel)); set => WriteHere(nameof(UserRangeInKernel), value); }

        [Offset(4UL)]
        public uint FaultFailed { get => ReadHere<uint>(nameof(FaultFailed)); set => WriteHere(nameof(FaultFailed), value); }

        [Offset(8UL)]
        public uint WriteFaultFailed { get => ReadHere<uint>(nameof(WriteFaultFailed)); set => WriteHere(nameof(WriteFaultFailed), value); }

        [Offset(12UL)]
        public uint LargePageFailed { get => ReadHere<uint>(nameof(LargePageFailed)); set => WriteHere(nameof(LargePageFailed), value); }

        [Offset(16UL)]
        public uint UserAccessToKernelPte { get => ReadHere<uint>(nameof(UserAccessToKernelPte)); set => WriteHere(nameof(UserAccessToKernelPte), value); }

        [Offset(20UL)]
        public uint BadPageLocation { get => ReadHere<uint>(nameof(BadPageLocation)); set => WriteHere(nameof(BadPageLocation), value); }

        [Offset(24UL)]
        public uint InsufficientCharge { get => ReadHere<uint>(nameof(InsufficientCharge)); set => WriteHere(nameof(InsufficientCharge), value); }

        [Offset(28UL)]
        public uint PageTableCharge { get => ReadHere<uint>(nameof(PageTableCharge)); set => WriteHere(nameof(PageTableCharge), value); }

        [Offset(32UL)]
        public uint NoIoReference { get => ReadHere<uint>(nameof(NoIoReference)); set => WriteHere(nameof(NoIoReference), value); }

        [Offset(36UL)]
        public uint ProbeFailed { get => ReadHere<uint>(nameof(ProbeFailed)); set => WriteHere(nameof(ProbeFailed), value); }

        [Offset(40UL)]
        public uint PteIsZero { get => ReadHere<uint>(nameof(PteIsZero)); set => WriteHere(nameof(PteIsZero), value); }

        [Offset(44UL)]
        public uint StrongCodeWrite { get => ReadHere<uint>(nameof(StrongCodeWrite)); set => WriteHere(nameof(StrongCodeWrite), value); }

        [Offset(48UL)]
        public uint ReducedCloneCommitChargeFailed { get => ReadHere<uint>(nameof(ReducedCloneCommitChargeFailed)); set => WriteHere(nameof(ReducedCloneCommitChargeFailed), value); }

        [Offset(52UL)]
        public uint CopyOnWriteAtDispatchNoPages { get => ReadHere<uint>(nameof(CopyOnWriteAtDispatchNoPages)); set => WriteHere(nameof(CopyOnWriteAtDispatchNoPages), value); }

        [Offset(56UL)]
        public uint NoPageTablesAllowed { get => ReadHere<uint>(nameof(NoPageTablesAllowed)); set => WriteHere(nameof(NoPageTablesAllowed), value); }

        [Offset(60UL)]
        public uint EnclavePageFailed { get => ReadHere<uint>(nameof(EnclavePageFailed)); set => WriteHere(nameof(EnclavePageFailed), value); }

        public MiProbeRaiseTracker(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiProbeRaiseTracker>();
        }
    }
}