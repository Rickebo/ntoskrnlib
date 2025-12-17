#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 240)]
    public partial struct _IMAGE_OPTIONAL_HEADER64
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
        public ulong ImageBase;
        [FieldOffset(32)]
        public uint SectionAlignment;
        [FieldOffset(36)]
        public uint FileAlignment;
        [FieldOffset(40)]
        public ushort MajorOperatingSystemVersion;
        [FieldOffset(42)]
        public ushort MinorOperatingSystemVersion;
        [FieldOffset(44)]
        public ushort MajorImageVersion;
        [FieldOffset(46)]
        public ushort MinorImageVersion;
        [FieldOffset(48)]
        public ushort MajorSubsystemVersion;
        [FieldOffset(50)]
        public ushort MinorSubsystemVersion;
        [FieldOffset(52)]
        public uint Win32VersionValue;
        [FieldOffset(56)]
        public uint SizeOfImage;
        [FieldOffset(60)]
        public uint SizeOfHeaders;
        [FieldOffset(64)]
        public uint CheckSum;
        [FieldOffset(68)]
        public ushort Subsystem;
        [FieldOffset(70)]
        public ushort DllCharacteristics;
        [FieldOffset(72)]
        public ulong SizeOfStackReserve;
        [FieldOffset(80)]
        public ulong SizeOfStackCommit;
        [FieldOffset(88)]
        public ulong SizeOfHeapReserve;
        [FieldOffset(96)]
        public ulong SizeOfHeapCommit;
        [FieldOffset(104)]
        public uint LoaderFlags;
        [FieldOffset(108)]
        public uint NumberOfRvaAndSizes;
        [FieldOffset(112)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _IMAGE_DATA_DIRECTORY[] DataDirectory;
    }
}