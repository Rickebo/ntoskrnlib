#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 116)]
    public partial struct _WHEA_DEVICE_DRIVER_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ushort Type;
        [FieldOffset(2)]
        public byte Enabled;
        [FieldOffset(3)]
        public byte Reserved;
        [FieldOffset(4)]
        public _GUID SourceGuid;
        [FieldOffset(20)]
        public ushort LogTag;
        [FieldOffset(22)]
        public ushort Reserved2;
        [FieldOffset(24)]
        public uint PacketLength;
        [FieldOffset(28)]
        public uint PacketCount;
        [FieldOffset(32)]
        public IntPtr PacketBuffer;
        [FieldOffset(40)]
        public _WHEA_ERROR_SOURCE_CONFIGURATION_DD Config;
        [FieldOffset(64)]
        public _GUID CreatorId;
        [FieldOffset(80)]
        public _GUID PartitionId;
        [FieldOffset(96)]
        public uint MaxSectionDataLength;
        [FieldOffset(100)]
        public uint MaxSectionsPerRecord;
        [FieldOffset(104)]
        public IntPtr PacketStateBuffer;
        [FieldOffset(112)]
        public int OpenHandles;
    }
}