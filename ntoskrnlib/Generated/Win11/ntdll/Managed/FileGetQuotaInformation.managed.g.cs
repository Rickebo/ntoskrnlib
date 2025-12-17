using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_FILE_GET_QUOTA_INFORMATION")]
    public sealed class FileGetQuotaInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint NextEntryOffset { get => ReadHere<uint>(nameof(NextEntryOffset)); set => WriteHere(nameof(NextEntryOffset), value); }

        [Offset(4UL)]
        public uint SidLength { get => ReadHere<uint>(nameof(SidLength)); set => WriteHere(nameof(SidLength), value); }

        [Offset(8UL)]
        public Sid Sid { get => ReadStructure<Sid>(nameof(Sid)); set => WriteStructure(nameof(Sid), value); }

        public FileGetQuotaInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FileGetQuotaInformation>();
        }
    }
}