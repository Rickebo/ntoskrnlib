using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_PAGE_HANDLING_DATA")]
    public sealed class IommuPageHandlingData : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock ResetLock { get => ReadStructure<ExPushLock>(nameof(ResetLock)); set => WriteStructure(nameof(ResetLock), value); }

        [Offset(8UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(16UL)]
        public uint ValidGroupFaultSequenceNumber { get => ReadHere<uint>(nameof(ValidGroupFaultSequenceNumber)); set => WriteHere(nameof(ValidGroupFaultSequenceNumber), value); }

        [Offset(24UL)]
        public IntPtr GetPageFault { get => ReadHere<IntPtr>(nameof(GetPageFault)); set => WriteHere(nameof(GetPageFault), value); }

        [Offset(32UL)]
        public IntPtr DismissPageFault { get => ReadHere<IntPtr>(nameof(DismissPageFault)); set => WriteHere(nameof(DismissPageFault), value); }

        public IommuPageHandlingData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuPageHandlingData>();
        }
    }
}