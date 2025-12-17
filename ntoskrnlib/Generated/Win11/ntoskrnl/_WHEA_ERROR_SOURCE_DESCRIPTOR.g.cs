#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 972)]
    public partial struct _WHEA_ERROR_SOURCE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public uint Length;
        [FieldOffset(4)]
        public uint Version;
        [FieldOffset(8)]
        public uint Type;
        [FieldOffset(12)]
        public uint State;
        [FieldOffset(16)]
        public uint MaxRawDataLength;
        [FieldOffset(20)]
        public uint NumRecordsToPreallocate;
        [FieldOffset(24)]
        public uint MaxSectionsPerRecord;
        [FieldOffset(28)]
        public uint ErrorSourceId;
        [FieldOffset(32)]
        public uint PlatformErrorSourceId;
        [FieldOffset(36)]
        public uint Flags;
        [FieldOffset(40)]
        public _unnamed_tag_ Info;
    }
}