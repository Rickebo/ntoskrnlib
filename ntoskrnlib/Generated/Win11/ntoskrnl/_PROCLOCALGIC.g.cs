#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _PROCLOCALGIC
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public ushort Reserved;
        [FieldOffset(4)]
        public uint Identifier;
        [FieldOffset(8)]
        public uint AcpiProcessorId;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public uint ParkingProtocolVersion;
        [FieldOffset(20)]
        public uint PerformanceInterruptGsi;
        [FieldOffset(24)]
        public ulong ParkedPhysicalAddress;
        [FieldOffset(32)]
        public ulong ControllerPhysicalAddress;
        [FieldOffset(40)]
        public ulong Gicv;
        [FieldOffset(48)]
        public ulong Gich;
        [FieldOffset(56)]
        public uint VgicMaintenanceInterrupt;
        [FieldOffset(60)]
        public ulong GicrBaseAddress;
        [FieldOffset(68)]
        public ulong Mpidr;
        [FieldOffset(76)]
        public byte ProcessorPowerEfficiencyClass;
        [FieldOffset(77)]
        public byte Reserved77;
        [FieldOffset(78)]
        public ushort SpeInterruptGsi;
    }
}