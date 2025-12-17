using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCLOCALGIC")]
    public sealed class Proclocalgic : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint Identifier { get => ReadHere<uint>(nameof(Identifier)); set => WriteHere(nameof(Identifier), value); }

        [Offset(8UL)]
        public uint AcpiProcessorId { get => ReadHere<uint>(nameof(AcpiProcessorId)); set => WriteHere(nameof(AcpiProcessorId), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public uint ParkingProtocolVersion { get => ReadHere<uint>(nameof(ParkingProtocolVersion)); set => WriteHere(nameof(ParkingProtocolVersion), value); }

        [Offset(20UL)]
        public uint PerformanceInterruptGsi { get => ReadHere<uint>(nameof(PerformanceInterruptGsi)); set => WriteHere(nameof(PerformanceInterruptGsi), value); }

        [Offset(24UL)]
        public ulong ParkedPhysicalAddress { get => ReadHere<ulong>(nameof(ParkedPhysicalAddress)); set => WriteHere(nameof(ParkedPhysicalAddress), value); }

        [Offset(32UL)]
        public ulong ControllerPhysicalAddress { get => ReadHere<ulong>(nameof(ControllerPhysicalAddress)); set => WriteHere(nameof(ControllerPhysicalAddress), value); }

        [Offset(40UL)]
        public ulong Gicv { get => ReadHere<ulong>(nameof(Gicv)); set => WriteHere(nameof(Gicv), value); }

        [Offset(48UL)]
        public ulong Gich { get => ReadHere<ulong>(nameof(Gich)); set => WriteHere(nameof(Gich), value); }

        [Offset(56UL)]
        public uint VgicMaintenanceInterrupt { get => ReadHere<uint>(nameof(VgicMaintenanceInterrupt)); set => WriteHere(nameof(VgicMaintenanceInterrupt), value); }

        [Offset(60UL)]
        public ulong GicrBaseAddress { get => ReadHere<ulong>(nameof(GicrBaseAddress)); set => WriteHere(nameof(GicrBaseAddress), value); }

        [Offset(68UL)]
        public ulong Mpidr { get => ReadHere<ulong>(nameof(Mpidr)); set => WriteHere(nameof(Mpidr), value); }

        [Offset(76UL)]
        public byte ProcessorPowerEfficiencyClass { get => ReadHere<byte>(nameof(ProcessorPowerEfficiencyClass)); set => WriteHere(nameof(ProcessorPowerEfficiencyClass), value); }

        [Offset(77UL)]
        public byte Reserved77 { get => ReadHere<byte>(nameof(Reserved77)); set => WriteHere(nameof(Reserved77), value); }

        [Offset(78UL)]
        public ushort SpeInterruptGsi { get => ReadHere<ushort>(nameof(SpeInterruptGsi)); set => WriteHere(nameof(SpeInterruptGsi), value); }

        public Proclocalgic(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Proclocalgic>();
        }
    }
}