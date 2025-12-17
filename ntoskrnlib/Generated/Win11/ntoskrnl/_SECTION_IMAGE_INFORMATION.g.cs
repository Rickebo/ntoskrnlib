#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _SECTION_IMAGE_INFORMATION
    {
        [FieldOffset(0)]
        public IntPtr TransferAddress;
        [FieldOffset(8)]
        public uint ZeroBits;
        [FieldOffset(16)]
        public ulong MaximumStackSize;
        [FieldOffset(24)]
        public ulong CommittedStackSize;
        [FieldOffset(32)]
        public uint SubSystemType;
        [FieldOffset(36)]
        public ushort SubSystemMinorVersion;
        [FieldOffset(38)]
        public ushort SubSystemMajorVersion;
        [FieldOffset(36)]
        public uint SubSystemVersion;
        [FieldOffset(40)]
        public ushort MajorOperatingSystemVersion;
        [FieldOffset(42)]
        public ushort MinorOperatingSystemVersion;
        [FieldOffset(40)]
        public uint OperatingSystemVersion;
        [FieldOffset(44)]
        public ushort ImageCharacteristics;
        [FieldOffset(46)]
        public ushort DllCharacteristics;
        [FieldOffset(48)]
        public ushort Machine;
        [FieldOffset(50)]
        public byte ImageContainsCode;
        [FieldOffset(51)]
        public byte ImageFlags;
        [FieldOffset(51)]
        public byte ComPlusNativeReady;
        [FieldOffset(51)]
        public byte ComPlusILOnly;
        [FieldOffset(51)]
        public byte ImageDynamicallyRelocated;
        [FieldOffset(51)]
        public byte ImageMappedFlat;
        [FieldOffset(51)]
        public byte BaseBelow4gb;
        [FieldOffset(51)]
        public byte ComPlusPrefer32bit;
        [FieldOffset(51)]
        public byte Reserved;
        [FieldOffset(52)]
        public uint LoaderFlags;
        [FieldOffset(56)]
        public uint ImageFileSize;
        [FieldOffset(60)]
        public uint CheckSum;
    }
}