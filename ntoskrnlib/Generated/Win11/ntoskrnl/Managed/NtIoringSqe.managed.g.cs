using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_SQE")]
    public sealed class NtIoringSqe : DynamicStructure
    {
        [Offset(0UL)]
        public uint OpCode { get => ReadHere<uint>(nameof(OpCode)); set => WriteHere(nameof(OpCode), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public ulong UserData { get => ReadHere<ulong>(nameof(UserData)); set => WriteHere(nameof(UserData), value); }

        [Offset(8UL)]
        public ulong PaddingUserDataForWow { get => ReadHere<ulong>(nameof(PaddingUserDataForWow)); set => WriteHere(nameof(PaddingUserDataForWow), value); }

        [Offset(16UL)]
        public NtIoringOpRead Read { get => ReadStructure<NtIoringOpRead>(nameof(Read)); set => WriteStructure(nameof(Read), value); }

        [Offset(16UL)]
        public NtIoringOpRegisterFiles RegisterFiles { get => ReadStructure<NtIoringOpRegisterFiles>(nameof(RegisterFiles)); set => WriteStructure(nameof(RegisterFiles), value); }

        [Offset(16UL)]
        public NtIoringOpRegisterBuffers RegisterBuffers { get => ReadStructure<NtIoringOpRegisterBuffers>(nameof(RegisterBuffers)); set => WriteStructure(nameof(RegisterBuffers), value); }

        [Offset(16UL)]
        public NtIoringOpCancel Cancel { get => ReadStructure<NtIoringOpCancel>(nameof(Cancel)); set => WriteStructure(nameof(Cancel), value); }

        [Offset(16UL)]
        public NtIoringOpWrite Write { get => ReadStructure<NtIoringOpWrite>(nameof(Write)); set => WriteStructure(nameof(Write), value); }

        [Offset(16UL)]
        public NtIoringOpFlush Flush { get => ReadStructure<NtIoringOpFlush>(nameof(Flush)); set => WriteStructure(nameof(Flush), value); }

        [Offset(16UL)]
        public NtIoringOpReadScatter ReadScatter { get => ReadStructure<NtIoringOpReadScatter>(nameof(ReadScatter)); set => WriteStructure(nameof(ReadScatter), value); }

        [Offset(16UL)]
        public NtIoringOpWriteGather WriteGather { get => ReadStructure<NtIoringOpWriteGather>(nameof(WriteGather)); set => WriteStructure(nameof(WriteGather), value); }

        [Offset(16UL)]
        public NtIoringOpReserved ReservedMaxSizePadding { get => ReadStructure<NtIoringOpReserved>(nameof(ReservedMaxSizePadding)); set => WriteStructure(nameof(ReservedMaxSizePadding), value); }

        public NtIoringSqe(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringSqe>();
        }
    }
}