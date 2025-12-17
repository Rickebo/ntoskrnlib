using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_WRITE")]
    public sealed class NtIoringOpWrite : DynamicStructure
    {
        [Offset(0UL)]
        public uint CommonOpFlags { get => ReadHere<uint>(nameof(CommonOpFlags)); set => WriteHere(nameof(CommonOpFlags), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public NtIoringHandleref File { get => ReadStructure<NtIoringHandleref>(nameof(File)); set => WriteStructure(nameof(File), value); }

        [Offset(16UL)]
        public NtIoringBufferref Buffer { get => ReadStructure<NtIoringBufferref>(nameof(Buffer)); set => WriteStructure(nameof(Buffer), value); }

        [Offset(24UL)]
        public ulong Offset { get => ReadHere<ulong>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(32UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(36UL)]
        public uint Key { get => ReadHere<uint>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        public NtIoringOpWrite(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringOpWrite>();
        }
    }
}