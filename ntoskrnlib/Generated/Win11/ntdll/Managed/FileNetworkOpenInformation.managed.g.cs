using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_FILE_NETWORK_OPEN_INFORMATION")]
    public sealed class FileNetworkOpenInformation : DynamicStructure
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
        public LargeInteger AllocationSize { get => ReadStructure<LargeInteger>(nameof(AllocationSize)); set => WriteStructure(nameof(AllocationSize), value); }

        [Offset(40UL)]
        public LargeInteger EndOfFile { get => ReadStructure<LargeInteger>(nameof(EndOfFile)); set => WriteStructure(nameof(EndOfFile), value); }

        [Offset(48UL)]
        public uint FileAttributes { get => ReadHere<uint>(nameof(FileAttributes)); set => WriteHere(nameof(FileAttributes), value); }

        public FileNetworkOpenInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FileNetworkOpenInformation>();
        }
    }
}