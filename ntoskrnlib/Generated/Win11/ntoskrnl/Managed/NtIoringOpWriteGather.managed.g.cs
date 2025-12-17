using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_WRITE_GATHER")]
    public sealed class NtIoringOpWriteGather : DynamicStructure
    {
        [Offset(0UL)]
        public uint CommonOpFlags { get => ReadHere<uint>(nameof(CommonOpFlags)); set => WriteHere(nameof(CommonOpFlags), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public NtIoringHandleref File { get => ReadStructure<NtIoringHandleref>(nameof(File)); set => WriteStructure(nameof(File), value); }

        [Offset(16UL)]
        public uint SegmentCount { get => ReadHere<uint>(nameof(SegmentCount)); set => WriteHere(nameof(SegmentCount), value); }

        [Offset(24UL)]
        public IntPtr SegmentArray { get => ReadHere<IntPtr>(nameof(SegmentArray)); set => WriteHere(nameof(SegmentArray), value); }

        [Offset(32UL)]
        public ulong Offset { get => ReadHere<ulong>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(40UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(44UL)]
        public uint Key { get => ReadHere<uint>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        public NtIoringOpWriteGather(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringOpWriteGather>();
        }
    }
}