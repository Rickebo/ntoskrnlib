#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_DRIVE_LETTER_CURDIR
    {
        [FieldOffset(0)]
        public ushort Flags;
        [FieldOffset(2)]
        public ushort Length;
        [FieldOffset(4)]
        public uint TimeStamp;
        [FieldOffset(8)]
        public _STRING DosPath;
    }
}