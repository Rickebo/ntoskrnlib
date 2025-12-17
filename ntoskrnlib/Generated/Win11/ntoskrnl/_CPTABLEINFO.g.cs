#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _CPTABLEINFO
    {
        [FieldOffset(0)]
        public ushort CodePage;
        [FieldOffset(2)]
        public ushort MaximumCharacterSize;
        [FieldOffset(4)]
        public ushort DefaultChar;
        [FieldOffset(6)]
        public ushort UniDefaultChar;
        [FieldOffset(8)]
        public ushort TransDefaultChar;
        [FieldOffset(10)]
        public ushort TransUniDefaultChar;
        [FieldOffset(12)]
        public ushort DBCSCodePage;
        [FieldOffset(14)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] LeadByte;
        [FieldOffset(32)]
        public IntPtr MultiByteTable;
        [FieldOffset(40)]
        public IntPtr WideCharTable;
        [FieldOffset(48)]
        public IntPtr DBCSRanges;
        [FieldOffset(56)]
        public IntPtr DBCSOffsets;
    }
}