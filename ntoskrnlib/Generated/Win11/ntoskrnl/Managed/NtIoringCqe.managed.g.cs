using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_CQE")]
    public sealed class NtIoringCqe : DynamicStructure
    {
        [Offset(0UL)]
        public ulong UserData { get => ReadHere<ulong>(nameof(UserData)); set => WriteHere(nameof(UserData), value); }

        [Offset(0UL)]
        public ulong PaddingUserDataForWow { get => ReadHere<ulong>(nameof(PaddingUserDataForWow)); set => WriteHere(nameof(PaddingUserDataForWow), value); }

        [Offset(8UL)]
        public IoStatusBlock IoStatus { get => ReadStructure<IoStatusBlock>(nameof(IoStatus)); set => WriteStructure(nameof(IoStatus), value); }

        public NtIoringCqe(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringCqe>();
        }
    }
}