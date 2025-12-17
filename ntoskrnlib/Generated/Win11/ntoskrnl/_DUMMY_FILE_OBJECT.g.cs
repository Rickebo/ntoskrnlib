#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public partial struct _DUMMY_FILE_OBJECT
    {
        [FieldOffset(0)]
        public _OBJECT_HEADER ObjectHeader;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 216)]
        public sbyte[] FileObjectBody;
    }
}