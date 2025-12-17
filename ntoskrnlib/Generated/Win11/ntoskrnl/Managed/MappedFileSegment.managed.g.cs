using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MAPPED_FILE_SEGMENT")]
    public sealed class MappedFileSegment : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ControlArea { get => ReadHere<IntPtr>(nameof(ControlArea)); set => WriteHere(nameof(ControlArea), value); }

        [Offset(8UL)]
        public uint TotalNumberOfPtes { get => ReadHere<uint>(nameof(TotalNumberOfPtes)); set => WriteHere(nameof(TotalNumberOfPtes), value); }

        [Offset(12UL)]
        public SegmentFlags SegmentFlags { get => ReadStructure<SegmentFlags>(nameof(SegmentFlags)); set => WriteStructure(nameof(SegmentFlags), value); }

        [Offset(16UL)]
        public ulong NumberOfCommittedPages { get => ReadHere<ulong>(nameof(NumberOfCommittedPages)); set => WriteHere(nameof(NumberOfCommittedPages), value); }

        [Offset(24UL)]
        public ulong SizeOfSegment { get => ReadHere<ulong>(nameof(SizeOfSegment)); set => WriteHere(nameof(SizeOfSegment), value); }

        [Offset(32UL)]
        public IntPtr ExtendInfo { get => ReadHere<IntPtr>(nameof(ExtendInfo)); set => WriteHere(nameof(ExtendInfo), value); }

        [Offset(32UL)]
        public IntPtr BasedAddress { get => ReadHere<IntPtr>(nameof(BasedAddress)); set => WriteHere(nameof(BasedAddress), value); }

        [Offset(40UL)]
        public ExPushLock SegmentLock { get => ReadStructure<ExPushLock>(nameof(SegmentLock)); set => WriteStructure(nameof(SegmentLock), value); }

        public MappedFileSegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MappedFileSegment>();
        }
    }
}