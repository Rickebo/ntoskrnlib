#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _IMAGE_DEBUG_DIRECTORY
    {
        [FieldOffset(0)]
        public uint Characteristics;
        [FieldOffset(4)]
        public uint TimeDateStamp;
        [FieldOffset(8)]
        public ushort MajorVersion;
        [FieldOffset(10)]
        public ushort MinorVersion;
        [FieldOffset(12)]
        public uint Type;
        [FieldOffset(16)]
        public uint SizeOfData;
        [FieldOffset(20)]
        public uint AddressOfRawData;
        [FieldOffset(24)]
        public uint PointerToRawData;
    }
}