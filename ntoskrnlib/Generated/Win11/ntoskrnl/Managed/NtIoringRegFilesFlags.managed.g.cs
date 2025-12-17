using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_REG_FILES_FLAGS")]
    public sealed class NtIoringRegFilesFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Required { get => ReadHere<uint>(nameof(Required)); set => WriteHere(nameof(Required), value); }

        [Offset(4UL)]
        public uint Advisory { get => ReadHere<uint>(nameof(Advisory)); set => WriteHere(nameof(Advisory), value); }

        public NtIoringRegFilesFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringRegFilesFlags>();
        }
    }
}