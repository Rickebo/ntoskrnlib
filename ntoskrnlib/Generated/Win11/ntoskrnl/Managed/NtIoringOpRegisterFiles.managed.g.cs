using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_REGISTER_FILES")]
    public sealed class NtIoringOpRegisterFiles : DynamicStructure
    {
        [Offset(0UL)]
        public uint CommonOpFlags { get => ReadHere<uint>(nameof(CommonOpFlags)); set => WriteHere(nameof(CommonOpFlags), value); }

        [Offset(4UL)]
        public NtIoringRegFilesFlags Flags { get => ReadStructure<NtIoringRegFilesFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(12UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(16UL)]
        public IntPtr Handles { get => ReadHere<IntPtr>(nameof(Handles)); set => WriteHere(nameof(Handles), value); }

        public NtIoringOpRegisterFiles(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringOpRegisterFiles>();
        }
    }
}