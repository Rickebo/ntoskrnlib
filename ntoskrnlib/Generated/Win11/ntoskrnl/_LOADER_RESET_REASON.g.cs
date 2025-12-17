#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _LOADER_RESET_REASON
    {
        [FieldOffset(0)]
        public byte Supplied;
        [FieldOffset(8)]
        public _unnamed_tag_ Basic;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] AdditionalInfo;
    }
}