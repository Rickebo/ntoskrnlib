using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMINPAGE_FLAGS")]
    public sealed class MminpageFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint GetExtents { get => ReadHere<uint>(nameof(GetExtents)); set => WriteHere(nameof(GetExtents), value); }

        [Offset(0UL)]
        public uint VmType { get => ReadHere<uint>(nameof(VmType)); set => WriteHere(nameof(VmType), value); }

        [Offset(0UL)]
        public uint VaPrefetchReadBlock { get => ReadHere<uint>(nameof(VaPrefetchReadBlock)); set => WriteHere(nameof(VaPrefetchReadBlock), value); }

        [Offset(0UL)]
        public uint CollidedFlowThrough { get => ReadHere<uint>(nameof(CollidedFlowThrough)); set => WriteHere(nameof(CollidedFlowThrough), value); }

        [Offset(0UL)]
        public uint ForceCollisions { get => ReadHere<uint>(nameof(ForceCollisions)); set => WriteHere(nameof(ForceCollisions), value); }

        [Offset(0UL)]
        public uint InPageExpanded { get => ReadHere<uint>(nameof(InPageExpanded)); set => WriteHere(nameof(InPageExpanded), value); }

        [Offset(0UL)]
        public uint IssuedAtLowPriority { get => ReadHere<uint>(nameof(IssuedAtLowPriority)); set => WriteHere(nameof(IssuedAtLowPriority), value); }

        [Offset(0UL)]
        public uint FaultFromStore { get => ReadHere<uint>(nameof(FaultFromStore)); set => WriteHere(nameof(FaultFromStore), value); }

        [Offset(0UL)]
        public uint PagePriority { get => ReadHere<uint>(nameof(PagePriority)); set => WriteHere(nameof(PagePriority), value); }

        [Offset(0UL)]
        public uint ClusteredPagePriority { get => ReadHere<uint>(nameof(ClusteredPagePriority)); set => WriteHere(nameof(ClusteredPagePriority), value); }

        [Offset(0UL)]
        public uint MakeClusterValid { get => ReadHere<uint>(nameof(MakeClusterValid)); set => WriteHere(nameof(MakeClusterValid), value); }

        [Offset(0UL)]
        public uint ZeroLastPage { get => ReadHere<uint>(nameof(ZeroLastPage)); set => WriteHere(nameof(ZeroLastPage), value); }

        [Offset(0UL)]
        public uint UserFault { get => ReadHere<uint>(nameof(UserFault)); set => WriteHere(nameof(UserFault), value); }

        [Offset(0UL)]
        public uint StandbyProtectionNeeded { get => ReadHere<uint>(nameof(StandbyProtectionNeeded)); set => WriteHere(nameof(StandbyProtectionNeeded), value); }

        [Offset(0UL)]
        public uint PteChanged { get => ReadHere<uint>(nameof(PteChanged)); set => WriteHere(nameof(PteChanged), value); }

        [Offset(0UL)]
        public uint PageFileFault { get => ReadHere<uint>(nameof(PageFileFault)); set => WriteHere(nameof(PageFileFault), value); }

        [Offset(0UL)]
        public uint PageFilePageHashActive { get => ReadHere<uint>(nameof(PageFilePageHashActive)); set => WriteHere(nameof(PageFilePageHashActive), value); }

        [Offset(0UL)]
        public uint CoalescedIo { get => ReadHere<uint>(nameof(CoalescedIo)); set => WriteHere(nameof(CoalescedIo), value); }

        [Offset(0UL)]
        public uint VmLockNotNeeded { get => ReadHere<uint>(nameof(VmLockNotNeeded)); set => WriteHere(nameof(VmLockNotNeeded), value); }

        [Offset(0UL)]
        public uint PartitionReferenced { get => ReadHere<uint>(nameof(PartitionReferenced)); set => WriteHere(nameof(PartitionReferenced), value); }

        [Offset(0UL)]
        public uint Spare0 { get => ReadHere<uint>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(0UL)]
        public uint Spare1 { get => ReadHere<uint>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        public MminpageFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MminpageFlags>();
        }
    }
}