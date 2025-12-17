using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_DEVICE_DRIVER_DESCRIPTOR")]
    public sealed class WheaDeviceDriverDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(3UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public Guid SourceGuid { get => ReadStructure<Guid>(nameof(SourceGuid)); set => WriteStructure(nameof(SourceGuid), value); }

        [Offset(20UL)]
        public ushort LogTag { get => ReadHere<ushort>(nameof(LogTag)); set => WriteHere(nameof(LogTag), value); }

        [Offset(22UL)]
        public ushort Reserved2 { get => ReadHere<ushort>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(24UL)]
        public uint PacketLength { get => ReadHere<uint>(nameof(PacketLength)); set => WriteHere(nameof(PacketLength), value); }

        [Offset(28UL)]
        public uint PacketCount { get => ReadHere<uint>(nameof(PacketCount)); set => WriteHere(nameof(PacketCount), value); }

        [Offset(32UL)]
        public IntPtr PacketBuffer { get => ReadHere<IntPtr>(nameof(PacketBuffer)); set => WriteHere(nameof(PacketBuffer), value); }

        [Offset(40UL)]
        public WheaErrorSourceConfigurationDd Config { get => ReadStructure<WheaErrorSourceConfigurationDd>(nameof(Config)); set => WriteStructure(nameof(Config), value); }

        [Offset(64UL)]
        public Guid CreatorId { get => ReadStructure<Guid>(nameof(CreatorId)); set => WriteStructure(nameof(CreatorId), value); }

        [Offset(80UL)]
        public Guid PartitionId { get => ReadStructure<Guid>(nameof(PartitionId)); set => WriteStructure(nameof(PartitionId), value); }

        [Offset(96UL)]
        public uint MaxSectionDataLength { get => ReadHere<uint>(nameof(MaxSectionDataLength)); set => WriteHere(nameof(MaxSectionDataLength), value); }

        [Offset(100UL)]
        public uint MaxSectionsPerRecord { get => ReadHere<uint>(nameof(MaxSectionsPerRecord)); set => WriteHere(nameof(MaxSectionsPerRecord), value); }

        [Offset(104UL)]
        public IntPtr PacketStateBuffer { get => ReadHere<IntPtr>(nameof(PacketStateBuffer)); set => WriteHere(nameof(PacketStateBuffer), value); }

        [Offset(112UL)]
        public int OpenHandles { get => ReadHere<int>(nameof(OpenHandles)); set => WriteHere(nameof(OpenHandles), value); }

        public WheaDeviceDriverDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaDeviceDriverDescriptor>();
        }
    }
}