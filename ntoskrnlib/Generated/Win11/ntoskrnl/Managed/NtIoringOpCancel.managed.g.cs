using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_CANCEL")]
    public sealed class NtIoringOpCancel : DynamicStructure
    {
        [Offset(0UL)]
        public uint CommonOpFlags { get => ReadHere<uint>(nameof(CommonOpFlags)); set => WriteHere(nameof(CommonOpFlags), value); }

        [Offset(8UL)]
        public NtIoringHandleref File { get => ReadStructure<NtIoringHandleref>(nameof(File)); set => WriteStructure(nameof(File), value); }

        [Offset(16UL)]
        public ulong CancelId { get => ReadHere<ulong>(nameof(CancelId)); set => WriteHere(nameof(CancelId), value); }

        public NtIoringOpCancel(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringOpCancel>();
        }
    }
}