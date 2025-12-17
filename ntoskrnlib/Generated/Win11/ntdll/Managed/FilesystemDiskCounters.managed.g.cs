using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_FILESYSTEM_DISK_COUNTERS")]
    public sealed class FilesystemDiskCounters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong FsBytesRead { get => ReadHere<ulong>(nameof(FsBytesRead)); set => WriteHere(nameof(FsBytesRead), value); }

        [Offset(8UL)]
        public ulong FsBytesWritten { get => ReadHere<ulong>(nameof(FsBytesWritten)); set => WriteHere(nameof(FsBytesWritten), value); }

        public FilesystemDiskCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FilesystemDiskCounters>();
        }
    }
}