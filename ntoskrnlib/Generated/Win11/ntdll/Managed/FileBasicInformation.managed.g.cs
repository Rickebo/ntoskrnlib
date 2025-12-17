using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_FILE_BASIC_INFORMATION")]
    public sealed class FileBasicInformation : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger CreationTime { get => ReadStructure<LargeInteger>(nameof(CreationTime)); set => WriteStructure(nameof(CreationTime), value); }

        [Offset(8UL)]
        public LargeInteger LastAccessTime { get => ReadStructure<LargeInteger>(nameof(LastAccessTime)); set => WriteStructure(nameof(LastAccessTime), value); }

        [Offset(16UL)]
        public LargeInteger LastWriteTime { get => ReadStructure<LargeInteger>(nameof(LastWriteTime)); set => WriteStructure(nameof(LastWriteTime), value); }

        [Offset(24UL)]
        public LargeInteger ChangeTime { get => ReadStructure<LargeInteger>(nameof(ChangeTime)); set => WriteStructure(nameof(ChangeTime), value); }

        [Offset(32UL)]
        public uint FileAttributes { get => ReadHere<uint>(nameof(FileAttributes)); set => WriteHere(nameof(FileAttributes), value); }

        public FileBasicInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FileBasicInformation>();
        }
    }
}