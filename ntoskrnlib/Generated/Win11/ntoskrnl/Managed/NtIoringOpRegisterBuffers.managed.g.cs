using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_REGISTER_BUFFERS")]
    public sealed class NtIoringOpRegisterBuffers : DynamicStructure
    {
        [Offset(0UL)]
        public uint CommonOpFlags { get => ReadHere<uint>(nameof(CommonOpFlags)); set => WriteHere(nameof(CommonOpFlags), value); }

        [Offset(4UL)]
        public NtIoringRegBuffersFlags Flags { get => ReadStructure<NtIoringRegBuffersFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(12UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(16UL)]
        public IntPtr Buffers { get => ReadHere<IntPtr>(nameof(Buffers)); set => WriteHere(nameof(Buffers), value); }

        public NtIoringOpRegisterBuffers(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringOpRegisterBuffers>();
        }
    }
}