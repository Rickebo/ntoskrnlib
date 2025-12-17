#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _IMAGE_ROM_OPTIONAL_HEADER
    {
        [FieldOffset(0)]
        public ushort Magic;
        [FieldOffset(2)]
        public byte MajorLinkerVersion;
        [FieldOffset(3)]
        public byte MinorLinkerVersion;
        [FieldOffset(4)]
        public uint SizeOfCode;
        [FieldOffset(8)]
        public uint SizeOfInitializedData;
        [FieldOffset(12)]
        public uint SizeOfUninitializedData;
        [FieldOffset(16)]
        public uint AddressOfEntryPoint;
        [FieldOffset(20)]
        public uint BaseOfCode;
        [FieldOffset(24)]
        public uint BaseOfData;
        [FieldOffset(28)]
        public uint BaseOfBss;
        [FieldOffset(32)]
        public uint GprMask;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] CprMask;
        [FieldOffset(52)]
        public uint GpValue;
    }
}