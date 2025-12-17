using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_ERROR_SOURCE_DESCRIPTOR")]
    public sealed class WheaErrorSourceDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(4UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(12UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(16UL)]
        public uint MaxRawDataLength { get => ReadHere<uint>(nameof(MaxRawDataLength)); set => WriteHere(nameof(MaxRawDataLength), value); }

        [Offset(20UL)]
        public uint NumRecordsToPreallocate { get => ReadHere<uint>(nameof(NumRecordsToPreallocate)); set => WriteHere(nameof(NumRecordsToPreallocate), value); }

        [Offset(24UL)]
        public uint MaxSectionsPerRecord { get => ReadHere<uint>(nameof(MaxSectionsPerRecord)); set => WriteHere(nameof(MaxSectionsPerRecord), value); }

        [Offset(28UL)]
        public uint ErrorSourceId { get => ReadHere<uint>(nameof(ErrorSourceId)); set => WriteHere(nameof(ErrorSourceId), value); }

        [Offset(32UL)]
        public uint PlatformErrorSourceId { get => ReadHere<uint>(nameof(PlatformErrorSourceId)); set => WriteHere(nameof(PlatformErrorSourceId), value); }

        [Offset(36UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(40UL)]
        public UnnamedTag Info { get => ReadStructure<UnnamedTag>(nameof(Info)); set => WriteStructure(nameof(Info), value); }

        public WheaErrorSourceDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorSourceDescriptor>();
        }
    }
}