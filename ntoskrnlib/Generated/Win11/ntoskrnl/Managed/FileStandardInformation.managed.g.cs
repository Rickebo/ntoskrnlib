using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FILE_STANDARD_INFORMATION")]
    public sealed class FileStandardInformation : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger AllocationSize { get => ReadStructure<LargeInteger>(nameof(AllocationSize)); set => WriteStructure(nameof(AllocationSize), value); }

        [Offset(8UL)]
        public LargeInteger EndOfFile { get => ReadStructure<LargeInteger>(nameof(EndOfFile)); set => WriteStructure(nameof(EndOfFile), value); }

        [Offset(16UL)]
        public uint NumberOfLinks { get => ReadHere<uint>(nameof(NumberOfLinks)); set => WriteHere(nameof(NumberOfLinks), value); }

        [Offset(20UL)]
        public byte DeletePending { get => ReadHere<byte>(nameof(DeletePending)); set => WriteHere(nameof(DeletePending), value); }

        [Offset(21UL)]
        public byte Directory { get => ReadHere<byte>(nameof(Directory)); set => WriteHere(nameof(Directory), value); }

        public FileStandardInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FileStandardInformation>();
        }
    }
}