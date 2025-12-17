using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEGMENT_FLAGS")]
    public sealed class SegmentFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ushort TotalNumberOfPtes4132 { get => ReadHere<ushort>(nameof(TotalNumberOfPtes4132)); set => WriteHere(nameof(TotalNumberOfPtes4132), value); }

        [Offset(0UL)]
        public ushort LargePages { get => ReadHere<ushort>(nameof(LargePages)); set => WriteHere(nameof(LargePages), value); }

        [Offset(0UL)]
        public ushort DebugSymbolsLoaded { get => ReadHere<ushort>(nameof(DebugSymbolsLoaded)); set => WriteHere(nameof(DebugSymbolsLoaded), value); }

        [Offset(0UL)]
        public ushort WriteCombined { get => ReadHere<ushort>(nameof(WriteCombined)); set => WriteHere(nameof(WriteCombined), value); }

        [Offset(0UL)]
        public ushort NoCache { get => ReadHere<ushort>(nameof(NoCache)); set => WriteHere(nameof(NoCache), value); }

        [Offset(0UL)]
        public ushort ForceCollision { get => ReadHere<ushort>(nameof(ForceCollision)); set => WriteHere(nameof(ForceCollision), value); }

        [Offset(0UL)]
        public ushort Binary32 { get => ReadHere<ushort>(nameof(Binary32)); set => WriteHere(nameof(Binary32), value); }

        [Offset(0UL)]
        public ushort Short0 { get => ReadHere<ushort>(nameof(Short0)); set => WriteHere(nameof(Short0), value); }

        [Offset(2UL)]
        public byte DefaultProtectionMask { get => ReadHere<byte>(nameof(DefaultProtectionMask)); set => WriteHere(nameof(DefaultProtectionMask), value); }

        [Offset(2UL)]
        public byte ContainsDebug { get => ReadHere<byte>(nameof(ContainsDebug)); set => WriteHere(nameof(ContainsDebug), value); }

        [Offset(2UL)]
        public byte Spare { get => ReadHere<byte>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(2UL)]
        public byte UChar1 { get => ReadHere<byte>(nameof(UChar1)); set => WriteHere(nameof(UChar1), value); }

        [Offset(3UL)]
        public MiSegmentSignatureFlags Signature { get => ReadStructure<MiSegmentSignatureFlags>(nameof(Signature)); set => WriteStructure(nameof(Signature), value); }

        public SegmentFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SegmentFlags>();
        }
    }
}